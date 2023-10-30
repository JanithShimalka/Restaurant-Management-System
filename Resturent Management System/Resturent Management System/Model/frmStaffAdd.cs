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

namespace Resturent_Management_System.Model
{
    public partial class frmStaffAdd : sampleAdd
    {
        public frmStaffAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {

        }
        
        public override void button1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into staff Values (@Name, @phone, @role)";
            }

            else
            {
                qry = "Update staff set sName = @Name, sPhone = @phone, sRole = @role where staffID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textBox1.Text);
            ht.Add("@phone", textBox2.Text);
            ht.Add("@role", comboBox1.Text);

            if (mainclass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...");
                id = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
                textBox1.Focus();
            }

        }
    }
}
