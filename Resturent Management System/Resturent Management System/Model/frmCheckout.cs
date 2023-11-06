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
    public partial class frmCheckout : sampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
        }
        public double amt;
        public int mainID = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtreceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtbillamount.Text, out amt);
            double.TryParse(txtreceived.Text, out receipt);

            change = Math.Abs(amt - receipt);
            btnChange.Text = change.ToString();

        }
        public override void button1_Click(object sender, EventArgs e)
        {
            string qry = @"update tblMain set total = @total, received = @rec, change = @change, status = 'Paid' where mainID = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", mainID);
            ht.Add("@total",txtbillamount.Text);
            ht.Add("@rec", txtreceived.Text);
            ht.Add("@change", btnChange.Text);

            if (mainclass.SQ1(qry, ht) > 0) {
                MessageBox.Show("Saved Successfully");
                this.Close();
            }

        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {
            txtbillamount.Text = amt.ToString();
        }
    }
}
