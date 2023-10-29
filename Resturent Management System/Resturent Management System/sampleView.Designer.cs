namespace Resturent_Management_System
{
    partial class sampleView
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(485, 83);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(221, 22);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Image = global::Resturent_Management_System.Properties.Resources.add;
            this.btnadd.Location = new System.Drawing.Point(26, 64);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(51, 52);
            this.btnadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnadd.TabIndex = 2;
            this.btnadd.TabStop = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Header Text";
            // 
            // sampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sampleView";
            this.Text = "sampleView";
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.PictureBox btnadd;
        public System.Windows.Forms.Label label2;
    }
}