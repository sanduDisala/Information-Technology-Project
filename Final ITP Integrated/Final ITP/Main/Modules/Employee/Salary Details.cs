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
    public partial class Salary_Details : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        public Salary_Details()
        {
            InitializeComponent();
            this.ActiveControl = sal_empcode;
        }

        private void paye_check_Click(object sender, EventArgs e)
        {
            if (paye_check.Checked == true)
            {
                paye_pct.Enabled = true;
                paye_pct.Text = "";
            }
            else if (paye_check.Checked == false)
            {
                paye_pct.Enabled = false;
                paye_pct.Text = "";
            }
            //sal_paye_amt.ReadOnly = false;
        }

        private void ot_check_Click(object sender, EventArgs e)
        {
            if (ot_check.Checked == true)
            {
                sal_ot_amt.Enabled = true;
                sal_ot_amt.Text = "";
            }
            else if (ot_check.Checked == false)
            {
                sal_ot_amt.Enabled = false;
                sal_ot_amt.Text = "";
            }
        }
        private void bonus_Click(object sender, EventArgs e)
        {
            if (bonus.Checked == true)
            {
                bonus_amt.Enabled = true;
                bonus_amt.Text = "";
            }
            else if (ot_check.Checked == false)
            {
                bonus_amt.Enabled = false;
                bonus_amt.Text = "";
            }
        }

        private void sal_empcode_Leave(object sender, EventArgs e)
        {
            fv.empcode_validator(sal_empcode.Text, sal_err_code);
        }

        private void sal_submit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < salary_grid.Rows.Count; i++)
                {
                    string code = salary_grid.Rows[i].Cells[0].Value.ToString();
                    double salary = double.Parse(salary_grid.Rows[i].Cells[1].Value.ToString());
                    double epf = double.Parse(salary_grid.Rows[i].Cells[2].Value.ToString());
                    double epfTot = double.Parse(salary_grid.Rows[i].Cells[3].Value.ToString());
                    double etf = double.Parse(salary_grid.Rows[i].Cells[4].Value.ToString());
                    double paye_percentage = double.Parse(salary_grid.Rows[i].Cells[5].Value.ToString());
                    double payee_amt = double.Parse(salary_grid.Rows[i].Cells[6].Value.ToString());
                    double ot = double.Parse(salary_grid.Rows[i].Cells[7].Value.ToString());
                    double bon = double.Parse(salary_grid.Rows[i].Cells[8].Value.ToString());

                   // MessageBox.Show("code" + code + "salary" + salary + "epf" + epf + "epfTot" + epfTot + "etf" + etf + "ppct" + paye_percentage + "pamt" + payee_amt + "ot" + ot);
                    setter.SendToDB("INSERT INTO salary_and_tax_details(emp_code, basic_salary, epfAmt, tot_epf, etfAmt, paye_percentage, paye_amt, ot_amt, bonus) VALUES ('" + code + "'," + salary + "," + epf + "," + epfTot + "," + etf + "," + paye_percentage + "," + payee_amt + "," + ot + ","+ bon +")");
                    
                }
                MessageBox.Show("Information successfully Submitted");
                salary_grid.Rows.Clear();
            }

        }

        private void sal_add_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;
            if (salary_grid.Rows.Count > 0)
            {
                for (int k = 0; k < salary_grid.Rows.Count; k++)
                {
                    if (salary_grid.Rows[k].Cells[0].Value.ToString() == sal_empcode.Text || salary_grid.Rows[k].Cells[0].Value.ToString() == sal_code_label.Text)
                    {
                        rowIndex = salary_grid.CurrentCell.RowIndex;
                        break;
                    }
                    else
                    {
                        rowIndex = -1;
                    }
                }

                if (rowIndex != -1)
                {
                    salary_grid.Rows.RemoveAt(rowIndex);
                }
                
            }
            
            Boolean c = fv.empcode_validator(sal_empcode.Text, sal_err_code);
            Boolean c1 = fv.decimal_Validator(sal_basic_sal.Text, sal_err_bsal);
            Boolean c2 = false;
            Boolean c3 = false;
            //Boolean c3 = false;
            if (paye_check.Checked == true)
            {
                c2 = fv.decimal_Validator(paye_pct.Text, sal_err_ppct);
                //c3 = fv.decimal_Validator(sal_paye_amt.Text, sal_err_pamt);
            }
            else if (paye_check.Checked == false)
            {
                if (c1 == false)
                {
                    if (paye_check.Checked == false && double.Parse(sal_basic_sal.Text) >= 50000)
                    {
                        sal_err_ppct.Text = "*PAYE is Applies for salaries greater than 50000";
                        sal_err_ppct.Visible = true;
                        c3 = true;
                    }
                }
            }
            Boolean c4 = false;
            if (ot_check.Checked == true)
            {
                c4 = fv.decimal_Validator(sal_ot_amt.Text, sal_err_otamt);
            }
            Boolean c5 = false;
            if (bonus.Checked == true)
            {
                c5 = fv.decimal_Validator(bonus_amt.Text, err_bonus);
            }
            Boolean c6 = emp_code_availaility_validator();
            if ((c || c1 || c2 || c3 || c4 || c5 || c6) == false)
            {
                string code = "";
                if (sal_empcode.Visible == true)
                {
                    code = sal_empcode.Text;
                }
                else if (sal_code_label.Visible == true)
                {
                    code = sal_code_label.Text;
                }
                double salary = double.Parse(sal_basic_sal.Text);
                double payee_amt = 0;
                double paye_percentage = 0;
                if (paye_check.Checked == true)
                {
                    paye_percentage = double.Parse(paye_pct.Text);
                    payee_amt = salary * (paye_percentage / 100);
                }
                double epf = salary * 0.08;
                double epfTot = salary * 0.2;
                double etf = salary * 0.03;
                double ot = 0;
                double bon = 0;
                if (ot_check.Checked == true)
                {
                    ot = double.Parse(sal_ot_amt.Text);
                    
                }
                if (bonus.Checked == true)
                {
                    bon = double.Parse(bonus_amt.Text);

                }

                salary_grid.Rows.Add(code, salary.ToString(), epf.ToString(), epfTot.ToString(), etf.ToString(), paye_percentage.ToString(), payee_amt.ToString(), ot.ToString(),bon.ToString());
                ClearTextBoxes(this.Controls);
            }

        }

        private void salary_grid_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (salary_grid.RowCount > 0)
            {
                int index = salary_grid.CurrentCell.RowIndex;
                sal_empcode.Visible = true;
                //MessageBox.Show(salary_grid.Rows[index].Cells[0].Value.ToString());
                sal_empcode.Text = salary_grid.Rows[index].Cells[0].Value.ToString();
                sal_basic_sal.Text = salary_grid.Rows[index].Cells[1].Value.ToString();
                if (salary_grid.Rows[index].Cells[5].Value.ToString() == "0")
                {
                    paye_check.Checked = false;
                    paye_pct.Enabled = false; 
                }
                else if(salary_grid.Rows[index].Cells[5].Value.ToString() != "0")
                {
                    paye_check.Checked = true;
                    paye_pct.Enabled = true;
                    paye_pct.Text = salary_grid.Rows[index].Cells[5].Value.ToString();
                }
                if(salary_grid.Rows[index].Cells[7].Value.ToString() == "0")
                {
                    ot_check.Checked = false;
                    sal_ot_amt.Enabled = false; 
                }
                else if(salary_grid.Rows[index].Cells[7].Value.ToString() != "0")
                {
                    ot_check.Checked = true;
                    sal_ot_amt.Enabled = true;
                    sal_ot_amt.Text = salary_grid.Rows[index].Cells[7].Value.ToString();
                }
                if (salary_grid.Rows[index].Cells[8].Value.ToString() == "0")
                {
                    bonus.Checked = false;
                    bonus_amt.Enabled = false;
                }
                else if (salary_grid.Rows[index].Cells[8].Value.ToString() != "0")
                {
                    bonus.Checked = true;
                    bonus_amt.Enabled = true;
                    bonus_amt.Text = salary_grid.Rows[index].Cells[8].Value.ToString();
                }
                salary_grid.Rows.RemoveAt(index);
            }
            
        }

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
            ot_check.Checked = false;
            paye_check.Checked = false;
            paye_pct.Enabled = false;
            sal_ot_amt.Enabled = false;
            sal_err_code.Visible = false;
            sal_err_ppct.Visible = false;
            sal_err_bsal.Visible = false;
            sal_err_otamt.Visible = false;
            bonus.Checked = false;
            bonus_amt.Enabled = false;
        }

        private void sal_edit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void edit()
        {
            ClearTextBoxes(this.Controls);
            DialogResult dr = MessageBox.Show("Please Enter The Employee Code", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                sal_basic_sal.Enabled = false;
                sal_empcode.Visible = true;
                sal_code_label.Visible = false;
                this.ActiveControl = sal_empcode;
                salary_grid.Rows.Clear();
                pd_getDetails.Visible = true;
                sal_save.Visible = true;
                sal_submit.Visible = false;
            }
        }

        private void pd_getDetails_Click(object sender, EventArgs e)
        {
            salary_grid.Rows.Clear();
            Boolean c = fv.empcode_validator(sal_empcode.Text, sal_err_code);
            if (c == false)
            {
                ot_check.Checked = false;
                paye_check.Checked = false;
                paye_pct.Enabled = false;
                sal_ot_amt.Enabled = false;
                sal_basic_sal.Enabled = true;
                string code = "";
                string bsal = "";
                string epf = "";
                string tot_epf = "";
                string etf = "";
                string ppct = "";
                string p_amt = "";
                string ot = "";
                string bon = "";
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM salary_and_tax_details WHERE emp_code = '" + sal_empcode.Text + "'");
                int k = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (k > 0)
                {
                    ds = setter.GetFromDB("SELECT * FROM salary_and_tax_details WHERE emp_code = '" + sal_empcode.Text + "'");
                    for (int i = 0; i < 8; i++)
                    {
                        //MessageBox.Show(ds.Tables[0].Rows[0][i].ToString());
                        code = ds.Tables[0].Rows[0][0].ToString();
                        bsal = ds.Tables[0].Rows[0][1].ToString();
                        epf = ds.Tables[0].Rows[0][2].ToString();
                        tot_epf = ds.Tables[0].Rows[0][3].ToString();
                        etf = ds.Tables[0].Rows[0][4].ToString();
                        ppct = ds.Tables[0].Rows[0][5].ToString();
                        p_amt = ds.Tables[0].Rows[0][6].ToString();
                        ot = ds.Tables[0].Rows[0][7].ToString();
                        bon = ds.Tables[0].Rows[0][8].ToString();
                    }
                    salary_grid.Rows.Add(code, bsal, epf, tot_epf, etf, ppct, p_amt, ot, bon);
                }
                else
                {
                    MessageBox.Show("You have not Entered Salary Details of this Employee", "Error");
                }
            }
        }

        private void sal_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < salary_grid.Rows.Count; i++)
                {
                    string code = salary_grid.Rows[i].Cells[0].Value.ToString();
                    double salary = double.Parse(salary_grid.Rows[i].Cells[1].Value.ToString());
                    double epf = double.Parse(salary_grid.Rows[i].Cells[2].Value.ToString());
                    double epfTot = double.Parse(salary_grid.Rows[i].Cells[3].Value.ToString());
                    double etf = double.Parse(salary_grid.Rows[i].Cells[4].Value.ToString());
                    double paye_percentage = double.Parse(salary_grid.Rows[i].Cells[5].Value.ToString());
                    double payee_amt = double.Parse(salary_grid.Rows[i].Cells[6].Value.ToString());
                    double ot = double.Parse(salary_grid.Rows[i].Cells[7].Value.ToString());
                    double bon = double.Parse(salary_grid.Rows[i].Cells[8].Value.ToString());

                    //MessageBox.Show("code" + code + "salary" + salary + "epf" + epf + "epfTot" + epfTot + "etf" + etf + "ppct" + paye_percentage + "pamt" + payee_amt + "ot" + ot);
                    //setter.SendToDB("INSERT INTO salary_and_tax_details(emp_code, basic_salary, epfAmt, tot_epf, etfAmt, paye_percentage, paye_amt, ot_amt) VALUES ('" + code + "'," + salary + "," + epf + "," + epfTot + "," + etf + "," + paye_percentage + "," + payee_amt + "," + ot + ")");
                    setter.SendToDB("UPDATE salary_and_tax_details SET basic_salary = " + salary + ", epfAmt = " + epf + ", tot_epf = " + epfTot + ", etfAmt = " + etf + ", paye_percentage = " + paye_percentage + ", paye_amt = " + payee_amt + ", ot_amt = " + ot + ", bonus = " + bon + " WHERE emp_code = '" + code + "'");
                    MessageBox.Show("Information successfully Updated");
                }
                salary_grid.Rows.Clear();
            }
        }

        private void sal_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void sal_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private Boolean emp_code_availaility_validator()
        {
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM salary_and_tax_details WHERE emp_code = '" + sal_empcode.Text + "'");
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

        private void demo_Click(object sender, EventArgs e)
        {
            sal_empcode.Text = "E0006";
            sal_basic_sal.Text = "45000";
            ot_check.Checked = true;
            sal_ot_amt.Enabled = true;
            sal_ot_amt.Text = "100";
            bonus.Checked = true;
            bonus_amt.Enabled = true;
            bonus_amt.Text = "1000";
        }
        
    }
}









































































































































































































































































