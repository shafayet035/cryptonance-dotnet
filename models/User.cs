using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptonance.models
{
    internal class User
    {
        public object id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public User(object id, string username, string email, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
        }

        public void UpdateUsername(string username)
        {
            this.username = username;
        }

        public void UpdatePassword(string password)
        {
            this.password = password;
        }

    }
}
