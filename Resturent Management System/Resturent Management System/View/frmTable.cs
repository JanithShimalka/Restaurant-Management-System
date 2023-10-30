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
    public partial class frmTable : sampleView
    {
        public frmTable()
        {
            InitializeComponent();
        }

        public void GetData()
        {

            /*
             first create tables table 

            Eg:
            Create table tables(
            tID int Primary Key,
            tName varchar(50)
            );
             */

            string qry = " Select * From tables where tName like '% " + txtsearch + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            mainclass.LoadData(qry, dataGridView1, lb);

        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            frmTableAdd frm = new frmTableAdd();
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
                frmCategoryAdd frm = new frmCategoryAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.ShowDialog();
                GetData();

            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from table where tId = " + id + " ";
                Hashtable ht = new Hashtable();
                mainclass.SQ1(qry, ht);

                MessageBox.Show("Deleted Successfully");
                GetData();

            }
        }
    }
}
