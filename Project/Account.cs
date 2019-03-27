using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Account
    {
        public String Username { set; get; }
        public String Password { set; get; }

        public Account()
        {

        }

        public Account(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
