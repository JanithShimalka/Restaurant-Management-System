using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }
        public int mainId = 0;
        public string orderType;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCatagory();
            productPanel.Controls.Clear();
            LoadProduct();

        }

        private void AddCatagory() {
            /*
            string qry = "Select * from catalog";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            */
            categorypanel.Controls.Clear();
            /*
            if (dt.Rows.Count > 0) {
                foreach (DataRow row in dt.Rows) {
                    Button btn = new Button();
                    btn.BackColor = Color.DarkTurquoise; 
                    btn.Size = new Size(168, 48);
                    btn.AccessibleRole = AccessibleRole.RadioButton;
                    btn.Text = row["catName"].ToString();
                    btn.Click += new EventHandler(_Click);

                    categorypanel.Controls.Add(btn);
                }
            }
            */
        }

        private void _Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "All Categories") {
                txtsearch.Text = "1";
                txtsearch.Text = "";
                return;
            }
            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pCategory.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string proID,string name, string cat, string price, Image pimage) {
            var w = new ucProduct()
            {
                pName = name,
                pCategory = cat,
                pPrice = price,
                pImage = pimage,
                id = Convert.ToInt32(proID)
            };
            productPanel.Controls.Add(w);
            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                foreach (DataGridViewRow item in dataGridView1.Rows) {
                    if (Convert.ToInt32(item.Cells["dgvid"].Value) == wdg.id) {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;


                    }
                    
                }
                dataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.pName, 1, wdg.pPrice, wdg.pPrice });
                GetTotal();
            };
        }

        private void LoadProduct() {
            /*
            string qry = "select * from products inner join catelog on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imageArray = (byte[])item["pImage"];
                byte[] imagebytearry = imageArray;

               AddItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
            }*/
            
            }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productPanel.Controls) {
                var pro = (ucProduct)item;
                pro.Visible = pro.Name.ToLower().Contains(txtsearch.Text.Trim().ToLower());
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal() {
            double tot = 0;
            lbltot.Text = "";
            foreach (DataGridViewRow item in dataGridView1.Rows) {
                tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                lbltot.Text = tot.ToString("N2");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            lbltable.Text = "";
            lblwaiter.Text = "";
            lbltable.Visible = false;
            lblwaiter.Visible = false;
            dataGridView1.Rows.Clear();
            mainId = 0;
            lbltot.Text = "0.00";

        }

        private void btndelivery_Click(object sender, EventArgs e)
        {
            lbltable.Text = "";
            lblwaiter.Text = "";
            lbltable.Visible = false;
            lblwaiter.Visible = false;
            orderType = "Delivery";

        }

        private void btntake_Click(object sender, EventArgs e)
        {
            lbltable.Text = "";
            lblwaiter.Text = "";
            lbltable.Visible = false;
            lblwaiter.Visible = false;
            orderType = "Take Away";
        }

        private void btndin_Click(object sender, EventArgs e)
        {
            orderType = "Din In";
            frmTableSelect frm = new frmTableSelect();
            frm.Show();
            if (frm.tableName != "")
            {
                lbltable.Text = frm.tableName;
                lbltable.Visible = true;

            }
            else {
                lbltable.Text = "";
                lbltable.Visible = false;
            }

            frmWaiterSelect frm2 = new frmWaiterSelect();
            frm2.Show();
            if (frm2.waiterName != "")
            {
                lblwaiter.Text = frm2.waiterName;
                lblwaiter.Visible = true;

            }
            else
            {
                lblwaiter.Text = "";
                lblwaiter.Visible = false;
            }
        }

        private void btnkot_Click(object sender, EventArgs e)
        {
            /*
             create table tblMain(
            mainID int primary key,
            adate date,
            atime varchar(15),
            tableName varchar(10),
            waitername varchar(15),
            status varchar(15),
            ordrType varchar(15),
            total float,
            received float,
            change float 
            );

            create table tblDetails(
            DetailID int primary key,
            mainID int,
            proID int,
            qty int,
            price float,
            amount float
            );

             */

            string qry1 = "";
            string qry2 = "";
            int detailID = 0;

            if (mainId == 0)
            {
                qry1 = @"insert into tblMain values(@aDate,@aTime,@tableName,@waiterName,@status,@orderType,@total,@received,@change); Select SCOPE_IDENTITY()";

            }
            else {
                qry2 = @"update tblMain set status = @status, total = @total, received = @received, change =  @change where mainID = @ID";

            }

            //Hashtable ht = new Hashtable();
            /*
            SqlCommand cmd = new SqlCommand(qry1,mainclass.con);
            cmd.Parameters.AddWithValue("@ID",mainId);
            cmd.Parameters.AddWithValue("@aDate",Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime",DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@tableName",lbltable.Text);
            cmd.Parameters.AddWithValue("@waiterName",lblwaiter.Text);
            cmd.Parameters.AddWithValue("@status","Pending");
            cmd.Parameters.AddWithValue("@orderType",orderType);
            cmd.Parameters.AddWithValue("@total",Convert.ToDouble(lbltot.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (mainclass.con.State == ConnectionState.Closed) {
                mainclass.con.Open();
            }
            if (mainId == 0)
            {
                mainId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else {
                cmd.ExecuteNonQuery();
            }
            if (mainclass.con.State == ConnectionState.Open)
            {
                mainclass.con.Close();
            }

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);
                if(detailID == 0)
                {
                    qry2 = @"insert into tblDetails values(@mainId,@proID,@qty,@price,@amount)";
                }else
                {
                    qry2 = @"Update tblDetails set proID = @proID, qty = @qty, price = @price, amount = @amount Where DetailID = @ID";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, mainclass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@mainID", mainId);
                cmd2.Parameters.AddWithValue("@proID",Convert.ToInt32( row.Cells["proID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (mainclass.con.State == ConnectionState.Closed)
                {
                    mainclass.con.Open();
                }
                cmd2.ExecuteNonQuery();
                if (mainclass.con.State == ConnectionState.Open)
                {
                    mainclass.con.Close();
                }

                MessageBox.Show("Saved Successfully");
                mainId = 0;
                detailID = 0;
                dataGridView1.Rows.Clear();
                lbltable.Text = "";
                lblwaiter.Text = "";
                lbltable.Visible = false;
                lblwaiter.Visible = false;
                lbltot.Text = "0.00";

            }
            */


            /*
             Select * from tblMain m inner join tblDetails d on m.mainID = d.mainID ; 
             */
        }

        public int id = 0;
        private void btnbill_Click(object sender, EventArgs e)
        {
            frmBillList frm = new frmBillList();
            frm.ShowDialog();

            if (frm.mainID > 0) {
                id = frm.mainID;
                LoadEntries();
            }
        }
        private void LoadEntries() {

            /*

            string qry = @"Select* from tblMain m inner join tblDetails d on m.mainID = d.mainID inner join products p on p.pID = d,proID where m.mainID = "+id+"";
            SqlCommand cmd2 = new SqlCommand(qry, mainclass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            if (dt2.Rows[0]["orderType"].ToString() == "Delivery")
            {
                lblwaiter.Visible = false;
                lbltable.Visible = false;
                btndelivery.Focus();
            }
            else if (dt2.Rows[0]["orderType"].ToString() == "Take Away")
            {
                lblwaiter.Visible = false;
                lbltable.Visible = false;
                btntake.Focus();
            }
            else {
                lblwaiter.Visible = false;
                lbltable.Visible = false;
            }

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows) {

                lbltable.Text = item["tableName"].ToString();
                lblwaiter.Text = item["waiterName"].ToString();

                string detailID = item["detailID"].ToString();
                string proName = item["pName"].ToString();
                string proID = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = {0,detailID,proID, proName, qty,price,amount };
                dataGridView1.Rows.Add(obj); 
            }
            GetTotal();

            */
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.mainID = id;
            frm.amt = Convert.ToDouble(lbltot.Text);
            frm.ShowDialog();

            mainId = 0;
            dataGridView1.Rows.Clear();
            lbltable.Text = "";
            lblwaiter.Text = "";
            lbltable.Visible = false;
            lblwaiter.Visible = false;
            lbltot.Text = "0.00";
        }
    }
}
