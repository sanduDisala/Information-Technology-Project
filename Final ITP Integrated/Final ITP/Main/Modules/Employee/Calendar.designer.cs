namespace Main.Module.Employee
{
    partial class Calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.sun = new System.Windows.Forms.CheckBox();
            this.sat = new System.Windows.Forms.CheckBox();
            this.pub_hol = new System.Windows.Forms.CheckBox();
            this.add_grid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pholiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.cal_save = new System.Windows.Forms.Button();
            this.cal_clear = new System.Windows.Forms.Button();
            this.cal_view = new System.Windows.Forms.Button();
            this.view_grid = new System.Windows.Forms.DataGridView();
            this.cal_hisClear = new System.Windows.Forms.Button();
            this.add_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.add_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(588, 55);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // sun
            // 
            this.sun.AutoSize = true;
            this.sun.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sun.Location = new System.Drawing.Point(416, 83);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(88, 20);
            this.sun.TabIndex = 165;
            this.sun.Text = "Sundays";
            this.sun.UseVisualStyleBackColor = true;
            this.sun.CheckedChanged += new System.EventHandler(this.sun_CheckedChanged);
            // 
            // sat
            // 
            this.sat.AutoSize = true;
            this.sat.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat.Location = new System.Drawing.Point(416, 139);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(99, 20);
            this.sat.TabIndex = 166;
            this.sat.Text = "Saturdays";
            this.sat.UseVisualStyleBackColor = true;
            this.sat.CheckedChanged += new System.EventHandler(this.sat_CheckedChanged);
            // 
            // pub_hol
            // 
            this.pub_hol.AutoSize = true;
            this.pub_hol.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pub_hol.Location = new System.Drawing.Point(416, 197);
            this.pub_hol.Name = "pub_hol";
            this.pub_hol.Size = new System.Drawing.Size(140, 20);
            this.pub_hol.TabIndex = 167;
            this.pub_hol.Text = "Public Hoildays";
            this.pub_hol.UseVisualStyleBackColor = true;
            this.pub_hol.CheckedChanged += new System.EventHandler(this.pub_hol_CheckedChanged);
            // 
            // add_grid
            // 
            this.add_grid.AllowUserToAddRows = false;
            this.add_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.add_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Month,
            this.Sunday,
            this.Saturday,
            this.pholiday});
            this.add_grid.Location = new System.Drawing.Point(367, 279);
            this.add_grid.Name = "add_grid";
            this.add_grid.ReadOnly = true;
            this.add_grid.Size = new System.Drawing.Size(655, 270);
            this.add_grid.TabIndex = 168;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            // 
            // pholiday
            // 
            this.pholiday.HeaderText = "Public Holiday";
            this.pholiday.Name = "pholiday";
            this.pholiday.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 28);
            this.label13.TabIndex = 169;
            this.label13.Text = "Office Calendar";
            // 
            // cal_save
            // 
            this.cal_save.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_save.Location = new System.Drawing.Point(456, 588);
            this.cal_save.Margin = new System.Windows.Forms.Padding(4);
            this.cal_save.Name = "cal_save";
            this.cal_save.Size = new System.Drawing.Size(126, 30);
            this.cal_save.TabIndex = 170;
            this.cal_save.Text = "Submit";
            this.cal_save.UseVisualStyleBackColor = true;
            this.cal_save.Click += new System.EventHandler(this.cal_save_Click);
            // 
            // cal_clear
            // 
            this.cal_clear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_clear.Location = new System.Drawing.Point(636, 588);
            this.cal_clear.Margin = new System.Windows.Forms.Padding(4);
            this.cal_clear.Name = "cal_clear";
            this.cal_clear.Size = new System.Drawing.Size(126, 30);
            this.cal_clear.TabIndex = 171;
            this.cal_clear.Text = "Clear";
            this.cal_clear.UseVisualStyleBackColor = true;
            this.cal_clear.Click += new System.EventHandler(this.cal_clear_Click);
            // 
            // cal_view
            // 
            this.cal_view.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_view.Location = new System.Drawing.Point(827, 588);
            this.cal_view.Margin = new System.Windows.Forms.Padding(4);
            this.cal_view.Name = "cal_view";
            this.cal_view.Size = new System.Drawing.Size(126, 30);
            this.cal_view.TabIndex = 172;
            this.cal_view.Text = "View History";
            this.cal_view.UseVisualStyleBackColor = true;
            this.cal_view.Click += new System.EventHandler(this.cal_view_Click);
            // 
            // view_grid
            // 
            this.view_grid.AllowUserToAddRows = false;
            this.view_grid.AllowUserToDeleteRows = false;
            this.view_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_grid.Location = new System.Drawing.Point(367, 279);
            this.view_grid.Name = "view_grid";
            this.view_grid.ReadOnly = true;
            this.view_grid.Size = new System.Drawing.Size(655, 270);
            this.view_grid.TabIndex = 173;
            this.view_grid.Visible = false;
            // 
            // cal_hisClear
            // 
            this.cal_hisClear.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_hisClear.Location = new System.Drawing.Point(636, 588);
            this.cal_hisClear.Margin = new System.Windows.Forms.Padding(4);
            this.cal_hisClear.Name = "cal_hisClear";
            this.cal_hisClear.Size = new System.Drawing.Size(126, 30);
            this.cal_hisClear.TabIndex = 174;
            this.cal_hisClear.Text = "Clear History";
            this.cal_hisClear.UseVisualStyleBackColor = true;
            this.cal_hisClear.Visible = false;
            this.cal_hisClear.Click += new System.EventHandler(this.cal_hisClear_Click);
            // 
            // add_new
            // 
            this.add_new.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new.Location = new System.Drawing.Point(456, 588);
            this.add_new.Margin = new System.Windows.Forms.Padding(4);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(126, 30);
            this.add_new.TabIndex = 175;
            this.add_new.Text = "Add New";
            this.add_new.UseVisualStyleBackColor = true;
            this.add_new.Visible = false;
            this.add_new.Click += new System.EventHandler(this.add_new_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.cal_hisClear);
            this.Controls.Add(this.cal_view);
            this.Controls.Add(this.cal_clear);
            this.Controls.Add(this.cal_save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pub_hol);
            this.Controls.Add(this.sat);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.add_grid);
            this.Controls.Add(this.view_grid);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox sun;
        private System.Windows.Forms.CheckBox sat;
        private System.Windows.Forms.CheckBox pub_hol;
        private System.Windows.Forms.DataGridView add_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn pholiday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cal_save;
        private System.Windows.Forms.Button cal_clear;
        private System.Windows.Forms.Button cal_view;
        private System.Windows.Forms.DataGridView view_grid;
        private System.Windows.Forms.Button cal_hisClear;
        private System.Windows.Forms.Button add_new;
    }
}