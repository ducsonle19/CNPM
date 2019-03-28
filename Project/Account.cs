using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Account
    {
        public String ID { set; get; }
        public String Username { set; get; }
        public String Password { set; get; }

        public Account()
        {

        }

        public Account(String id, String username, String password)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
        }

        public bool isAdmin()
        {
            String type = this.ID.Substring(0, 2);

            if (type == "AD")
            {
                return true;
            }

            return false;
        }
    }
}
