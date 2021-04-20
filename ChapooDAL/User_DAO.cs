using System;
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
        //Check if user does exist.(login)
        public User GetUser(string userName, string password)
        {
            string query = "select [UserId], [UserName], [userPassword], [UserCode], [userKey] from [User] where UserName = '" + userName + "' and   userPassword =  '" + password + "' ";
            return RetrieveUser(ExecuteSelectQuery(query));
        }
        //If user exist -> fill all the info
        private User RetrieveUser(DataTable dataTable)
        {
            int userId = 0;
            string userName = "";
            string userPassword = "";
            int userCode = 0;
            string userKey = "";

            foreach (DataRow i in dataTable.Rows)
            {
                {
                    userId = (int)i["UserId"];
                    userName = (string)i["userName"];
                    userPassword = (string)i["userPassword"];
                    userCode = (int)i["UserCode"];
                    userKey = (string)i["userKey"].ToString();
                };
            }
            return new User(userId, userName, userPassword, userCode, userKey);
        }

        //Create new user /Insert new user in db
        public void InserNewUser(string userName, string password, int rol)
        {
            string query = $"Insert into [User] (userName, userPassword, UserCode) Values('{userName}', '{password}', '{rol}')";
            ExecuteEditQuery(query);
        }

        //Create private key -> to reset password.
        public void InsertPrivateKey(string privateKey, int userId)
        {
            string query = $"update [user]set userKey='{privateKey}' where userid='{userId}'";
            ExecuteEditQuery(query);
        }

        //Return List of players -> Admin panel.
        public User getAllUsersList()
        {
            string query = "select userId, userName as Name, title, userKey as PrivateKey from[user], [UserRol] where userCode = Rol_Id";
            return RetrieveAllUsers(ExecuteSelectQuery(query));
        }
        //Return values for list
        private User RetrieveAllUsers(DataTable dataTable)
        {
            int userId = 0;
            string userName = "";
            string title = "";
            string PrivateKey = "";

            foreach (DataRow i in dataTable.Rows)
            {
                {
                    userId = (int)i["UserId"];
                    userName = (string)i["Name"];
                    title = (string)i["title"];
                    PrivateKey = (string)i["PrivateKey"].ToString();
                };
            }
            return new User(userId, userName, title, PrivateKey);
        }

        //return userId
        private void UserId()
        {
            string query = "select rol_id,Title from[UserRol]";
            ExecuteEditQuery(query);
        }


    }
}
