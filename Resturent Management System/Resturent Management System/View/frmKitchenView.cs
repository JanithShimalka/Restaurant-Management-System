using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders() {
            /*
            flowLayoutPanel1.Controls.Clear();
            string qry1 = @"Select * from tblMain where status = 'Pending' ";
            SqlCommand cmd1 = new SqlCommand(qry1,mainclass.con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt1);

            FlowLayoutPanel p1, p2;

            for (int i = 0; i < dt1.Rows.Count; i++) {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Height = 230;
                p1.Width = 350;
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);


                p2 = new FlowLayoutPanel();
                p2.AutoSize = true;
                p2.BackColor = Color.DarkSlateGray;
                p2.Height = 230;
                p2.Width = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.BorderStyle = BorderStyle.FixedSingle;
                p2.Margin = new Padding(0,0,0,0);

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;

                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 10, 3, 0);
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 10, 3, 0);
                lb4.AutoSize = true;

                lb1.Text = "Table : " + dt1.Rows[i]["TableName"].ToString();
                lb1.Text = "Waiter Name : " + dt1.Rows[i]["waiterName"].ToString();
                lb1.Text = "Order Time : " + dt1.Rows[i]["aTime"].ToString();
                lb1.Text = "Order Type : " + dt1.Rows[i]["orderType"].ToString();

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                int mid = 0;
                mid = Convert.ToInt32(dt1.Rows[i]["mainID"].ToString());

                string qry2 = @"Select * from tblMain m inner join tblDetails d on m.mainID = d.mainID inner join products p on p.pID = d,proID where m.mainID = "+mid+"";
                SqlCommand cmd2 = new SqlCommand(qry2, mainclass.con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                for (int j = 0; j<dt2.Rows .Count; j++)
                {
                    Label lb5 = new Label();
                    lb5.ForeColor = Color.White;
                    lb5.Margin = new Padding(10, 10, 3, 0);
                    lb5.AutoSize = true;

                    int no = j + 1;

                    lb5.Text = " " + no + " " + dt2.Rows[j]["pName"].ToString() + " " + dt2.Rows[j]["qty"].ToString();
                    p1.Controls.Add(lb5);
                }

                Button btn = new Button();
                btn.Size = new Size(100,35);
                btn.BackColor = Color.DarkTurquoise;
                btn.Margin = new Padding(30,5,3,10);
                btn.Text = "Complete";
                btn.Tag = dt1.Rows[i]["mainID"].ToString();

                btn.Click += new EventHandler(b_click);

                flowLayoutPanel1.Controls.Add(p1);

            }

            */

        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Button).Tag.ToString());
            string qry = @"Update tblMain set status = 'Complete' where mainID = @ID";
            Hashtable ht = new Hashtable();
            ht.Add("@ID", id);
            if (mainclass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully");
            }
            GetOrders();
        }
    }
}
