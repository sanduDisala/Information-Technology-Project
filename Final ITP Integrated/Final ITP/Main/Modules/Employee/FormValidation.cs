using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;


namespace Main.Module.Employee
{
    class FormValidation
    {
        DBConnect setter = new DBConnect();
        public Boolean checkEmpty(string objectValue, Label label) 
        {
            if (objectValue == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                label.Hide();
                return false;
            }
        }

        public Boolean dobValidator(DateTime date, Label label)
        {
            DateTime currentDate = DateTime.Now.Date;
            //Console.WriteLine(currentDate);

            DateTime inputDate = date;
            if (currentDate == inputDate || currentDate < inputDate )
            {
                label.Text = "*Invalid Date of Birth";
                label.Visible = true;
                return true;
            }
            else
            {
                if ((currentDate.Year - inputDate.Year) < 18)
                {
                    label.Text = "*Employee's age cannot be less than 18 ";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }
        }

        public Boolean radio_button_validator(RadioButton r1, RadioButton r2, Label label)
        {
            if (!(r1.Checked || r2.Checked))
            {
                label.Text = "* Please select a relavent field";
                label.Visible = true;
                return true;
            }
            else
            {
                label.Visible = false;
                return false;
            }
        }
        public Boolean name_initial_Validator(string name, Label label)
        {
            if (name == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }   
            else
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z.]+$"))
                {
                    label.Text = "* Invalid Text. Try again";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
                
            }
        }

