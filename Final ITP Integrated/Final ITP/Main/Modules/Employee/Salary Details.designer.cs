namespace Main.Module.Employee
{
    partial class Salary_Details
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
            this.label13 = new System.Windows.Forms.Label();
            this.sal_exit = new System.Windows.Forms.Button();
            this.sal_clear = new System.Windows.Forms.Button();
            this.sal_submit = new System.Windows.Forms.Button();
            this.sal_empcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sal_err_ppct = new System.Windows.Forms.Label();
            this.paye_pct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.paye_check = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sal_err_bsal = new System.Windows.Forms.Label();
            this.sal_basic_sal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sal_edit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sal_err_otamt = new System.Windows.Forms.Label();
            this.ot_check = new System.Windows.Forms.CheckBox();
            this.sal_ot_amt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salary_grid = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basic_sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epf_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_epf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etf_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paye_percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paye_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ot_amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sal_err_code = new System.Windows.Forms.Label();
            this.sal_add = new System.Windows.Forms.Button();
            this.sal_code_label = new System.Windows.Forms.Label();
            this.pd_getDetails = new System.Windows.Forms.Button();
            this.sal_save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.err_bonus = new System.Windows.Forms.Label();
            this.bonus = new System.Windows.Forms.CheckBox();
            this.bonus_amt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.demo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_grid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(364, 28);
            this.label13.TabIndex = 76;
            this.label13.Text = "Salary Details of the Employee";
            // 
            // sal_exit
            // 
            this.sal_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_exit.Location = new System.Drawing.Point(525, 517);
            this.sal_exit.Margin = new System.Windows.Forms.Padding(4);
            this.sal_exit.Name = "sal_exit";
            this.sal_exit.Size = new System.Drawing.Size(172, 39);
            this.sal_exit.TabIndex = 119;
            this.sal_exit.Text = "Exit";
            this.sal_exit.UseVisualStyleBackColor = true;
            this.sal_exit.Click += new System.EventHandler(this.sal_exit_Click);
            // 
            // sal_clear
            // 
            this.sal_clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_clear.Location = new System.Drawing.Point(290, 517);
            this.sal_clear.Margin = new System.Windows.Forms.Padding(4);
            this.sal_clear.Name = "sal_clear";
            this.sal_clear.Size = new System.Drawing.Size(172, 39);
            this.sal_clear.TabIndex = 118;
            this.sal_clear.Text = "Clear";
            this.sal_clear.UseVisualStyleBackColor = true;
            this.sal_clear.Click += new System.EventHandler(this.sal_clear_Click);
            // 
            // sal_submit
            // 
            this.sal_submit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_submit.Location = new System.Drawing.Point(41, 517);
            this.sal_submit.Margin = new System.Windows.Forms.Padding(4);
            this.sal_submit.Name = "sal_submit";
            this.sal_submit.Size = new System.Drawing.Size(172, 39);
            this.sal_submit.TabIndex = 117;
            this.sal_submit.Text = "Submit";
            this.sal_submit.UseVisualStyleBackColor = true;
            this.sal_submit.Click += new System.EventHandler(this.sal_submit_Click);
            // 
            // sal_empcode
            // 
            this.sal_empcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_empcode.Location = new System.Drawing.Point(220, 51);
            this.sal_empcode.Margin = new System.Windows.Forms.Padding(4);
            this.sal_empcode.Name = "sal_empcode";
            this.sal_empcode.Size = new System.Drawing.Size(112, 20);
            this.sal_empcode.TabIndex = 120;
            this.sal_empcode.Leave += new System.EventHandler(this.sal_empcode_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 52);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 36);
            this.label14.TabIndex = 119;
            this.label14.Text = "Employee Code:\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.sal_err_ppct);
            this.groupBox1.Controls.Add(this.paye_pct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.paye_check);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 143);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tax Details";
            // 
            // sal_err_ppct
            // 
            this.sal_err_ppct.AutoSize = true;
            this.sal_err_ppct.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_err_ppct.ForeColor = System.Drawing.Color.Red;
            this.sal_err_ppct.Location = new System.Drawing.Point(48, 90);
            this.sal_err_ppct.Name = "sal_err_ppct";
            this.sal_err_ppct.Size = new System.Drawing.Size(56, 14);
            this.sal_err_ppct.TabIndex = 170;
            this.sal_err_ppct.Text = "err_label";
            this.sal_err_ppct.Visible = false;
            // 
            // paye_pct
            // 
            this.paye_pct.Enabled = false;
            this.paye_pct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paye_pct.Location = new System.Drawing.Point(247, 59);
            this.paye_pct.Margin = new System.Windows.Forms.Padding(4);
            this.paye_pct.Name = "paye_pct";
            this.paye_pct.Size = new System.Drawing.Size(112, 20);
            this.paye_pct.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 109;
            this.label1.Text = "PAYE Tax Percentage:";
            // 
            // paye_check
            // 
            this.paye_check.AutoSize = true;
            this.paye_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paye_check.Location = new System.Drawing.Point(48, 20);
            this.paye_check.Name = "paye_check";
            this.paye_check.Size = new System.Drawing.Size(113, 20);
            this.paye_check.TabIndex = 103;
            this.paye_check.Text = "PAYE Effect";
            this.paye_check.UseVisualStyleBackColor = true;
            this.paye_check.Click += new System.EventHandler(this.paye_check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.sal_err_bsal);
            this.groupBox2.Controls.Add(this.sal_basic_sal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 130);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Details";
            // 
            // sal_err_bsal
            // 
            this.sal_err_bsal.AutoSize = true;
            this.sal_err_bsal.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_err_bsal.ForeColor = System.Drawing.Color.Red;
            this.sal_err_bsal.Location = new System.Drawing.Point(161, 85);
            this.sal_err_bsal.Name = "sal_err_bsal";
            this.sal_err_bsal.Size = new System.Drawing.Size(56, 14);
            this.sal_err_bsal.TabIndex = 173;
            this.sal_err_bsal.Text = "err_label";
            this.sal_err_bsal.Visible = false;
            // 
            // sal_basic_sal
            // 
            this.sal_basic_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_basic_sal.Location = new System.Drawing.Point(164, 61);
            this.sal_basic_sal.Margin = new System.Windows.Forms.Padding(4);
            this.sal_basic_sal.Name = "sal_basic_sal";
            this.sal_basic_sal.Size = new System.Drawing.Size(112, 20);
            this.sal_basic_sal.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 97;
            this.label5.Text = "Basic Salary:";
            // 
            // sal_edit
            // 
            this.sal_edit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_edit.Location = new System.Drawing.Point(786, 517);
            this.sal_edit.Margin = new System.Windows.Forms.Padding(4);
            this.sal_edit.Name = "sal_edit";
            this.sal_edit.Size = new System.Drawing.Size(172, 39);
            this.sal_edit.TabIndex = 161;
            this.sal_edit.Text = "Edit";
            this.sal_edit.UseVisualStyleBackColor = true;
            this.sal_edit.Click += new System.EventHandler(this.sal_edit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.sal_err_otamt);
            this.groupBox3.Controls.Add(this.ot_check);
            this.groupBox3.Controls.Add(this.sal_ot_amt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(407, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 130);
            this.groupBox3.TabIndex = 162;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overtime Details";
            // 
            // sal_err_otamt
            // 
            this.sal_err_otamt.AutoSize = true;
            this.sal_err_otamt.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_err_otamt.ForeColor = System.Drawing.Color.Red;
            this.sal_err_otamt.Location = new System.Drawing.Point(195, 97);
            this.sal_err_otamt.Name = "sal_err_otamt";
            this.sal_err_otamt.Size = new System.Drawing.Size(56, 14);
            this.sal_err_otamt.TabIndex = 171;
            this.sal_err_otamt.Text = "err_label";
            this.sal_err_otamt.Visible = false;
            // 
            // ot_check
            // 
            this.ot_check.AutoSize = true;
            this.ot_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ot_check.Location = new System.Drawing.Point(42, 34);
            this.ot_check.Name = "ot_check";
            this.ot_check.Size = new System.Drawing.Size(97, 20);
            this.ot_check.TabIndex = 106;
            this.ot_check.Text = "OT Liable";
            this.ot_check.UseVisualStyleBackColor = true;
            this.ot_check.Click += new System.EventHandler(this.ot_check_Click);
            // 
            // sal_ot_amt
            // 
            this.sal_ot_amt.Enabled = false;
            this.sal_ot_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_ot_amt.Location = new System.Drawing.Point(198, 73);
            this.sal_ot_amt.Margin = new System.Windows.Forms.Padding(4);
            this.sal_ot_amt.Name = "sal_ot_amt";
            this.sal_ot_amt.Size = new System.Drawing.Size(112, 20);
            this.sal_ot_amt.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 18);
            this.label7.TabIndex = 104;
            this.label7.Text = "OT amount per hour:";
            // 
            // salary_grid
            // 
            this.salary_grid.AllowUserToAddRows = false;
            this.salary_grid.AllowUserToDeleteRows = false;
            this.salary_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salary_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.basic_sal,
            this.epf_amt,
            this.tot_epf,
            this.etf_amt,
            this.paye_percent,
            this.paye_amt,
            this.ot_amt,
            this.bon});
            this.salary_grid.Location = new System.Drawing.Point(407, 85);
            this.salary_grid.Name = "salary_grid";
            this.salary_grid.ReadOnly = true;
            this.salary_grid.Size = new System.Drawing.Size(943, 149);
            this.salary_grid.TabIndex = 163;
            this.salary_grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.salary_grid_MouseClick);
            // 
            // code
            // 
            this.code.HeaderText = "Employee Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // basic_sal
            // 
            this.basic_sal.HeaderText = "Basic Salary";
            this.basic_sal.Name = "basic_sal";
            this.basic_sal.ReadOnly = true;
            // 
            // epf_amt
            // 
            this.epf_amt.HeaderText = "EPF Amount";
            this.epf_amt.Name = "epf_amt";
            this.epf_amt.ReadOnly = true;
            // 
            // tot_epf
            // 
            this.tot_epf.HeaderText = "Total EPF";
            this.tot_epf.Name = "tot_epf";
            this.tot_epf.ReadOnly = true;
            // 
            // etf_amt
            // 
            this.etf_amt.HeaderText = "ETF Amount";
            this.etf_amt.Name = "etf_amt";
            this.etf_amt.ReadOnly = true;
            // 
            // paye_percent
            // 
            this.paye_percent.HeaderText = "PAYE Percentage";
            this.paye_percent.Name = "paye_percent";
            this.paye_percent.ReadOnly = true;
            // 
            // paye_amt
            // 
            this.paye_amt.HeaderText = "PAYE Amount";
            this.paye_amt.Name = "paye_amt";
            this.paye_amt.ReadOnly = true;
            // 
            // ot_amt
            // 
            this.ot_amt.HeaderText = "OT Amount";
            this.ot_amt.Name = "ot_amt";
            this.ot_amt.ReadOnly = true;
            // 
            // bon
            // 
            this.bon.HeaderText = "Allowances";
            this.bon.Name = "bon";
            this.bon.ReadOnly = true;
            // 
            // sal_err_code
            // 
            this.sal_err_code.AutoSize = true;
            this.sal_err_code.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_err_code.ForeColor = System.Drawing.Color.Red;
            this.sal_err_code.Location = new System.Drawing.Point(217, 75);
            this.sal_err_code.Name = "sal_err_code";
            this.sal_err_code.Size = new System.Drawing.Size(56, 14);
            this.sal_err_code.TabIndex = 172;
            this.sal_err_code.Text = "err_label";
            this.sal_err_code.Visible = false;
            // 
            // sal_add
            // 
            this.sal_add.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_add.Location = new System.Drawing.Point(1173, 241);
            this.sal_add.Margin = new System.Windows.Forms.Padding(4);
            this.sal_add.Name = "sal_add";
            this.sal_add.Size = new System.Drawing.Size(137, 39);
            this.sal_add.TabIndex = 173;
            this.sal_add.Text = "Add";
            this.sal_add.UseVisualStyleBackColor = true;
            this.sal_add.Click += new System.EventHandler(this.sal_add_Click);
            // 
            // sal_code_label
            // 
            this.sal_code_label.AutoSize = true;
            this.sal_code_label.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_code_label.Location = new System.Drawing.Point(217, 52);
            this.sal_code_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sal_code_label.Name = "sal_code_label";
            this.sal_code_label.Size = new System.Drawing.Size(73, 18);
            this.sal_code_label.TabIndex = 169;
            this.sal_code_label.Text = "emp code";
            this.sal_code_label.Visible = false;
            // 
            // pd_getDetails
            // 
            this.pd_getDetails.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pd_getDetails.Location = new System.Drawing.Point(357, 45);
            this.pd_getDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pd_getDetails.Name = "pd_getDetails";
            this.pd_getDetails.Size = new System.Drawing.Size(189, 29);
            this.pd_getDetails.TabIndex = 174;
            this.pd_getDetails.Text = "Get Details";
            this.pd_getDetails.UseVisualStyleBackColor = true;
            this.pd_getDetails.Visible = false;
            this.pd_getDetails.Click += new System.EventHandler(this.pd_getDetails_Click);
            // 
            // sal_save
            // 
            this.sal_save.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sal_save.Location = new System.Drawing.Point(41, 517);
            this.sal_save.Margin = new System.Windows.Forms.Padding(4);
            this.sal_save.Name = "sal_save";
            this.sal_save.Size = new System.Drawing.Size(172, 39);
            this.sal_save.TabIndex = 175;
            this.sal_save.Text = "Save";
            this.sal_save.UseVisualStyleBackColor = true;
            this.sal_save.Visible = false;
            this.sal_save.Click += new System.EventHandler(this.sal_save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.err_bonus);
            this.groupBox4.Controls.Add(this.bonus);
            this.groupBox4.Controls.Add(this.bonus_amt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(842, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 130);
            this.groupBox4.TabIndex = 172;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Allowances";
            // 
            // err_bonus
            // 
            this.err_bonus.AutoSize = true;
            this.err_bonus.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_bonus.ForeColor = System.Drawing.Color.Red;
            this.err_bonus.Location = new System.Drawing.Point(200, 97);
            this.err_bonus.Name = "err_bonus";
            this.err_bonus.Size = new System.Drawing.Size(56, 14);
            this.err_bonus.TabIndex = 171;
            this.err_bonus.Text = "err_label";
            this.err_bonus.Visible = false;
            // 
            // bonus
            // 
            this.bonus.AutoSize = true;
            this.bonus.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonus.Location = new System.Drawing.Point(42, 34);
            this.bonus.Name = "bonus";
            this.bonus.Size = new System.Drawing.Size(110, 20);
            this.bonus.TabIndex = 106;
            this.bonus.Text = "Allowances";
            this.bonus.UseVisualStyleBackColor = true;
            this.bonus.Click += new System.EventHandler(this.bonus_Click);
            // 
            // bonus_amt
            // 
            this.bonus_amt.Enabled = false;
            this.bonus_amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonus_amt.Location = new System.Drawing.Point(203, 73);
            this.bonus_amt.Margin = new System.Windows.Forms.Padding(4);
            this.bonus_amt.Name = "bonus_amt";
            this.bonus_amt.Size = new System.Drawing.Size(112, 20);
            this.bonus_amt.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 18);
            this.label3.TabIndex = 104;
            this.label3.Text = "Allowances per Month:";
            // 
            // demo
            // 
            this.demo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo.Location = new System.Drawing.Point(1045, 517);
            this.demo.Margin = new System.Windows.Forms.Padding(4);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(172, 39);
            this.demo.TabIndex = 176;
            this.demo.Text = "Demo";
            this.demo.UseVisualStyleBackColor = true;
            this.demo.Click += new System.EventHandler(this.demo_Click);
            // 
            // Salary_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pd_getDetails);
            this.Controls.Add(this.sal_add);
            this.Controls.Add(this.sal_err_code);
            this.Controls.Add(this.sal_code_label);
            this.Controls.Add(this.salary_grid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sal_edit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sal_empcode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sal_exit);
            this.Controls.Add(this.sal_clear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sal_submit);
            this.Controls.Add(this.sal_save);
            this.MinimizeBox = false;
            this.Name = "Salary_Details";
            this.Text = "Salary_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_grid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button sal_exit;
        private System.Windows.Forms.Button sal_clear;
        private System.Windows.Forms.Button sal_submit;
        private System.Windows.Forms.TextBox sal_empcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox paye_check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sal_basic_sal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sal_edit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ot_check;
        private System.Windows.Forms.TextBox sal_ot_amt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox paye_pct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView salary_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn basic_sal;
        private System.Windows.Forms.DataGridViewTextBoxColumn epf_amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_epf;
        private System.Windows.Forms.DataGridViewTextBoxColumn etf_amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn paye_percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn paye_amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ot_amt;
        private System.Windows.Forms.Label sal_err_ppct;
        private System.Windows.Forms.Label sal_err_bsal;
        private System.Windows.Forms.Label sal_err_otamt;
        private System.Windows.Forms.Label sal_err_code;
        private System.Windows.Forms.Button sal_add;
        public System.Windows.Forms.Label sal_code_label;
        private System.Windows.Forms.Button pd_getDetails;
        private System.Windows.Forms.Button sal_save;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label err_bonus;
        private System.Windows.Forms.CheckBox bonus;
        private System.Windows.Forms.TextBox bonus_amt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bon;
        private System.Windows.Forms.Button demo;
    }
}