namespace Resturent_Management_System.Model
{
    partial class frmCheckout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtreceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbillamount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Size = new System.Drawing.Size(434, 102);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.Controls.SetChildIndex(this.lblheader, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox2, 0);
            // 
            // lblheader
            // 
            this.lblheader.Size = new System.Drawing.Size(108, 24);
            this.lblheader.Text = "Check Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Resturent_Management_System.Properties.Resources.bill;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Resturent_Management_System.Properties.Resources.pwr;
            this.pictureBox2.Location = new System.Drawing.Point(380, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(44, 298);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(258, 22);
            this.btnChange.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Change";
            // 
            // txtreceived
            // 
            this.txtreceived.Location = new System.Drawing.Point(44, 218);
            this.txtreceived.Name = "txtreceived";
            this.txtreceived.Size = new System.Drawing.Size(258, 22);
            this.txtreceived.TabIndex = 15;
            this.txtreceived.TextChanged += new System.EventHandler(this.txtreceived_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Payment Received";
            // 
            // txtbillamount
            // 
            this.txtbillamount.Enabled = false;
            this.txtbillamount.Location = new System.Drawing.Point(44, 146);
            this.txtbillamount.Name = "txtbillamount";
            this.txtbillamount.Size = new System.Drawing.Size(258, 22);
            this.txtbillamount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bill Amount";
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 414);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtreceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbillamount);
            this.Controls.Add(this.label1);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtbillamount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtreceived, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnChange, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox btnChange;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtreceived;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbillamount;
        private System.Windows.Forms.Label label1;
    }
}