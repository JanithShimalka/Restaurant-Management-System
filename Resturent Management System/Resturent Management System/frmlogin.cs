using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainclass.isValid(textBox1.Text, textBox2.Text)==false)
            {
                MessageBox.Show("Please Check Your User Name And Password", "Invalid Details");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            else {
                this.Hide();
                frmMain frm1 = new frmMain();
                frm1.Show();
            }
        }
    }
}
