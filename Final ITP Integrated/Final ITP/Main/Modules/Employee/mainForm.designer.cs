namespace Main.Module.Employee
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officialDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officeCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAttendanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSalaryDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem,
            this.salaryDetailsToolStripMenuItem,
            this.getAttendanceToolStripMenuItem,
            this.leavesToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1016, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem,
            this.officialDetailsToolStripMenuItem,
            this.contactDetailsToolStripMenuItem,
            this.qualificationsToolStripMenuItem});
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(135, 33);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.personalDetailsToolStripMenuItem.Text = "Personal Details";
            this.personalDetailsToolStripMenuItem.Click += new System.EventHandler(this.personalDetailsToolStripMenuItem_Click);
            // 
            // officialDetailsToolStripMenuItem
            // 
            this.officialDetailsToolStripMenuItem.Name = "officialDetailsToolStripMenuItem";
            this.officialDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.officialDetailsToolStripMenuItem.Text = "Official Details";
            this.officialDetailsToolStripMenuItem.Click += new System.EventHandler(this.officialDetailsToolStripMenuItem_Click);
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            this.contactDetailsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.contactDetailsToolStripMenuItem.Text = "Contact Details";
            this.contactDetailsToolStripMenuItem.Click += new System.EventHandler(this.contactDetailsToolStripMenuItem_Click);
            // 
            // qualificationsToolStripMenuItem
            // 
            this.qualificationsToolStripMenuItem.Name = "qualificationsToolStripMenuItem";
            this.qualificationsToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.qualificationsToolStripMenuItem.Text = "Qualifications and Experiances";
            this.qualificationsToolStripMenuItem.Click += new System.EventHandler(this.qualificationsToolStripMenuItem_Click);
            // 
            // salaryDetailsToolStripMenuItem
            // 
            this.salaryDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSalaryDetailsToolStripMenuItem,
            this.salaryReportToolStripMenuItem});
            this.salaryDetailsToolStripMenuItem.Name = "salaryDetailsToolStripMenuItem";
            this.salaryDetailsToolStripMenuItem.Size = new System.Drawing.Size(132, 33);
            this.salaryDetailsToolStripMenuItem.Text = "Employee Salary";
            this.salaryDetailsToolStripMenuItem.Click += new System.EventHandler(this.salaryDetailsToolStripMenuItem_Click);
            // 
            // getAttendanceToolStripMenuItem
            // 
            this.getAttendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officeCalendarToolStripMenuItem,
            this.getAttendanceToolStripMenuItem1,
            this.viewAttendanceToolStripMenuItem});
            this.getAttendanceToolStripMenuItem.Name = "getAttendanceToolStripMenuItem";
            this.getAttendanceToolStripMenuItem.Size = new System.Drawing.Size(95, 33);
            this.getAttendanceToolStripMenuItem.Text = "Attendance";
            this.getAttendanceToolStripMenuItem.Click += new System.EventHandler(this.AttendanceToolStripMenuItem_Click);
            // 
            // officeCalendarToolStripMenuItem
            // 
            this.officeCalendarToolStripMenuItem.Name = "officeCalendarToolStripMenuItem";
            this.officeCalendarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.officeCalendarToolStripMenuItem.Text = "Office Calendar";
            this.officeCalendarToolStripMenuItem.Click += new System.EventHandler(this.officeCalendarToolStripMenuItem_Click);
            // 
            // getAttendanceToolStripMenuItem1
            // 
            this.getAttendanceToolStripMenuItem1.Name = "getAttendanceToolStripMenuItem1";
            this.getAttendanceToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.getAttendanceToolStripMenuItem1.Text = "Get Attendance";
            this.getAttendanceToolStripMenuItem1.Click += new System.EventHandler(this.getAttendanceToolStripMenuItem1_Click);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewAttendanceToolStripMenuItem.Text = "View Attendance";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendanceToolStripMenuItem_Click);
            // 
            // leavesToolStripMenuItem
            // 
            this.leavesToolStripMenuItem.Name = "leavesToolStripMenuItem";
            this.leavesToolStripMenuItem.Size = new System.Drawing.Size(107, 33);
            this.leavesToolStripMenuItem.Text = "Apply Leaves";
            this.leavesToolStripMenuItem.Click += new System.EventHandler(this.leavesToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.employeeDetailsToolStripMenuItem1});
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(131, 33);
            this.viewDetailsToolStripMenuItem.Text = "View and Search";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // employeeDetailsToolStripMenuItem1
            // 
            this.employeeDetailsToolStripMenuItem1.Name = "employeeDetailsToolStripMenuItem1";
            this.employeeDetailsToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.employeeDetailsToolStripMenuItem1.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem1.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem1_Click);
            // 
            // addSalaryDetailsToolStripMenuItem
            // 
            this.addSalaryDetailsToolStripMenuItem.Name = "addSalaryDetailsToolStripMenuItem";
            this.addSalaryDetailsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addSalaryDetailsToolStripMenuItem.Text = "Add Salary Details";
            this.addSalaryDetailsToolStripMenuItem.Click += new System.EventHandler(this.addSalaryDetailsToolStripMenuItem_Click);
            // 
            // salaryReportToolStripMenuItem
            // 
            this.salaryReportToolStripMenuItem.Name = "salaryReportToolStripMenuItem";
            this.salaryReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salaryReportToolStripMenuItem.Text = "Salary Report";
            this.salaryReportToolStripMenuItem.Click += new System.EventHandler(this.salaryReportToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1016, 596);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "HR Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officialDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officeCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAttendanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSalaryDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryReportToolStripMenuItem;
    }
}

