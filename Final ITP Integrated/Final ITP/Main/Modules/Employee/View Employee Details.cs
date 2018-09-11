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
    public partial class View_Employee_Details : Form
    {
        
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        DataSet ds = new DataSet();
        int index = 0;
        
        public View_Employee_Details()
        {
            InitializeComponent();
        }

        private void View_Employee_Details_Load(object sender, EventArgs e)
        {
            
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM employee_details");
            
            //MessageBox.Show("ds = " + ds.Tables[0].Rows[0][0]);

            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            //MessageBox.Show("i = " + i);
            if (i > 0)
            {
                ds = setter.GetFromDB("SELECT d.emp_code AS 'Employee Code', d.name_initials AS 'Name Initials' FROM employee_details d");
                detail_grid.DataSource = ds.Tables[0];
                               
                
            }



        }

        private void ed_search_Click(object sender, EventArgs e)
        {
            Boolean c = false;
            if (code_search.Checked == true && ed_empcode.Text != "")
            {
                c = fv.empcode_validator(ed_empcode.Text, ed_err_code);
                if (c == false)
                {
                    Boolean found = false;
                    detail_grid.Rows[index].Selected = false;
                    for (int i = 0; i < detail_grid.Rows.Count; i++)
                    {
                        if (detail_grid.Rows[i].Cells[0].Value.ToString() == ed_empcode.Text)
                        {
                            index = i;
                            //MessageBox.Show("index = "+index);
                            detail_grid.Rows[index].Selected = true;
                            found = true;
                            break;
                        }
                        else
                        {
                            found = false;
                        }
                    }
                    if (found == false)
                    {
                        MessageBox.Show("Employee has not registered with the system");

                    }

                }
            }
            else if (name_search.Checked == true && emp_name.Text != "")
            {
                c = fv.emp_name_Validator(emp_name.Text, err_name);
                if (c == false)
                {
                    Boolean found = false;
                    detail_grid.Rows[index].Selected = false;
                    for (int i = 0; i < detail_grid.Rows.Count; i++)
                    {
                        if (detail_grid.Rows[i].Cells[1].Value.ToString() == emp_name.Text)
                        {
                            index = i;
                            //MessageBox.Show("index = "+index);
                            detail_grid.Rows[index].Selected = true;
                            found = true;
                            break;
                        }
                        else
                        {
                            found = false;
                        }
                    }
                    if (found == false)
                    {
                        MessageBox.Show("Employee has not registered with the system");

                    }
                }
            }
        }

        private void ed_delete_Click(object sender, EventArgs e)
        {
            Boolean c = false;
            if (code_search.Checked == true && ed_empcode.Text != "")
            {
                c = fv.empcode_validator(ed_empcode.Text, ed_err_code);
                if (c == false)
                {
                    DialogResult d = MessageBox.Show("Do you want to Delete Every Entry related with this Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == System.Windows.Forms.DialogResult.Yes)
                    {
                        setter.SendToDB("DELETE FROM employee_contacts WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM leaves_left WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM qualifications WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM experiances WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM office_detail WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM leaves_taken WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM salary_and_tax_details WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM attendance WHERE emp_code = '" + ed_empcode.Text + "'");
                        setter.SendToDB("DELETE FROM employee_details WHERE emp_code = '" + ed_empcode.Text + "'");
                        MessageBox.Show("Information successfully Deleted");
                        detail_grid.DataSource = null;
                        ds = setter.GetFromDB("SELECT d.emp_code AS 'Employee Code', d.name_initials AS 'Name Initials' FROM employee_details d");
                        detail_grid.DataSource = ds.Tables[0];
                    }
                }
            }
            else if (name_search.Checked == true && emp_name.Text != "")
            {
                c = fv.emp_name_Validator(emp_name.Text, err_name);
                if (c == false)
                {
                    DialogResult d = MessageBox.Show("Do you want to Delete Every Entry related with this Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == System.Windows.Forms.DialogResult.Yes)
                    {
                        string code = "";
                        for (int i = 0; i < detail_grid.Rows.Count; i++)
                        {
                            if (detail_grid.Rows[i].Cells[1].Value.ToString() == emp_name.Text)
                            {
                                //index = i;
                                //MessageBox.Show("index = "+index);
                                //detail_grid.Rows[index].Selected = true;
                                code = detail_grid.Rows[i].Cells[0].Value.ToString();
                                break;
                            }
                            
                        }
                        setter.SendToDB("DELETE FROM employee_contacts WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM leaves_left WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM qualifications WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM experiances WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM office_detail WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM leaves_taken WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM salary_and_tax_details WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM attendance WHERE emp_code = '" + code + "'");
                        setter.SendToDB("DELETE FROM employee_details WHERE emp_code = '" + code + "'");
                        MessageBox.Show("Information successfully Deleted");
                        detail_grid.DataSource = null;
                        ds = setter.GetFromDB("SELECT d.emp_code AS 'Employee Code', d.name_initials AS 'Name Initials' FROM employee_details d");
                        detail_grid.DataSource = ds.Tables[0];
                    }
                }
                }
        }

        private void ed_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void name_search_Click(object sender, EventArgs e)
        {
            emp_name.Enabled = true;
            ed_empcode.Text = "";
            ed_err_code.Visible = false;
            ed_empcode.Enabled = false;
        }

        private void code_search_Click(object sender, EventArgs e)
        {
            emp_name.Text = "";
            err_name.Visible = false;
            emp_name.Enabled = false;
            ed_empcode.Enabled = true;
        }



    }
}

