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
    public partial class Contact_Details : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        
        public Contact_Details()
        {
            InitializeComponent();
            this.ActiveControl = cd_code;
        }

        private void cd_code_Leave(object sender, EventArgs e)
        {
            //fv.checkEmpty(cd_code.Text, cd_err_code);
            fv.empcode_validator(cd_code.Text, cd_err_code);
            //emp_code_availaility_validator();
        }

        private void residance_add_Leave(object sender, EventArgs e)
        {
            fv.address_Validator(residance_add.Text, cd_err_resiadd);
            
        }

        private void residance_tp_Leave(object sender, EventArgs e)
        {
            fv.telephone_no_Vlidator(residance_tp.Text, cd_err_resitp);
            
        }

        private void mobile_no_Leave(object sender, EventArgs e)
        {
            fv.telephone_no_Vlidator(mobile_no.Text, cd_err_mobile);
            
        }

        private void person_email_Leave(object sender, EventArgs e)
        {
            fv.email_Validator(person_email.Text, cd_err_pemail);
            //fv.checkEmpty(person_email.Text, cd_err_pemail);
        }

        private void office_email_Leave(object sender, EventArgs e)
        {
            fv.email_Validator(office_email.Text, cd_err_oemail);
            //fv.checkEmpty(office_email.Text, cd_err_oemail);
        }

        private void cd_submit_Click(object sender, EventArgs e)
        {
            Boolean c1 = false;
            Boolean c2 = false;
            Boolean c3 = false;
            Boolean c4 = false;
            Boolean c5 = false;
            Boolean c6 = false;
            Boolean c7 = false;
            Boolean c8 = false;
            Boolean c9 = false;
            Boolean c10 = false;
            Boolean c11 = false;
        
            if (cd_code.Visible == true) 
            {
                c1 = fv.empcode_validator(cd_code.Text, cd_err_code);
                c2 = fv.address_Validator(residance_add.Text, cd_err_resiadd);
                c3 = fv.address_Validator(temp_add.Text, cd_err_tempadd);
                c4 = fv.telephone_no_Vlidator(residance_tp.Text, cd_err_resitp);
                c5 = fv.telephone_no_Vlidator(mobile_no.Text, cd_err_mobile);
                c6 = fv.email_Validator(person_email.Text, cd_err_pemail);
                c7 = fv.email_Validator(office_email.Text, cd_err_oemail);
                c8 = fv.name_initial_Validator(contact_person.Text, cd_err_conperson);
                c9 = fv.string_Validator(relation.Text, cd_err_relation);
                c10 = fv.isTelephone_Number(contact_tp.Text, cd_err_contp);
                c11 = emp_code_availaility_validator();

                if (c1 || c2 || c3 || c4 || c5 || c6 || c7 || c8 || c9 || c10 || c11)
                {
                    MessageBox.Show("Incomplete or Invalid information.", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (d == System.Windows.Forms.DialogResult.OK)
                    {
                        string empcode = cd_code.Text;
                        string resi_address = residance_add.Text;
                        string temp_address = temp_add.Text;
                        string resi_tp = residance_tp.Text;
                        string mobile = mobile_no.Text;
                        string pemail = person_email.Text;
                        string oemail = office_email.Text;
                        string con_person = contact_person.Text;
                        string relationship = relation.Text;
                        string con_tp = contact_tp.Text;


                        //MessageBox.Show(empcode + " " + resi_address + " " + temp_address + " " + resi_tp + " " + mobile + " " + pemail + " " + oemail + " " + con_person + " " + relationship + " " + con_tp);
                        setter.SendToDB("INSERT INTO employee_contacts(emp_code, residance_add, temp_address, residance_tpno, mobile_no, personal_email, office_email, contact_person, relationship, tp_contactPerson) VALUES ('" + empcode + "','" + resi_address + "','" + temp_address + "','" + resi_tp + "','" + mobile + "','" + pemail + "','" + oemail + "','" + con_person + "','" + relationship + "','" + con_tp + "')");
                        MessageBox.Show("Information successfully Submitted");
                    }
                }

            }
            else if (cd_empcode_lb.Visible == true)
            {
                c2 = fv.address_Validator(residance_add.Text, cd_err_resiadd);
                c3 = fv.address_Validator(temp_add.Text, cd_err_tempadd);
                c4 = fv.telephone_no_Vlidator(residance_tp.Text, cd_err_resitp);
                c5 = fv.telephone_no_Vlidator(mobile_no.Text, cd_err_mobile);
                c6 = fv.email_Validator(person_email.Text, cd_err_pemail);
                c7 = fv.email_Validator(office_email.Text, cd_err_oemail);
                c8 = fv.string_Validator(contact_person.Text, cd_err_conperson);
                c9 = fv.string_Validator(relation.Text, cd_err_relation);
                c10 = fv.isTelephone_Number(contact_tp.Text, cd_err_contp);

                if (c2 || c3 || c4 || c5 || c6 || c7 || c8 || c9 || c10)
                {
                    MessageBox.Show("Incomplete or Invalid information.", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (d == System.Windows.Forms.DialogResult.OK)
                    {
                        string empcode = cd_empcode_lb.Text;
                        string resi_address = residance_add.Text;
                        string temp_address = temp_add.Text;
                        string resi_tp = residance_tp.Text;
                        string mobile = mobile_no.Text;
                        string pemail = person_email.Text;
                        string oemail = office_email.Text;
                        string con_person = contact_person.Text;
                        string relationship = relation.Text;
                        string con_tp = contact_tp.Text;
                        //MessageBox.Show(empcode + " " + resi_address + " " + temp_address + " " + resi_tp + " " + mobile + " " + pemail + " " + oemail + " " + con_person + " " + relationship + " " + con_tp);
                        setter.SendToDB("INSERT INTO employee_contacts(emp_code, residance_add, temp_address, residance_tpno, mobile_no, personal_email, office_email, contact_person, relationship, tp_contactPerson) VALUES ('" + empcode + "','" + resi_address + "','" + temp_address + "','" + resi_tp + "','" + mobile + "','" + pemail + "','" + oemail + "','" + con_person + "','" + relationship + "','" + con_tp + "')");
                        MessageBox.Show("Information successfully Submitted");

                    }

                }
            }
        }

        public void cd_edit_Click(object sender, EventArgs e)
        {
            edit();
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
            cd_err_code.Visible = false;
            cd_err_resiadd.Visible = false;
            cd_err_tempadd.Visible = false;
            cd_err_resitp.Visible = false;
            cd_err_mobile.Visible = false;
            cd_err_pemail.Visible = false;
            cd_err_oemail.Visible = false;
            cd_err_conperson.Visible = false;
            cd_err_relation.Visible = false;
            cd_err_contp.Visible = false;
        }

        private void cd_getDetails_Click(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(cd_code.Text, cd_err_code);
            if (c == false)
            {
                residance_add.Enabled = true;
                temp_add.Enabled = true;
                residance_tp.Enabled = true;
                mobile_no.Enabled = true;
                person_email.Enabled = true;
                office_email.Enabled = true;
                contact_person.Enabled = true;
                relation.Enabled = true;
                contact_tp.Enabled = true;
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT * FROM employee_contacts WHERE emp_code = '" + cd_code.Text + "'");
                for (int i = 1; i < 10; i++)
                {
                    residance_add.Text = ds.Tables[0].Rows[0][1].ToString();
                    temp_add.Text = ds.Tables[0].Rows[0][2].ToString();
                    residance_tp.Text = ds.Tables[0].Rows[0][3].ToString();
                    mobile_no.Text = ds.Tables[0].Rows[0][4].ToString();
                    person_email.Text = ds.Tables[0].Rows[0][5].ToString();
                    office_email.Text = ds.Tables[0].Rows[0][6].ToString();
                    contact_person.Text = ds.Tables[0].Rows[0][7].ToString();
                    relation.Text = ds.Tables[0].Rows[0][8].ToString();
                    contact_tp.Text = ds.Tables[0].Rows[0][9].ToString();
                }
            }
        }

        private void cd_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to save the given Information", "Submition Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //*****
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                Boolean c2 = false;
                Boolean c3 = false;
                Boolean c4 = false;
                Boolean c5 = false;
                Boolean c6 = false;
                Boolean c7 = false;
                Boolean c8 = false;
                Boolean c9 = false;
                Boolean c10 = false;

                c2 = fv.address_Validator(residance_add.Text, cd_err_resiadd);
                c3 = fv.address_Validator(temp_add.Text, cd_err_tempadd);
                c4 = fv.telephone_no_Vlidator(residance_tp.Text, cd_err_resitp);
                c5 = fv.telephone_no_Vlidator(mobile_no.Text, cd_err_mobile);
                c6 = fv.email_Validator(person_email.Text, cd_err_pemail);
                c7 = fv.email_Validator(office_email.Text, cd_err_oemail);
                c8 = fv.string_Validator(contact_person.Text, cd_err_conperson);
                c9 = fv.string_Validator(relation.Text, cd_err_relation);
                c10 = fv.isTelephone_Number(contact_tp.Text, cd_err_contp);

                if (c2 || c3 || c4 || c5 || c6 || c7 || c8 || c9 || c10)
                {
                    MessageBox.Show("Incomplete or Invalid information.", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string empcode = cd_code.Text;
                    string resi_address = residance_add.Text;
                    string temp_address = temp_add.Text;
                    string resi_tp = residance_tp.Text;
                    string mobile = mobile_no.Text;
                    string pemail = person_email.Text;
                    string oemail = office_email.Text;
                    string con_person = contact_person.Text;
                    string relationship = relation.Text;
                    string con_tp = contact_tp.Text;


                    //MessageBox.Show(empcode + " " + resi_address + " " + temp_address + " " + resi_tp + " " + mobile + " " + pemail + " " + oemail + " " + con_person + " " + relationship + " " + con_tp);
                    //setter.SendToDB("INSERT INTO employee_contacts(emp_code, residance_add, temp_address, residance_tpno, mobile_no, personal_email, office_email, contact_person, relationship, tp_contactPerson) VALUES ('" + empcode + "','" + resi_address + "','" + temp_address + "','" + resi_tp + "','" + mobile + "','" + pemail + "','" + oemail + "','" + con_person + "','" + relationship + "','" + con_tp + "')");
                    setter.SendToDB("UPDATE employee_contacts SET residance_add = '" + resi_address + "', temp_address = '" + temp_address + "', residance_tpno = '" + resi_tp + "', mobile_no = '" + mobile + "', personal_email = '" + pemail + "', office_email = '" + oemail + "', contact_person = '" + con_person + "', relationship = '" + relationship + "', tp_contactPerson = '" + con_tp + "' WHERE emp_code = '" + cd_code.Text + "'");
                    MessageBox.Show("Changes saved successfully.");
                }
            }
        }

        private void cd_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void cd_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cd_next_Click(object sender, EventArgs e)
        {
            Qualifications form = new Qualifications();
            if (cd_empcode_lb.Visible == true || cd_code.Text != "")
            {
                DialogResult d = MessageBox.Show("Do you want to submit the Information?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (d == System.Windows.Forms.DialogResult.No)
                {
                    form.qual_empcode.Visible = true;
                    form.MdiParent = this.MdiParent;
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                form.qual_empcode.Visible = true;
                cd_code.Visible = true;
                form.MdiParent = this.MdiParent;
                form.Show();
                this.Hide();
            }
        }

//########
        private Boolean emp_code_availaility_validator()
        {
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM employee_contacts WHERE emp_code = '" + cd_code.Text + "'");
            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (i == 0)
            {
                return false;
            }
            else if (i != 0)
            {
                DialogResult d = MessageBox.Show("Contact details of this employee has already entered. Do you want to edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void edit()
        {
            DialogResult dr = MessageBox.Show("Please Enter The Employee Code", "Edit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ClearTextBoxes(this.Controls);
                cd_empcode_lb.Visible = false;
                cd_code.Visible = true;
                residance_add.Enabled = false;
                temp_add.Enabled = false;
                residance_tp.Enabled = false;
                mobile_no.Enabled = false;
                person_email.Enabled = false;
                office_email.Enabled = false;
                contact_person.Enabled = false;
                relation.Enabled = false;
                contact_tp.Enabled = false;
                cd_save.Visible = true;
                cd_getDetails.Visible = true;
            }
        }

        private void demo_Click(object sender, EventArgs e)
        {
            cd_code.Text = "E0006";
            residance_add.Text = "Negombo, Sri Lanka";
            temp_add.Text = "Colombo, Sri Lanka";
            residance_tp.Text = "0325567788";
            mobile_no.Text = "0771234567";
            person_email.Text = "shamini@gmail.com";
            office_email.Text = "shamini6@my.em.lk";
            contact_person.Text = "A.B.C.Fernando";
            relation.Text = "Mother";
            contact_tp.Text = "0714678950";
        }


       
    }
}
