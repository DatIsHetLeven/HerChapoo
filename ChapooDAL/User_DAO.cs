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
                    userKey = (string)i["userKey"];
                };
            }
            return new User(userId, userName, userPassword, userCode, userKey);
            //return new User();
        }

        //Create new user /Insert new user in db
        public void InserNewUser(string userName, string password, int rol)
        {
            string query = $"Insert into [User] (userName, userPassword, UserCode) Values('{userName}', '{password}', '{rol}')";
            ExecuteEditQuery(query);
        }

        //Create private key -> so user can reset password.
        public void InsertPrivateKey(string privateKey, int userId)
        {
            string query = $"update [user]set userKey='{privateKey}' where userid='{userId}'";
            ExecuteEditQuery(query);
        }

        //Return List of players -> Admin panel.
        public List<UserList> getAllUsersList()
        {
            string query = "select [userId], [userName], [title], [userKey]  from[user], [UserRol] where userCode = Rol_Id";
            return RetrieveAllUsers(ExecuteSelectQuery(query));
        }
        //Return users values for list(admin page)
        private List<UserList> RetrieveAllUsers(DataTable dataTable)
        {
            int userId = 0;
            string userName = "";
            string title = "";
            string userKey = "";

            List<UserList> UserList = new List<UserList>();

            foreach (DataRow dr in dataTable.Rows)
            {
                UserList user = new UserList(userId, userName, title, userKey);
                {
                    userId = (int)dr["UserId"];
                    userName = (string)dr["userName"].ToString();
                    title = (string)dr["title"].ToString();
                    userKey = (string)dr["userKey"].ToString();
                };
                if (user.userId != 0)
                {
                    UserList.Add(user);
                }
            }
            return UserList;
        }
        private void UserIdtest()
        {
            string query = "select rol_id,Title from[UserRol]";
            ExecuteEditQuery(query);
        }
        //List userId
        public List<string> UserIdDropdown()
        {
            string query = "select userId from[user]";
            return UserId(ExecuteSelectQuery(query));
        }

        private List<string> UserId(DataTable datatable)
        {
            int userId = 1;

            List<string> UserIdList = new List<string>();

            foreach (DataRow item in datatable.Rows)
            {
                userId = (int)item["userId"];
                UserIdList.Add(userId.ToString());
            }
            return UserIdList;
        }

        //List userRol
        public List<string> userRol()
        {
            string query = "select [Title] from [userrol]";
            return UserRoll(ExecuteSelectQuery(query));
        }

        private List<string> UserRoll(DataTable datatable)
        {
            List<string> UserIdList = new List<string>();

            foreach (DataRow item in datatable.Rows)
            {
                string Title = (string)item["Title"];
                UserIdList.Add(Title.ToString());
            }
            return UserIdList;
        }
    }
}
