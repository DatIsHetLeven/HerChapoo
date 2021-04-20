﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public int userCode { get; set; }
        public string userKey { get; set; }
        public string title { get; set; }

        public User(int UserId, string UserName, string UserPassword, int UserCode, string UserKey)
        {
            this.userId = UserId;
            this.userName = UserName;
            this.userPassword = UserPassword;
            this.userCode = UserCode;
            this.userKey = UserKey;
        }

        public User(int UserId, string UserName, string Title, string UserKey)
        {
            this.userId = UserId;
            this.userName = UserName;
            this.title = Title;
            this.userKey = UserKey;
        }
    }
}
