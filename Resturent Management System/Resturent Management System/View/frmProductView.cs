using Resturent_Management_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.View
{
    public partial class frmProductView : sampleView
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            /*
             first create Product table 

            Eg:
            create table products(
            pID int primary key,
            pName varchar(50),
            pPrice float,
            CategoryID int,
            pImage image
            );

             */

            string qry = " Select pID,pName,pPrice,CategoryID,c.catName from products p, catelog c on c.catID = p.CategoryID where pName like '% " + txtsearch + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatid);
            lb.Items.Add(dgvCat);

            mainclass.LoadData(qry, dataGridView1, lb);

        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            frmProductAdd frm = new frmProductAdd();
            frm.ShowDialog();
            GetData();

        }

        public override void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.cID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgncatID"]);
                frm.ShowDialog();
                GetData();

            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from products where pID = " + id + " ";
                Hashtable ht = new Hashtable();
                mainclass.SQ1(qry, ht);

                MessageBox.Show("Deleted Successfully");
                GetData();

            }
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {

        }
    }

}
