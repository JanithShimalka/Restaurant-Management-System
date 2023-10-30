using Resturent_Management_System.View;
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
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        public void Addcontrols(Form f) {
            panelc.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelc.Controls.Add(f);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void btnhome_Click(object sender, EventArgs e)
        {
            Addcontrols(new frmHone());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label2.Text = mainclass.USER;
        }

        private void btncatagories_Click(object sender, EventArgs e)
        {
            Addcontrols(new frmcategoryview());
        }

        private void btntables_Click(object sender, EventArgs e)
        {
            Addcontrols(new frmTable());
        }
    }
}
