namespace Main.Module.Employee
{
    partial class Official_Details
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
            this.od_empcode_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.od_dept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.RadioButton();
            this.yes = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.od_exit = new System.Windows.Forms.Button();
            this.od_clear = new System.Windows.Forms.Button();
            this.od_submit = new System.Windows.Forms.Button();
            this.od_next = new System.Windows.Forms.Button();
            this.od_edit = new System.Windows.Forms.Button();
            this.od_empcode = new System.Windows.Forms.Label();
            this.od_name_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.od_name = new System.Windows.Forms.Label();
            this.od_err_code = new System.Windows.Forms.Label();
            this.od_err_initial = new System.Windows.Forms.Label();
            this.od_err_dept = new System.Windows.Forms.Label();
            this.od_err_desig = new System.Windows.Forms.Label();
            this.od_err_active = new System.Windows.Forms.Label();
            this.prob_date = new System.Windows.Forms.DateTimePicker();
            this.confirm_date = new System.Windows.Forms.DateTimePicker();
            this.resig_date = new System.Windows.Forms.DateTimePicker();
            this.od_err_cdate = new System.Windows.Forms.Label();
            this.od_save = new System.Windows.Forms.Button();
            this.od_getDetails = new System.Windows.Forms.Button();
            this.od_desig = new System.Windows.Forms.TextBox();
            this.demo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // od_empcode_tb
            // 
            this.od_empcode_tb.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_empcode_tb.Location = new System.Drawing.Point(225, 73);
            this.od_empcode_tb.Margin = new System.Windows.Forms.Padding(4);
            this.od_empcode_tb.Name = "od_empcode_tb";
            this.od_empcode_tb.Size = new System.Drawing.Size(112, 21);
            this.od_empcode_tb.TabIndex = 120;
            this.od_empcode_tb.Visible = false;
            this.od_empcode_tb.Leave += new System.EventHandler(this.od_empcode_tb_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 36);
            this.label12.TabIndex = 119;
            this.label12.Text = "Employee Code:\r\n\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(331, 28);
            this.label13.TabIndex = 121;
            this.label13.Text = "Official Details of Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 128;
            this.label4.Text = "Designation:";
            // 
            // od_dept
            // 
            this.od_dept.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_dept.FormattingEnabled = true;
            this.od_dept.ImeMode = System.Windows.Forms.ImeMode.On;
            this.od_dept.Items.AddRange(new object[] {
            "Managemnt",
            "Marketing",
            "Financial",
            "Digital and IT",
            "Production",
            "Scheduling",
            "Operation",
            "Other"});
            this.od_dept.Location = new System.Drawing.Point(225, 180);
            this.od_dept.Name = "od_dept";
            this.od_dept.Size = new System.Drawing.Size(153, 23);
            this.od_dept.TabIndex = 132;
            this.od_dept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.od_dept_KeyPress);
            this.od_dept.Leave += new System.EventHandler(this.od_dept_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 136;
            this.label7.Text = "Resignation Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 138;
            this.label8.Text = "Date of Probation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 18);
            this.label9.TabIndex = 140;
            this.label9.Text = "Date of Confirmation:";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(294, 275);
            this.no.Margin = new System.Windows.Forms.Padding(4);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(41, 19);
            this.no.TabIndex = 143;
            this.no.TabStop = true;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = true;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(226, 275);
            this.yes.Margin = new System.Windows.Forms.Padding(4);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(44, 19);
            this.yes.TabIndex = 142;
            this.yes.TabStop = true;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.CheckedChanged += new System.EventHandler(this.yes_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 278);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 144;
            this.label10.Text = "Active:";
            // 
            // od_exit
            // 
            this.od_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_exit.Location = new System.Drawing.Point(480, 544);
            this.od_exit.Margin = new System.Windows.Forms.Padding(4);
            this.od_exit.Name = "od_exit";
            this.od_exit.Size = new System.Drawing.Size(172, 39);
            this.od_exit.TabIndex = 151;
            this.od_exit.Text = "Exit";
            this.od_exit.UseVisualStyleBackColor = true;
            this.od_exit.Click += new System.EventHandler(this.od_exit_Click);
            // 
            // od_clear
            // 
            this.od_clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_clear.Location = new System.Drawing.Point(251, 544);
            this.od_clear.Margin = new System.Windows.Forms.Padding(4);
            this.od_clear.Name = "od_clear";
            this.od_clear.Size = new System.Drawing.Size(172, 39);
            this.od_clear.TabIndex = 150;
            this.od_clear.Text = "Clear";
            this.od_clear.UseVisualStyleBackColor = true;
            this.od_clear.Click += new System.EventHandler(this.od_clear_Click);
            // 
            // od_submit
            // 
            this.od_submit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_submit.Location = new System.Drawing.Point(22, 544);
            this.od_submit.Margin = new System.Windows.Forms.Padding(4);
            this.od_submit.Name = "od_submit";
            this.od_submit.Size = new System.Drawing.Size(172, 39);
            this.od_submit.TabIndex = 149;
            this.od_submit.Text = "Submit";
            this.od_submit.UseVisualStyleBackColor = true;
            this.od_submit.Click += new System.EventHandler(this.od_submit_Click);
            // 
            // od_next
            // 
            this.od_next.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_next.Location = new System.Drawing.Point(929, 544);
            this.od_next.Margin = new System.Windows.Forms.Padding(4);
            this.od_next.Name = "od_next";
            this.od_next.Size = new System.Drawing.Size(172, 39);
            this.od_next.TabIndex = 152;
            this.od_next.Text = "Next";
            this.od_next.UseVisualStyleBackColor = true;
            this.od_next.Click += new System.EventHandler(this.od_next_Click);
            // 
            // od_edit
            // 
            this.od_edit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_edit.Location = new System.Drawing.Point(709, 544);
            this.od_edit.Margin = new System.Windows.Forms.Padding(4);
            this.od_edit.Name = "od_edit";
            this.od_edit.Size = new System.Drawing.Size(172, 39);
            this.od_edit.TabIndex = 153;
            this.od_edit.Text = "Edit";
            this.od_edit.UseVisualStyleBackColor = true;
            this.od_edit.Click += new System.EventHandler(this.od_edit_Click);
            // 
            // od_empcode
            // 
            this.od_empcode.AutoSize = true;
            this.od_empcode.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_empcode.Location = new System.Drawing.Point(223, 73);
            this.od_empcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.od_empcode.Name = "od_empcode";
            this.od_empcode.Size = new System.Drawing.Size(73, 18);
            this.od_empcode.TabIndex = 154;
            this.od_empcode.Text = "emp code";
            this.od_empcode.Visible = false;
            // 
            // od_name_tb
            // 
            this.od_name_tb.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_name_tb.Location = new System.Drawing.Point(225, 127);
            this.od_name_tb.Margin = new System.Windows.Forms.Padding(4);
            this.od_name_tb.Name = "od_name_tb";
            this.od_name_tb.Size = new System.Drawing.Size(427, 21);
            this.od_name_tb.TabIndex = 156;
            this.od_name_tb.Visible = false;
            this.od_name_tb.Leave += new System.EventHandler(this.od_name_tb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 155;
            this.label1.Text = "Name with Initials:";
            // 
            // od_name
            // 
            this.od_name.AutoSize = true;
            this.od_name.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_name.Location = new System.Drawing.Point(223, 127);
            this.od_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.od_name.Name = "od_name";
            this.od_name.Size = new System.Drawing.Size(128, 18);
            this.od_name.TabIndex = 157;
            this.od_name.Text = "Name with initials";
            this.od_name.Visible = false;
            // 
            // od_err_code
            // 
            this.od_err_code.AutoSize = true;
            this.od_err_code.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_code.ForeColor = System.Drawing.Color.Red;
            this.od_err_code.Location = new System.Drawing.Point(223, 97);
            this.od_err_code.Name = "od_err_code";
            this.od_err_code.Size = new System.Drawing.Size(56, 14);
            this.od_err_code.TabIndex = 158;
            this.od_err_code.Text = "err_label";
            this.od_err_code.Visible = false;
            // 
            // od_err_initial
            // 
            this.od_err_initial.AutoSize = true;
            this.od_err_initial.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_initial.ForeColor = System.Drawing.Color.Red;
            this.od_err_initial.Location = new System.Drawing.Point(223, 151);
            this.od_err_initial.Name = "od_err_initial";
            this.od_err_initial.Size = new System.Drawing.Size(56, 14);
            this.od_err_initial.TabIndex = 159;
            this.od_err_initial.Text = "err_label";
            this.od_err_initial.Visible = false;
            // 
            // od_err_dept
            // 
            this.od_err_dept.AutoSize = true;
            this.od_err_dept.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_dept.ForeColor = System.Drawing.Color.Red;
            this.od_err_dept.Location = new System.Drawing.Point(223, 204);
            this.od_err_dept.Name = "od_err_dept";
            this.od_err_dept.Size = new System.Drawing.Size(56, 14);
            this.od_err_dept.TabIndex = 160;
            this.od_err_dept.Text = "err_label";
            this.od_err_dept.Visible = false;
            // 
            // od_err_desig
            // 
            this.od_err_desig.AutoSize = true;
            this.od_err_desig.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_desig.ForeColor = System.Drawing.Color.Red;
            this.od_err_desig.Location = new System.Drawing.Point(223, 249);
            this.od_err_desig.Name = "od_err_desig";
            this.od_err_desig.Size = new System.Drawing.Size(56, 14);
            this.od_err_desig.TabIndex = 161;
            this.od_err_desig.Text = "err_label";
            this.od_err_desig.Visible = false;
            // 
            // od_err_active
            // 
            this.od_err_active.AutoSize = true;
            this.od_err_active.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_active.ForeColor = System.Drawing.Color.Red;
            this.od_err_active.Location = new System.Drawing.Point(223, 298);
            this.od_err_active.Name = "od_err_active";
            this.od_err_active.Size = new System.Drawing.Size(56, 14);
            this.od_err_active.TabIndex = 162;
            this.od_err_active.Text = "err_label";
            this.od_err_active.Visible = false;
            // 
            // prob_date
            // 
            this.prob_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.prob_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.prob_date.Location = new System.Drawing.Point(225, 328);
            this.prob_date.Margin = new System.Windows.Forms.Padding(4);
            this.prob_date.Name = "prob_date";
            this.prob_date.Size = new System.Drawing.Size(120, 20);
            this.prob_date.TabIndex = 164;
            // 
            // confirm_date
            // 
            this.confirm_date.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.confirm_date.Location = new System.Drawing.Point(225, 376);
            this.confirm_date.Margin = new System.Windows.Forms.Padding(4);
            this.confirm_date.Name = "confirm_date";
            this.confirm_date.Size = new System.Drawing.Size(120, 20);
            this.confirm_date.TabIndex = 165;
            // 
            // resig_date
            // 
            this.resig_date.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resig_date.Enabled = false;
            this.resig_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.resig_date.Location = new System.Drawing.Point(225, 427);
            this.resig_date.Margin = new System.Windows.Forms.Padding(4);
            this.resig_date.Name = "resig_date";
            this.resig_date.Size = new System.Drawing.Size(120, 20);
            this.resig_date.TabIndex = 166;
            // 
            // od_err_cdate
            // 
            this.od_err_cdate.AutoSize = true;
            this.od_err_cdate.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_err_cdate.ForeColor = System.Drawing.Color.Red;
            this.od_err_cdate.Location = new System.Drawing.Point(223, 400);
            this.od_err_cdate.Name = "od_err_cdate";
            this.od_err_cdate.Size = new System.Drawing.Size(56, 14);
            this.od_err_cdate.TabIndex = 167;
            this.od_err_cdate.Text = "err_label";
            this.od_err_cdate.Visible = false;
            // 
            // od_save
            // 
            this.od_save.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_save.Location = new System.Drawing.Point(22, 544);
            this.od_save.Margin = new System.Windows.Forms.Padding(4);
            this.od_save.Name = "od_save";
            this.od_save.Size = new System.Drawing.Size(172, 39);
            this.od_save.TabIndex = 168;
            this.od_save.Text = "Save";
            this.od_save.UseVisualStyleBackColor = true;
            this.od_save.Visible = false;
            this.od_save.Click += new System.EventHandler(this.od_save_Click);
            // 
            // od_getDetails
            // 
            this.od_getDetails.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_getDetails.Location = new System.Drawing.Point(413, 67);
            this.od_getDetails.Margin = new System.Windows.Forms.Padding(4);
            this.od_getDetails.Name = "od_getDetails";
            this.od_getDetails.Size = new System.Drawing.Size(189, 29);
            this.od_getDetails.TabIndex = 169;
            this.od_getDetails.Text = "Get Details";
            this.od_getDetails.UseVisualStyleBackColor = true;
            this.od_getDetails.Visible = false;
            this.od_getDetails.Click += new System.EventHandler(this.od_getDetails_Click);
            // 
            // od_desig
            // 
            this.od_desig.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.od_desig.Location = new System.Drawing.Point(225, 223);
            this.od_desig.Margin = new System.Windows.Forms.Padding(4);
            this.od_desig.MaxLength = 10;
            this.od_desig.Name = "od_desig";
            this.od_desig.Size = new System.Drawing.Size(206, 21);
            this.od_desig.TabIndex = 177;
            // 
            // demo
            // 
            this.demo.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demo.Location = new System.Drawing.Point(929, 419);
            this.demo.Margin = new System.Windows.Forms.Padding(4);
            this.demo.Name = "demo";
            this.demo.Size = new System.Drawing.Size(172, 39);
            this.demo.TabIndex = 178;
            this.demo.Text = "Demo";
            this.demo.UseVisualStyleBackColor = true;
            this.demo.Click += new System.EventHandler(this.demo_Click);
            // 
            // Official_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.od_desig);
            this.Controls.Add(this.od_getDetails);
            this.Controls.Add(this.od_save);
            this.Controls.Add(this.od_err_cdate);
            this.Controls.Add(this.resig_date);
            this.Controls.Add(this.confirm_date);
            this.Controls.Add(this.prob_date);
            this.Controls.Add(this.od_err_active);
            this.Controls.Add(this.od_err_desig);
            this.Controls.Add(this.od_err_dept);
            this.Controls.Add(this.od_err_initial);
            this.Controls.Add(this.od_err_code);
            this.Controls.Add(this.od_name);
            this.Controls.Add(this.od_name_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.od_empcode);
            this.Controls.Add(this.od_edit);
            this.Controls.Add(this.od_next);
            this.Controls.Add(this.od_exit);
            this.Controls.Add(this.od_clear);
            this.Controls.Add(this.od_submit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.od_dept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.od_empcode_tb);
            this.Controls.Add(this.label12);
            this.Name = "Official_Details";
            this.Text = "Official_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Official_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox od_empcode_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox od_dept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton yes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button od_exit;
        private System.Windows.Forms.Button od_clear;
        private System.Windows.Forms.Button od_submit;
        private System.Windows.Forms.Button od_next;
        private System.Windows.Forms.Button od_edit;
        public System.Windows.Forms.Label od_empcode;
        public System.Windows.Forms.TextBox od_name_tb;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label od_name;
        private System.Windows.Forms.Label od_err_code;
        private System.Windows.Forms.Label od_err_initial;
        private System.Windows.Forms.Label od_err_dept;
        private System.Windows.Forms.Label od_err_desig;
        private System.Windows.Forms.Label od_err_active;
        private System.Windows.Forms.DateTimePicker prob_date;
        private System.Windows.Forms.DateTimePicker confirm_date;
        private System.Windows.Forms.DateTimePicker resig_date;
        private System.Windows.Forms.Label od_err_cdate;
        private System.Windows.Forms.Button od_save;
        private System.Windows.Forms.Button od_getDetails;
        private System.Windows.Forms.TextBox od_desig;
        private System.Windows.Forms.Button demo;
    }
}