        public Boolean fullname_Validator(string name, Label label)
        {
            if (name == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;

            }
            else
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    label.Text = "*Invalid Text. Try again.";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }

            }
        }

        public Boolean nic_validator(string nic, Label label)
        {
            if (nic == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                if (!Regex.IsMatch(nic, @"^([0-9]{9}[V])$"))
                {
                    label.Text = "*Invalid NIC. Try again. ";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    //*****//
                    DataSet ds = new DataSet();
                    ds = setter.GetFromDB("SELECT COUNT(nic) FROM employee_details WHERE nic = '"+ nic +"'");
                    int k = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                    if (k == 0)
                    {
                        label.Visible = false;
                        return false;
                    }
                    else
                    {
                        label.Text = "*Invalid NIC. This NIC is owned by another Employee";
                        label.Visible = true;
                        return true;
                        
                    }
                    //***//
                }

            }
        }
        public Boolean check_number(string data, Label label)
        {
            if (data != "")
            {
                if (!Regex.IsMatch(data, @"^[0-9]+$"))
                {
                    label.Text = "*Enter only the numeric characters";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }
            else
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;

            }
        }

        public Boolean telephone_no_Vlidator(string no, Label label)
        {
            if (no == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                if (!Regex.IsMatch(no, @"^[0-9]{10}$"))
                {
                    label.Text = "*Invalid Telephone Number. Try Again.";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }

            }
        }

        public Boolean address_Validator(string address, Label label)
        {
            if (address == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                if (!Regex.IsMatch(address, @"^[A-Za-z0-9:,]+(?:\s[A-Za-z0-9',/]+)+$"))
                {
                    label.Text = "*Invalid Text. Try again";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }

            }
        }

        public Boolean email_Validator(string email, Label label)
        {
            if (email == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            {
                label.Text = "*Invalid email Address. Try again.";
                label.Visible = true;
                return true;
            }
            else if (email.IndexOf('@') > email.IndexOf('.'))
            {
                label.Text = "*Invalid email Address. Try again.";
                label.Visible = true;
                return true;
            }
            else 
            {
                label.Visible = false;
                return false;
            }
        }

        public Boolean string_Validator(string data, Label label)
        {
            if (data == "")
            {
                label.Visible = false;
                return false;
            }
            else if (!Regex.IsMatch(data, @"^[a-zA-Z\s]+$"))
            {
                label.Text = "*Invalid Text. Try again.";
                label.Visible = true;
                return true;
            }
            else
            {
                label.Visible = false;
                return false;
            }
        }

        public Boolean empcode_validator(string code, Label label)
        {
            if (code == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM employee_details WHERE emp_code = '" + code + "' ");
                //MessageBox.Show("ds = " + ds);
                //MessageBox.Show("ds = " + ds.Tables[0].Rows[0][0]);

                int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                //MessageBox.Show("i = " + i);
                if (i == 0)
                {
                    label.Text = "*Invalid Employee Code. Try again.";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }

        }

        public Boolean isTelephone_Number(string number, Label label)
        {
            if (number == "")
            {
                label.Visible = false;
                return false;
            }
            else if (!Regex.IsMatch(number, @"^[0-9]{10}$"))
            {
                label.Text = "*Invalid Telephone Number. Try Again.";
                label.Visible = true;
                return true;
            }
            else
            {
                label.Visible = false;
                return false;
            }
        }

        public Boolean date_Validator(DateTime date, Label label)
        {
            DateTime currentDate = DateTime.Now.Date;
            //Console.WriteLine(currentDate);

            DateTime inputDate = date;
            if (currentDate == inputDate || currentDate < inputDate)
            {
                label.Text = "*Invalid Date.Please try again";
                label.Visible = true;
                return true;
            }
            else
            {
                    label.Visible = false;
                    return false;
            }
        }

        public Boolean alphanumeric_Validator(string data, Label label)
        {
            if (data == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                if (!Regex.IsMatch(data, @"^[a-zA-Z0-9/s]+$"))
                {
                    label.Text = "* Invalid Text. Try again";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }
        }

        public Boolean decimal_Validator(string number, Label label)
        {
            if (number == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            if (!Regex.IsMatch(number, @"^((\d+)((\.\d{1,2})?))$"))
            {
                label.Text = "* Invalid Text. Try again";
                label.Visible = true;
                return true;
            }
            else
            {
                label.Visible = false;
                return false;
            }
        }

        public Boolean emp_name_Validator(string name, Label label)
        {
            if (name == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(name_initials) FROM employee_details WHERE name_initials = '" + name + "' ");
                //MessageBox.Show("ds = " + ds);
                //MessageBox.Show("ds = " + ds.Tables[0].Rows[0][0]);

                int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                //MessageBox.Show("i = " + i);
                if (i == 0)
                {
                    label.Text = "*Invalid Employee Name. Try again.";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }
        }
        //*****//
        public Boolean account_no_validator(string accno, Label label)
        {
            if (accno == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
            else
            {
                int account_no = Convert.ToInt32(accno);
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(acc_no) FROM employee_details WHERE acc_no = " + account_no + "");
                int k = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                //MessageBox.Show("k = " + k);
                

                    if (!Regex.IsMatch(accno, @"^[0-9]+$"))
                    {
                        label.Text = "*Enter only the numeric characters";
                        label.Visible = true;
                        return true;
                    }
                    else
                    {
                        if (k == 0)
                        {
                            label.Visible = false;
                            return false;
                        }
                        else
                        {
                            label.Text = "*Invalid Account Number. This Account Number is owned by another Employee.";
                            label.Visible = true;
                            return true;
                        }

                    }

                

            }
        }
        //*************

        public Boolean account_no_validator1(string accno, Label label)
        {

            if (accno != "")
            {
                if (!Regex.IsMatch(accno, @"^[0-9]+$"))
                {
                    label.Text = "*Enter only the numeric characters";
                    label.Visible = true;
                    return true;
                }
                else
                {
                    label.Visible = false;
                    return false;
                }
            }
            else
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = true;
                return true;
            }
        }

        public Boolean nic_validator1(string nic, Label label)
        {
            if (nic == "")
            {
                label.Text = "* You cannot leave this field empty.";
                label.Visible = false;
                return true;
            }
            else
            {
                if (!Regex.IsMatch(nic, @"^([0-9]{9}[V])$"))
                {
                    label.Text = "*Invalid NIC. Try again. ";
                    label.Visible = true;
                    return true;
                }

                else
                {
                    label.Visible = false;
                    return false;
                }
                        
                    
                    //***//
            }

            
        }
        //*************
        




        
    }
}
