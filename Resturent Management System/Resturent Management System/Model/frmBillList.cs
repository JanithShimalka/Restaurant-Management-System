using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.Model
{
    public partial class frmBillList : sampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int mainID = 0;

        private void frmBillList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData() {
            string qry = " Select mainID,tableName,waiterName,orderType,status,total from tblMain where status <> 'Pending'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvwaiter);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvstatus);
            lb.Items.Add(dgvtotal);

            mainclass.LoadData(qry, dataGridView1, lb);
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                mainID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();

            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
