﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;

namespace ChapooDAL
{
    public class User_DAO : Base
    {
        int userId = 0;
        string userName = "";
        string userPassword = "";
        string title = "";
        int userCode = 0;
        string userKey = "";
        //Check if user does exist.(login)
        public User GetUser(string userName, string password){
            string query = "select [UserId], [UserName], [userPassword], [UserCode], [userKey] from [User] where UserName = '" + userName + "' and   userPassword =  '" + password + "' ";
            return RetrieveUser(ExecuteSelectQuery(query));
        }
        //If user exist -> fill all the info
        private User RetrieveUser(DataTable dataTable){
            foreach (DataRow i in dataTable.Rows)
            {
                userId = (int)i["UserId"];
                userName = (string)i["userName"];
                userPassword = (string)i["userPassword"];
                userCode = (int)i["UserCode"];
                userKey = (string)i["userKey"];
            }
            return new User(userId, userName, userPassword, userCode, userKey);
        }
        //Create new user /Insert new user in db
        public void InserNewUser(string userName, string password, int rol){
            string query = $"Insert into [User] (userName, userPassword, UserCode) Values('{userName}', '{password}', '{rol}')";
            ExecuteEditQuery(query);
        }
        //Create private key -> so user can reset password.
        public void InsertPrivateKey(string privateKey, int userId){
            string query = $"update [user]set userKey='{privateKey}' where userid='{userId}'";
            ExecuteEditQuery(query);
        }
        //Reset password by User
        public void ResetPassword(string privateKey, int userId, string Password)
        {
            string query = $"update [user] set [userPassword] = '{Password}' where [userId]= '{userId}' AND [userKey] ='{privateKey}' ";
            ExecuteEditQuery(query);
        }
        //Return List of players -> Admin panel.
        public List<UserList> getAllUsersList(){
            string query = "select [userId], [userName], [title], [userKey]  from[user], [UserRol] where userCode = Rol_Id Order By [userId]";
            return RetrieveAllUsers(ExecuteSelectQuery(query));
        }
        //Return users values for list(admin page)
        private List<UserList> RetrieveAllUsers(DataTable dataTable){
            List<UserList> UserList = new List<UserList>();
            foreach (DataRow dr in dataTable.Rows)
            {
                userId = (int)dr["UserId"];
                userName = (string)dr["userName"].ToString();
                title = (string)dr["title"].ToString();
                userKey = (string)dr["userKey"].ToString();
                UserList user = new UserList(userId, userName, title, userKey);
                UserList.Add(user);
            }
            return UserList;
        }
    }
}
