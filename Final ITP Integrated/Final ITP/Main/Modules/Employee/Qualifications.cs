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
    public partial class Qualifications : Form
    {
        string emp_id = "";
        string q_id = "";
        string e_id = "";
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        public Qualifications()
        {
            InitializeComponent();
            this.ActiveControl = qual_empcode;
        }

        private void Qualifications_Load(object sender, EventArgs e)
        {

        }

        private void qual_empcode_Leave(object sender, EventArgs e)
        {
            fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
        }

        private void edu_add_Click(object sender, EventArgs e)
        {
            string code = "";
            string id = "";
            //MessageBox.Show("emp_id" + emp_id + " q_id " + q_id + "e_id" + e_id);
            if (emp_id == "" && q_id == "")
            {
                Boolean c = fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
                Boolean check = fv.checkEmpty(qual_edu.Text, qual_err_edu);
                id = qual_id_generator(qualification_grid);
              

                if (check == false & c == false)
                {

                    if (qual_empcode.Visible == true)
                    {
                        code = qual_empcode.Text;
                    }
                    else if (qual_code_label.Visible == true)
                    {
                        code = qual_code_label.Text;
                    }
                    //MessageBox.Show(check + " " + id + " " + code + " " + qual_edu.Text);
                    qualification_grid.Rows.Add(code, id, qual_edu.Text, " ", " ");
                    qual_edu.Clear();
                }
            }
            else if (emp_id != "edited" & q_id != "edited")
            {
                if (fv.checkEmpty(qual_edu.Text, qual_err_edu) == false)
                {
                    code = emp_id;
                    id = q_id;
                    //MessageBox.Show(id + " " + code + " " + qual_edu.Text);
                    qualification_grid.Rows.Add(code, id, qual_edu.Text, " ", " ");
                    qual_edu.Clear();
                    emp_id = "edited";
                    q_id = "edited";
                }
            }
            else if (emp_id == "edited" && q_id == "edited")
            {
                MessageBox.Show("Please select the entry you want to Edit.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pro_add_Click(object sender, EventArgs e)
        {
            string code = "";
            string id = "";
            //MessageBox.Show("emp_id" + emp_id + " q_id " + q_id + "e_id" + e_id);
            if (emp_id == "" & q_id == "")
            {
                Boolean c = fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
                Boolean check = fv.checkEmpty(qual_pro.Text, qual_err_pro);
                id = qual_id_generator(qualification_grid);

                if (check == false & c == false)
                {
                    
            //        MessageBox.Show("check and c false","checkc");

                    if (qual_empcode.Visible == true)
                    {
                        code = qual_empcode.Text;
                    }
                    else if (qual_code_label.Visible == true)
                    {
                        code = qual_code_label.Text;
                    }
                    //MessageBox.Show(check + " " + id + " " + code + " " + qual_pro.Text);
                    qualification_grid.Rows.Add(code, id, " ", qual_pro.Text, " ");
                    qual_pro.Clear();
                }
            }
            else if (emp_id != "edited" & q_id != "edited")
            {
           //     MessageBox.Show("emp_id and q_id false", "empidqid");

                if (fv.checkEmpty(qual_pro.Text, qual_err_pro) == false)
                {
                    code = emp_id;
                    id = q_id;
                    //MessageBox.Show(id + " " + code + " " + qual_pro.Text);
                    qualification_grid.Rows.Add(code, id, " ", qual_pro.Text, "");
                    qual_pro.Clear();

                    emp_id = "edited";
                    q_id = "edited";
                }
            }
            else if (emp_id == "edited" & q_id == "edited")
            {
                MessageBox.Show("Please select the entry you want to Edit.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void other_add_Click(object sender, EventArgs e)
        {
            string code = "";
            string id = "";
            MessageBox.Show("Click add");
            //MessageBox.Show("emp_id" + emp_id + " q_id " + q_id + "e_id" + e_id);
            if (emp_id == "" & q_id == "")
            {
                Boolean c = fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
                Boolean check = fv.checkEmpty(qual_other.Text, qual_err_other);
                id = qual_id_generator(qualification_grid);

                if (check == false & c == false)
                {
                    //MessageBox.Show("click add new ");

                    if (qual_empcode.Visible == true)
                    {
                        code = qual_empcode.Text;
                    }
                    else if (qual_code_label.Visible == true)
                    {
                        code = qual_code_label.Text;
                    }
                   
                    //MessageBox.Show(check + " " + id + " " + code + " " + qual_other.Text);
                    qualification_grid.Rows.Add(code, id, " ", " ", qual_other.Text);
                    qual_other.Clear();
                }
                
            }
            else if (emp_id != "edited" & q_id != "edited")
            {
                if (fv.checkEmpty(qual_other.Text, qual_err_pro) == false)
                {
                    code = emp_id;
                    id = q_id;
                    //MessageBox.Show("click edit");
                    //MessageBox.Show(id + " " + code + " " + qual_other.Text);
                    qualification_grid.Rows.Add(code, id, " ", " ", qual_other.Text);
                    qual_other.Clear();
                    emp_id = "edited";
                    q_id = "edited";
                }
            }
            else if (emp_id == "edited" & q_id == "edited")
            {
                MessageBox.Show("Please select the entry you want to Edit.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exp_add_Click(object sender, EventArgs e)
        {
            string id = "";
            string code = "";
            string org = "";
            string dept = "";
            string pos = "";
            string from = "";
            string to = "";
           // MessageBox.Show("from = " + exp_from.Text + "currentt = " + DateTime.Now.Date + "to=" + exp_to.Text);
            Boolean c = fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
            Boolean c1 = fv.alphanumeric_Validator(exp_org.Text, exp_err_org);
            Boolean c2 = fv.fullname_Validator(exp_dept.Text, exp_err_dept);
            Boolean c3 = fv.fullname_Validator(exp_pos.Text, exp_err_pos);
            Boolean c4 = fv.date_Validator(DateTime.Parse(exp_from.Text), exp_err_from);
            Boolean c5 = fv.date_Validator(DateTime.Parse(exp_to.Text), exp_err_to);
            Boolean c6 = false;
            if (DateTime.Parse(exp_from.Text) >= DateTime.Parse(exp_to.Text))
            {
                exp_err_to.Text = "*Invalid Date.Please try again";
                exp_err_to.Visible = true;
                c6 = true;
            }
            //MessageBox.Show("emp_id"+emp_id+" q_id "+q_id + "e_id"+e_id);
            if (emp_id == "" && e_id == "")
            {
                
                id = exp_id_generator(exp_grid);

                if ((c || c1 || c2 || c3 || c4 || c5 || c6) == false)
                {
                    if (qual_empcode.Visible == true)
                    {
                        code = qual_empcode.Text;
                    }
                    else if (qual_code_label.Visible == true)
                    {
                        code = qual_code_label.Text;
                    }
                    //MessageBox.Show("code = "+code+"id ="+id+" org = "+exp_org.Text+"dept = "+exp_dept.Text+"pos = "+exp_pos.Text+"from = "+exp_from.Value.ToString("yyyy-MM-dd")+" to ="+exp_to.Value.ToString("yyyy-MM-dd"));
                    org = exp_org.Text;
                    dept = exp_dept.Text;
                    pos = exp_pos.Text;
                    from = exp_from.Value.ToString("yyyy-MM-dd");
                    to = exp_to.Value.ToString("yyyy-MM-dd");
                    exp_grid.Rows.Add(code, id, org, dept, pos, from, to);
                    
                }
            }
            else if (emp_id != "edited" && e_id != "edited")
            {
                if ((c1 || c2 || c3 || c4 || c5||c6) == false)
                {
                    code = emp_id;
                    id = e_id;
                    //MessageBox.Show(id + " " + code + " " + qual_pro.Text);
                    org = exp_org.Text;
                    dept = exp_dept.Text;
                    pos = exp_pos.Text;
                    from = exp_from.Value.ToString("yyyy-MM-dd");
                    to = exp_to.Value.ToString("yyyy-MM-dd");
                    exp_grid.Rows.Add(code, id, org, dept, pos, from, to);
                    emp_id = "edited";
                    e_id = "edited";
                }
            }
            else if (emp_id == "edited" && e_id == "edited")
            {
                MessageBox.Show("Please select the entry you want to Edit.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //*****
        public string qual_id_generator( DataGridView grid)
        {
            string code = "";
            if (qual_empcode.Visible == true)
            {
                code = qual_empcode.Text;
            }
            else if (qual_code_label.Visible == true)
            {
                code = qual_code_label.Text;
            }
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM qualifications WHERE emp_code = '" + code + "'");
            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (grid.Rows.Count == 0)
            {
                //MessageBox.Show("grid row count is zero");
                if (i == 0)
                {
                    //MessageBox.Show("db row count is zero");
                    //MessageBox.Show("i data rows in db = " + i);
                    i.ToString();
                    i++;
                    return (code + "-" + i);
                }
                else
                {
                    //MessageBox.Show("db row count not zero");
                    ds = setter.GetFromDB("SELECT TOP 1 qual_id FROM qualifications WHERE emp_code = '"+code+"' ORDER BY qual_id DESC");
                    string c = ds.Tables[0].Rows[0][0].ToString();
                   // MessageBox.Show("string c = " + c);
                    char k = c[c.LastIndexOf('-')+1];
                   // MessageBox.Show("char k = " + k);
                    k.ToString();
                    k++;
                    return (code+"-" + k);
                }
            }
            else
            {

                string s = grid.Rows[grid.RowCount-1].Cells[1].Value.ToString();
                //MessageBox.Show("j == "+s);
                char d = s[s.LastIndexOf('-') + 1];
                //MessageBox.Show("char d = " + d);
                d.ToString();
                d++;
                return (code + "-" + d);
            }

        }

        public string exp_id_generator(DataGridView grid)
        {
            string code = "";
            if (qual_empcode.Visible == true)
            {
                code = qual_empcode.Text;
            }
            else if (qual_code_label.Visible == true)
            {
                code = qual_code_label.Text;
            }
            DataSet ds = new DataSet();
            ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM experiances WHERE emp_code = '" + code + "'");
            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            if (grid.Rows.Count == 0)
            {

               // MessageBox.Show("grid row count is zero");
                if (i == 0)
                {
                    //MessageBox.Show("db row count is zero");
                    //MessageBox.Show("i data rows in db = " + i);
                    i.ToString();
                    i++;
                    return (code + ":" + i);
                }
                else
                {
                    //MessageBox.Show("db row count not zero");
                    ds = setter.GetFromDB("SELECT TOP 1 exp_id FROM experiances WHERE emp_code = '" + code + "' ORDER BY exp_id DESC");
                    string c = ds.Tables[0].Rows[0][0].ToString();
                   // MessageBox.Show("string c = " + c);
                    char k = c[c.LastIndexOf(':') + 1];
                   // MessageBox.Show("char k = " + k);
                    k.ToString();
                    k++;
                    return (code + ":" + k);
                }
            }
            else
            {
                string s = grid.Rows[grid.RowCount - 1].Cells[1].Value.ToString();
                MessageBox.Show("j == " + s);
                char d = s[s.LastIndexOf(':') + 1];
                MessageBox.Show("char d = " + d);
                d.ToString();
                d++;
                return (code + ":" + d);
            }

        }
        //**********
        private void qual_submit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                string code = " ";
                for (int i = 0; i < qualification_grid.Rows.Count; i++)
                {
                    if (qualification_grid.Rows[i].Cells[0].Value == null)
                    {
                        //MessageBox.Show("error" + exp_grid.Rows[i]);
                        continue;
                    }
                    else
                    {
                        code = qualification_grid.Rows[i].Cells[0].Value.ToString();
                    }

                    string id = qualification_grid.Rows[i].Cells[1].Value.ToString();
                    string edu = "";
                    string pro = "";
                    string other = "";
                    if (qualification_grid.Rows[i].Cells[2].Value.ToString() == " ")
                    {
                        //MessageBox.Show("edu empty");
                        if (qualification_grid.Rows[i].Cells[3].Value.ToString() == " ")
                        {
                            //MessageBox.Show("edu and pro empty");
                            edu = null;
                            pro = null;
                            other = qualification_grid.Rows[i].Cells[4].Value.ToString();
                        }
                        else
                        {
                            //MessageBox.Show("edu and other empty");
                            edu = null;
                            pro = qualification_grid.Rows[i].Cells[3].Value.ToString();
                            other = null;
                        }

                    }
                    else
                    {
                        //MessageBox.Show("pro and other empty");
                        edu = qualification_grid.Rows[i].Cells[2].Value.ToString();
                        pro = null;
                        other = null;
                    }


                    setter.SendToDB("INSERT INTO qualifications(emp_code, qual_id, edu_qual, prof_qual, other_qual) VALUES ('" + code + "', '" + id + "', '" + edu + "', '" + pro + "', '" + other + "')");
                }

                qualification_grid.Rows.Clear();
            }
        }

        private void exp_submit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to submit the given Information", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < exp_grid.Rows.Count; i++)
                {
                    string code = "";
                    if (exp_grid.Rows[i].Cells[0].Value == null)
                    {
                        //MessageBox.Show("error" + qualification_grid.Rows[i]);
                        continue;
                    }
                    else
                    {
                        code = exp_grid.Rows[i].Cells[0].Value.ToString();
                    }

                    string id = exp_grid.Rows[i].Cells[1].Value.ToString();
                    string org = exp_grid.Rows[i].Cells[2].Value.ToString();
                    string dept = exp_grid.Rows[i].Cells[3].Value.ToString();
                    string pos = exp_grid.Rows[i].Cells[4].Value.ToString();
                    string from = exp_grid.Rows[i].Cells[5].Value.ToString();
                    string to = exp_grid.Rows[i].Cells[6].Value.ToString();

                    setter.SendToDB("INSERT INTO experiances(emp_code, exp_id, org_name, department, position, from_date, to_date) VALUES ('" + code + "','" + id + "','" + org + "','" + dept + "','" + pos + "','" + from + "','" + to + "')");
                    MessageBox.Show("Data submitted Successfully");
                }
                exp_grid.Rows.Clear();
            }
        }

        private void qual_edit_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            qualification_grid.Rows.Clear();
            exp_grid.Rows.Clear();
            DialogResult dr = MessageBox.Show("Please Enter The Employee Code", "Edit",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                qual_empcode.Visible = true;
                qual_code_label.Visible = false;
                edu_add.Enabled = false;
                pro_add.Enabled = false;
                other_add.Enabled = false;
                exp_add.Enabled = false;
                exp_clear.Enabled = false;
                qual_edu.Enabled = false;
                qual_pro.Enabled = false;
                qual_other.Enabled = false;
                exp_org.Enabled = false;
                exp_dept.Enabled = false;
                exp_pos.Enabled = false;
                exp_from.Enabled = false;
                exp_to.Enabled = false;
                qual_getDetails.Visible = true;
                qual_save.Visible = true;
                exp_save.Visible = true;
                qual_submit.Visible = false;
                exp_submit.Visible = false;
                exp_clear.Visible = false;
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
                qual_err_empcode.Visible = false;
                qual_err_edu.Visible = false;
                qual_err_pro.Visible = false;
                qual_err_other.Visible = false;
                exp_err_org.Visible = false;
                exp_err_dept.Visible = false;
                exp_err_pos.Visible = false;
                exp_err_from.Visible = false;
                exp_err_to.Visible = false;
            }
        }

        private void qual_getDetails_Click(object sender, EventArgs e)
        {
            Boolean c = fv.empcode_validator(qual_empcode.Text, qual_err_empcode);
            if (c == false)
            {
                DataSet ds = new DataSet();
                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM qualifications WHERE emp_code = '" + qual_empcode.Text + "'");
                int rowCount = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                //MessageBox.Show("rowCount = " + rowCount);
                if (rowCount > 0)
                {
                    ds = setter.GetFromDB("SELECT * FROM qualifications WHERE emp_code = '" + qual_empcode.Text + "'");
                    for (int i = 0; i < rowCount; i++)
                    {
                        string code = ds.Tables[0].Rows[i][0].ToString();
                        string id = ds.Tables[0].Rows[i][1].ToString();
                        string edu = ds.Tables[0].Rows[i][2].ToString();
                        string pro = ds.Tables[0].Rows[i][3].ToString();
                        string other = ds.Tables[0].Rows[i][4].ToString();
                        qualification_grid.Rows.Add(code, id, edu, pro, other);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry,No any Qualification entries for this employee");
                }

                ds = setter.GetFromDB("SELECT COUNT(emp_code) FROM experiances WHERE emp_code = '" + qual_empcode.Text + "'");
                int e_rowCount = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                //MessageBox.Show("rowCount = " + e_rowCount);
                ds = setter.GetFromDB("SELECT * FROM experiances WHERE emp_code = '" + qual_empcode.Text + "'");
                if (e_rowCount > 0)
                {
                    for (int i = 0; i < e_rowCount; i++)
                    {
                        string ecode = ds.Tables[0].Rows[i][0].ToString();
                        string eid = ds.Tables[0].Rows[i][1].ToString();
                        string org = ds.Tables[0].Rows[i][2].ToString();
                        string dept = ds.Tables[0].Rows[i][3].ToString();
                        string pos = ds.Tables[0].Rows[i][4].ToString();
                        string from = ds.Tables[0].Rows[i][5].ToString();
                        string to = ds.Tables[0].Rows[i][6].ToString();
                        exp_grid.Rows.Add(ecode, eid, org, dept, pos, from, to);
                    }
                }
                else
                {
                    MessageBox.Show("Sorry,No any Experiances entries for this employee");
                }
                if (rowCount > 0 || e_rowCount > 0)
                {
                    MessageBox.Show("Please select the entry you want to Edit."," ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        }

        private void qualification_grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (qualification_grid.Rows.Count > 0)
            {
                edu_add.Enabled = true;
                pro_add.Enabled = true;
                other_add.Enabled = true;
                qual_edu.Enabled = true;
                qual_pro.Enabled = true;
                qual_other.Enabled = true;
                int index = qualification_grid.CurrentCell.RowIndex;
                emp_id = qualification_grid.Rows[index].Cells[0].Value.ToString();
                q_id = qualification_grid.Rows[index].Cells[1].Value.ToString();
                qual_edu.Text = qualification_grid.Rows[index].Cells[2].Value.ToString();
                qual_pro.Text = qualification_grid.Rows[index].Cells[3].Value.ToString();
                qual_other.Text = qualification_grid.Rows[index].Cells[4].Value.ToString();
                qualification_grid.Rows.RemoveAt(index);
                qual_del.Visible = true;
            }
        }

        private void exp_grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (exp_grid.Rows.Count > 0)
            {
                exp_add.Enabled = true;
                exp_clear.Enabled = true;
                exp_org.Enabled = true;
                exp_dept.Enabled = true;
                exp_pos.Enabled = true;
                exp_from.Enabled = true;
                exp_to.Enabled = true;
                int index = exp_grid.CurrentCell.RowIndex;
                emp_id = exp_grid.Rows[index].Cells[0].Value.ToString();
                e_id = exp_grid.Rows[index].Cells[1].Value.ToString();
                exp_org.Text = exp_grid.Rows[index].Cells[2].Value.ToString();
                exp_dept.Text = exp_grid.Rows[index].Cells[3].Value.ToString();
                exp_pos.Text = exp_grid.Rows[index].Cells[4].Value.ToString();
                exp_from.Text = exp_grid.Rows[index].Cells[5].Value.ToString();
                exp_to.Text = exp_grid.Rows[index].Cells[6].Value.ToString();
                exp_grid.Rows.RemoveAt(index);
                exp_del.Visible = true;
            }
        }

        private void exp_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Save the Changes?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                string id = "";
                string code = "";
                string org = "";
                string dept = "";
                string pos = "";
                string from = "";
                string to = "";
                for (int i = 0; i < exp_grid.Rows.Count; i++)
                {
                    code = exp_grid.Rows[i].Cells[0].Value.ToString();
                    id = exp_grid.Rows[i].Cells[1].Value.ToString();
                    org = exp_grid.Rows[i].Cells[2].Value.ToString();
                    dept = exp_grid.Rows[i].Cells[3].Value.ToString();
                    pos = exp_grid.Rows[i].Cells[4].Value.ToString();
                    from = exp_grid.Rows[i].Cells[5].Value.ToString();
                    to = exp_grid.Rows[i].Cells[6].Value.ToString();
                    //MessageBox.Show("emppid="+code+"eid="+id+"org="+org+"pos="+pos+"from="+from+"to="+to);
                    setter.SendToDB("UPDATE experiances SET org_name = '" + org + "', department = '" + dept + "', position = '" + pos + "', from_date = '" + from + "', to_date = '" + to + "' WHERE exp_id = '" + id + "' AND emp_code = '" + code + "'");
                    
                             
                }
                MessageBox.Show("Changes saved successfully");
                exp_grid.Rows.Clear();   
                exp_del.Visible = false;
                exp_clear_Click(sender, e);
            }
        }

        private void qual_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to save the Changes?", "Submition Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.OK)
            {
                string code = "";
                string id = "";
                string edu = "";
                string pro = "";
                string other = "";
                for (int i = 0; i < qualification_grid.Rows.Count; i++)
                {
                    code = qualification_grid.Rows[i].Cells[0].Value.ToString();
                    id = qualification_grid.Rows[i].Cells[1].Value.ToString();
                    edu = qualification_grid.Rows[i].Cells[2].Value.ToString();
                    pro = qualification_grid.Rows[i].Cells[3].Value.ToString();
                    other = qualification_grid.Rows[i].Cells[4].Value.ToString();
                    setter.SendToDB("UPDATE qualifications SET edu_qual = '" + edu + "', prof_qual = '" + pro + "', other_qual = '" + other + "' WHERE qual_id = '" + id + "' AND emp_code = '" + code + "'");
                             
                }
                MessageBox.Show("Changes saved successfully");
                qualification_grid.Rows.Clear();
                qual_del.Visible = false;
                qual_edu.Text = "";
                qual_pro.Text = "";
                qual_other.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void qual_del_Click(object sender, EventArgs e)
        {
            
            DialogResult d = MessageBox.Show("Do you want to delete this Entry?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                qual_edu.Text = "";
                qual_pro.Text = "";
                qual_other.Text = "";
                setter.SendToDB("DELETE FROM qualifications WHERE qual_id = '"+q_id+"'");
                MessageBox.Show("Entry has successfully Deleted");
            }
           
        }

        private void exp_del_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to delete this Entry?","Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                exp_clear_Click(sender, e);
                setter.SendToDB("DELETE FROM experiances WHERE exp_id = '"+e_id+"'");
                MessageBox.Show("Entry has successfully Deleted");
            }
        }

        private void exp_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void demo_Click(object sender, EventArgs e)
        {
            qual_edu.Text = "Pass O/L with 9A";
            qual_pro.Text = "Proffesional Member of ABC Association";
            qual_other.Text = "SLIIT Basket Ball team Captain";
            exp_org.Text = "WSO2";
            exp_dept.Text = "IT";
            exp_pos.Text = "Software Engineer";
            //exp_from.Text = "7/20/2016";
            //exp_to.Text = "12/20/2016";
        }

        



    }
}
