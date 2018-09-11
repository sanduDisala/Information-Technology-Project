using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Main.Modules.Event
{
    public partial class Hire : Form
    {
        int count;
        string []Type=new string [3];
     
   
        public Hire()
        {
            InitializeComponent();
            count = 0;
        }

        string pce;
        string reg;
        string type;
        string cunt;

        private void Hire_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
            //DataSet dataset = new DBConnect().GetFromDB("select COUNT(*) from Hired_Compo_Details");
            //int hiredID = Convert.ToInt32(dataset.Tables[0].Rows[0][0]) + 1;
            //hire_id.Text = "EV0" + hiredID.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(dates.Text.ToString());
          

           // MessageBox.Show(theText);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //int date = Convert.ToInt32(dates.Text);
            //DateTime somedate = Convert.ToDateTime(hdates.Text);
            //somedate.AddDays(date);
            //rdates.Text = somedate.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

           // int date = int32.Parse(dates.Text);
            //MessageBox.Show(date.ToString());
            //DateTime somedate = Convert.ToDateTime(hdates.Text);
            //somedate.AddDays(date);
            //rdates.Text = somedate.ToString();
            //rdates.Text = hdates.Text + dates.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            if (event_name.Text == "Event name")
            {
                event_name.Text = "";
                event_name.ForeColor = Color.Black;

            }
        }

        private void con_Enter(object sender, EventArgs e)
        {
            if (con.Text == "Contact number")
            {
                con.Text = "";
                con.ForeColor = Color.Black;

            }
        }

        private void venu_Enter(object sender, EventArgs e)
        {
            if (venu.Text == "Venu")
            {
                venu.Text = "";
                venu.ForeColor = Color.Black;

            }
        }

        private void pr1_Enter(object sender, EventArgs e)
        {
            if (pr1.Text == "Pricing")
            {
                pr1.Text = "";
                pr1.ForeColor = Color.Black;

            }
        }

        private void pr2_Enter(object sender, EventArgs e)
        {
            if (pr2.Text == "Pricing")
            {
                pr2.Text = "";
                pr2.ForeColor = Color.Black;

            }
        }

        private void pr3_Enter(object sender, EventArgs e)
        {
            if (pr3.Text == "Pricing")
            {
                pr3.Text = "";
                pr3.ForeColor = Color.Black;

            }
        }

        private void cu1_Enter(object sender, EventArgs e)
        {
            if (cu1.Text == "Count")
            {
                cu1.Text = "";
                cu1.ForeColor = Color.Black;

            }
        }

        private void cu2_Enter(object sender, EventArgs e)
        {
            if (cu2.Text == "Count")
            {
                cu2.Text = "";
                cu2.ForeColor = Color.Black;

            }
        }

        private void cu3_Enter(object sender, EventArgs e)
        {
            if (cu3.Text == "Count")
            {
                cu3.Text = "";
                cu3.ForeColor = Color.Black;

            }
        }

        private void event_name_Leave(object sender, EventArgs e)
        {
            if (event_name.Text == "")
            {
                event_name.Text = "Event name";
                event_name.ForeColor = Color.Silver;
            }


            if (event_name.Text == "Event name")
            {
                ename.SetError(event_name, "Please enter the event name");
                ename.Icon = Properties.Resources.wrong;
            }
            else
            {
                ename.Dispose();
                DataSet dataset1 = new DBConnect().GetFromDB("select COUNT(*) from Hired_Compo_Details");
                int eventID = Convert.ToInt32(dataset1.Tables[0].Rows[0][0]) + 1;
                string id = event_name.Text.Substring(0, 2) + "-" + "HI0" + eventID;
                hire_id.Text = id;
            }
        }

        private void dates_Leave(object sender, EventArgs e)
        {
            if (dates.Text == "")
            {
                dates.Text = "No. of days";
                dates.ForeColor = Color.Silver;
            }


            if (dates.Text == "No. of days")
            {
                edates.SetError(dates, "Please enter the date count");
                edates.Icon = Properties.Resources.wrong;
            }
            else
            {
                edates.Dispose();
            }
        }

        private void con_Leave(object sender, EventArgs e)
        {
            if (con.Text == "")
            {
                con.Text = "Contact number";
                con.ForeColor = Color.Silver;
            }

            //if (!Regex.IsMatch(con.Text, @"^([0-9]{10})$"))
            //{
            //    econ.Icon = Properties.Resources.wrong;
            //    econ.SetError(con, "Invalid contact number");
            //}

            if (con.Text == "Contact number")
            {
                econ.SetError(con, "Please enter the contact number");
                econ.Icon = Properties.Resources.wrong;
            }
            else
            {
                econ.Dispose();
            }
        }

        private void venu_Leave(object sender, EventArgs e)
        {
            if (venu.Text == "")
            {
                venu.Text = "Venu";
                venu.ForeColor = Color.Silver;
            }


            if (venu.Text == "Venu")
            {
                evenu.SetError(venu, "Please enter the contact number");
                evenu.Icon = Properties.Resources.wrong;
            }
            else
            {
                evenu.Dispose();
            }
        }

 
        private void depo_Leave(object sender, EventArgs e)
        {
            if (depo.Text == "")
            {
                edp.SetError(depo, "Please enter the deposit");
                edp.Icon = Properties.Resources.wrong;
            }
            else
            {
                edp.Dispose();
            }
        }

        private void dates_Enter_1(object sender, EventArgs e)
        {
            if (dates.Text == "No. of days")
            {
                dates.Text = "";
                dates.ForeColor = Color.Black;

            }
        }

        private void dates_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void con_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void swc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void trn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void depo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void pr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void pr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void pr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cu3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void event_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void venu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            reg  = "No";
            if (n.Checked == true)
            {
                depo.Visible = true;
            }
            else
            {
                depo.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (led.Checked == true)
            {
                type = "LED screen";
                Type[count] = type;
                 count++;

                pr1.Visible = true;
                cu1.Visible = true;
                led.Enabled = false;
            }
            else
            {
                pr1.Visible = false;
                cu1.Visible = false;
            }
        }

        private void Is_CheckedChanged(object sender, EventArgs e)
        {
         
            if (Is.Checked == true)
            {
                type = "Interactive screen";
                Type[count] = type;
                count++;

                pr2.Visible = true;
                cu2.Visible = true;
                Is.Enabled = false;
            }
            else
            {
                pr2.Visible = false;
                cu2.Visible = false;
            }
        }

        private void ds_CheckedChanged(object sender, EventArgs e)
        {
           
            if (ds.Checked == true)
            {
                type = "Display screen";
                Type[count] = type;
                count++;

                pr3.Visible = true;
                cu3.Visible = true;
                ds.Enabled = false;
            }
            else
            {
                pr3.Visible = false;
                cu3.Visible = false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(event_name.Text, "Event name");
            Boolean c2 = v1.validateInput(dates.Text, "No. of days");
            Boolean c4 = v1.validateInput(con.Text, "Contact number");
            Boolean c5 = v1.validateInput(venu.Text, "Venu");
            Boolean c6 = v1.validateInput(swc.Text, "Software cost");
          //  Boolean c7 = v1.validateInput(pr1.Text, "Pricing");

            if (depo.Visible == true)
            {
                Boolean c8 = v1.validateInput(depo.Text, "Deposit");
            }

            if (c1 == true || c2 == true || c4 == true || c5 == true || c6 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    if (y.Checked == true)
                    {
                        reg = "Yes";
                    }

                    if (n.Checked == true)
                    {
                        reg = "No";
                    }

                    DBConnect b1 = new DBConnect();
                    b1.ConnectToDatabase();
                    for (int i = 0; i < count; i++)
                    {
                        if (Type[i] == "LED screen")
                        {
                            pce = pr1.Text;
                            cunt = cu1.Text;
                          string ty = Type[0];

                          b1.SendToDB("insert into Hired_Compo_Details (hire_id,hired_compo,price,count,event_name,date,no_of_date,phone,cus_name,venu,soft_cost,reg_cus,deposit,status) values('" + this.hire_id.Text + "','" + ty + "','" + pce + "','" + cunt + "','" + this.event_name.Text + "','" + this.hdates.Text + "','" + Convert.ToInt32(this.dates.Text).ToString() + "','" + Convert.ToInt32(this.con.Text).ToString() + "','" + this.cus_name.Text + "','" + this.venu.Text + "','" + this.swc.Text + "','" + reg + "','" + this.depo.Text + "','Hired')");
                        }

                        if (Type[i] == "Interactive screen")
                        {
                            pce = pr2.Text;
                            cunt = cu2.Text;
                            string ty = Type[i];

                            b1.SendToDB("insert into Hired_Compo_Details (hire_id,hired_compo,price,count,event_name,date,no_of_date,phone,cus_name,venu,soft_cost,reg_cus,deposit,status) values('" + this.hire_id.Text + "','"+ ty + "','" + pce + "','" + cunt + "','" + this.event_name.Text + "','" + this.hdates.Text + "','" + Convert.ToInt32(this.dates.Text).ToString() + "','" + Convert.ToInt32(this.con.Text).ToString() + "','" + this.cus_name.Text + "','" + this.venu.Text + "','" + this.swc.Text + "','" + reg + "','" + this.depo.Text + "','Hired')");
                            //  b1.SendToDB("insert into Hired_Compo_Details (hire_id,hired_compo,price,count,phone)values('" + this.hire_id.Text + "','" + ty + "','" + pce.ToString() + "','" + cunt.ToString() + "','" + Convert.ToInt32(this.con.Text) + "')");
                        }
                        if (Type[i] == "Display screen")
                        {
                            pce = pr3.Text;
                            cunt = cu3.Text;
                            string ty = Type[i];

                            b1.SendToDB("insert into Hired_Compo_Details (hire_id,hired_compo,price,count,event_name,date,no_of_date,phone,cus_name,venu,soft_cost,reg_cus,deposit,status) values('" + this.hire_id.Text + "','" + ty + "','" + pce + "','" + cunt + "','" + this.event_name.Text + "','" + this.hdates.Text + "','" + Convert.ToInt32(this.dates.Text).ToString() + "','" + Convert.ToInt32(this.con.Text).ToString() + "','" + this.cus_name.Text + "','" + this.venu.Text + "','" + this.swc.Text + "','" + reg + "','" + this.depo.Text + "','Hired')");
                        }

                        if (Type[i] == textBox1.Text)
                        {
                            pce = pr4.Text;
                            cunt = cu4.Text;
                            string ty = Type[i];

                            b1.SendToDB("insert into Hired_Compo_Details (hire_id,hired_compo,price,count,event_name,date,no_of_date,phone,cus_name,venu,soft_cost,reg_cus,deposit,status) values('" + this.hire_id.Text + "','" + ty + "','" + pce + "','" + cunt + "','" + this.event_name.Text + "','" + this.hdates.Text + "','" + Convert.ToInt32(this.dates.Text).ToString() + "','" + Convert.ToInt32(this.con.Text).ToString() + "','" + this.cus_name.Text + "','" + this.venu.Text + "','" + this.swc.Text + "','" + reg + "','" + this.depo.Text + "','Hired')");
                        }
                   
                    }
                    
                    MessageBox.Show("Saved");

                }

                else if (dia == DialogResult.No)
                {

                }


            }
        }

            private void event_name_TextChanged(object sender, EventArgs e)
        {
            //DataSet dataset1 = new DBConnect().GetFromDB("select COUNT(*) from Hired_Compo_Details");
            //int eventID = Convert.ToInt32(dataset1.Tables[0].Rows[0][0]) + 1;
            //string id = event_name.Text.Substring(0, 2) + "-" + "HI0" + eventID;
            //hire_id.Text = id;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void swc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depo_TextChanged(object sender, EventArgs e)
        {
            depo.ForeColor = Color.Black;
        }

        private void cus_name_Enter(object sender, EventArgs e)
        {
            if (cus_name.Text == "Customer name")
            {
                cus_name.Text = "";
                cus_name.ForeColor = Color.Black;

            }
        }

        private void cus_name_Leave(object sender, EventArgs e)
        {
            if (cus_name.Text == "")
            {
                cus_name.Text = "Customer name";
                cus_name.ForeColor = Color.Silver;
            }

            if (cus_name.Text == "Customer name")
            {
                cname.Icon = Properties.Resources.wrong;
                cname.SetError(cus_name, "Please enter the customer name");
            }
            else
            {
                cname.Dispose();
            }
        }

        private void swc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cus_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void swc_Enter(object sender, EventArgs e)
        {
            if (swc.Text == "Software cost")
            {
                swc.Text = "";
                swc.ForeColor = Color.Black;

            }
        }

        private void swc_Leave(object sender, EventArgs e)
        {
            if (swc.Text == "")
            {
                swc.Text = "Software cost";
                swc.ForeColor = Color.Silver;
            }

            if (swc.Text == "Software cost")
            {
                esw.Icon = Properties.Resources.wrong;
                esw.SetError(swc, "Please enter the customer name");
            }
            else
            {
                esw.Dispose();
            }
        }

        private void pr1_Leave(object sender, EventArgs e)
        {
            if (pr1.Text == "")
            {
                pr1.Text = "Pricing";
                pr1.ForeColor = Color.Silver;
            }

            if (pr1.Text == "Pricing")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(pr1, "Please enter the unit price name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void pr2_Leave(object sender, EventArgs e)
        {
            if (pr2.Text == "")
            {
                pr2.Text = "Pricing";
                pr2.ForeColor = Color.Silver;
            }

            if (pr2.Text == "Pricing")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(pr2, "Please enter the unit price name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void pr3_Leave(object sender, EventArgs e)
        {
            if (pr3.Text == "")
            {
                pr3.Text = "Pricing";
                pr3.ForeColor = Color.Silver;
            }

            if (pr3.Text == "Pricing")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(pr3, "Please enter the unit price name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void cu1_Leave(object sender, EventArgs e)
        {
            if (cu1.Text == "")
            {
                cu1.Text = "Count";
                cu1.ForeColor = Color.Silver;
            }

            if (cu1.Text == "Count")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(cu1, "Please enter the count name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void cu2_Leave(object sender, EventArgs e)
        {
            if (cu2.Text == "")
            {
                cu2.Text = "Count";
                cu2.ForeColor = Color.Silver;
            }

            if (cu2.Text == "Count")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(cu2, "Please enter the count name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void cu3_Leave(object sender, EventArgs e)
        {
            if (cu3.Text == "")
            {
                cu3.Text = "Count";
                cu3.ForeColor = Color.Silver;
            }

            if (cu3.Text == "Count")
            {
                epri.Icon = Properties.Resources.wrong;
                epri.SetError(cu3, "Please enter the count name");
            }
            else
            {
                epri.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
         
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            pr4.Visible = true;
            cu4.Visible = true;  
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    type = textBox1.Text;
            //    Type[count] = type;
            //    count++;
            //}
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string w = textBox1.Text;

            if (textBox1.Text == w )
            {
                type = textBox1.Text;
                Type[count] = type;
                count++;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            led.Checked = true;
            pr1.Text = "20000";
            pr1.ForeColor = Color.Black;
            cu1.TabIndex = 2;
           
            Is.Checked = true;
            pr2.Text = "30000";
            pr2.ForeColor = Color.Black;
            
            event_name.Text = "Thala'17";
            event_name.ForeColor = Color.Black;

            dates.Text = "1";
            dates.ForeColor = Color.Black;

            con.Text = "0774869421";
            con.ForeColor = Color.Black;

            cus_name.Text = "Sunimal Perera";
            cus_name.ForeColor = Color.Black;

            venu.Text = "Gampaha";
            venu.ForeColor = Color.Black;

            swc.Text = "None";
            swc.ForeColor = Color.Black;

            y.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel3.Visible = false;
            button3.Visible = false;
        }

      
    }
}
