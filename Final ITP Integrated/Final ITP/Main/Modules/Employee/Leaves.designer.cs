namespace Main.Module.Employee
{
    partial class Leaves
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
            this.leave_emp_code = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leave_type = new System.Windows.Forms.ComboBox();
            this.leave_to = new System.Windows.Forms.DateTimePicker();
            this.leave_from = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leaves_left = new System.Windows.Forms.DataGridView();
            this.Emp_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ann_leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cas_leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sick_leave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.half_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leave_submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nopay_check = new System.Windows.Forms.CheckBox();
            this.leave_err_empcode = new System.Windows.Forms.Label();
            this.leave_err_type = new System.Windows.Forms.Label();
            this.leave_err = new System.Windows.Forms.Label();
            this.leaves_taken = new System.Windows.Forms.DataGridView();
            this.empcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_of_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.half_check = new System.Windows.Forms.CheckBox();
            this.full_day_check = new System.Windows.Forms.CheckBox();
            this.half_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.leave_add = new System.Windows.Forms.Button();
            this.leave_err_half = new System.Windows.Forms.Label();
            this.leave_edit = new System.Windows.Forms.Button();
            this.leave_delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.leave_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaves_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaves_taken)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 28);
            this.label13.TabIndex = 122;
            this.label13.Text = "Record Employee  Leave";
            // 
            // leave_emp_code
            // 
            this.leave_emp_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_emp_code.Location = new System.Drawing.Point(188, 69);
            this.leave_emp_code.Margin = new System.Windows.Forms.Padding(4);
            this.leave_emp_code.Name = "leave_emp_code";
            this.leave_emp_code.Size = new System.Drawing.Size(112, 20);
            this.leave_emp_code.TabIndex = 124;
            this.leave_emp_code.Leave += new System.EventHandler(this.leave_emp_code_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 36);
            this.label12.TabIndex = 123;
            this.label12.Text = "Employee Code:\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Leave Type:";
            // 
            // leave_type
            // 
            this.leave_type.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_type.FormattingEnabled = true;
            this.leave_type.Items.AddRange(new object[] {
            "Annual Leave",
            "Casual Leave",
            "Sick Leave",
            "Maternity Leave"});
            this.leave_type.Location = new System.Drawing.Point(188, 121);
            this.leave_type.Name = "leave_type";
            this.leave_type.Size = new System.Drawing.Size(170, 22);
            this.leave_type.TabIndex = 126;
            // 
            // leave_to
            // 
            this.leave_to.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_to.Enabled = false;
            this.leave_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.leave_to.Location = new System.Drawing.Point(187, 370);
            this.leave_to.Margin = new System.Windows.Forms.Padding(4);
            this.leave_to.Name = "leave_to";
            this.leave_to.Size = new System.Drawing.Size(120, 20);
            this.leave_to.TabIndex = 135;
            // 
            // leave_from
            // 
            this.leave_from.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_from.Enabled = false;
            this.leave_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.leave_from.Location = new System.Drawing.Point(187, 310);
            this.leave_from.Margin = new System.Windows.Forms.Padding(4);
            this.leave_from.Name = "leave_from";
            this.leave_from.Size = new System.Drawing.Size(120, 20);
            this.leave_from.TabIndex = 134;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 373);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 18);
            this.label8.TabIndex = 133;
            this.label8.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 132;
            this.label6.Text = "From:";
            // 
            // leaves_left
            // 
            this.leaves_left.AllowUserToAddRows = false;
            this.leaves_left.AllowUserToDeleteRows = false;
            this.leaves_left.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaves_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaves_left.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_code,
            this.Emp_name,
            this.Ann_leave,
            this.Cas_leave,
            this.sick_leave,
            this.half_day});
            this.leaves_left.Location = new System.Drawing.Point(505, 44);
            this.leaves_left.Name = "leaves_left";
            this.leaves_left.ReadOnly = true;
            this.leaves_left.Size = new System.Drawing.Size(681, 132);
            this.leaves_left.TabIndex = 136;
            // 
            // Emp_code
            // 
            this.Emp_code.HeaderText = "Employee Code";
            this.Emp_code.Name = "Emp_code";
            this.Emp_code.ReadOnly = true;
            // 
            // Emp_name
            // 
            this.Emp_name.HeaderText = "Employee Name";
            this.Emp_name.Name = "Emp_name";
            this.Emp_name.ReadOnly = true;
            // 
            // Ann_leave
            // 
            this.Ann_leave.HeaderText = "Annual Leave";
            this.Ann_leave.Name = "Ann_leave";
            this.Ann_leave.ReadOnly = true;
            // 
            // Cas_leave
            // 
            this.Cas_leave.HeaderText = "Casual Leaves";
            this.Cas_leave.Name = "Cas_leave";
            this.Cas_leave.ReadOnly = true;
            // 
            // sick_leave
            // 
            this.sick_leave.HeaderText = "Sick Leave";
            this.sick_leave.Name = "sick_leave";
            this.sick_leave.ReadOnly = true;
            // 
            // half_day
            // 
            this.half_day.HeaderText = "Half Days";
            this.half_day.Name = "half_day";
            this.half_day.ReadOnly = true;
            // 
            // leave_submit
            // 
            this.leave_submit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_submit.Location = new System.Drawing.Point(543, 394);
            this.leave_submit.Margin = new System.Windows.Forms.Padding(4);
            this.leave_submit.Name = "leave_submit";
            this.leave_submit.Size = new System.Drawing.Size(172, 39);
            this.leave_submit.TabIndex = 150;
            this.leave_submit.Text = "Submit";
            this.leave_submit.UseVisualStyleBackColor = true;
            this.leave_submit.Click += new System.EventHandler(this.leave_submit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(372, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 151;
            this.button1.Text = "View Leaves";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nopay_check
            // 
            this.nopay_check.AutoSize = true;
            this.nopay_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nopay_check.Location = new System.Drawing.Point(83, 454);
            this.nopay_check.Name = "nopay_check";
            this.nopay_check.Size = new System.Drawing.Size(168, 20);
            this.nopay_check.TabIndex = 152;
            this.nopay_check.Text = "No Pay Cut on leave";
            this.nopay_check.UseVisualStyleBackColor = true;
            // 
            // leave_err_empcode
            // 
            this.leave_err_empcode.AutoSize = true;
            this.leave_err_empcode.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_err_empcode.ForeColor = System.Drawing.Color.Red;
            this.leave_err_empcode.Location = new System.Drawing.Point(185, 93);
            this.leave_err_empcode.Name = "leave_err_empcode";
            this.leave_err_empcode.Size = new System.Drawing.Size(56, 14);
            this.leave_err_empcode.TabIndex = 160;
            this.leave_err_empcode.Text = "err_label";
            this.leave_err_empcode.Visible = false;
            // 
            // leave_err_type
            // 
            this.leave_err_type.AutoSize = true;
            this.leave_err_type.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_err_type.ForeColor = System.Drawing.Color.Red;
            this.leave_err_type.Location = new System.Drawing.Point(185, 146);
            this.leave_err_type.Name = "leave_err_type";
            this.leave_err_type.Size = new System.Drawing.Size(56, 14);
            this.leave_err_type.TabIndex = 161;
            this.leave_err_type.Text = "err_label";
            this.leave_err_type.Visible = false;
            // 
            // leave_err
            // 
            this.leave_err.AutoSize = true;
            this.leave_err.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_err.ForeColor = System.Drawing.Color.Red;
            this.leave_err.Location = new System.Drawing.Point(53, 408);
            this.leave_err.Name = "leave_err";
            this.leave_err.Size = new System.Drawing.Size(56, 14);
            this.leave_err.TabIndex = 163;
            this.leave_err.Text = "err_label";
            this.leave_err.Visible = false;
            // 
            // leaves_taken
            // 
            this.leaves_taken.AllowUserToAddRows = false;
            this.leaves_taken.AllowUserToDeleteRows = false;
            this.leaves_taken.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaves_taken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaves_taken.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empcode,
            this.id,
            this.type,
            this.from,
            this.to,
            this.no_of_days,
            this.date,
            this.pay});
            this.leaves_taken.Location = new System.Drawing.Point(505, 215);
            this.leaves_taken.Name = "leaves_taken";
            this.leaves_taken.ReadOnly = true;
            this.leaves_taken.Size = new System.Drawing.Size(681, 150);
            this.leaves_taken.TabIndex = 164;
            this.leaves_taken.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leaves_taken_MouseClick);
            // 
            // empcode
            // 
            this.empcode.HeaderText = "Employee Code";
            this.empcode.Name = "empcode";
            this.empcode.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Leave ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Leave Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // no_of_days
            // 
            this.no_of_days.HeaderText = "No. of Days";
            this.no_of_days.Name = "no_of_days";
            this.no_of_days.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // pay
            // 
            this.pay.HeaderText = "No Pay";
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            // 
            // half_check
            // 
            this.half_check.AutoSize = true;
            this.half_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.half_check.Location = new System.Drawing.Point(51, 190);
            this.half_check.Name = "half_check";
            this.half_check.Size = new System.Drawing.Size(88, 20);
            this.half_check.TabIndex = 165;
            this.half_check.Text = "Half Day";
            this.half_check.UseVisualStyleBackColor = true;
            this.half_check.Click += new System.EventHandler(this.half_check_Click);
            // 
            // full_day_check
            // 
            this.full_day_check.AutoSize = true;
            this.full_day_check.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_day_check.Location = new System.Drawing.Point(56, 283);
            this.full_day_check.Name = "full_day_check";
            this.full_day_check.Size = new System.Drawing.Size(87, 20);
            this.full_day_check.TabIndex = 166;
            this.full_day_check.Text = "Full Day";
            this.full_day_check.UseVisualStyleBackColor = true;
            this.full_day_check.Click += new System.EventHandler(this.full_day_check_Click);
            // 
            // half_date
            // 
            this.half_date.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.half_date.Enabled = false;
            this.half_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.half_date.Location = new System.Drawing.Point(187, 219);
            this.half_date.Margin = new System.Windows.Forms.Padding(4);
            this.half_date.Name = "half_date";
            this.half_date.Size = new System.Drawing.Size(120, 20);
            this.half_date.TabIndex = 168;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 167;
            this.label7.Text = "Date:";
            // 
            // leave_add
            // 
            this.leave_add.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_add.Location = new System.Drawing.Point(29, 525);
            this.leave_add.Margin = new System.Windows.Forms.Padding(4);
            this.leave_add.Name = "leave_add";
            this.leave_add.Size = new System.Drawing.Size(172, 39);
            this.leave_add.TabIndex = 170;
            this.leave_add.Text = "Add Leave";
            this.leave_add.UseVisualStyleBackColor = true;
            this.leave_add.Click += new System.EventHandler(this.leave_add_Click);
            // 
            // leave_err_half
            // 
            this.leave_err_half.AutoSize = true;
            this.leave_err_half.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_err_half.ForeColor = System.Drawing.Color.Red;
            this.leave_err_half.Location = new System.Drawing.Point(53, 253);
            this.leave_err_half.Name = "leave_err_half";
            this.leave_err_half.Size = new System.Drawing.Size(56, 14);
            this.leave_err_half.TabIndex = 171;
            this.leave_err_half.Text = "err_label";
            this.leave_err_half.Visible = false;
            // 
            // leave_edit
            // 
            this.leave_edit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_edit.Location = new System.Drawing.Point(733, 394);
            this.leave_edit.Margin = new System.Windows.Forms.Padding(4);
            this.leave_edit.Name = "leave_edit";
            this.leave_edit.Size = new System.Drawing.Size(172, 39);
            this.leave_edit.TabIndex = 172;
            this.leave_edit.Text = "Edit";
            this.leave_edit.UseVisualStyleBackColor = true;
            this.leave_edit.Click += new System.EventHandler(this.leave_edit_Click);
            // 
            // leave_delete
            // 
            this.leave_delete.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_delete.Location = new System.Drawing.Point(938, 394);
            this.leave_delete.Margin = new System.Windows.Forms.Padding(4);
            this.leave_delete.Name = "leave_delete";
            this.leave_delete.Size = new System.Drawing.Size(172, 39);
            this.leave_delete.TabIndex = 173;
            this.leave_delete.Text = "Delete";
            this.leave_delete.UseVisualStyleBackColor = true;
            this.leave_delete.Click += new System.EventHandler(this.leave_delete_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(235, 525);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(172, 39);
            this.clear.TabIndex = 174;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // leave_exit
            // 
            this.leave_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_exit.Location = new System.Drawing.Point(445, 525);
            this.leave_exit.Margin = new System.Windows.Forms.Padding(4);
            this.leave_exit.Name = "leave_exit";
            this.leave_exit.Size = new System.Drawing.Size(172, 39);
            this.leave_exit.TabIndex = 175;
            this.leave_exit.Text = "Exit";
            this.leave_exit.UseVisualStyleBackColor = true;
            this.leave_exit.Click += new System.EventHandler(this.leave_exit_Click);
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 706);
            this.Controls.Add(this.leave_exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.leave_delete);
            this.Controls.Add(this.leave_edit);
            this.Controls.Add(this.leave_err_half);
            this.Controls.Add(this.leave_add);
            this.Controls.Add(this.half_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.full_day_check);
            this.Controls.Add(this.half_check);
            this.Controls.Add(this.leaves_taken);
            this.Controls.Add(this.leave_err);
            this.Controls.Add(this.leave_err_type);
            this.Controls.Add(this.leave_err_empcode);
            this.Controls.Add(this.nopay_check);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leave_submit);
            this.Controls.Add(this.leaves_left);
            this.Controls.Add(this.leave_to);
            this.Controls.Add(this.leave_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leave_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leave_emp_code);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "Leaves";
            this.Text = "Employee Leave";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Leaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaves_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaves_taken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox leave_emp_code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leave_type;
        private System.Windows.Forms.DateTimePicker leave_to;
        private System.Windows.Forms.DateTimePicker leave_from;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView leaves_left;
        private System.Windows.Forms.Button leave_submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox nopay_check;
        private System.Windows.Forms.Label leave_err_empcode;
        private System.Windows.Forms.Label leave_err_type;
        private System.Windows.Forms.Label leave_err;
        private System.Windows.Forms.DataGridView leaves_taken;
        private System.Windows.Forms.CheckBox half_check;
        private System.Windows.Forms.CheckBox full_day_check;
        private System.Windows.Forms.DateTimePicker half_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ann_leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cas_leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn sick_leave;
        private System.Windows.Forms.DataGridViewTextBoxColumn half_day;
        private System.Windows.Forms.Button leave_add;
        private System.Windows.Forms.Label leave_err_half;
        private System.Windows.Forms.Button leave_edit;
        private System.Windows.Forms.Button leave_delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button leave_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_of_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
    }
}