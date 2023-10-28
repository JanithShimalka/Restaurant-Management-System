using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Management_System
{
    class mainclass
    {/*
        public static readonly string con_string = "Data Source=JANITH;Initial Catalog=resman;User ID=sa;Password=123";
        public static SqlConnection con = new SqlConnection(con_string);
        */

        public static bool isValid(string user, string pass)
        {
            bool isvalid = false;
            /*
            string query = @"select * from users where username = '" + user + "'and upass = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                isvalid = true;
            }
            */
            // Hard coded User Name And Password, Connect your db for real usernames and passwords
            if (user == "admin" && pass == "123")
            {
                isvalid = true;
            }
            return isvalid;

        }
    }
}
