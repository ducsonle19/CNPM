using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class AccountDataBase
    {
        public enum Error { NONE, ACC_NOT_FOUND }

        private static AccountDataBase instance;

        public static AccountDataBase get()
        {
            if (instance == null)
            {
                instance = new AccountDataBase();
            }
            return instance;
        }

        private DataBaseManager manager;

        private AccountDataBase()
        {
            manager = new DataBaseManager();
            manager.open();
        }

        public Account login(String username, String password)
        {
            String sql = "select * from Account where username = @name and password = @pass";
            SqlParameter[] para = { new SqlParameter("@name", username), new SqlParameter("@pass", password) };

            DataTable table = manager.executeQuery(sql, para);
            if (table.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = table.Rows[0];

            Account acc = new Account((String)row["username"], (String)row["password"]);

            return acc;
        }
    }
}
