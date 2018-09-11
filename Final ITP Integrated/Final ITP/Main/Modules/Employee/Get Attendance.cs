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
    public partial class Get_Attendance : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        public Get_Attendance()
        {
            InitializeComponent();
            this.ActiveControl = att_code;
        }

        private void Get_Attendance_Load(object sender, EventArgs e)
        {
            //time.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void time_Click(object sender, EventArgs e)
        {
            //time.Text = DateTime.Now.ToLongTimeString();
        }

        private void att_code_Leave(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(att_code.Text, attin_err_empcode);
            if (c == false)
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT name_initials FROM employee_details WHERE emp_code = '" + att_code.Text + "'");
                //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                emp_name.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void emp_name_Leave(object sender, EventArgs e)
        {
            Boolean c = fv.emp_name_Validator(emp_name.Text, att_err_name);
            if (c == false)
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT emp_code FROM employee_details WHERE name_initials = '" + emp_name.Text + "'");
                //MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                att_code.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        //private void set_time_Click(object sender, EventArgs e)
        //{
        //    time.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        //    time.Visible = true;
        //}

        private void att_add_Click(object sender, EventArgs e)
        {
            Boolean c1 = fv.empcode_validator(att_code.Text, attin_err_empcode);
            Boolean c2 = fv.emp_name_Validator(emp_name.Text, att_err_name);
            Boolean c3 = false;

         //   MessageBox.Show("att_add_Click", "Enter");

            if ((in_check.Checked || out_check.Checked) == false)
            {
                c3 = true;
                att_err_time.Text = "*Please set the time";
                att_err_time.Visible = true;
            }
            else if ((in_check.Checked || out_check.Checked) == true)
            {
                c3 = false;
                if (in_check.Checked == true)
                {
                    string id = att_code.Text;
                    string adate = date_picker.Text;
                    //DateTime date = DateTime.Parse(adate +" " +atime.Text);
                  //  MessageBox.Show("in date = "+adate);
                    for (int i = 0; i < attendance.Rows.Count; i++)
                    {
                        if (id == attendance.Rows[i].Cells[0].Value.ToString())
                        {
                          //  MessageBox.Show("date in grid =" + DateTime.Parse(attendance.Rows[i].Cells[2].Value.ToString()));
                            if (DateTime.Parse(adate)  == DateTime.Parse(attendance.Rows[i].Cells[2].Value.ToString()).Date)
                            {
                                att_err_time.Text = "*This Employees attendance has already entered";
                                att_err_time.Visible = true;
                                c3 = true;
                            }
                        }
                    }
                    if (c3 == false)
                    {
                        DataSet ds = setter.GetFromDB("SELECT CONVERT(VARCHAR(10), in_time, 101) AS date FROM attendance WHERE emp_code = '" + id + "'");
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                           // MessageBox.Show("ds=" + ds.Tables[0].Rows[i].ItemArray[0].ToString() + "date = " + adate);
                            if (adate == ds.Tables[0].Rows[i].ItemArray[0].ToString())
                            {
                                att_err_time.Text = "*This Employees attendance has already entered";
                                att_err_time.Visible = true;
                                c3 = true;
                                break;
                            }
                        }
                    }
                }
            }

         //   MessageBox.Show(c1.ToString() + " " + c2.ToString() + " " + c3.ToString(), "c1 c2 c3");

            if ((c1 || c2 || c3) == false)
            {
                string code = att_code.Text;
                string name = emp_name.Text;
                string inTime = "";
                

               // MessageBox.Show(out_check.ToString(), "out_check");

                if (in_check.Checked == true)
                {
                    code = att_code.Text;
                    name = emp_name.Text;
                    inTime = date_picker.Text+" "+atime.Text;
                   // MessageBox.Show("intime = " + inTime);
                    attendance.Rows.Add(code, name, inTime);
                    att_err_time.Visible = false;
                    date_picker.Enabled = false;
                    atime.Enabled = false;
                }

                else if (out_check.Checked == true)
                {
                    Boolean inFind = false;
                    for (int i = 0; i < attendance.Rows.Count; i++)
                    {

                        if (attendance.Rows[i].Cells[0].Value.ToString() == code)
                        {
                            attendance.Rows[i].Cells[3].Value = date_picker.Text + " " + atime.Text;
                            string in_time = attendance.Rows[i].Cells[2].Value.ToString();
                            string out_time = atime.Text;
                            //MessageBox.Show("in_time = "+in_time+"out_time = "+out_time);
                            double ot = Calculate_OT(code, in_time, out_time);
                            attendance.Rows[i].Cells[4].Value = ot.ToString();
                            //outTime = date_picker.Text + " " + atime.Text; 
                            //******
                            //inTime = attendance.Rows[i].Cells[2].Value.ToString();
                            //index = i;
                            inFind = true;
                            
                            att_err_time.Visible = false;
                            Clear(this.Controls);
                            break;
                        }
                        else
                        {
                            inFind = false;
                            continue;
                        }
                    }

            //        MessageBox.Show(inFind.ToString(), "inFInd");


                    if (inFind == false)
                    {
                        MessageBox.Show("You have not recorded the In Time today", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else if (inFind == true)
                    //{
                    //    //***
                    //    id = id_generator();
                    //    double ot = Calculate_OT(code, inTime, outTime);
                    //    MessageBox.Show("ot="+ot);
                    //    setter.SendToDB("INSERT INTO attendance(emp_code, AID, in_time, out_time, ot_hrs) VALUES ('" + code + "','" + id + "','" + inTime + "','" + outTime + "',"+ ot +")");
                    //    attendance.Rows.RemoveAt(index);
                    //    MessageBox.Show("Information successfully Submitted");
                    //    Clear(this.Controls);
                    //}
                }

            }
        }

        private void in_check_Click(object sender, EventArgs e)
        {
            if (in_check.Checked == true)
            {
                date_picker.Enabled = true;
                atime.Enabled = true;
                out_check.Checked = false;
            }
            else if (in_check.Checked == false)
            {
                date_picker.Enabled = false;
                atime.Enabled = false;
            }
        }

        private void out_check_Click(object sender, EventArgs e)
        {
            if (out_check.Checked == true)
            {
                date_picker.Enabled = true;
                atime.Enabled = true;
                in_check.Checked = false;
            }
            else if (out_check.Checked == false)
            {
                date_picker.Enabled = false;
                atime.Enabled = false;
            }
        }


        private string id_generator(string code)
        {
            DataSet ds = new DataSet();
            //string code = att_code.Text;
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM attendance WHERE emp_code = '" + code + "'");
            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            //MessageBox.Show("i = "+i);
            //MessageBox.Show("i data rows in db = " + i);
            i++;
            i.ToString();

            //MessageBox.Show("i = " + code + "A" + i);
            return (code + "A" + i);
        }
        //*************
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
            in_check.Checked = false;
            out_check.Checked = false;
            date_picker.Enabled = false;
            atime.Enabled = false;
            //####
            attin_err_empcode.Visible = false;
            att_err_name.Visible = false;
            att_err_time.Visible = false;
        }

        private void att_clear_Click(object sender, EventArgs e)
        {
            Clear(this.Controls);
        }

        private void att_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //****************

        private double Calculate_OT(string id, string inTime, string outTime)
            {
               // MessageBox.Show("intime = " +inTime+"outTime = "+outTime);
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT ot_amt FROM salary_and_tax_details WHERE emp_code = '"+ id +"'");
                double i = Convert.ToDouble(ds.Tables[0].Rows[0][0]);
               // MessageBox.Show("i="+i); 
                TimeSpan ot = DateTime.Now.TimeOfDay ;
                double ot_hrs = 0;
                //DateTime tt1 = DateTime.Parse(inTime).ToString("hh:mm tt");
                //TimeSpan t1 = TimeSpan.Parse(DateTime.Parse(inTime).ToString("hh:mm"));
                //TimeSpan t2 = TimeSpan.Parse(DateTime.Parse(outTime).ToString("HH:mm"));
                string tt1 = inTime;//DateTime.Parse(inTime).ToString("HH:mm");
                string tt2 = outTime;//DateTime.Parse(outTime).ToString("HH:mm");

                //TimeSpan t1 = TimeSpan.Parse(DateTime.Parse(tt1).ToString());
                //TimeSpan t2 = TimeSpan.Parse(DateTime.Parse(tt2).ToString());
                //MessageBox.Show("tt1 =" +tt1+"tt2="+tt2);
                //int t1Hr = DateTime.Parse(inTime).Hour;
                //int t2Hr = DateTime.Parse(outTime).Hour;
               // MessageBox.Show("t1=" + t1+"t2="+t2+"t1hr="+t1Hr+"t2hr"+t2Hr);
                if (i > 0)
                {
                  //  MessageBox.Show("i>0");
                    string[] a = inTime.Split(' ');
                    string indate = a[0];
                   // MessageBox.Show("indate array 0=" + a);
                    int month = DateTime.Parse(indate).Month;
                    ds = setter.GetFromDB("SELECT * FROM Calendar WHERE month = " + month + "");
                    string date = "";
                    for (int k = 0; k < ds.Tables[0].Rows.Count; k++)
                    {
                        if (ds.Tables[0].Rows[k][2].ToString() == "")
                        {
                            if (ds.Tables[0].Rows[k][3].ToString() == "")
                            {
                                date = ds.Tables[0].Rows[k][4].ToString();
                                //MessageBox.Show("public holiday = " + date);
                                if (indate == date)
                                {
                                   // MessageBox.Show("public holiday!");
                                    ot = DateTime.Parse(tt2).Subtract(DateTime.Parse(tt1));

                                   // MessageBox.Show("ot beforeR=" + ot);
                                    ot_hrs = ot.Hours + ot.Minutes / 60.0;
                                    ot_hrs = Math.Round(ot_hrs, 1);
                                   // MessageBox.Show("ot_hrs=" + ot_hrs);
                                    return ot_hrs;
                                }

                            }
                            else
                            {
                                date = ds.Tables[0].Rows[k][3].ToString();
                                //MessageBox.Show("saturday = " + date);
                                if (indate == date)
                                {
                                    //MessageBox.Show("saturday!");
                                    //TimeSpan ot_limit = TimeSpan.Parse("13:00");
                                    DateTime ot_limit = DateTime.Parse("13:00");
                                    if (DateTime.Parse(tt2) > ot_limit)
                                    {

                                        ot = DateTime.Parse(tt2).Subtract(ot_limit);
                                        //MessageBox.Show("ot beforeR=" + ot);
                                        ot_hrs = ot.Hours + ot.Minutes / 60.0;
                                        ot_hrs = Math.Round(ot_hrs, 1);
                                       // MessageBox.Show("ot_hrs=" + ot_hrs);
                                        return ot_hrs;
                                    }
                                    else
                                    {
                                        return 0;
                                    }
                                }
                            }

                        }
                        else
                        {
                            date = ds.Tables[0].Rows[k][2].ToString();
                            //MessageBox.Show("sunday = " + date);
                            //MessageBox.Show("indate = " + indate+"date= "+date);
                            if (indate == date)
                            {
                                //MessageBox.Show("sunday!");
                                ot = DateTime.Parse(tt2).Subtract(DateTime.Parse(tt1));
                                //MessageBox.Show("ot beforeR=" + ot);
                                ot_hrs = ot.Hours + ot.Minutes / 60.0;
                                ot_hrs = Math.Round(ot_hrs, 1);
                                //MessageBox.Show("ot_hrs=" + ot_hrs);
                                return ot_hrs;
                            }
                        }
                    }
                    DateTime ot_week = DateTime.Parse("18:00");
                    if (DateTime.Parse(tt2) > ot_week)
                    {
                        //MessageBox.Show("weekday!");
                        ot = DateTime.Parse(tt2).Subtract(ot_week);
                       // MessageBox.Show("ot beforeR=" + ot);


                        ot_hrs = ot.Hours + ot.Minutes / 60.0;
                        ot_hrs = Math.Round(ot_hrs, 1);
                        //MessageBox.Show("ot_hrs=" + ot_hrs);
                        return ot_hrs;
                     }
                     else
                     {
                        return 0;
                     }


                }
                else
                {
                    MessageBox.Show("No ot liable");
                    return 0;
                }

            }

        private void att_submit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Submit the Entries?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < attendance.Rows.Count; i++)
                {
                    string code = attendance.Rows[i].Cells[0].Value.ToString();
                    string id = id_generator(code);

                    string inTime = attendance.Rows[i].Cells[2].Value.ToString();

                    string outTime = attendance.Rows[i].Cells[3].Value.ToString();
                    double ot = Double.Parse(attendance.Rows[i].Cells[4].Value.ToString());
                    //MessageBox.Show("ot=" + ot);
                    setter.SendToDB("INSERT INTO attendance(emp_code, AID, in_time, out_time, ot_hrs) VALUES ('" + code + "','" + id + "','" + inTime + "','" + outTime + "'," + ot + ")");
                    
                }
                attendance.Rows.Clear();
                MessageBox.Show("Information successfully Submitted");
                Clear(this.Controls);
            }
        }

              



        }
    
}
