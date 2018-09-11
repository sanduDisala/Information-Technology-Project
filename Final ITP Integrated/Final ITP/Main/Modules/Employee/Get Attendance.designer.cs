namespace Main.Module.Employee
{
    partial class Get_Attendance
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
            this.att_code = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atten_time = new System.Windows.Forms.Label();
            this.attendance = new System.Windows.Forms.DataGridView();
            this.Employee_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.In_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtHr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.att_add = new System.Windows.Forms.Button();
            this.attin_err_empcode = new System.Windows.Forms.Label();
            this.att_err_name = new System.Windows.Forms.Label();
            this.att_err_time = new System.Windows.Forms.Label();
            this.in_check = new System.Windows.Forms.CheckBox();
            this.out_check = new System.Windows.Forms.CheckBox();
            this.att_clear = new System.Windows.Forms.Button();
            this.att_exit = new System.Windows.Forms.Button();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.atime = new System.Windows.Forms.DateTimePicker();
            this.att_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(355, 28);
            this.label13.TabIndex = 74;
            this.label13.Text = "Record Employee Attendance";
            // 
            // att_code
            // 
            this.att_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_code.Location = new System.Drawing.Point(240, 99);
            this.att_code.Margin = new System.Windows.Forms.Padding(4);
            this.att_code.Name = "att_code";
            this.att_code.Size = new System.Drawing.Size(112, 20);
            this.att_code.TabIndex = 76;
            this.att_code.Leave += new System.EventHandler(this.att_code_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 36);
            this.label12.TabIndex = 75;
            this.label12.Text = "Employee Code:\r\n\r\n";
            // 
            // emp_name
            // 
            this.emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.Location = new System.Drawing.Point(240, 155);
            this.emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(237, 20);
            this.emp_name.TabIndex = 78;
            this.emp_name.Leave += new System.EventHandler(this.emp_name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 77;
            this.label1.Text = "Employee Name:\r\n\r\n";
            // 
            // atten_time
            // 
            this.atten_time.AutoSize = true;
            this.atten_time.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atten_time.Location = new System.Drawing.Point(88, 260);
            this.atten_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.atten_time.Name = "atten_time";
            this.atten_time.Size = new System.Drawing.Size(46, 18);
            this.atten_time.TabIndex = 79;
            this.atten_time.Text = "Time:";
            // 
            // attendance
            // 
            this.attendance.AllowUserToAddRows = false;
            this.attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_Code,
            this.Employee_Name,
            this.In_time,
            this.Out_time,
            this.OtHr});
            this.attendance.Location = new System.Drawing.Point(484, 80);
            this.attendance.Name = "attendance";
            this.attendance.ReadOnly = true;
            this.attendance.Size = new System.Drawing.Size(787, 273);
            this.attendance.TabIndex = 81;
            // 
            // Employee_Code
            // 
            this.Employee_Code.HeaderText = "Employee_Code";
            this.Employee_Code.Name = "Employee_Code";
            this.Employee_Code.ReadOnly = true;
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Employee Name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            // 
            // In_time
            // 
            this.In_time.HeaderText = "In_time";
            this.In_time.Name = "In_time";
            this.In_time.ReadOnly = true;
            // 
            // Out_time
            // 
            this.Out_time.HeaderText = "Out time";
            this.Out_time.Name = "Out_time";
            this.Out_time.ReadOnly = true;
            // 
            // OtHr
            // 
            this.OtHr.HeaderText = "OT_hours";
            this.OtHr.Name = "OtHr";
            this.OtHr.ReadOnly = true;
            // 
            // att_add
            // 
            this.att_add.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_add.Location = new System.Drawing.Point(39, 367);
            this.att_add.Margin = new System.Windows.Forms.Padding(4);
            this.att_add.Name = "att_add";
            this.att_add.Size = new System.Drawing.Size(126, 30);
            this.att_add.TabIndex = 84;
            this.att_add.Text = "Add";
            this.att_add.UseVisualStyleBackColor = true;
            this.att_add.Click += new System.EventHandler(this.att_add_Click);
            // 
            // attin_err_empcode
            // 
            this.attin_err_empcode.AutoSize = true;
            this.attin_err_empcode.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attin_err_empcode.ForeColor = System.Drawing.Color.Red;
            this.attin_err_empcode.Location = new System.Drawing.Point(237, 123);
            this.attin_err_empcode.Name = "attin_err_empcode";
            this.attin_err_empcode.Size = new System.Drawing.Size(56, 14);
            this.attin_err_empcode.TabIndex = 161;
            this.attin_err_empcode.Text = "err_label";
            this.attin_err_empcode.Visible = false;
            // 
            // att_err_name
            // 
            this.att_err_name.AutoSize = true;
            this.att_err_name.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_err_name.ForeColor = System.Drawing.Color.Red;
            this.att_err_name.Location = new System.Drawing.Point(237, 179);
            this.att_err_name.Name = "att_err_name";
            this.att_err_name.Size = new System.Drawing.Size(56, 14);
            this.att_err_name.TabIndex = 162;
            this.att_err_name.Text = "err_label";
            this.att_err_name.Visible = false;
            // 
            // att_err_time
            // 
            this.att_err_time.AutoSize = true;
            this.att_err_time.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_err_time.ForeColor = System.Drawing.Color.Red;
            this.att_err_time.Location = new System.Drawing.Point(194, 285);
            this.att_err_time.Name = "att_err_time";
            this.att_err_time.Size = new System.Drawing.Size(56, 14);
            this.att_err_time.TabIndex = 163;
            this.att_err_time.Text = "err_label";
            this.att_err_time.Visible = false;
            // 
            // in_check
            // 
            this.in_check.AutoSize = true;
            this.in_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_check.Location = new System.Drawing.Point(184, 221);
            this.in_check.Name = "in_check";
            this.in_check.Size = new System.Drawing.Size(86, 20);
            this.in_check.TabIndex = 164;
            this.in_check.Text = "In Time";
            this.in_check.UseVisualStyleBackColor = true;
            this.in_check.Click += new System.EventHandler(this.in_check_Click);
            // 
            // out_check
            // 
            this.out_check.AutoSize = true;
            this.out_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_check.Location = new System.Drawing.Point(293, 221);
            this.out_check.Name = "out_check";
            this.out_check.Size = new System.Drawing.Size(96, 20);
            this.out_check.TabIndex = 165;
            this.out_check.Text = "Out Time";
            this.out_check.UseVisualStyleBackColor = true;
            this.out_check.Click += new System.EventHandler(this.out_check_Click);
            // 
            // att_clear
            // 
            this.att_clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_clear.Location = new System.Drawing.Point(195, 367);
            this.att_clear.Margin = new System.Windows.Forms.Padding(4);
            this.att_clear.Name = "att_clear";
            this.att_clear.Size = new System.Drawing.Size(126, 30);
            this.att_clear.TabIndex = 166;
            this.att_clear.Text = "Clear";
            this.att_clear.UseVisualStyleBackColor = true;
            this.att_clear.Click += new System.EventHandler(this.att_clear_Click);
            // 
            // att_exit
            // 
            this.att_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_exit.Location = new System.Drawing.Point(368, 367);
            this.att_exit.Margin = new System.Windows.Forms.Padding(4);
            this.att_exit.Name = "att_exit";
            this.att_exit.Size = new System.Drawing.Size(126, 30);
            this.att_exit.TabIndex = 167;
            this.att_exit.Text = "Exit";
            this.att_exit.UseVisualStyleBackColor = true;
            this.att_exit.Click += new System.EventHandler(this.att_exit_Click);
            // 
            // date_picker
            // 
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker.Location = new System.Drawing.Point(177, 260);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(96, 20);
            this.date_picker.TabIndex = 168;
            // 
            // atime
            // 
            this.atime.CustomFormat = "HH:ss:mm tt";
            this.atime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.atime.Location = new System.Drawing.Point(287, 260);
            this.atime.Name = "atime";
            this.atime.ShowUpDown = true;
            this.atime.Size = new System.Drawing.Size(96, 20);
            this.atime.TabIndex = 169;
            this.atime.Value = new System.DateTime(2017, 11, 17, 22, 57, 21, 0);
            // 
            // att_submit
            // 
            this.att_submit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_submit.Location = new System.Drawing.Point(616, 367);
            this.att_submit.Margin = new System.Windows.Forms.Padding(4);
            this.att_submit.Name = "att_submit";
            this.att_submit.Size = new System.Drawing.Size(126, 30);
            this.att_submit.TabIndex = 170;
            this.att_submit.Text = "Submit";
            this.att_submit.UseVisualStyleBackColor = true;
            this.att_submit.Click += new System.EventHandler(this.att_submit_Click);
            // 
            // Get_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.att_submit);
            this.Controls.Add(this.atime);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.att_exit);
            this.Controls.Add(this.att_clear);
            this.Controls.Add(this.out_check);
            this.Controls.Add(this.in_check);
            this.Controls.Add(this.att_err_time);
            this.Controls.Add(this.att_err_name);
            this.Controls.Add(this.attin_err_empcode);
            this.Controls.Add(this.att_add);
            this.Controls.Add(this.attendance);
            this.Controls.Add(this.atten_time);
            this.Controls.Add(this.emp_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.att_code);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.MaximizeBox = false;
            this.Name = "Get_Attendance";
            this.ShowInTaskbar = false;
            this.Text = "Get Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Get_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox att_code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox emp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView attendance;
        private System.Windows.Forms.Button att_add;
        public System.Windows.Forms.Label atten_time;
        private System.Windows.Forms.Label attin_err_empcode;
        private System.Windows.Forms.Label att_err_name;
        private System.Windows.Forms.Label att_err_time;
        private System.Windows.Forms.CheckBox in_check;
        private System.Windows.Forms.CheckBox out_check;
        private System.Windows.Forms.Button att_clear;
        private System.Windows.Forms.Button att_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn In_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtHr;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.DateTimePicker atime;
        private System.Windows.Forms.Button att_submit;
    }
}