namespace Resturent_Management_System.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltable = new System.Windows.Forms.Label();
            this.lblwaiter = new System.Windows.Forms.Label();
            this.btndin = new System.Windows.Forms.Button();
            this.btntake = new System.Windows.Forms.Button();
            this.btnkot = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.btndelivery = new System.Windows.Forms.Button();
            this.btnhold = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbltot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categorypanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.productPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucProduct1 = new Resturent_Management_System.Model.ucProduct();
            this.ucProduct2 = new Resturent_Management_System.Model.ucProduct();
            this.ucProduct3 = new Resturent_Management_System.Model.ucProduct();
            this.ucProduct4 = new Resturent_Management_System.Model.ucProduct();
            this.ucProduct5 = new Resturent_Management_System.Model.ucProduct();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.categorypanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbltable);
            this.panel1.Controls.Add(this.lblwaiter);
            this.panel1.Controls.Add(this.btndin);
            this.panel1.Controls.Add(this.btntake);
            this.panel1.Controls.Add(this.btnkot);
            this.panel1.Controls.Add(this.btnbill);
            this.panel1.Controls.Add(this.btndelivery);
            this.panel1.Controls.Add(this.btnhold);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.BackColor = System.Drawing.Color.Transparent;
            this.lbltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltable.ForeColor = System.Drawing.Color.White;
            this.lbltable.Location = new System.Drawing.Point(798, 22);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(65, 26);
            this.lbltable.TabIndex = 2;
            this.lbltable.Text = "Table";
            this.lbltable.Visible = false;
            this.lbltable.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblwaiter
            // 
            this.lblwaiter.AutoSize = true;
            this.lblwaiter.BackColor = System.Drawing.Color.Transparent;
            this.lblwaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwaiter.ForeColor = System.Drawing.Color.White;
            this.lblwaiter.Location = new System.Drawing.Point(798, 52);
            this.lblwaiter.Name = "lblwaiter";
            this.lblwaiter.Size = new System.Drawing.Size(75, 26);
            this.lblwaiter.TabIndex = 3;
            this.lblwaiter.Text = "Waiter";
            this.lblwaiter.Visible = false;
            // 
            // btndin
            // 
            this.btndin.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btndin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndin.ForeColor = System.Drawing.Color.White;
            this.btndin.Location = new System.Drawing.Point(711, 12);
            this.btndin.Name = "btndin";
            this.btndin.Size = new System.Drawing.Size(65, 66);
            this.btndin.TabIndex = 8;
            this.btndin.Text = "Din in";
            this.btndin.UseVisualStyleBackColor = false;
            this.btndin.Click += new System.EventHandler(this.btndin_Click);
            // 
            // btntake
            // 
            this.btntake.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btntake.BackColor = System.Drawing.Color.DodgerBlue;
            this.btntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntake.ForeColor = System.Drawing.Color.White;
            this.btntake.Location = new System.Drawing.Point(628, 12);
            this.btntake.Name = "btntake";
            this.btntake.Size = new System.Drawing.Size(65, 66);
            this.btntake.TabIndex = 7;
            this.btntake.Text = "Take Away";
            this.btntake.UseVisualStyleBackColor = false;
            this.btntake.Click += new System.EventHandler(this.btntake_Click);
            // 
            // btnkot
            // 
            this.btnkot.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnkot.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnkot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkot.ForeColor = System.Drawing.Color.White;
            this.btnkot.Location = new System.Drawing.Point(465, 12);
            this.btnkot.Name = "btnkot";
            this.btnkot.Size = new System.Drawing.Size(65, 66);
            this.btnkot.TabIndex = 5;
            this.btnkot.Text = "KOT";
            this.btnkot.UseVisualStyleBackColor = false;
            this.btnkot.Click += new System.EventHandler(this.btnkot_Click);
            // 
            // btnbill
            // 
            this.btnbill.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnbill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.ForeColor = System.Drawing.Color.White;
            this.btnbill.Location = new System.Drawing.Point(384, 12);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(65, 66);
            this.btnbill.TabIndex = 4;
            this.btnbill.Text = "Bill List";
            this.btnbill.UseVisualStyleBackColor = false;
            // 
            // btndelivery
            // 
            this.btndelivery.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btndelivery.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelivery.ForeColor = System.Drawing.Color.White;
            this.btndelivery.Location = new System.Drawing.Point(546, 12);
            this.btndelivery.Name = "btndelivery";
            this.btndelivery.Size = new System.Drawing.Size(65, 66);
            this.btndelivery.TabIndex = 6;
            this.btndelivery.Text = "Delivery";
            this.btndelivery.UseVisualStyleBackColor = false;
            this.btndelivery.Click += new System.EventHandler(this.btndelivery_Click);
            // 
            // btnhold
            // 
            this.btnhold.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnhold.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhold.ForeColor = System.Drawing.Color.White;
            this.btnhold.Location = new System.Drawing.Point(304, 12);
            this.btnhold.Name = "btnhold";
            this.btnhold.Size = new System.Drawing.Size(65, 66);
            this.btnhold.TabIndex = 3;
            this.btnhold.Text = "Hold";
            this.btnhold.UseVisualStyleBackColor = false;
            // 
            // btnnew
            // 
            this.btnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnnew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(223, 12);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(65, 66);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lbltot);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 52);
            this.panel2.TabIndex = 1;
            // 
            // lbltot
            // 
            this.lbltot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltot.AutoSize = true;
            this.lbltot.BackColor = System.Drawing.Color.Transparent;
            this.lbltot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltot.ForeColor = System.Drawing.Color.White;
            this.lbltot.Location = new System.Drawing.Point(861, 17);
            this.lbltot.Name = "lbltot";
            this.lbltot.Size = new System.Drawing.Size(54, 26);
            this.lbltot.TabIndex = 3;
            this.lbltot.Text = "0.00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(786, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // categorypanel
            // 
            this.categorypanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.categorypanel.Controls.Add(this.button1);
            this.categorypanel.Location = new System.Drawing.Point(12, 145);
            this.categorypanel.Name = "categorypanel";
            this.categorypanel.Size = new System.Drawing.Size(171, 327);
            this.categorypanel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPanel.Controls.Add(this.ucProduct1);
            this.productPanel.Controls.Add(this.ucProduct2);
            this.productPanel.Controls.Add(this.ucProduct3);
            this.productPanel.Controls.Add(this.ucProduct4);
            this.productPanel.Controls.Add(this.ucProduct5);
            this.productPanel.Location = new System.Drawing.Point(189, 145);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(504, 327);
            this.productPanel.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.proID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            this.dataGridView1.Location = new System.Drawing.Point(699, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(258, 327);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(192, 118);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(221, 20);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Resturent_Management_System.Properties.Resources.pwr;
            this.pictureBox2.Location = new System.Drawing.Point(910, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Resturent_Management_System.Properties.Resources.food1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucProduct1
            // 
            this.ucProduct1.id = 0;
            this.ucProduct1.Location = new System.Drawing.Point(3, 3);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.pCategory = null;
            this.ucProduct1.pImage = ((System.Drawing.Image)(resources.GetObject("ucProduct1.pImage")));
            this.ucProduct1.pName = "Product Name";
            this.ucProduct1.pPrice = null;
            this.ucProduct1.Size = new System.Drawing.Size(119, 155);
            this.ucProduct1.TabIndex = 0;
            // 
            // ucProduct2
            // 
            this.ucProduct2.id = 0;
            this.ucProduct2.Location = new System.Drawing.Point(128, 3);
            this.ucProduct2.Name = "ucProduct2";
            this.ucProduct2.pCategory = null;
            this.ucProduct2.pImage = ((System.Drawing.Image)(resources.GetObject("ucProduct2.pImage")));
            this.ucProduct2.pName = "Product Name";
            this.ucProduct2.pPrice = null;
            this.ucProduct2.Size = new System.Drawing.Size(119, 155);
            this.ucProduct2.TabIndex = 1;
            // 
            // ucProduct3
            // 
            this.ucProduct3.id = 0;
            this.ucProduct3.Location = new System.Drawing.Point(253, 3);
            this.ucProduct3.Name = "ucProduct3";
            this.ucProduct3.pCategory = null;
            this.ucProduct3.pImage = ((System.Drawing.Image)(resources.GetObject("ucProduct3.pImage")));
            this.ucProduct3.pName = "Product Name";
            this.ucProduct3.pPrice = null;
            this.ucProduct3.Size = new System.Drawing.Size(119, 155);
            this.ucProduct3.TabIndex = 2;
            // 
            // ucProduct4
            // 
            this.ucProduct4.id = 0;
            this.ucProduct4.Location = new System.Drawing.Point(378, 3);
            this.ucProduct4.Name = "ucProduct4";
            this.ucProduct4.pCategory = null;
            this.ucProduct4.pImage = ((System.Drawing.Image)(resources.GetObject("ucProduct4.pImage")));
            this.ucProduct4.pName = "Product Name";
            this.ucProduct4.pPrice = null;
            this.ucProduct4.Size = new System.Drawing.Size(119, 155);
            this.ucProduct4.TabIndex = 3;
            // 
            // ucProduct5
            // 
            this.ucProduct5.id = 0;
            this.ucProduct5.Location = new System.Drawing.Point(3, 164);
            this.ucProduct5.Name = "ucProduct5";
            this.ucProduct5.pCategory = null;
            this.ucProduct5.pImage = ((System.Drawing.Image)(resources.GetObject("ucProduct5.pImage")));
            this.ucProduct5.pName = "Product Name";
            this.ucProduct5.pPrice = null;
            this.ucProduct5.Size = new System.Drawing.Size(119, 155);
            this.ucProduct5.TabIndex = 4;
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 40;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 40;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // proID
            // 
            this.proID.HeaderText = "ProductID";
            this.proID.Name = "proID";
            this.proID.ReadOnly = true;
            this.proID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 30F;
            this.dgvQty.HeaderText = "QTY";
            this.dgvQty.MinimumWidth = 30;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 30;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 50F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 50;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 50;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(969, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.categorypanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.categorypanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.Label lblwaiter;
        private System.Windows.Forms.Button btndin;
        private System.Windows.Forms.Button btntake;
        private System.Windows.Forms.Button btnkot;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Button btndelivery;
        private System.Windows.Forms.Button btnhold;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel categorypanel;
        private System.Windows.Forms.FlowLayoutPanel productPanel;
        public System.Windows.Forms.DataGridView dataGridView1;
        private ucProduct ucProduct1;
        private ucProduct ucProduct2;
        private ucProduct ucProduct3;
        private ucProduct ucProduct4;
        private ucProduct ucProduct5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lbltot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
    }
}