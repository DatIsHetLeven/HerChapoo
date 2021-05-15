using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class UserList
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string userKey { get; set; }
        public string title { get; set; }


        public UserList(int UserId, string UserName, string Title, string UserKey)
        {
            this.userId = UserId;
            this.userName = UserName;
            this.title = Title;
            this.userKey = UserKey;
        }
        public UserList(int UserId, string UserName)
        {
            this.userId = UserId;
            this.userName = UserName;
        }

    }
}
