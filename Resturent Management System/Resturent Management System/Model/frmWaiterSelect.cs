﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.Model
{
    public partial class frmWaiterSelect : Form
    {
        public frmWaiterSelect()
        {
            InitializeComponent();
        }
        public string waiterName;

        private void frmWaiterSelect_Load(object sender, EventArgs e)
        { /*
            string qry = "Select * from staff where sRole like 'waiter'";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Button btn = new Button();
                btn.Text = row["sName"].ToString();
                btn.Width = 150;
                btn.Height = 50;
                btn.BackColor = Color.DarkTurquoise;
                btn.Click += new EventHandler(_Click);
                flowLayoutPanel1.Controls.Add(btn);

            }
            */

        }
        private void _Click(object sender, EventArgs e)
        {
            waiterName = (sender as Button).Text.ToString();
            this.Close();
        }
    }
}
