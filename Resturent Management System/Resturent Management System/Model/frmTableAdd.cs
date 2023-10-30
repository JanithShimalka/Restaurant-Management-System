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
    public partial class frmTableAdd : sampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;

        public override void button1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tables Values (@Name)";
            }

            else
            {
                qry = "Update tables set tName = @Name where tid = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textBox1.Text);

            if (mainclass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...");
                id = 0;
                textBox1.Text = "";
                textBox1.Focus();
            }

        }
    }
}
