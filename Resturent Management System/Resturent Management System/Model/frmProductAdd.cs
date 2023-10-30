﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Management_System.Model
{
    public partial class frmProductAdd : sampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        string filepath;
        Byte[] imageByteArray;

        private void btnbrws_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg,.png)|*.png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK) {
                filepath = ofd.FileName;
                pictureBox2.Image = new Bitmap(filepath);
            }
        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id', catName 'name' from catalog ";
            mainclass.CBFill(qry,cbCat);

            if(cID > 0)
            {
                cbCat.SelectedValue = cID;
            }
            if(id > 0)
            {
                forUpdate();
            }
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into products Values (@Name, @price, @cat,@img)";
            }

            else
            {
                qry = "Update products set pName = @Name, pPrice = @price, CategoryID = @cat, pImage = @img where pID = @id";
            }

            Image temp = new Bitmap(pictureBox2.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", textBox1.Text);
            ht.Add("@price", textBox2.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (mainclass.SQ1(qry, ht) > 0)
            {
                MessageBox.Show("Saved Successfully...");
                id = 0;
                cID = 0;
                textBox1.Text = "";
                textBox2.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                textBox1.Focus();
                pictureBox2.Image = Resturent_Management_System.Properties.Resources.product2;
            }

        }
        private void forUpdate() {
            string qry = @"Select * from products where pid = "+ id +"";
            SqlCommand cmd = new SqlCommand(qry, mainclass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0) {
                textBox1.Text = dt.Rows[0]["pName"].ToString();
                textBox2.Text = dt.Rows[0]["pPrice"].ToString();

                Byte [] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                pictureBox2.Image = Image.FromStream(new MemoryStream(imageArray));
            }
        }
    }
}
