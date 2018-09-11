using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Module.Employee
{
    public partial class View_Attendance : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        DataSet ds = new DataSet();
        public View_Attendance()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void daily_Click(object sender, EventArgs e)
        {
            month.Text = "";
            date.Enabled = true;
            month.Enabled = false;
            ed_empcode.Enabled = true;
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.Date.ToString();
            month.Enabled = true;
            date.Enabled = false;
            ed_empcode.Enabled = true;
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            ed_empcode.Text = "";
            if (view_all.Checked == true)
            {
                ed_empcode.Enabled = false;
            }
            else if (view_all.Checked == false)
            {
                ed_empcode.Enabled = true;
            }
        }

        private void att_search_Click(object sender, EventArgs e)
        {
            string day = "";
            string code = "";
            int mon = 0;
            if (daily.Checked == true && view_all.Checked == true)
            {
                if (fv.date_Validator(DateTime.Parse(date.Text), err_date) == false)
                {
                    day = DateTime.Parse(date.Text).ToString("MM/dd/yyyy");
                    ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', in_time AS 'In Time', out_time AS 'Out Time', ot_hrs AS 'OT Hours' FROM attendance WHERE CONVERT(varchar(10), in_time, 101) = '" + day + "'");
                    detail_grid.DataSource = ds.Tables[0];
                }
                                                                                //SELECT * FROM attendance WHERE emp_code = 'E0004' AND CONVERT(varchar(10), in_time, 101) = '09/20/2017'
            }
            else if (daily.Checked == true && view_all.Checked != true)
            {
                if (fv.date_Validator(DateTime.Parse(date.Text), err_date) == false && fv.empcode_validator(ed_empcode.Text, ed_err_code) == false)
                {
                    day = DateTime.Parse(date.Text).ToString("MM/dd/yyyy");
                    //MessageBox.Show("day = " + day);
                    code = ed_empcode.Text;
                    ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', in_time AS 'In Time', out_time AS 'Out Time', ot_hrs AS 'OT Hours' FROM attendance WHERE CONVERT(varchar(10), in_time, 101) = '" + day + "' AND emp_code = '" + code + "'");
                    detail_grid.DataSource = ds.Tables[0];
                }

            }
            else if(monthly.Checked == true && view_all.Checked == true) 
            {
                if(fv.checkEmpty(month.Text, err_month) == false)
                {
                    switch (month.Text)
                    {
                        case "January":
                            mon = 1;
                            break;
                        case "February":
                            mon = 2;
                            break;
                        case "March":
                            mon = 3;
                            break;
                        case "April":
                            mon = 4;
                            break;
                        case "May":
                            mon = 5;
                            break;
                        case "June":
                            mon = 6;
                            break;
                        case "July":
                            mon = 7;
                            break;
                        case "August":
                            mon = 8;
                            break;
                        case "September":
                            mon = 9;
                            break;
                        case "October":
                            mon = 10;
                            break;
                        case "November":
                            mon = 11;
                            break;
                        case "December":
                            mon = 12;
                            break;
                    }
                     ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', in_time AS 'In Time', out_time AS 'Out Time', ot_hrs AS 'OT Hours' FROM attendance WHERE DATEPART(month,in_time) = " + mon + "");
                     detail_grid.DataSource = ds.Tables[0];
                }
                               
            }
            else if (monthly.Checked == true && view_all.Checked != true)
            {
                if (fv.empcode_validator(ed_empcode.Text, ed_err_code) == false && fv.checkEmpty(month.Text, err_month) == false)
                {
                    code = ed_empcode.Text;
                    switch (month.Text)
                    {
                        case "January":
                            mon = 1;
                            break;
                        case "February":
                            mon = 2;
                            break;
                        case "March":
                            mon = 3;
                            break;
                        case "April":
                            mon = 4;
                            break;
                        case "May":
                            mon = 5;
                            break;
                        case "June":
                            mon = 6;
                            break;
                        case "July":
                            mon = 7;
                            break;
                        case "August":
                            mon = 8;
                            break;
                        case "September":
                            mon = 9;
                            break;
                        case "October":
                            mon = 10;
                            break;
                        case "November":
                            mon = 11;
                            break;
                        case "December":
                            mon = 12;
                            break;
                    }
                    ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', in_time AS 'In Time', out_time AS 'Out Time', ot_hrs AS 'OT Hours' FROM attendance WHERE DATEPART(month,in_time) = " + mon + " AND emp_code = '"+ code +"'");
                    detail_grid.DataSource = ds.Tables[0];
                }
            }
        }

        private void att_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }








    }
}
