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
    public partial class frmStaffView : sampleView
    {
        public frmStaffView()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            /*
             first create Staff table 

            Eg:
            Create table staff(
            staffID int Primary Key,
            sName varchar(50),
            sPhone varchar(50),
            sRole varchar(50)
            );
             */

            string qry = " Select * From staff where sName like '% " + txtsearch + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);

            mainclass.LoadData(qry, dataGridView1, lb);

        }
        private void frmStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void btnadd_Click(object sender, EventArgs e)
        {
            frmStaffAdd frm = new frmStaffAdd();
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
                frmStaffAdd frm = new frmStaffAdd();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.comboBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["dgvRole"].Value);
                frm.ShowDialog();
                GetData();

            }
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                string qry = "Delete from staff where staffID = " + id + " ";
                Hashtable ht = new Hashtable();
                mainclass.SQ1(qry, ht);

                MessageBox.Show("Deleted Successfully");
                GetData();

            }
        }
    }
}
