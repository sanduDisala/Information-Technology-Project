namespace Main.Modules.Customer
{
    partial class Payments
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.totalAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnBillSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddPayment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFullPay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Advance Payment";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(204, 427);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(200, 20);
            this.txtAdvance.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Advance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(505, 95);
            this.dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Print Receipt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpPayDate);
            this.groupBox1.Controls.Add(this.totalAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhoneSearch);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.dataGridView3);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.btnBillSearch);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAdvance);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 549);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advance Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pay Date";
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Location = new System.Drawing.Point(204, 453);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPayDate.TabIndex = 19;
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.ForeColor = System.Drawing.Color.Red;
            this.totalAmount.Location = new System.Drawing.Point(201, 395);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(0, 13);
            this.totalAmount.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Do you want to search the  Bill Number??";
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneSearch.Location = new System.Drawing.Point(17, 64);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(186, 20);
            this.txtPhoneSearch.TabIndex = 15;
            this.txtPhoneSearch.Text = "Contact Number";
            this.txtPhoneSearch.Enter += new System.EventHandler(this.txtPhoneSearch_Enter);
            this.txtPhoneSearch.Leave += new System.EventHandler(this.txtPhoneSearch_Leave);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(227, 64);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(144, 20);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search Bill number";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(10, 99);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(499, 89);
            this.dataGridView3.TabIndex = 13;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(17, 236);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(184, 20);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.Text = "No";
            // 
            // btnBillSearch
            // 
            this.btnBillSearch.Location = new System.Drawing.Point(228, 233);
            this.btnBillSearch.Name = "btnBillSearch";
            this.btnBillSearch.Size = new System.Drawing.Size(143, 23);
            this.btnBillSearch.TabIndex = 11;
            this.btnBillSearch.Text = "Bill";
            this.btnBillSearch.UseVisualStyleBackColor = true;
            this.btnBillSearch.Click += new System.EventHandler(this.btnBillSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblPayment);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAddPayment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFullPay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(545, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 425);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Full Payment";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(211, 220);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(0, 13);
            this.lblPayment.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Your Payment Amount Is";
            // 
            // txtAddPayment
            // 
            this.txtAddPayment.Location = new System.Drawing.Point(147, 271);
            this.txtAddPayment.Name = "txtAddPayment";
            this.txtAddPayment.Size = new System.Drawing.Size(200, 20);
            this.txtAddPayment.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Add Payment";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 31);
            this.button4.TabIndex = 21;
            this.button4.Text = "Add Payment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Bill No Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-135, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date";
            // 
            // dtpFullPay
            // 
            this.dtpFullPay.Location = new System.Drawing.Point(147, 303);
            this.dtpFullPay.Name = "dtpFullPay";
            this.dtpFullPay.Size = new System.Drawing.Size(200, 20);
            this.dtpFullPay.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-144, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Payment Type";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(497, 89);
            this.dataGridView2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pay Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-144, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Amount";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(278, 43);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(123, 29);
            this.btnBill.TabIndex = 27;
            this.btnBill.Text = "View receipt";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(110, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 31);
            this.button6.TabIndex = 26;
            this.button6.Text = "Add receipt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btnBill);
            this.groupBox3.Location = new System.Drawing.Point(545, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 113);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnBillSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFullPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.TextBox txtAddPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}