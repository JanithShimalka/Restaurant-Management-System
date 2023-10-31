using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.Model
{
    

    public partial class ucProduct : UserControl
    {

        public event EventHandler onSelect = null;

        public ucProduct()
        {
            InitializeComponent();
        }
        public int id {
            get; set;

        }
        public string pPrice
        {
            get; set;

        }

        public string pCategory
        {
            get; set;

        }
        public string pName {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public Image pImage
        {
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
