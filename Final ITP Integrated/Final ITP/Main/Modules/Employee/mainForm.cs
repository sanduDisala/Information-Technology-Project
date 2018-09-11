using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Main.Module.Employee
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
                                        
        }


        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details form = new Employee_Details();
            form.MdiParent = this;
            form.Show();
        }

        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_Details form = new Contact_Details();
            form.MdiParent = this;
            form.cd_code.Visible = true;
            form.Show();


        }

        private void qualificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Qualifications form = new Qualifications();
            form.MdiParent = this;
            form.qual_empcode.Visible = true;
            form.Show();

        }

        

        

        private void officialDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Official_Details form = new Official_Details();
            form.MdiParent = this;
            form.Show();
            form.od_empcode_tb.Visible = true;
            form.od_name_tb.Visible = true;
        }

       

        private void employeeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        private void AttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void leavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaves form = new Leaves();
            form.MdiParent = this;
            form.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void officeCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar form = new Calendar();
            form.MdiParent = this;
            form.Show();
        }

        private void getAttendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Get_Attendance form = new Get_Attendance();
            form.MdiParent = this;
            //form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Employee_Details form = new View_Employee_Details();
            form.MdiParent = this;
            form.Show();
        }

        private void employeeDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchEmployeeDetails form = new SearchEmployeeDetails();
            form.MdiParent = this;
            form.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Attendance form = new View_Attendance();
            form.MdiParent = this;
            form.Show();
        }

        private void salaryReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addSalaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Details form = new Salary_Details();
            form.MdiParent = this;
            form.Show();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Report_Details form = new Salary_Report_Details();
            form.MdiParent = this;
            form.Show();
        }

       
    }
}
