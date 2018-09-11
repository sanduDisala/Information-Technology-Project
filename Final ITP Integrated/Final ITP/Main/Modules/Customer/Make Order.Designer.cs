namespace Main.Modules.Customer
{
    partial class Make_Order_Copy
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
            this.btmakeorder = new System.Windows.Forms.Button();
            this.dtpreturn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RByes = new System.Windows.Forms.RadioButton();
            this.RBno = new System.Windows.Forms.RadioButton();
            this.txtDadd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btremove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LItems = new System.Windows.Forms.DataGridView();
            this.itemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btngo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmakeorder
            // 
            this.btmakeorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmakeorder.Location = new System.Drawing.Point(645, 324);
            this.btmakeorder.Name = "btmakeorder";
            this.btmakeorder.Size = new System.Drawing.Size(164, 41);
            this.btmakeorder.TabIndex = 0;
            this.btmakeorder.Text = "Make Order";
            this.btmakeorder.UseVisualStyleBackColor = true;
            this.btmakeorder.Click += new System.EventHandler(this.btmakeorder_Click);
            // 
            // dtpreturn
            // 
            this.dtpreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpreturn.Location = new System.Drawing.Point(172, 244);
            this.dtpreturn.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpreturn.MinDate = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtpreturn.Name = "dtpreturn";
            this.dtpreturn.Size = new System.Drawing.Size(295, 20);
            this.dtpreturn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transport Facilties";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Deliver Address";
            // 
            // RByes
            // 
            this.RByes.AutoSize = true;
            this.RByes.Location = new System.Drawing.Point(172, 305);
            this.RByes.Name = "RByes";
            this.RByes.Size = new System.Drawing.Size(43, 17);
            this.RByes.TabIndex = 11;
            this.RByes.TabStop = true;
            this.RByes.Text = "Yes";
            this.RByes.UseVisualStyleBackColor = true;
            // 
            // RBno
            // 
            this.RBno.AutoSize = true;
            this.RBno.Location = new System.Drawing.Point(263, 304);
            this.RBno.Name = "RBno";
            this.RBno.Size = new System.Drawing.Size(39, 17);
            this.RBno.TabIndex = 12;
            this.RBno.TabStop = true;
            this.RBno.Text = "No";
            this.RBno.UseVisualStyleBackColor = true;
            // 
            // txtDadd
            // 
            this.txtDadd.ForeColor = System.Drawing.Color.DimGray;
            this.txtDadd.Location = new System.Drawing.Point(172, 363);
            this.txtDadd.Multiline = true;
            this.txtDadd.Name = "txtDadd";
            this.txtDadd.Size = new System.Drawing.Size(295, 48);
            this.txtDadd.TabIndex = 13;
            this.txtDadd.Text = "Address";
            this.txtDadd.Enter += new System.EventHandler(this.txtDadd_Enter);
            this.txtDadd.Leave += new System.EventHandler(this.txtDadd_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btmakeorder);
            this.groupBox1.Controls.Add(this.btremove);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtDadd);
            this.groupBox1.Controls.Add(this.RBno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RByes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpreturn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(57, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 453);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Items ";
            // 
            // btremove
            // 
            this.btremove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btremove.Location = new System.Drawing.Point(668, 233);
            this.btremove.Name = "btremove";
            this.btremove.Size = new System.Drawing.Size(114, 31);
            this.btremove.TabIndex = 17;
            this.btremove.Text = "Remove";
            this.btremove.UseVisualStyleBackColor = true;
            this.btremove.Click += new System.EventHandler(this.btremove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(16, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 178);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(430, 148);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LItems);
            this.groupBox4.Location = new System.Drawing.Point(484, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 175);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selected Items";
            // 
            // LItems
            // 
            this.LItems.AllowUserToAddRows = false;
            this.LItems.AllowUserToDeleteRows = false;
            this.LItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNo,
            this.itemName,
            this.itemCategory,
            this.origin,
            this.price,
            this.quantity});
            this.LItems.Location = new System.Drawing.Point(14, 17);
            this.LItems.Name = "LItems";
            this.LItems.Size = new System.Drawing.Size(465, 148);
            this.LItems.TabIndex = 18;
            // 
            // itemNo
            // 
            this.itemNo.HeaderText = "Item no";
            this.itemNo.Name = "itemNo";
            this.itemNo.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemCategory
            // 
            this.itemCategory.HeaderText = "Item category";
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.ReadOnly = true;
            // 
            // origin
            // 
            this.origin.HeaderText = "Origin";
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Contact Number";
            // 
            // txtConNo
            // 
            this.txtConNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtConNo.Location = new System.Drawing.Point(132, 50);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(251, 20);
            this.txtConNo.TabIndex = 22;
            this.txtConNo.Text = "Contact Number";
            this.txtConNo.Enter += new System.EventHandler(this.txtConNo_Enter);
            this.txtConNo.Leave += new System.EventHandler(this.txtConNo_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btngo);
            this.groupBox2.Controls.Add(this.txtConNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(57, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 76);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Outdoor Advertising",
            "Indoor Advertising",
            "Event",
            "Project",
            "Digital Services",
            "Interactive Screen",
            "Production"});
            this.cmbCategory.Location = new System.Drawing.Point(132, 16);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(251, 21);
            this.cmbCategory.TabIndex = 25;
            this.cmbCategory.Text = "Select Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Category";
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(415, 30);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(39, 33);
            this.btngo.TabIndex = 23;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // Make_Order_Copy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Make_Order_Copy";
            this.Text = "Make_Order";
           // this.Load += new System.EventHandler(this.Make_Order_Copy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmakeorder;
        private System.Windows.Forms.DateTimePicker dtpreturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RByes;
        private System.Windows.Forms.RadioButton RBno;
        private System.Windows.Forms.TextBox txtDadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btremove;
        private System.Windows.Forms.DataGridView LItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}