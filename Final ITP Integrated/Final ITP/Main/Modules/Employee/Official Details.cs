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
    public partial class Official_Details : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        public Official_Details()
        {
            InitializeComponent();
            this.ActiveControl = od_empcode_tb;
        }

        private void Official_Details_Load(object sender, EventArgs e)
        {

           

        }

        private void od_submit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                Boolean c1 = false;
                Boolean c2 = false;
                Boolean c3 = false;
                Boolean c4 = false;
                Boolean c5 = false;
                Boolean c = false;
                Boolean c6 = emp_code_availaility_validator();
                DateTime c_date = DateTime.Parse(confirm_date.Text);
                DateTime p_date = DateTime.Parse(prob_date.Text);
                int period = 12 * (c_date.Year - p_date.Year) + (c_date.Month - p_date.Month) + (c_date.Day - p_date.Day) / 31 + 1;
                if (period == 6)
                {
                    c = false;
                    od_err_cdate.Visible = false;
                }
                else
                {
                    c = true;
                    od_err_cdate.Text = "*Invalid Confirmation Date";
                    od_err_cdate.Visible = true;
                }

                if (od_empcode_tb.Visible == true && od_name_tb.Visible == true)
                {
                    c1 = fv.empcode_validator(od_empcode_tb.Text, od_err_code);
                    c2 = fv.name_initial_Validator(od_name_tb.Text, od_err_initial);
                    c3 = fv.checkEmpty(od_dept.Text, od_err_dept);
                    c4 = fv.fullname_Validator(od_desig.Text, od_err_desig);
                    c5 = fv.radio_button_validator(yes, no, od_err_active);
                    if (c || c1 || c2 || c3 || c4 || c5 || c6)
                    {
                        string error = "Incomplete Information";
                        MessageBox.Show(error, "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string empcode = od_empcode_tb.Text;
                        //string name = od_name_tb.Text;
                        string dept = od_dept.Text;
                        string desig = od_desig.Text;
                        string active;
                        string res_date = null;
                        if (yes.Checked)
                        {
                            active = "Yes";
                            res_date = "";
                        }
                        else
                        {
                            active = "No";
                            res_date = DateTime.Parse(resig_date.Text).ToString("yyyy-MM-dd");
                        }
                        string pro_date = prob_date.Value.ToString("yyyy-MM-dd");
                        string confo_date = confirm_date.Value.ToString("yyyy-MM-dd");
                       

                        //MessageBox.Show(empcode + " " + dept + " " + desig + " " + active + " " + pro_date + " " + confo_date + " " + resi_date);
                        setter.SendToDB("INSERT INTO office_detail(emp_code, department, designation, active, probation_date, resignation_date, confirm_date) VALUES ('" + empcode + "','" + dept + "','" + desig + "','" + active + "','" + pro_date + "','" + res_date + "','" + confo_date + "' )");
                        MessageBox.Show("Information successfully Submitted");
                    }

                }
                else if (od_empcode.Visible == true && od_name.Visible == true)
                {
                    c3 = fv.checkEmpty(od_dept.Text, od_err_dept);
                    c4 = fv.fullname_Validator(od_desig.Text, od_err_desig);
                    c5 = fv.radio_button_validator(yes, no, od_err_active);

                    if (c3 || c4 || c5)
                    {
                        MessageBox.Show("Incomplete or Invalid information.", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string empcode = od_empcode.Text;
                        string name = od_name.Text;
                        string dept = od_dept.Text;
                        string desig = od_desig.Text;
                        string active;
                        string res_date = null;
                        if (yes.Checked)
                        {
                            active = "Yes";
                            res_date = null;
                        }
                        else
                        {
                            active = "No";
                            res_date = DateTime.Parse(resig_date.Text).ToString("yyyy-MM-dd");
                        }
                        string pro_date = prob_date.Value.ToString("yyyy-MM-dd");
                        //DateTime con = DateTime.Parse(confirm_date.Text).Month;
                        string confo_date = confirm_date.Value.ToString("yyyy-MM-dd");
                        //string resi_date = resig_date.Value.ToString("yyyy-MM-dd");

                        //MessageBox.Show(empcode + " " + dept + " " + desig + " " + active + " " + pro_date + " " + confo_date + " " + resi_date);
                        setter.SendToDB("INSERT INTO office_detail(emp_code, department, designation, active, probation_date, resignation_date, confirm_date) VALUES ('" + empcode + "','" + dept + "','" + desig + "','" + active + "','" + pro_date + "','" + res_date + "','" + confo_date + "' )");
                        MessageBox.Show("Information successfully Submitted");

                    }
                }
            }
  
        }

        private void od_empcode_tb_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(od_empcode_tb.Text,od_err_code);
            fv.empcode_validator(od_empcode_tb.Text, od_err_code);
            //emp_code_availaility_validator();
        }

        private void od_name_tb_Leave(object sender, EventArgs e)
        {
            fv.name_initial_Validator(od_name_tb.Text, od_err_initial);
        }

        private void od_dept_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(od_dept.Text, od_err_dept);
        }

        private void od_desig_Leave(object sender, EventArgs e)
        {
            fv.fullname_Validator(od_desig.Text, od_err_desig);
            fv.checkEmpty(od_desig.Text, od_err_desig);
        }
        //****
        public void od_edit_Click(object sender, EventArgs e)
        {
            edit();
        }
        //****
        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
            od_err_code.Visible = false;
            od_empcode_tb.Text = "";
            od_err_code.Visible = false;
            od_name_tb.Text = "";
            od_err_initial.Visible = false;
            od_dept.Text = "";
            od_err_dept.Visible = false;
            od_desig.Text = "";
            od_err_desig.Visible = false;
            yes.Checked = false;
            no.Checked = false;
            prob_date.Text = DateTime.Now.Date.ToString();
            confirm_date.Text = DateTime.Now.Date.ToString();
            od_err_cdate.Visible = false;
            resig_date.Text = DateTime.Now.Date.ToString();

        }

        private void od_getDetails_Click(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(od_empcode_tb.Text, od_err_code);
            if (c == false)
            {
                od_name_tb.Enabled = true;
                od_dept.Enabled = true;
                od_desig.Enabled = true;
                yes.Enabled = true;
                no.Enabled = true;
                prob_date.Enabled = true;
                confirm_date.Enabled = true;
                resig_date.Enabled = true;

                od_name_tb.Text = getName();
                //MessageBox.Show("em");
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT * FROM office_detail WHERE emp_code = '" + od_empcode_tb.Text + "'");
                for (int k = 1; k < 6; k++)
                {
                    //MessageBox.Show(ds.Tables[0].Rows[0][k].ToString());
                    od_dept.Text = ds.Tables[0].Rows[0][1].ToString();
                    od_desig.Text = ds.Tables[0].Rows[0][2].ToString();
                    if (ds.Tables[0].Rows[0][3].ToString() == "Yes")
                    {
                        yes.Checked = true;
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "No")
                    {
                        no.Checked = true;
                    }
                    prob_date.Text = ds.Tables[0].Rows[0][4].ToString();
                    resig_date.Text = ds.Tables[0].Rows[0][5].ToString();
                    confirm_date.Text = ds.Tables[0].Rows[0][6].ToString();
                }
            }
            
        }


        private string getName()
        {
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT name_initials FROM employee_details WHERE emp_code = '" + od_empcode_tb.Text + "'");
            //MessageBox.Show("name = " + ds.Tables[0].Rows[0][0].ToString());
            return ds.Tables[0].Rows[0][0].ToString();
        }

        private void od_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to save the given Information", "Submition Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //*****
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                Boolean c3 = false;
                Boolean c4 = false;
                Boolean c5 = false;
                Boolean c = false;
                DateTime c_date = DateTime.Parse(confirm_date.Text);
                DateTime p_date = DateTime.Parse(prob_date.Text);
                int period = 12 * (c_date.Year - p_date.Year) + (c_date.Month - p_date.Month) + (c_date.Day - p_date.Day) / 31 + 1;
                if (period == 6)
                {
                    c = false;
                    od_err_cdate.Visible = false;
                }
                else
                {
                    c = true;
                    od_err_cdate.Text = "*Invalid Confirmation Date";
                    od_err_cdate.Visible = true;
                }
                c3 = fv.checkEmpty(od_dept.Text, od_err_dept);
                c4 = fv.fullname_Validator(od_desig.Text, od_err_desig);
                c5 = fv.radio_button_validator(yes, no, od_err_active);
                if (c || c3 || c4 || c5)
                {
                    string error = "Incomplete Information";
                    MessageBox.Show(error, "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string empcode = od_empcode_tb.Text;
                    string dept = od_dept.Text;
                    string desig = od_desig.Text;
                    string active;
                    if (yes.Checked)
                    {
                        active = "Yes";
                    }
                    else
                    {
                        active = "No";
                    }
                    string pro_date = prob_date.Value.ToString("yyyy-MM-dd");
                    string confo_date = confirm_date.Value.ToString("yyyy-MM-dd");
                    string resi_date = resig_date.Value.ToString("yyyy-MM-dd");

                    //MessageBox.Show(empcode + " " + dept + " " + desig + " " + active + " " + pro_date + " " + confo_date + " " + resi_date);
                    //setter.SendToDB("INSERT INTO office_detail(emp_code, department, designation, active, probation_date, resignation_date, confirm_date) VALUES ('" + empcode + "','" + dept + "','" + desig + "','" + active + "','" + pro_date + "','" + resi_date + "','" + confo_date + "' )");

                    setter.SendToDB("UPDATE office_detail SET department = '" + dept + "', designation = '" + desig + "', active = '" + active + "', probation_date = '" + pro_date + "', resignation_date = '" + resi_date + "', confirm_date = '" + confo_date + "' WHERE emp_code = '" + od_empcode_tb.Text + "'");
                    MessageBox.Show("Changes saved successfully.");
                }
            }
        }

        private void od_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void od_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void od_next_Click(object sender, EventArgs e)
        {
            Contact_Details form = new Contact_Details();
            if (od_empcode.Visible == true || od_empcode_tb.Text != "")
            {
                DialogResult d = MessageBox.Show("Do you want to submit the Information?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (d == System.Windows.Forms.DialogResult.No)
                {
                    //form.Visible = true;
                    form.cd_code.Visible = true;
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                form.cd_code.Visible = true;
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Hide();
            }
        }

        private void od_dept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        
            //if (od_dept.Text == "Operation")
            //{
            //    this.od_dept.Items.AddRange(new object[] { "Driver", "Electrician" });
            //}


        //*****
        private void edit()
        {
            ClearTextBoxes(this.Controls);

            DialogResult dr = MessageBox.Show("Please Enter The Employee Code", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                od_empcode.Visible = false;
                od_empcode_tb.Visible = true;
                od_name.Visible = false;
                od_name_tb.Visible = true;
                od_name_tb.Enabled = false;
                od_dept.Enabled = false;
                od_desig.Enabled = false;
                yes.Enabled = false;
                no.Enabled = false;
                prob_date.Enabled = false;
                confirm_date.Enabled = false;
                resig_date.Enabled = false;
                od_getDetails.Visible = true;
                od_save.Visible = true;
                od_empcode_tb.Enabled = true;
                od_empcode_tb.Visible = true;
                this.ActiveControl = od_empcode_tb;
            }
            else if(dr == System.Windows.Forms.DialogResult.Cancel)
            {
                ClearTextBoxes(this.Controls);
            }
        }


        //####
        private Boolean emp_code_availaility_validator()
        {
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM office_detail WHERE emp_code = '" + od_empcode_tb.Text + "'");
            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (i == 0)
            {
                return false;
            }
            else if (i != 0)
            {
                DialogResult d = MessageBox.Show("Office details of this employee has already entered. Do you want to edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    edit();
                    return false;
                }
                else if (d == System.Windows.Forms.DialogResult.No)
                {
                    return true;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }

        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            resig_date.Enabled = false;
        }

        private void no_Click(object sender, EventArgs e)
        {
            resig_date.Enabled = true;
        }

        private void demo_Click(object sender, EventArgs e)
        {
            od_dept.Text = "Digital and IT";
            od_desig.Text = "Software Engineer";
            yes.Checked = true;
            //prob_date.Text = "1/20/2017";
            //confirm_date.Text = "6/20/2017";
            
        }

        


    }
   
}

