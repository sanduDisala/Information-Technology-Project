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
    public partial class SearchEmployeeDetails : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        DataSet ds = new DataSet();
        public SearchEmployeeDetails()
        {
            InitializeComponent();
        }

        private void field_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            ed_empcode.Text = "";
            ed_empcode.Enabled = false;
            field.Enabled = true;
            ed_err_code.Visible = false;
            field_err.Visible = false;

        }

        private void view_emp_Click(object sender, EventArgs e)
        {
            ed_empcode.Text = "";
            ed_empcode.Enabled = true;
            field.Enabled = true;
            ed_err_code.Visible = false;
            field_err.Visible = false;
        }

        private void ed_search_Click(object sender, EventArgs e)
        {
            //Boolean c1 = fv.checkEmpty(field.Text, field_err);

            if (view_all.Checked == true && field.Text != "")
            {
                if (field.Text == "Personal Details")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', name_initials AS 'Name with Intials', full_name AS 'Full Name', sex AS 'Gender', dob AS 'Date of Birth', nic AS 'NIC', nationality AS 'Nationality', bank_name AS 'Bank', b_branch AS 'Branch', acc_no 'Account Number' FROM employee_details");
                } 
                else if (field.Text == "Office Details")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', department AS 'Department', designation AS 'Designation', active AS 'Active', probation_date AS 'Date of Probation', resignation_date AS 'Date of Resignation', confirm_date AS 'Date of Confirmation' FROM office_detail");
                }
                else if (field.Text == "Contact Details")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', residance_add AS 'Residance Address', temp_address AS 'Temperory Address', residance_tpno AS 'Residance Telephone No', mobile_no AS 'Mobile Number', personal_email AS 'Personal Email', office_email AS 'Office Email', contact_person AS 'Contact Person', relationship AS 'Relationship', tp_contactPerson AS 'Contact Person TP' FROM employee_contacts");
                }
                else if (field.Text == "Experiances")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', org_name AS 'Organization', department AS 'Department', position AS 'Designation', from_date AS 'Start Date', to_date AS 'End Date' FROM experiances");
                }
                else if (field.Text == "Qualifications")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', edu_qual AS 'Educational', prof_qual AS 'Proffessional', other_qual AS 'Other' FROM qualifications");
                }
                else if (field.Text == "Salary and Tax Details")
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', basic_salary AS 'Basic Salary', epfAmt AS 'EPF', tot_epf AS 'Total EPF Amount', etfAmt AS 'ETF', paye_percentage AS 'Paye Percentage', paye_amt AS 'Payee Amount', ot_amt AS 'OT Amount per Hour', bonus As'Allowances' FROM salary_and_tax_details");
                }
                else 
                {
                    ds = setter.GetFromDB("SELECT emp_code AS 'Code', leave_type AS 'Type', from_date AS 'From', to_date AS 'To', no_of_days AS 'No.Of days', half_days AS 'Half days', date AS 'Half day Taken', pay AS 'No Pay' FROM leaves_taken");
                }
                detail_grid.DataSource = ds.Tables[0];
            }
            else if (view_emp.Checked == true)
            {
                if (fv.empcode_validator(ed_empcode.Text, ed_err_code) == false)
                {
                    if (field.Text == "Personal Details")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', name_initials AS 'Name with Intials', full_name AS 'Full Name', sex AS 'Gender', dob AS 'Date of Birth', nic AS 'NIC', nationality AS 'Nationality', bank_name AS 'Bank', b_branch AS 'Branch', acc_no 'Account Number' FROM employee_details WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else if (field.Text == "Office Details")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', department AS 'Department', designation AS 'Designation', active AS 'Active', probation_date AS 'Date of Probation', resignation_date AS 'Date of Resignation', confirm_date AS 'Date of Confirmation' FROM office_detail WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else if (field.Text == "Contact Details")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', residance_add AS 'Residance Address', temp_address AS 'Temperory Address', residance_tpno AS 'Residance Telephone No', mobile_no AS 'Mobile Number', personal_email AS 'Personal Email', office_email AS 'Office Email', contact_person AS 'Contact Person', relationship AS 'Relationship', tp_contactPerson AS 'Contact Person TP' FROM employee_contacts WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else if (field.Text == "Experiances")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Employee Code', org_name AS 'Organization', department AS 'Department', position AS 'Designation', from_date AS 'Start Date', to_date AS 'End Date' FROM experiances WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else if (field.Text == "Qualifications")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', edu_qual AS 'Educational', prof_qual AS 'Proffessional', other_qual AS 'Other' FROM qualifications WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else if (field.Text == "Salary and Tax Details")
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', basic_salary AS 'Basic Salary', epfAmt AS 'EPF', tot_epf AS 'Total EPF Amount', etfAmt AS 'ETF', paye_percentage AS 'Paye Percentage', paye_amt AS 'Payee Amount', ot_amt AS 'OT Amount per Hour', bonus As'Allowances' FROM salary_and_tax_details WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    else
                    {
                        ds = setter.GetFromDB("SELECT emp_code AS 'Code', leave_type AS 'Type', from_date AS 'From', to_date AS 'To', no_of_days AS 'No.Of days', half_days AS 'Half days', date AS 'Half day Taken', pay AS 'No Pay' FROM leaves_taken WHERE emp_code = '" + ed_empcode.Text + "'");
                    }
                    detail_grid.DataSource = ds.Tables[0];
                }
            }
        }

        private void ed_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
