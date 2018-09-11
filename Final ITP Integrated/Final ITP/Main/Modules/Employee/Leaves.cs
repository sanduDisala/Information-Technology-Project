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
    public partial class Leaves : Form
    {
        int annual = 0;
        double casual = 0;
        int sick = 0;
        int half = 0;
        int k = 0;
        string empname = "";
        string empid = "";
        string lid = "";
        Boolean delete = false;
        DateTime prob_date = DateTime.Now.Date;
        DateTime confo_date = DateTime.Now.Date;
        string name = "";
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        public Leaves()
        {
            InitializeComponent();
            this.ActiveControl = leave_emp_code;
        }
        
        private void half_check_Click(object sender, EventArgs e)
        {
            if (half_check.Checked == true)
            {
                if (leave_type.Text == "Casual Leave")
                {
                    half_date.Enabled = true;
                    leave_err_half.Visible = false;
                }
                else
                {
                    leave_err_half.Text = "*Half days can be applied under Casual Leave type";
                    leave_err_half.Visible = true;
                    half_date.Enabled = false;
                    half_check.Checked = false;
                }
            }
            else if (half_check.Checked == false)
            {
                half_date.Enabled = false;
                leave_err_half.Visible = false;
            }
        }

        private void full_day_check_Click(object sender, EventArgs e)
        {
            if (full_day_check.Checked == true)
            {
                if (confo_date <= DateTime.Now.Date)
                {
                    leave_from.Enabled = true;
                    leave_to.Enabled = true;
                    leave_err.Visible = false;
                }
                else
                {
                    leave_from.Enabled = false;
                    leave_to.Enabled = false;
                    leave_err.Text = "*Employee is still in his probation period";
                    leave_err.Visible = true;
                    full_day_check.Checked = false;
                }
            }
            else if (full_day_check.Checked == false)
            {
                leave_from.Enabled = false;
                leave_to.Enabled = false;
            }
        }

        private void leave_emp_code_Leave(object sender, EventArgs e)
        {
            leave_err_empcode.Visible = false;
            Boolean c = fv.empcode_validator(leave_emp_code.Text, leave_err_empcode);
            int rows = leaves_left.Rows.Count;
            DataSet ds = new DataSet();
            if (c == false && rows == 0)
            {
                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM office_detail WHERE emp_code = '" + leave_emp_code.Text + "' ");
                int t = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                if (t > 0)
                {
                  //  MessageBox.Show("t>0");
                    empname = leave_emp_code.Text;

                    ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM leaves_left WHERE emp_code = '" + leave_emp_code.Text + "' ");
                    int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                    ds = setter.GetFromDB("SELECT name_initials FROM employee_details WHERE emp_code = '" + leave_emp_code.Text + "'");
                    name = ds.Tables[0].Rows[0][0].ToString();

                    ds = setter.GetFromDB("SELECT probation_date, confirm_date FROM office_detail WHERE emp_code = '" + leave_emp_code.Text + "'");
                    prob_date = DateTime.Parse(ds.Tables[0].Rows[0][0].ToString());
                    confo_date = DateTime.Parse(ds.Tables[0].Rows[0][1].ToString());
                    //MessageBox.Show("i = " + i);
                    if (i == 0)
                    {
                       // MessageBox.Show("i == 0");
                        //MessageBox.Show("confodate = " + confo_date + "prob date = " + prob_date);
                        if (confo_date < DateTime.Now.Date)
                        {
                            annual = 14;
                            casual = 7;
                            sick = 7;
                            half = 0;

                            leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                            setter.SendToDB("INSERT INTO leaves_left(emp_code, annual, casual, sick, half_days) VALUES ('" + leave_emp_code.Text + "','" + annual + "','" + casual + "','" + sick + "','" + half + "')");
                            leave_emp_code.Text = empname;
                        }
                        else if (confo_date >= DateTime.Now.Date)
                        {

                            int months = 12 * (confo_date.Year - prob_date.Year) + (confo_date.Month - prob_date.Month);


                            switch (months)
                            {
                                case 6:
                                    half = 6;
                                    break;
                                case 5:
                                    half = 5;
                                    break;
                                case 4:
                                    half = 4;
                                    break;
                                case 3:
                                    half = 3;
                                    break;
                                case 2:
                                    half = 2;
                                    break;
                                case 1:
                                    half = 1;
                                    break;
                                default:
                                    break;
                            }
                            annual = 0;
                            casual = 0;
                            sick = 0;
                            leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                            setter.SendToDB("INSERT INTO leaves_left(emp_code, annual, casual, sick, half_days) VALUES ('" + leave_emp_code.Text + "','" + annual + "','" + casual + "','" + sick + "','" + half + "')");
                            leave_emp_code.Text = empname;
                        }
                    }
                    else if (i == 1)
                    {
                        //MessageBox.Show("i == 1");
                        ds = setter.GetFromDB("SELECT annual, casual, sick, half_days FROM leaves_left WHERE emp_code = '" + leave_emp_code.Text + "' ");
                        //DataSet das = new DataSet();

                        for (int k = 0; k < 4; k++)
                        {
                            //MessageBox.Show("value = " + ds.Tables[0].Rows[0][k].ToString());
                            if (ds.Tables[0].Rows[0][k].ToString() == "")
                            {
                                //MessageBox.Show("value = " + ds.Tables[0].Rows[0][k].ToString());
                                if (k == 0)
                                {
                                    annual = 0;
                                }
                                else if (k == 1)
                                {
                                    casual = 0;
                                }
                                else if (k == 2)
                                {
                                    sick = 0;
                                }
                                else if (k == 3)
                                {
                                    half = 0;
                                }

                            }
                            else
                            {
                                annual = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                                casual = Double.Parse(ds.Tables[0].Rows[0][1].ToString());
                                sick = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
                                half = Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString());

                            }
                            
                        }
                        //MessageBox.Show("confodate = " + confo_date + "prob date = " + prob_date);
                        //leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                        if (confo_date < DateTime.Now.Date)
                        {
                            //MessageBox.Show("Confo < Now Date");
                            string type = "Annual Leave";
                            ds = setter.GetFromDB("SELECT COUNT(leave_type) FROM leaves_taken WHERE emp_code = '" + leave_emp_code.Text + "' AND leave_type = '" + type + "'");
                            int j = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                            if (j == 0 && annual == 0)
                            {
                                annual = 14;
                                casual = 7;
                                sick = 7;
                                half = 0;
                                leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                //MessageBox.Show(annual + "" + casual + "" + sick + "" + half);
                                setter.SendToDB("UPDATE leaves_left SET annual = " + annual + ", casual = " + casual + ", sick = " + sick + ", half_days = " + half + " WHERE emp_code = '" + leave_emp_code.Text + "' ");
                                leave_emp_code.Text = empname;
                            }
                            else
                            {
                                //MessageBox.Show(annual + "" + casual + "" + sick + "" + half);
                                leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                leave_emp_code.Text = empname;
                            }
                        }
                        else
                        {
                            leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                            leave_emp_code.Text = empname;
                        }


                    }
                }
                else
                {
                    leave_err_empcode.Text = "*Please Add Employee's Salary Details";
                    leave_err_empcode.Visible = true;
                    leave_emp_code.Text = empname;
                }

            }
            else
            {
                if (rows != 0)
                {
                    leave_err_empcode.Text = "*Please Submit the previous Employee's Leaves";
                    leave_err_empcode.Visible = true;
                    leave_emp_code.Text = empname;
                    
                    
                }
            }
            
        }

        private void leave_add_Click(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(leave_emp_code.Text, leave_err_empcode);
            Boolean c1 = fv.checkEmpty(leave_type.Text, leave_err_type);
            Boolean c2 = false;
            Boolean c3 = false;
            Boolean c4 = false;
            
            if ((half_check.Checked || full_day_check.Checked) == false)
            {
                c2 = true;
                leave_err.Text = "* Please select Leave date";
                leave_err.Visible = true;
            }

            else if ((half_check.Checked && full_day_check.Checked) == true)
            {
                c2 = true;
                leave_err.Text = "*Please select one Leave at a time";
                leave_err.Visible = true;
            }
            else
            {
                leave_err.Visible = false;
                if (half_check.Checked == true && leave_type.Text == "Casual Leave")
                {
                    c3 = false;
                    leave_err_half.Visible = false;
                    half_date.Enabled = false;

                }
                else if (half_check.Checked == true && leave_type.Text != "Casual Leave")
                {
                    c3 = true;
                    leave_err_half.Text = "*Half days can be applied under Casual Leave type";
                    leave_err_half.Visible = true;
                    half_date.Enabled = false;
                    half_check.Checked = false;
                }
                else if(half_check.Checked == false)
                {
                    c3 = false;
                    leave_err_half.Visible = false;
                    half_date.Enabled = false;
                }

                
                if (full_day_check.Checked == true)
                {
                    if (confo_date <= DateTime.Now.Date)
                    {
                        leave_from.Enabled = true;
                        leave_to.Enabled = true;
                        leave_err.Visible = false;
                        c4 = false;
                    }
                    else
                    {
                        leave_from.Enabled = false;
                        leave_to.Enabled = false;
                        leave_err.Text = "*Employee is still in his probation period";
                        leave_err.Visible = true;
                        full_day_check.Checked = false;
                        c4 = true;
                    }
                }
                if ((c || c1 || c2 || c3 || c4) == false)
                {
                    //*******
                    annual = Convert.ToInt32(leaves_left.Rows[0].Cells[2].Value.ToString());
                    casual = Convert.ToInt32(leaves_left.Rows[0].Cells[3].Value.ToString());
                    sick = Convert.ToInt32(leaves_left.Rows[0].Cells[4].Value.ToString());
                    half = Convert.ToInt32(leaves_left.Rows[0].Cells[5].Value.ToString());
                    //**********
                    string code = "";
                    string id = "";
                    if (lid == "" && empid == "")
                    {
                        code = leave_emp_code.Text;
                        id = id_generator(leaves_taken);
                    }
                    else if (lid != "" && empid != "")
                    {
                        code = empid;
                        id = lid;
                    }
                    string type = leave_type.Text;
                    string date = "";
                    string from = "";
                    string to = "";
                    string no_pay = "No";
                    int days = 0;
                    if (half_check.Checked)
                    {
                        date = half_date.Value.ToString("yyyy-MM-dd");
                        if (nopay_check.Checked)
                        {
                            no_pay = "Yes";
                        }


                        if (confo_date > DateTime.Now.Date)
                        {
                            if (half == 0)
                            {
                                MessageBox.Show("You have taken all the leaves", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                half--;
                                no_pay = "Yes";
                                days = 0;
                                leaves_left.Rows.Clear();
                                leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);
                            }
                        }
                        else if (confo_date < DateTime.Now.Date)
                        {
                            if (casual == 0)
                            {
                                DialogResult d = MessageBox.Show("You have taken all the casual leaves. Do you still want to take a leave?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (d == DialogResult.Yes)
                                {
                                    casual = casual - 0.5;
                                    no_pay = "Yes";
                                    leaves_left.Rows.Clear();
                                    leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                    leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);
                                }

                            }
                            else if (casual != 0)
                            {
                                casual = casual - 0.5;
                                no_pay = "No";
                                leaves_left.Rows.Clear();
                                leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);

                            }
                        }


                    }

                    if (full_day_check.Checked)
                    {
                        DateTime fdate = DateTime.Parse(leave_from.Text);
                        DateTime tdate = DateTime.Parse(leave_to.Text);
                        from = leave_from.Value.ToString("yyyy-MM-dd");
                        //MessageBox.Show("tdate = " + tdate + " fdate =" + fdate);
                        days = days_Calculator(tdate, fdate);
                        //MessageBox.Show("leave days: " + days);
                        to = leave_to.Value.ToString("yyyy-MM-dd");
                        if (nopay_check.Checked == true)
                        {
                            no_pay = "Yes";
                        }
                        if (nopay_check.Checked == false)
                        {
                            no_pay = "No";
                        }
                        if (type == "Annual Leave")
                        {

                           // MessageBox.Show("days = " + days);
                            if (days == 7)
                            {
                                if (annual == 0)
                                {
                                    DialogResult d = MessageBox.Show("Sorry. Employee has taken all the Annual Leaves.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    annual = annual - 7;
                                    days = 7;
                                    half = 0;
                                    date = null;
                                    //MessageBox.Show("annual leave days: " + days);
                                    leaves_left.Rows.Clear();
                                    leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                    leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);

                                }
                            }
                            else
                            {
                                leave_err.Text = "*Minimum of 7 Annual Leaves can be apply at once";
                                leave_err.Visible = true;
                            }
                        }
                        else if (type == "Casual Leave")
                        {
                            if (casual == 0)
                            {
                                DialogResult d = MessageBox.Show("Employee has taken all the Casual Leaves. Do you still want to take a leave?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (d == DialogResult.Yes)
                                {

                                    no_pay = "Yes";
                                }
                            }
                            else
                            {
                                no_pay = "No";
                            }
                            casual = casual - days;
                            //MessageBox.Show("casual leave days: " + days);
                            date = null;
                            half = 0;
                            leaves_left.Rows.Clear();
                            leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                            leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);


                        }
                        else if (type == "Sick Leave")
                        {
                            if (sick == 0)
                            {
                                DialogResult d = MessageBox.Show("Employee has taken all the Sick Leaves. Do you still want to take a leave?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (d == DialogResult.Yes)
                                {

                                    no_pay = "Yes";
                                }
                            }
                            else
                            {
                                no_pay = "No";
                            }
                            sick = sick - days;
                            //MessageBox.Show("sick leave days: " + days);
                            half = 0;
                            date = null;
                            leaves_left.Rows.Clear();
                            leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                            leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);
                        }
                        else if (type == "Maternity Leave")
                        {
                            if (days == 84)
                            {
                                no_pay = "No";
                                //MessageBox.Show("maternity leave days: " + days);
                                half = 0;
                                date = null;
                                leaves_left.Rows.Clear();
                                leaves_left.Rows.Add(leave_emp_code.Text, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                                leaves_taken.Rows.Add(code, id, type, from, to, days, date, no_pay);

                            }
                        }

                    }


                }
            }
        }

        private void leave_submit_Click(object sender, EventArgs e)
        {
            DialogResult  d  = MessageBox.Show("Do you want to submit the Leaves? Editions are not Possible after the Submittion","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                string code = leaves_left.Rows[0].Cells[0].Value.ToString();
                annual = Convert.ToInt32(leaves_left.Rows[0].Cells[2].Value.ToString());
                casual = Convert.ToInt32(leaves_left.Rows[0].Cells[3].Value.ToString());
                sick = Convert.ToInt32(leaves_left.Rows[0].Cells[4].Value.ToString());
                half = Convert.ToInt32(leaves_left.Rows[0].Cells[5].Value.ToString());

                string id = "";
                string type = "";
                string from = "";
                string to = "";
                int days = 0;
                string h_date = "";
                string no_pay = "";
                for (int p = 0; p < leaves_taken.Rows.Count; p++)
                {
                    if (Convert.ToString(leaves_taken.Rows[p].Cells[6].Value) == string.Empty)
                    {
                        id = leaves_taken.Rows[p].Cells[1].Value.ToString();
                        type = leaves_taken.Rows[p].Cells[2].Value.ToString();
                        from = leaves_taken.Rows[p].Cells[3].Value.ToString();
                        to = leaves_taken.Rows[p].Cells[4].Value.ToString();
                        days = Convert.ToInt32(leaves_taken.Rows[p].Cells[5].Value.ToString());
                        h_date = "";
                        no_pay = leaves_taken.Rows[p].Cells[7].Value.ToString();

                    }
                    else if (Convert.ToString(leaves_taken.Rows[0].Cells[6].Value) != string.Empty)
                    {
                        //MessageBox.Show("p in else = " + p);
                        id = leaves_taken.Rows[p].Cells[1].Value.ToString();
                        type = leaves_taken.Rows[p].Cells[2].Value.ToString();
                        from = null;
                        to = null;
                        days = 0;
                        h_date = leaves_taken.Rows[p].Cells[6].Value.ToString();
                        no_pay = leaves_taken.Rows[p].Cells[7].Value.ToString();
                    }
                }

                //MessageBox.Show("code = " + code + "id = " + id + "type = " + type + "from = " + from + "to = " + to + "days = " + days + "half =" + half + "date = " + date + "pay = " + pay);
                setter.SendToDB("INSERT INTO leaves_taken(emp_code, leave_id, leave_type, from_date, to_date, no_of_days, half_days, date, pay) VALUES ('" + code + "','" + id + "','" + type + "','" + from + "','" + to + "'," + days + "," + half + ",'" + h_date + "','" + no_pay + "')");
                setter.SendToDB("UPDATE leaves_left SET annual = " + annual + ", casual = " + casual + ", sick = " + sick + ", half_days = " + half + " WHERE emp_code = '" + code + "' ");
                MessageBox.Show("Leaves submitted successfully");
                leaves_left.Rows.Clear();
                leaves_taken.Rows.Clear();
            }
        }


        public string id_generator(DataGridView grid)
        {
            string ecode = leave_emp_code.Text;
            if (grid.Rows.Count == 0)
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM leaves_taken WHERE emp_code = '" + ecode + "'");
                int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                k = i + 1;
                //MessageBox.Show("i data rows in db = " + i);
                i.ToString();
                i++;
                //MessageBox.Show("k = " + k);
                return (ecode + "_" + i);
            }
            else
            {
                
                MessageBox.Show("grid data rows r.c= " + grid.Rows.Count + "rowCount = " + grid.RowCount);
               // MessageBox.Show("k = " + k);
                k = k + 1;
                int j = k;
                //MessageBox.Show("j = "+j);
                return (ecode + "_" + j);
            }
        }

        public int days_Calculator(DateTime d1, DateTime d2)
        {
            //MessageBox.Show("d1 = "+d1+" d1 ="+d2);
            double x = (d1 - d2).TotalDays;
            //MessageBox.Show("Inside calculator =" + x);
            return ((d1 - d2).Days + 1);
        }

        private void leave_edit_Click(object sender, EventArgs e)
        {
            if (leaves_left.Rows.Count == 0 || leaves_taken.Rows.Count == 0)
            {
                MessageBox.Show("Please add a leave. ");
            }
            else
            {
                MessageBox.Show("Please select the entry you want to Edit.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void leaves_taken_MouseClick(object sender, MouseEventArgs e)
        {
            int ldays = 0;
            int index = leaves_taken.CurrentCell.RowIndex;
            empid = leave_emp_code.Text;
            //MessageBox.Show("delete = " + delete);
            if (delete == true)
            {
                DialogResult d = MessageBox.Show("Do you want to Delete the selected Leave Entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    annual = Convert.ToInt32(leaves_left.Rows[0].Cells[2].Value.ToString());
                    casual = double.Parse(leaves_left.Rows[0].Cells[3].Value.ToString());
                    sick = Convert.ToInt32(leaves_left.Rows[0].Cells[4].Value.ToString());
                    half = Convert.ToInt32(leaves_left.Rows[0].Cells[5].Value.ToString());
                    //MessageBox.Show("before deleting " + annual + "" + casual + "" + sick + "" + half);
                    if (Convert.ToString(leaves_taken.Rows[index].Cells[3].Value) == string.Empty)
                    {
                        casual = casual - 0.5;
                    }
                    else
                    {
                        ldays = Convert.ToInt32(leaves_taken.Rows[index].Cells[5].Value.ToString());
                    }
                    if (leave_type.Text == "Annual Leave")
                    {
                        annual = annual + ldays;
                    }

                    else if (leave_type.Text == "Casual Leave")
                    {
                        casual = casual + ldays;
                    }
                    else if (leave_type.Text == "Sick Leave")
                    {
                        sick = sick + ldays;
                    }
                    //MessageBox.Show("after deleting " + annual + "" + casual + "" + sick + "" + half);
                    leaves_left.Rows.RemoveAt(0);
                    leaves_taken.Rows.RemoveAt(index);
                    leaves_left.Rows.Add(empid, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());
                }
            }
            else
            {
                DialogResult d = MessageBox.Show("Do you want to edit this Leave Entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    annual = Convert.ToInt32(leaves_left.Rows[0].Cells[2].Value.ToString());
                    casual = double.Parse(leaves_left.Rows[0].Cells[3].Value.ToString());
                    sick = Convert.ToInt32(leaves_left.Rows[0].Cells[4].Value.ToString());
                    half = Convert.ToInt32(leaves_left.Rows[0].Cells[5].Value.ToString());
                    //MessageBox.Show("when selecting " + annual + "" + casual + "" + sick + "" + half);
                    

                    index = leaves_taken.CurrentCell.RowIndex;
                    if (Convert.ToString(leaves_taken.Rows[index].Cells[3].Value) == string.Empty)
                    {
                        leave_emp_code.Text = leaves_taken.Rows[index].Cells[0].Value.ToString();
                        leave_type.Text = leaves_taken.Rows[index].Cells[2].Value.ToString();
                        full_day_check.Checked = false;
                        leave_from.Text = DateTime.Now.Date.ToString();
                        leave_from.Enabled = false;
                        leave_to.Text = DateTime.Now.Date.ToString();
                        leave_to.Enabled = false;
                        half_check.Checked = true;
                        half_date.Text = leaves_taken.Rows[index].Cells[6].Value.ToString();
                        half_date.Enabled = true;

                        if (leaves_taken.Rows[index].Cells[7].Value.ToString() == "No")
                        {
                            nopay_check.Checked = false;
                        }
                        else if (leaves_taken.Rows[index].Cells[7].Value.ToString() == "Yes")
                        {
                            nopay_check.Checked = true;
                        }
                        casual = casual + 0.5;

                    }
                    else
                    {
                        leave_emp_code.Text = leaves_taken.Rows[index].Cells[0].Value.ToString();
                        leave_type.Text = leaves_taken.Rows[index].Cells[2].Value.ToString();
                        full_day_check.Checked = true;
                        leave_from.Text = leaves_taken.Rows[index].Cells[3].Value.ToString();
                        leave_from.Enabled = true;
                        leave_to.Text = leaves_taken.Rows[index].Cells[4].Value.ToString();
                        leave_to.Enabled = true;
                        half_check.Checked = false;
                        half_date.Text = DateTime.Now.Date.ToString();
                        half_date.Enabled = false;
                        ldays = Convert.ToInt32(leaves_taken.Rows[index].Cells[5].Value.ToString());

                        if (leaves_taken.Rows[index].Cells[7].Value.ToString() == "No")
                        {
                            nopay_check.Checked = false;
                        }
                        else if (leaves_taken.Rows[index].Cells[7].Value.ToString() == "Yes")
                        {
                            nopay_check.Checked = true;
                        }
                    }

                    
                    lid = leaves_taken.Rows[index].Cells[1].Value.ToString();
                    if (leave_type.Text == "Annual Leave")
                    {
                        annual = annual + ldays;
                    }

                    else if (leave_type.Text == "Casual Leave")
                    {
                        casual = casual + ldays;
                    }
                    else if (leave_type.Text == "Sick Leave")
                    {
                        sick = sick + ldays;
                    }
                    //MessageBox.Show("after selecting " + annual + "" + casual + "" + sick + "" + half);
                    //MessageBox.Show("Eid =" + empid + "name =" + name + " annual=" + annual + "casual= " + casual + "sick =" + sick + " half=" + half);
                    leaves_left.Rows.RemoveAt(0);
                    leaves_taken.Rows.RemoveAt(index);
                    leaves_left.Rows.Add(empid, name, annual.ToString(), casual.ToString(), sick.ToString(), half.ToString());

                }
            }
        }

        private void leave_delete_Click(object sender, EventArgs e)
        {
            DialogResult  d = MessageBox.Show("Select the row you need to delete","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                delete = true;
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
            leave_type.Text = "";
            half_date.Text = DateTime.Now.Date.ToString();
            leave_from.Text = DateTime.Now.Date.ToString();
            leave_to.Text = DateTime.Now.Date.ToString();
            nopay_check.Checked = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear(this.Controls);
        }

        private void Clear(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    Clear(ctrl.Controls);
            }
            leave_type.Text = "";
            half_check.Checked = false;
            full_day_check.Checked = false;
            half_date.Text = DateTime.Now.Date.ToString();
            leave_from.Text = DateTime.Now.Date.ToString();
            leave_to.Text = DateTime.Now.Date.ToString();
        }

        private void leave_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Leaves_Load(object sender, EventArgs e)
        {

        }




    }
}



//MessageBox.Show(code + "" + id + "" + type + "" + from + "" + to + "" + days + "" + half + "" + date + "" + pay);
//setter.SendToDB("INSERT INTO leaves_taken(emp_code, leave_id, leave_type, from_date, to_date, no_of_days, half_days, date, pay) VALUES ('"+ code +"','"+ id +"','"+ type +"','"+ from +"','"+ to +"',"+ days +","+ halfday +",'"+ date +"','"+ no_pay +"')");
//                            setter.SendToDB("UPDATE leaves_left SET annual = " + annual + ", casual = " + casual + ", sick = " + sick + ", half_days = " + half + " WHERE emp_code = '" + leave_emp_code.Text + "' ");
