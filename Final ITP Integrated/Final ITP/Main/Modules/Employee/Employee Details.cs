
using System.ComponentModel;

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Globalization;

namespace Main.Module.Employee
{
    public partial class Employee_Details : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        private Label label13;
        private Button emp_detail_exit;
        private Button emp_detail_clear;
        private Button pd_submit;
        private RadioButton male;
        private RadioButton female;
        private DateTimePicker dateTimePicker1;
        private TextBox pd_nation;
        private TextBox pd_nic;
        private TextBox pdfullname;
        private TextBox pdinitial;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label11;
        private TextBox pd_accno;
        private Label label1;
        private TextBox pd_bb;
        private Label label10;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button pd_edit;
        private Label pd_empcode;
        private Label pd_err_initial;
        private Label pd_err_fullname;
        private Label pd_err_dob;
        private Label pd_err_radio;
        private Label pd_err_nic;
        private Label pd_err_accno;
        private Label pd_err_bb;
        private Label pd_err_bank;
        private Label pd_national_err;
        private ComboBox pd_bank;
        private Button button2;
        private Button emp_details_next;
        private Label pd_err_ecode;
        private Button pd_getDetails;
        private TextBox pd_ecode_tb;
        private Button pd_save;
        private Button demo;
        private Label label12;

        public Employee_Details()
        {
            InitializeComponent();
            this.ActiveControl = pdinitial;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Details));
            this.label13 = new System.Windows.Forms.Label();
            this.emp_detail_exit = new System.Windows.Forms.Button();
            this.emp_detail_clear = new System.Windows.Forms.Button();
            this.pd_submit = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pd_nation = new System.Windows.Forms.TextBox();
            this.pd_nic = new System.Windows.Forms.TextBox();
            this.pdfullname = new System.Windows.Forms.TextBox();
            this.pdinitial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pd_accno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pd_bb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.demo = new System.Windows.Forms.Button();
            this.pd_bank = new System.Windows.Forms.ComboBox();
            this.pd_err_accno = new System.Windows.Forms.Label();
            this.pd_err_bb = new System.Windows.Forms.Label();
            this.pd_err_bank = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pd_err_ecode = new System.Windows.Forms.Label();
            this.pd_getDetails = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pd_national_err = new System.Windows.Forms.Label();
            this.pd_err_nic = new System.Windows.Forms.Label();
            this.pd_err_radio = new System.Windows.Forms.Label();
            this.pd_err_dob = new System.Windows.Forms.Label();
            this.pd_err_fullname = new System.Windows.Forms.Label();
            this.pd_err_initial = new System.Windows.Forms.Label();
            this.pd_empcode = new System.Windows.Forms.Label();
            this.pd_ecode_tb = new System.Windows.Forms.TextBox();
            this.pd_edit = new System.Windows.Forms.Button();
            this.emp_details_next = new System.Windows.Forms.Button();
            this.pd_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 28);
            this.label13.TabIndex = 73;
            this.label13.Text = "Employee Personal Details";
            // 
            // emp_detail_exit
            // 
            this.emp_detail_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_detail_exit.Location = new System.Drawing.Point(469, 616);
            this.emp_detail_exit.Margin = new System.Windows.Forms.Padding(4);
            this.emp_detail_exit.Name = "emp_detail_exit";
            this.emp_detail_exit.Size = new System.Drawing.Size(172, 39);
            this.emp_detail_exit.TabIndex = 72;
            this.emp_detail_exit.Text = "Exit";
            this.emp_detail_exit.UseVisualStyleBackColor = true;
            this.emp_detail_exit.Click += new System.EventHandler(this.emp_detail_exit_Click);
            // 
            // emp_detail_clear
            // 
            this.emp_detail_clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_detail_clear.Location = new System.Drawing.Point(240, 616);
            this.emp_detail_clear.Margin = new System.Windows.Forms.Padding(4);
            this.emp_detail_clear.Name = "emp_detail_clear";
            this.emp_detail_clear.Size = new System.Drawing.Size(172, 39);
            this.emp_detail_clear.TabIndex = 71;
            this.emp_detail_clear.Text = "Clear";
            this.emp_detail_clear.UseVisualStyleBackColor = true;
            this.emp_detail_clear.Click += new System.EventHandler(this.emp_detail_clear_Click);
            // 
            // pd_submit
            // 
            this.pd_submit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_submit.Location = new System.Drawing.Point(18, 616);
            this.pd_submit.Margin = new System.Windows.Forms.Padding(4);
            this.pd_submit.Name = "pd_submit";
            this.pd_submit.Size = new System.Drawing.Size(172, 39);
            this.pd_submit.TabIndex = 70;
            this.pd_submit.Text = "Submit";
            this.pd_submit.UseVisualStyleBackColor = true;
            this.pd_submit.Click += new System.EventHandler(this.pd_submit_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(369, 147);
            this.male.Margin = new System.Windows.Forms.Padding(4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(53, 19);
            this.male.TabIndex = 69;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(231, 147);
            this.female.Margin = new System.Windows.Forms.Padding(4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(67, 19);
            this.female.TabIndex = 68;
            this.female.TabStop = true;
            this.female.Text = "Female\r\n";
            this.female.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 193);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 21);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // pd_nation
            // 
            this.pd_nation.Location = new System.Drawing.Point(231, 288);
            this.pd_nation.Margin = new System.Windows.Forms.Padding(4);
            this.pd_nation.Name = "pd_nation";
            this.pd_nation.Size = new System.Drawing.Size(236, 21);
            this.pd_nation.TabIndex = 64;
            // 
            // pd_nic
            // 
            this.pd_nic.Location = new System.Drawing.Point(231, 240);
            this.pd_nic.Margin = new System.Windows.Forms.Padding(4);
            this.pd_nic.MaxLength = 10;
            this.pd_nic.Name = "pd_nic";
            this.pd_nic.Size = new System.Drawing.Size(236, 21);
            this.pd_nic.TabIndex = 62;
            this.pd_nic.Leave += new System.EventHandler(this.pd_nic_Leave);
            // 
            // pdfullname
            // 
            this.pdfullname.Location = new System.Drawing.Point(231, 108);
            this.pdfullname.Margin = new System.Windows.Forms.Padding(4);
            this.pdfullname.Name = "pdfullname";
            this.pdfullname.Size = new System.Drawing.Size(697, 21);
            this.pdfullname.TabIndex = 61;
            this.pdfullname.Leave += new System.EventHandler(this.pdfullname_Leave);
            // 
            // pdinitial
            // 
            this.pdinitial.Location = new System.Drawing.Point(231, 65);
            this.pdinitial.Margin = new System.Windows.Forms.Padding(4);
            this.pdinitial.Name = "pdinitial";
            this.pdinitial.Size = new System.Drawing.Size(697, 21);
            this.pdinitial.TabIndex = 60;
            this.pdinitial.Leave += new System.EventHandler(this.pdinitial_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nationality:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 241);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "NIC No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Full Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Name with Initials:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 17);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 36);
            this.label12.TabIndex = 49;
            this.label12.Text = "Employee Code:\r\n\r\n";
            // 
            // pd_accno
            // 
            this.pd_accno.Location = new System.Drawing.Point(231, 126);
            this.pd_accno.Margin = new System.Windows.Forms.Padding(4);
            this.pd_accno.Name = "pd_accno";
            this.pd_accno.Size = new System.Drawing.Size(236, 21);
            this.pd_accno.TabIndex = 153;
            this.pd_accno.Leave += new System.EventHandler(this.pd_accno_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 152;
            this.label1.Text = "Account No:";
            // 
            // pd_bb
            // 
            this.pd_bb.Location = new System.Drawing.Point(231, 79);
            this.pd_bb.Margin = new System.Windows.Forms.Padding(4);
            this.pd_bb.Name = "pd_bb";
            this.pd_bb.Size = new System.Drawing.Size(236, 21);
            this.pd_bb.TabIndex = 151;
            this.pd_bb.Leave += new System.EventHandler(this.pd_bb_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 150;
            this.label10.Text = "Branch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 148;
            this.label2.Text = "Bank:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.demo);
            this.groupBox1.Controls.Add(this.pd_bank);
            this.groupBox1.Controls.Add(this.pd_err_accno);
            this.groupBox1.Controls.Add(this.pd_err_bb);
            this.groupBox1.Controls.Add(this.pd_err_bank);
            this.groupBox1.Controls.Add(this.pd_accno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pd_bb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 180);
            this.groupBox1.TabIndex = 158;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bank Details";
            // 
            // demo
            // 
            this.demo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo.Location = new System.Drawing.Point(863, 69);
            this.demo.Margin = new System.Windows.Forms.Padding(4);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(172, 39);
            this.demo.TabIndex = 163;
            this.demo.Text = "Demo";
            this.demo.UseVisualStyleBackColor = true;
            this.demo.Click += new System.EventHandler(this.demo_Click);
            // 
            // pd_bank
            // 
            this.pd_bank.FormattingEnabled = true;
            this.pd_bank.Items.AddRange(new object[] {
            "Sampath Bank",
            "Commercial Bank",
            "Bank of Ceylon",
            "Peoples Bank",
            "Hatton National Bank",
            "Nations Trust Bank",
            "Seylan Bank"});
            this.pd_bank.Location = new System.Drawing.Point(231, 32);
            this.pd_bank.Name = "pd_bank";
            this.pd_bank.Size = new System.Drawing.Size(236, 23);
            this.pd_bank.TabIndex = 157;
            this.pd_bank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pd_bank_KeyPress);
            this.pd_bank.Leave += new System.EventHandler(this.pd_bank_Leave);
            // 
            // pd_err_accno
            // 
            this.pd_err_accno.AutoSize = true;
            this.pd_err_accno.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_accno.ForeColor = System.Drawing.Color.Red;
            this.pd_err_accno.Location = new System.Drawing.Point(242, 151);
            this.pd_err_accno.Name = "pd_err_accno";
            this.pd_err_accno.Size = new System.Drawing.Size(56, 14);
            this.pd_err_accno.TabIndex = 156;
            this.pd_err_accno.Text = "err_label";
            this.pd_err_accno.Visible = false;
            // 
            // pd_err_bb
            // 
            this.pd_err_bb.AutoSize = true;
            this.pd_err_bb.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_bb.ForeColor = System.Drawing.Color.Red;
            this.pd_err_bb.Location = new System.Drawing.Point(242, 104);
            this.pd_err_bb.Name = "pd_err_bb";
            this.pd_err_bb.Size = new System.Drawing.Size(56, 14);
            this.pd_err_bb.TabIndex = 155;
            this.pd_err_bb.Text = "err_label";
            this.pd_err_bb.Visible = false;
            // 
            // pd_err_bank
            // 
            this.pd_err_bank.AutoSize = true;
            this.pd_err_bank.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_bank.ForeColor = System.Drawing.Color.Red;
            this.pd_err_bank.Location = new System.Drawing.Point(242, 57);
            this.pd_err_bank.Name = "pd_err_bank";
            this.pd_err_bank.Size = new System.Drawing.Size(56, 14);
            this.pd_err_bank.TabIndex = 154;
            this.pd_err_bank.Text = "err_label";
            this.pd_err_bank.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.pd_err_ecode);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pd_national_err);
            this.groupBox2.Controls.Add(this.pd_err_nic);
            this.groupBox2.Controls.Add(this.pd_err_radio);
            this.groupBox2.Controls.Add(this.pd_err_dob);
            this.groupBox2.Controls.Add(this.pd_err_fullname);
            this.groupBox2.Controls.Add(this.pd_err_initial);
            this.groupBox2.Controls.Add(this.pd_empcode);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.pd_nation);
            this.groupBox2.Controls.Add(this.pd_nic);
            this.groupBox2.Controls.Add(this.pdfullname);
            this.groupBox2.Controls.Add(this.pdinitial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pd_ecode_tb);
            this.groupBox2.Controls.Add(this.pd_getDetails);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1059, 347);
            this.groupBox2.TabIndex = 159;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details";
            // 
            // pd_err_ecode
            // 
            this.pd_err_ecode.AutoSize = true;
            this.pd_err_ecode.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_ecode.ForeColor = System.Drawing.Color.Red;
            this.pd_err_ecode.Location = new System.Drawing.Point(241, 41);
            this.pd_err_ecode.Name = "pd_err_ecode";
            this.pd_err_ecode.Size = new System.Drawing.Size(56, 14);
            this.pd_err_ecode.TabIndex = 164;
            this.pd_err_ecode.Text = "err_label";
            this.pd_err_ecode.Visible = false;
            // 
            // pd_getDetails
            // 
            this.pd_getDetails.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_getDetails.Location = new System.Drawing.Point(397, 11);
            this.pd_getDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pd_getDetails.Name = "pd_getDetails";
            this.pd_getDetails.Size = new System.Drawing.Size(189, 29);
            this.pd_getDetails.TabIndex = 162;
            this.pd_getDetails.Text = "Get Details";
            this.pd_getDetails.UseVisualStyleBackColor = true;
            this.pd_getDetails.Visible = false;
            this.pd_getDetails.Click += new System.EventHandler(this.pd_getDetails_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 29);
            this.button2.TabIndex = 161;
            this.button2.Text = "Add New Employee";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pd_national_err
            // 
            this.pd_national_err.AutoSize = true;
            this.pd_national_err.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_national_err.ForeColor = System.Drawing.Color.Red;
            this.pd_national_err.Location = new System.Drawing.Point(241, 309);
            this.pd_national_err.Name = "pd_national_err";
            this.pd_national_err.Size = new System.Drawing.Size(56, 14);
            this.pd_national_err.TabIndex = 77;
            this.pd_national_err.Text = "err_label";
            this.pd_national_err.Visible = false;
            // 
            // pd_err_nic
            // 
            this.pd_err_nic.AutoSize = true;
            this.pd_err_nic.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_nic.ForeColor = System.Drawing.Color.Red;
            this.pd_err_nic.Location = new System.Drawing.Point(241, 265);
            this.pd_err_nic.Name = "pd_err_nic";
            this.pd_err_nic.Size = new System.Drawing.Size(56, 14);
            this.pd_err_nic.TabIndex = 75;
            this.pd_err_nic.Text = "err_label";
            this.pd_err_nic.Visible = false;
            // 
            // pd_err_radio
            // 
            this.pd_err_radio.AutoSize = true;
            this.pd_err_radio.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_radio.ForeColor = System.Drawing.Color.Red;
            this.pd_err_radio.Location = new System.Drawing.Point(241, 170);
            this.pd_err_radio.Name = "pd_err_radio";
            this.pd_err_radio.Size = new System.Drawing.Size(139, 14);
            this.pd_err_radio.TabIndex = 74;
            this.pd_err_radio.Text = "err_label(at subimttion)";
            this.pd_err_radio.Visible = false;
            // 
            // pd_err_dob
            // 
            this.pd_err_dob.AutoSize = true;
            this.pd_err_dob.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_dob.ForeColor = System.Drawing.Color.Red;
            this.pd_err_dob.Location = new System.Drawing.Point(241, 218);
            this.pd_err_dob.Name = "pd_err_dob";
            this.pd_err_dob.Size = new System.Drawing.Size(139, 14);
            this.pd_err_dob.TabIndex = 73;
            this.pd_err_dob.Text = "err_label(at subimttion)";
            this.pd_err_dob.Visible = false;
            // 
            // pd_err_fullname
            // 
            this.pd_err_fullname.AutoSize = true;
            this.pd_err_fullname.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_fullname.ForeColor = System.Drawing.Color.Red;
            this.pd_err_fullname.Location = new System.Drawing.Point(241, 133);
            this.pd_err_fullname.Name = "pd_err_fullname";
            this.pd_err_fullname.Size = new System.Drawing.Size(56, 14);
            this.pd_err_fullname.TabIndex = 72;
            this.pd_err_fullname.Text = "err_label";
            this.pd_err_fullname.Visible = false;
            // 
            // pd_err_initial
            // 
            this.pd_err_initial.AutoSize = true;
            this.pd_err_initial.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_err_initial.ForeColor = System.Drawing.Color.Red;
            this.pd_err_initial.Location = new System.Drawing.Point(241, 91);
            this.pd_err_initial.Name = "pd_err_initial";
            this.pd_err_initial.Size = new System.Drawing.Size(56, 14);
            this.pd_err_initial.TabIndex = 71;
            this.pd_err_initial.Text = "err_label";
            this.pd_err_initial.Visible = false;
            // 
            // pd_empcode
            // 
            this.pd_empcode.AutoSize = true;
            this.pd_empcode.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_empcode.Location = new System.Drawing.Point(228, 17);
            this.pd_empcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pd_empcode.Name = "pd_empcode";
            this.pd_empcode.Size = new System.Drawing.Size(73, 18);
            this.pd_empcode.TabIndex = 70;
            this.pd_empcode.Text = "emp code";
            this.pd_empcode.Visible = false;
            // 
            // pd_ecode_tb
            // 
            this.pd_ecode_tb.Location = new System.Drawing.Point(231, 16);
            this.pd_ecode_tb.Margin = new System.Windows.Forms.Padding(4);
            this.pd_ecode_tb.MaxLength = 10;
            this.pd_ecode_tb.Name = "pd_ecode_tb";
            this.pd_ecode_tb.Size = new System.Drawing.Size(102, 21);
            this.pd_ecode_tb.TabIndex = 163;
            this.pd_ecode_tb.Visible = false;
            // 
            // pd_edit
            // 
            this.pd_edit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_edit.Location = new System.Drawing.Point(699, 616);
            this.pd_edit.Margin = new System.Windows.Forms.Padding(4);
            this.pd_edit.Name = "pd_edit";
            this.pd_edit.Size = new System.Drawing.Size(172, 39);
            this.pd_edit.TabIndex = 160;
            this.pd_edit.Text = "Edit";
            this.pd_edit.UseVisualStyleBackColor = true;
            this.pd_edit.Click += new System.EventHandler(this.pd_edit_Click);
            // 
            // emp_details_next
            // 
            this.emp_details_next.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_details_next.Location = new System.Drawing.Point(906, 616);
            this.emp_details_next.Margin = new System.Windows.Forms.Padding(4);
            this.emp_details_next.Name = "emp_details_next";
            this.emp_details_next.Size = new System.Drawing.Size(172, 39);
            this.emp_details_next.TabIndex = 161;
            this.emp_details_next.Text = "Next";
            this.emp_details_next.UseVisualStyleBackColor = true;
            this.emp_details_next.Click += new System.EventHandler(this.emp_details_next_Click);
            // 
            // pd_save
            // 
            this.pd_save.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_save.Location = new System.Drawing.Point(18, 616);
            this.pd_save.Margin = new System.Windows.Forms.Padding(4);
            this.pd_save.Name = "pd_save";
            this.pd_save.Size = new System.Drawing.Size(172, 39);
            this.pd_save.TabIndex = 162;
            this.pd_save.Text = "Save";
            this.pd_save.UseVisualStyleBackColor = true;
            this.pd_save.Visible = false;
            this.pd_save.Click += new System.EventHandler(this.pd_save_Click);
            // 
            // Employee_Details
            // 
            this.ClientSize = new System.Drawing.Size(1091, 741);
            this.Controls.Add(this.emp_details_next);
            this.Controls.Add(this.pd_edit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.emp_detail_exit);
            this.Controls.Add(this.emp_detail_clear);
            this.Controls.Add(this.pd_submit);
            this.Controls.Add(this.pd_save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Employee_Details";
            this.Text = "Employee Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void pdinitial_Leave(object sender, EventArgs e)
        {
            fv.name_initial_Validator(pdinitial.Text, pd_err_initial);

        }

        private void pdfullname_Leave(object sender, EventArgs e)
        {

            fv.fullname_Validator(pdfullname.Text, pd_err_fullname);

        }

        private void pd_submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("eventargs: "+e);
            Boolean c1 = fv.name_initial_Validator(pdinitial.Text, pd_err_initial);
            Boolean c2 = fv.fullname_Validator(pdfullname.Text, pd_err_fullname);
            Boolean c3 = fv.radio_button_validator(female, male, pd_err_radio);
            Boolean c4 = fv.dobValidator(DateTime.Parse(dateTimePicker1.Text), pd_err_dob);
           //***//                  
            Boolean c5 = fv.nic_validator(pd_nic.Text, pd_err_nic);            
            //*****//
            Boolean c6 = fv.checkEmpty(pd_nic.Text, pd_err_nic);
            Boolean c7 = fv.checkEmpty(pd_bank.Text, pd_err_bank);
            Boolean c8 = fv.checkEmpty(pd_bb.Text, pd_err_bb);
            Boolean c9 = fv.check_number(pd_accno.Text, pd_err_accno);
            Boolean c10 = fv.account_no_validator(pd_accno.Text, pd_err_accno);


            if (pd_empcode.Visible == false || c1 || c2 || c3 || c4 || c5 || c6 || c7 || c8 || c9 || c10)
            {

                //********** 
                MessageBox.Show("Information you Entered are not Valid.", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //*********
            }
            else
            {
                DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == System.Windows.Forms.DialogResult.OK)
                {

                    string empId = pd_empcode.Text;
                    string initialName = pdinitial.Text;
                    string fullName = pdfullname.Text;
                    string gender;
                    if (female.Checked)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Male";
                    }
                    //DateTime date = DateTime.Parse(dateTimePicker1.Text);
                    string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    //string dob = DateTime.Parse(dateTimePicker1.Text).ToShortDateString();        //date.ToString("YYYY-MM-DD");
                    string nic = pd_nic.Text;
                    //string passport = pd_pp.Text;
                    string nationality = pd_nation.Text;

                    string bank = pd_bank.Text;
                    string branch = pd_bb.Text;
                    int accNo = Convert.ToInt32(pd_accno.Text);

                    //MessageBox.Show(empId + " " + initialName + " " + fullName + " " + gender + " " + dob + " " + nic + " " + nationality + " " + bank + " " + branch + " " + accNo);



                    if (nationality == "")
                    {
                        //nationality = null;
                        //MessageBox.Show("inside if loop");
                        setter.SendToDB("INSERT INTO employee_details(emp_code, name_initials, full_name, sex,dob,nic,bank_name,b_branch,acc_no) VALUES ('" + empId + "','" + initialName + "','" + fullName + "','" + gender + "','" + dob + "','" + nic + "','" + bank + "','" + branch + "'," + accNo + ")");
                        MessageBox.Show("Details submitted Successfully.");
                        ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        setter.SendToDB("INSERT INTO employee_details(emp_code, name_initials, full_name, sex,dob,nic,nationality,bank_name,b_branch,acc_no) VALUES ('" + empId + "','" + initialName + "','" + fullName + "','" + gender + "','" + dob + "','" + nic + "','" + nationality + "','" + bank + "','" + branch + "'," + accNo + ")");
                        MessageBox.Show("Details submitted Successfully.");
                        ClearTextBoxes(this.Controls);
                    }

                }
            }
            

        }





        private void pd_nic_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(pd_nic.Text, pd_err_nic);
            //***//                  
            fv.nic_validator1(pd_nic.Text, pd_err_nic);
            //*****//
        }

        private void pd_bb_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(pd_bb.Text, pd_err_bb);
        }

        private void pd_accno_Leave(object sender, EventArgs e)
        {
            fv.account_no_validator(pd_accno.Text, pd_err_accno);
            
        }

        private void pd_bank_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(pd_bank.Text, pd_err_bank);
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            fv.dobValidator(DateTime.Parse(dateTimePicker1.Text), pd_err_dob);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = generateAutoId();
            pd_empcode.Text = id;
            pd_empcode.Visible = true;
        }

        public string generateAutoId()
        {
            DataSet ds = new DataSet();
            //ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM employee_details");

            ds = new DBConnect().GetFromDB("SELECT TOP 1 emp_code FROM employee_details ORDER BY emp_code DESC");
            //MessageBox.Show("ds = " + ds);

            string c = ds.Tables[0].Rows[0][0].ToString();
            //MessageBox.Show("string c = " + c);
            char i = c.Last();
            //MessageBox.Show("char i = " + i);
            i.ToString();
            i++;
            return ("E000" + i);

        }

        private void emp_detail_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
            pd_empcode.Visible = false;
            pd_err_initial.Visible = false;
            pd_err_fullname.Visible = false;
            pd_err_nic.Visible = false;
            pd_err_bank.Visible = false;
            pd_err_bb.Visible = false;
            pd_err_accno.Visible = false;
            male.Checked = false;
            female.Checked = false;
            pd_bank.Text = "";
            dateTimePicker1.Text = DateTime.Now.Date.ToString();
            pd_err_radio.Visible = false;
            pd_err_dob.Visible = false;
        }
        
        private void emp_detail_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void emp_details_next_Click(object sender, EventArgs e)
        {
            //Boolean isText = false;
            Official_Details form = new Official_Details();
            mainForm form1 = new mainForm();
            if (pdinitial.Text != string.Empty || pdfullname.Text != string.Empty || pd_nic.Text != string.Empty || pd_nation.Text != string.Empty || pd_bank.Text != string.Empty || pd_bb.Text != string.Empty || pd_accno.Text != string.Empty)
            {
                DialogResult d = MessageBox.Show("Do you want to submit the Information?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if (d == System.Windows.Forms.DialogResult.No)
                {
                    //this.Hide();
                    //form.Visible = true;
                    //form.od_empcode_tb.Visible = true;
                    //form.od_name_tb.Visible = true;

                    //Official_Details form = new Official_Details();
                    //form.Show();
                    form.od_empcode_tb.Visible = true;
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                
                form.od_empcode_tb.Visible = true;
                form.od_name_tb.Visible = true;
                form.MdiParent = this.MdiParent;
                form.Show();
                
                form.BringToFront();
                //form.MdiParent = form1;
                
                this.Hide();
                
            }
        }
        //****
        private void pd_edit_Click(object sender, EventArgs e)
        {
            edit();
        }
        //*****
        private void pd_getDetails_Click(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(pd_ecode_tb.Text, pd_err_ecode);
            if (c == false)
            {

                pdinitial.Enabled = true;
                pdfullname.Enabled = true;
                female.Enabled = true;
                male.Enabled = true;
                dateTimePicker1.Enabled = true;
                pd_nic.Enabled = true;
                pd_nation.Enabled = true;
                pd_bank.Enabled = true;
                pd_bb.Enabled = true;
                pd_accno.Enabled = true;
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT * FROM employee_details WHERE emp_code = '" + pd_ecode_tb.Text + "'");
                for (int i = 1; i < 10; i++)
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0][i].ToString());
                    pdinitial.Text = ds.Tables[0].Rows[0][1].ToString();
                    pdfullname.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (ds.Tables[0].Rows[0][3].ToString() == "Female")
                    {
                        female.Checked = true;
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "Male")
                    {
                        male.Checked = true;
                    }
                    dateTimePicker1.Text = ds.Tables[0].Rows[0][4].ToString();
                    pd_nic.Text = ds.Tables[0].Rows[0][5].ToString();
                    pd_nation.Text = ds.Tables[0].Rows[0][6].ToString();
                    pd_bank.Text = ds.Tables[0].Rows[0][7].ToString();
                    pd_bb.Text = ds.Tables[0].Rows[0][8].ToString();
                    pd_accno.Text = ds.Tables[0].Rows[0][9].ToString();
                }
            }
        }

        private void pd_save_Click(object sender, EventArgs e)
        {
            Boolean c1 = fv.name_initial_Validator(pdinitial.Text, pd_err_initial);
            Boolean c2 = fv.fullname_Validator(pdfullname.Text, pd_err_fullname);
            Boolean c3 = fv.radio_button_validator(female, male, pd_err_radio);
            Boolean c4 = fv.dobValidator(DateTime.Parse(dateTimePicker1.Text), pd_err_dob);
            //***//                  
            Boolean c5 = fv.nic_validator1(pd_nic.Text, pd_err_nic);
            //*****//
            Boolean c6 = fv.checkEmpty(pd_nic.Text, pd_err_nic);
            Boolean c7 = fv.checkEmpty(pd_bank.Text, pd_err_bank);
            Boolean c8 = fv.checkEmpty(pd_bb.Text, pd_err_bb);
            Boolean c9 = fv.check_number(pd_accno.Text, pd_err_accno);
            //****
            Boolean c10 = fv.account_no_validator1(pd_accno.Text, pd_err_accno);
            //****

            

            if (c1 || c2 || c3 || c4 || c5  || c6 || c7 || c8 || c9 || c10)
            {

                string error = "Incomplete Information";
                MessageBox.Show(error, "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d = MessageBox.Show("Do you want to save the given Information", "Submition Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //*****
                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    string empId = pd_empcode.Text;
                    string initialName = pdinitial.Text;
                    string fullName = pdfullname.Text;
                    string gender;
                    if (female.Checked)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        gender = "Male";
                    }
                    //DateTime date = DateTime.Parse(dateTimePicker1.Text);
                    string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    //string dob = DateTime.Parse(dateTimePicker1.Text).ToShortDateString();        //date.ToString("YYYY-MM-DD");
                    string nic = pd_nic.Text;
                    //string passport = pd_pp.Text;
                    string nationality = pd_nation.Text;

                    string bank = pd_bank.Text;
                    string branch = pd_bb.Text;
                    int accNo = Convert.ToInt32(pd_accno.Text);

                    //MessageBox.Show(empId + " " + initialName + " " + fullName + " " + gender + " " + dob + " " + nic + " " + nationality + " " + bank + " " + branch + " " + accNo);



                    if (nationality == "")
                    {
                        //nationality = null;
                        //MessageBox.Show("inside if loop");
                        setter.SendToDB("UPDATE employee_details SET name_initials = '" + initialName + "', full_name = '" + fullName + "', sex = '" + gender + "', dob = '" + dob + "', nic = '" + nic + "', nationality = NULL, bank_name = '" + bank + "', b_branch = '" + branch + "', acc_no = '" + accNo + "' WHERE emp_code = '" + pd_ecode_tb.Text + "'");
                        //****
                        MessageBox.Show("Changes saved Successfuly.");
                        //****
                        ClearTextBoxes(this.Controls);
                    }
                    else
                    {
                        setter.SendToDB("UPDATE employee_details SET name_initials = '" + initialName + "', full_name = '" + fullName + "', sex = '" + gender + "', dob = '" + dob + "', nic = '" + nic + "', nationality = '" + nationality + "', bank_name = '" + bank + "', b_branch = '" + branch + "', acc_no = '" + accNo + "' WHERE emp_code = '" + pd_ecode_tb.Text + "'");
                        //***
                        MessageBox.Show("Changes saved Successfuly.");
                        //***
                        ClearTextBoxes(this.Controls);
                    }
                }
            }





        }

        private void pd_bank_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }



        //*********
       

        private void edit()
        {
            ClearTextBoxes(this.Controls);
            DialogResult d = MessageBox.Show("Please Enter The Employee Code", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                pdinitial.Enabled = false;
                pdfullname.Enabled = false;
                female.Enabled = false;
                male.Enabled = false;
                dateTimePicker1.Enabled = false;
                pd_nic.Enabled = false;
                pd_nation.Enabled = false;
                pd_bank.Enabled = false;
                pd_bb.Enabled = false;
                pd_accno.Enabled = false;
                button2.Visible = false;
                pd_submit.Visible = false;
                pd_getDetails.Visible = true;
                pd_save.Visible = true;
                pd_ecode_tb.Visible = true;
                this.ActiveControl = pd_ecode_tb;
            }
            else if (d == System.Windows.Forms.DialogResult.Cancel)
            {
                ClearTextBoxes(this.Controls);
            }
        }

        private void Employee_Details_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0,102,153);
        }

        private void demo_Click(object sender, EventArgs e)
        {
            pdinitial.Text = "S.T.Fernando";
            pdfullname.Text = "Shamini Tharaka Fernando";
            female.Checked = true;
            //dateTimePicker1.Text = "9/26/1990";
            pd_nic.Text = "112233445V";
            pd_nation.Text = "";
            pd_bank.Text = "Sampath Bank";
            pd_bb.Text = "Negombo";
            pd_accno.Text = "567890";

        }
        //*********
        



    }
}
