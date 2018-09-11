namespace Main.Module.Employee
{
    partial class View_Attendance
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
            this.monthly = new System.Windows.Forms.RadioButton();
            this.daily = new System.Windows.Forms.RadioButton();
            this.ed_err_code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ed_empcode = new System.Windows.Forms.TextBox();
            this.err_date = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.err_month = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.view_all = new System.Windows.Forms.CheckBox();
            this.att_exit = new System.Windows.Forms.Button();
            this.att_search = new System.Windows.Forms.Button();
            this.detail_grid = new System.Windows.Forms.DataGridView();
            this.month = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 28);
            this.label13.TabIndex = 122;
            this.label13.Text = "View Attendance";
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly.Location = new System.Drawing.Point(251, 81);
            this.monthly.Margin = new System.Windows.Forms.Padding(4);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(145, 19);
            this.monthly.TabIndex = 185;
            this.monthly.TabStop = true;
            this.monthly.Text = "Monthly Attendance";
            this.monthly.UseVisualStyleBackColor = true;
            this.monthly.Click += new System.EventHandler(this.monthly_Click);
            // 
            // daily
            // 
            this.daily.AutoSize = true;
            this.daily.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daily.Location = new System.Drawing.Point(83, 81);
            this.daily.Margin = new System.Windows.Forms.Padding(4);
            this.daily.Name = "daily";
            this.daily.Size = new System.Drawing.Size(127, 19);
            this.daily.TabIndex = 184;
            this.daily.TabStop = true;
            this.daily.Text = "Daily Attendance";
            this.daily.UseVisualStyleBackColor = true;
            this.daily.Click += new System.EventHandler(this.daily_Click);
            // 
            // ed_err_code
            // 
            this.ed_err_code.AutoSize = true;
            this.ed_err_code.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_err_code.ForeColor = System.Drawing.Color.Red;
            this.ed_err_code.Location = new System.Drawing.Point(212, 194);
            this.ed_err_code.Name = "ed_err_code";
            this.ed_err_code.Size = new System.Drawing.Size(56, 14);
            this.ed_err_code.TabIndex = 188;
            this.ed_err_code.Text = "err_label";
            this.ed_err_code.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 187;
            this.label1.Text = "Employee Code";
            // 
            // ed_empcode
            // 
            this.ed_empcode.Enabled = false;
            this.ed_empcode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_empcode.Location = new System.Drawing.Point(215, 168);
            this.ed_empcode.Margin = new System.Windows.Forms.Padding(4);
            this.ed_empcode.MaxLength = 10;
            this.ed_empcode.Name = "ed_empcode";
            this.ed_empcode.Size = new System.Drawing.Size(221, 22);
            this.ed_empcode.TabIndex = 186;
            // 
            // err_date
            // 
            this.err_date.AutoSize = true;
            this.err_date.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_date.ForeColor = System.Drawing.Color.Red;
            this.err_date.Location = new System.Drawing.Point(212, 268);
            this.err_date.Name = "err_date";
            this.err_date.Size = new System.Drawing.Size(139, 14);
            this.err_date.TabIndex = 190;
            this.err_date.Text = "err_label(at subimttion)";
            this.err_date.Visible = false;
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.CustomFormat = "MM/dd/yyyy";
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(215, 244);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(120, 20);
            this.date.TabIndex = 189;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 191;
            this.label2.Text = "Date";
            // 
            // err_month
            // 
            this.err_month.AutoSize = true;
            this.err_month.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_month.ForeColor = System.Drawing.Color.Red;
            this.err_month.Location = new System.Drawing.Point(212, 337);
            this.err_month.Name = "err_month";
            this.err_month.Size = new System.Drawing.Size(56, 14);
            this.err_month.TabIndex = 194;
            this.err_month.Text = "err_label";
            this.err_month.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 193;
            this.label3.Text = "Month";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // view_all
            // 
            this.view_all.AutoSize = true;
            this.view_all.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.Location = new System.Drawing.Point(97, 122);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(81, 19);
            this.view_all.TabIndex = 195;
            this.view_all.Text = "View All";
            this.view_all.UseVisualStyleBackColor = true;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // att_exit
            // 
            this.att_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_exit.Location = new System.Drawing.Point(297, 406);
            this.att_exit.Margin = new System.Windows.Forms.Padding(4);
            this.att_exit.Name = "att_exit";
            this.att_exit.Size = new System.Drawing.Size(121, 36);
            this.att_exit.TabIndex = 197;
            this.att_exit.Text = "Exit";
            this.att_exit.UseVisualStyleBackColor = true;
            this.att_exit.Click += new System.EventHandler(this.att_exit_Click);
            // 
            // att_search
            // 
            this.att_search.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att_search.Location = new System.Drawing.Point(112, 406);
            this.att_search.Margin = new System.Windows.Forms.Padding(4);
            this.att_search.Name = "att_search";
            this.att_search.Size = new System.Drawing.Size(121, 36);
            this.att_search.TabIndex = 196;
            this.att_search.Text = "Search";
            this.att_search.UseVisualStyleBackColor = true;
            this.att_search.Click += new System.EventHandler(this.att_search_Click);
            // 
            // detail_grid
            // 
            this.detail_grid.AllowUserToAddRows = false;
            this.detail_grid.AllowUserToDeleteRows = false;
            this.detail_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_grid.Location = new System.Drawing.Point(592, 81);
            this.detail_grid.Name = "detail_grid";
            this.detail_grid.ReadOnly = true;
            this.detail_grid.Size = new System.Drawing.Size(465, 465);
            this.detail_grid.TabIndex = 198;
            // 
            // month
            // 
            this.month.Enabled = false;
            this.month.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.FormattingEnabled = true;
            this.month.ImeMode = System.Windows.Forms.ImeMode.On;
            this.month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July ",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month.Location = new System.Drawing.Point(215, 311);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(221, 23);
            this.month.TabIndex = 199;
            // 
            // View_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 692);
            this.Controls.Add(this.month);
            this.Controls.Add(this.detail_grid);
            this.Controls.Add(this.att_exit);
            this.Controls.Add(this.att_search);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.err_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.err_date);
            this.Controls.Add(this.date);
            this.Controls.Add(this.ed_err_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_empcode);
            this.Controls.Add(this.monthly);
            this.Controls.Add(this.daily);
            this.Controls.Add(this.label13);
            this.Name = "View_Attendance";
            this.Text = "View_Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton monthly;
        private System.Windows.Forms.RadioButton daily;
        private System.Windows.Forms.Label ed_err_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ed_empcode;
        private System.Windows.Forms.Label err_date;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label err_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox view_all;
        private System.Windows.Forms.Button att_exit;
        private System.Windows.Forms.Button att_search;
        private System.Windows.Forms.DataGridView detail_grid;
        private System.Windows.Forms.ComboBox month;
    }
}