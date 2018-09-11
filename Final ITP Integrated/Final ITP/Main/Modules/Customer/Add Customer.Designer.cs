namespace Main.Modules.Customer
{
    partial class Add_Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btadd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.responce = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            this.txtConNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btndemo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // txtComName
            // 
            this.txtComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComName.ForeColor = System.Drawing.Color.DimGray;
            this.txtComName.Location = new System.Drawing.Point(223, 41);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(442, 22);
            this.txtComName.TabIndex = 1;
            this.txtComName.Text = "Company Name";
            this.txtComName.Enter += new System.EventHandler(this.txtComName_Enter);
            this.txtComName.Leave += new System.EventHandler(this.txtComName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Date Of Birth";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(223, 322);
            this.dtpDOB.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(442, 20);
            this.dtpDOB.TabIndex = 13;
            this.dtpDOB.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // btadd
            // 
            this.btadd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(478, 516);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(166, 44);
            this.btadd.TabIndex = 14;
            this.btadd.Text = "Add Customer ";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Contact Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.responce);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CBcategory);
            this.groupBox1.Controls.Add(this.txtConNo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtAdd2);
            this.groupBox1.Controls.Add(this.txtAdd1);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtComName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(43, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 413);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Information";
            // 
            // responce
            // 
            this.responce.AutoSize = true;
            this.responce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responce.ForeColor = System.Drawing.Color.Red;
            this.responce.Location = new System.Drawing.Point(691, 244);
            this.responce.Name = "responce";
            this.responce.Size = new System.Drawing.Size(0, 20);
            this.responce.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Customer Category";
            // 
            // CBcategory
            // 
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Items.AddRange(new object[] {
            "Outdoor Advertising",
            "Indoor Advertising",
            "Event",
            "Project",
            "Digital Services",
            "Interactive Screen",
            "Production"});
            this.CBcategory.Location = new System.Drawing.Point(223, 358);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(442, 21);
            this.CBcategory.TabIndex = 25;
            this.CBcategory.Text = "Select Category";
            // 
            // txtConNo
            // 
            this.txtConNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNo.ForeColor = System.Drawing.Color.DimGray;
            this.txtConNo.Location = new System.Drawing.Point(223, 280);
            this.txtConNo.MaxLength = 10;
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(442, 22);
            this.txtConNo.TabIndex = 24;
            this.txtConNo.Text = "Contact Number";
            this.txtConNo.Enter += new System.EventHandler(this.txtConNo_Enter);
            this.txtConNo.Leave += new System.EventHandler(this.txtConNo_Leave_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(223, 240);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(442, 22);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAdd2
            // 
            this.txtAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd2.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdd2.Location = new System.Drawing.Point(223, 200);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(442, 22);
            this.txtAdd2.TabIndex = 22;
            this.txtAdd2.Text = "City";
            this.txtAdd2.Enter += new System.EventHandler(this.txtAdd2_Enter);
            this.txtAdd2.Leave += new System.EventHandler(this.txtAdd2_Leave);
            // 
            // txtAdd1
            // 
            this.txtAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd1.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdd1.Location = new System.Drawing.Point(223, 163);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(442, 22);
            this.txtAdd1.TabIndex = 21;
            this.txtAdd1.Text = "Address";
            this.txtAdd1.Enter += new System.EventHandler(this.txtAdd1_Enter);
            this.txtAdd1.Leave += new System.EventHandler(this.txtAdd1_Leave);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLName.Location = new System.Drawing.Point(223, 120);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(442, 22);
            this.txtLName.TabIndex = 20;
            this.txtLName.Text = "Last Name";
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFName.Location = new System.Drawing.Point(223, 81);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(442, 22);
            this.txtFName.TabIndex = 19;
            this.txtFName.Text = "First Name";
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // btndemo
            // 
            this.btndemo.Location = new System.Drawing.Point(311, 516);
            this.btndemo.Name = "btndemo";
            this.btndemo.Size = new System.Drawing.Size(161, 44);
            this.btndemo.TabIndex = 21;
            this.btndemo.Text = "Demo";
            this.btndemo.UseVisualStyleBackColor = true;
            this.btndemo.Click += new System.EventHandler(this.btndemo_Click);
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 581);
            this.Controls.Add(this.btndemo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Customer";
            this.Load += new System.EventHandler(this.Add_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBcategory;
        private System.Windows.Forms.Label responce;
        private System.Windows.Forms.Button btndemo;
    }
}