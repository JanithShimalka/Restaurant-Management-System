using System;
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
            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pCategory.ToLower().Contains(btn.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, string name, string cat, string price, Image pimage) {
            var w = new ucProduct()
            {
                pName = name,
                pCategory = cat,
                pPrice = price,
                pImage = pimage,
                id = Convert.ToInt32(id)
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
                dataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.pName, 1, wdg.pPrice, wdg.pPrice });
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

               AddItems(item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(), item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imageArray)));
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
    }
}
