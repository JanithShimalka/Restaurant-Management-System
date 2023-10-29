using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System
{
    class mainclass
    {
        public static readonly string con_string = "Data Source=servername;Initial Catalog=dbname;User ID=sa;Password=123";
        public static SqlConnection con = new SqlConnection(con_string);
        

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
                USER = "Mahima"; // Read DB User Name here
            }
            return isvalid;

        }
        public static string user;

        public static string USER {
            private set { user = "Hello, "+ value; }
            get { return user; }
            
                
       }
        public static int SQ1(string qry, Hashtable ht) {
            int res = 0;
            /*
            try {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht) {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) {
                    con.Open();
                }
                res = cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            */
            return res;
        }

        public static void LoadData(string qry, DataGridView gv, ListBox lb) {
            /*
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++) {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                con.Close();
                
            }

            */
        }
    }
}
