using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Event
{
    public partial class Return : Form
    {
        int count;
        string[] Type = new string[3];
        string reg;
        string type;
      
        public Return()
        {
            InitializeComponent();
            count = 0;
        }

        //int count;
        //string[] Type = new string[3];
        //string reg;
        //string type;
      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment p1 = new payment();
            p1.Show();

            for (int i = 0; i <1; i++)
             {
                 p1.en.Items.Add(comboBox1.Text);

              }
            //p1.en.Text = comboBox1.Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            string name = comboBox1.Text;
            string sql = "select hire_id from Hired_Compo_Details where event_name='" + name + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            hid.Text = valu.Tables[0].Rows[0][0].ToString();

            string sql1 = "select hired_compo from Hired_Compo_Details where event_name='" + name + "'";

            DBConnect b2 = new DBConnect();
            b2.ConnectToDatabase();
            DataSet valu1 = b2.GetFromDB(sql1);

            for (int i = 0; i < valu1.Tables[0].Rows.Count; i++)
            {
                if (valu1.Tables[0].Rows[i][0].ToString() == "LED screen")
                {
                    checkBox1.Visible = true;
                  //  comboBox2.Visible = true;
                    checkBox2.Visible = false;
                    comboBox3.Visible = false;
                    checkBox3.Visible = false;
                    comboBox4.Visible = false;
                    panel3.Visible = false;

                }

                if (valu1.Tables[0].Rows[i][0].ToString() == "Interactive screen")
                {
                    checkBox2.Visible = true;
                   // comboBox3.Visible = true;
                    checkBox3.Visible = false;
                    comboBox4.Visible = false;
                    panel3.Visible = false;

                }

                if (valu1.Tables[0].Rows[i][0].ToString() == "Display screen")
                {
                    checkBox2.Visible = false;
                    checkBox3.Visible = true;
                   // comboBox4.Visible = true;
                    panel3.Visible = false;

                }
                if (valu1.Tables[0].Rows[i][0].ToString() != "LED screen" && valu1.Tables[0].Rows[i][0].ToString() != "Interactive screen" && valu1.Tables[0].Rows[i][0].ToString() != "Display screen")
                {
                    panel3.Visible = true;
                    textBox1.Text = valu1.Tables[0].Rows[i][0].ToString();
                    panel4.Visible = true;

  
                    string sql2 = "select count from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + textBox1.Text + "'";

                    DBConnect b3 = new DBConnect();
                    DataSet valu2 = b3.GetFromDB(sql2);



                    for (int k = 0; k < valu2.Tables[0].Rows.Count; k++)
                    {
                        label30.Text = valu2.Tables[0].Rows[k][0].ToString();
                    }

                }
            
            }

        }

        private void Return_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
            string sql = "select distinct event_name from Hired_Compo_Details where status!= 'Returned'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);

                for (int i = 0; i < valu.Tables[0].Rows.Count; i++)
                {
                    comboBox1.Items.Add(valu.Tables[0].Rows[i][0].ToString());

                }

        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "No")
            {
                erate1.Visible = true;

            }
            if (comboBox2.Text == "No")
            {
                erate1.Visible = false;
                ch1.Clear();
                ch1.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text != "No")
            {
                erate2.Visible = true;
            }

            if (comboBox3.Text == "No")
            {
                erate2.Visible = false;
                ch2.Clear();
                ch2.Visible = false;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text != "No")
            {
                erate3.Visible = true;
            }
            if (comboBox4.Text == "No")
            {
                erate3.Visible = false;
                ch3.Clear();
                ch3.Visible = false;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(comboBox1.Text, "Event name");
         //  Boolean c4 = v1.checkBox1.Checked ;

            if (c1 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    DBConnect b1 = new DBConnect();
                    b1.ConnectToDatabase();

                    for (int i = 0; i < count; i++)
                    {
                      //  MessageBox.Show(Type[i]);
                        
                        if (Type[i] == "LED screen")
                        {
                            if (radioButton1.Checked == true)
                            {
                                reg = "Yes";
                            }

                            if (radioButton7.Checked == true)
                            {
                                reg = "No";
                            }

                            string ty = Type[i];


                            b1.SendToDB("insert into Return_Compo (hire_id,event_name,hired_compo,count,lost,lcharge,damage,dcharge) values('" + this.hid.Text + "','" + this.comboBox1.Text + "','" + this.checkBox1.Text + "','"+label27.Text + "','" + this.comboBox2.Text + "','" + this.ch1.Text + "','" + reg + "','" + this.ch4.Text + "')");
                        }

                        if (Type[i] == "Interactive screen")
                        {
                           // MessageBox.Show("came here1");

                            if (radioButton3.Checked == true)
                            {
                                reg = "Yes";
                            }

                            if (radioButton2.Checked == true)
                            {
                                reg = "No";
                            }

                            string ty = Type[i];
                          //  MessageBox.Show("came here2");
                            b1.SendToDB("insert into Return_Compo (hire_id,event_name,hired_compo,count,lost,lcharge,damage,dcharge) values('" + this.hid.Text + "','" + this.comboBox1.Text + "','" + this.checkBox2.Text + "','"+label28.Text + "','" + this.comboBox3.Text + "','" + this.ch2.Text + "','" + reg + "','" + this.ch5.Text + "')");

                        }
                        if (Type[i] == "Display screen")
                        {
                            if (radioButton5.Checked == true)
                            {
                                reg = "Yes";
                            }

                            if (radioButton4.Checked == true)
                            {
                                reg = "No";
                            }

                            string ty = Type[i];

                            b1.SendToDB("insert into Return_Compo (hire_id,event_name,hired_compo,count,lost,lcharge,damage,dcharge) values('" + this.hid.Text + "','" + this.comboBox1.Text + "','" + this.checkBox3.Text + "','"+ label29.Text+"','" + this.comboBox4.Text + "','" + this.ch3.Text + "','" + reg + "','" + this.ch6.Text + "')");
                        }

                        if (Type[i] == textBox1.Text)
                        {
                            if (radioButton8.Checked == true)
                            {
                                reg = "Yes";
                            }

                            if (radioButton6.Checked == true)
                            {
                                reg = "No";
                            }

                            string ty = Type[i];

                            b1.SendToDB("insert into Return_Compo (hire_id,event_name,hired_compo,count,lost,lcharge,damage,dcharge) values('" + this.hid.Text + "','" + this.comboBox1.Text + "','" + this.textBox1.Text + "','"+ label30.Text+"','" + this.comboBox5.Text + "','" + this.ch7.Text + "','" + reg + "','" + this.textBox3.Text + "')");
                        }

                    }

                    MessageBox.Show("Saved");

                }
                else if (dia == DialogResult.No)
                {

                }


                calpay.Visible = true;
                back.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ch4.Visible = true;
            erate1.Visible = false;
            erate2.Visible = false;
            erate3.Visible = false;
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            ch4.Visible = false;
            erate1.Visible = false;
            erate2.Visible = false;
            erate3.Visible = false;
        }

        private void p1_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox2.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(p1.Text)) / 100) * Convert.ToInt32(count);

            ch1.Visible = true;
            ch1.Text = charge.ToString();
    
        }

        private void p2_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox2.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(p2.Text)) / 100) * Convert.ToInt32(count);

            ch1.Visible = true;
            ch1.Text = charge.ToString();
    

        }

        private void p1_Leave(object sender, EventArgs e)
        {
            p1.Checked = false;
        }

        private void p2_Leave(object sender, EventArgs e)
        {
            p2.Checked = false;
        }

        private void p3_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox2.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(p3.Text)) / 100) * Convert.ToInt32(count);

            ch1.Visible = true;
            ch1.Text = charge.ToString();
        }

        private void p3_Leave(object sender, EventArgs e)
        {
            p3.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox2.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox3.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox6.Text)) / 100) * Convert.ToInt32(count);

            ch2.Visible = true;
            ch2.Text = charge.ToString();
        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_Leave(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox2.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox3.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox5.Text)) / 100) * Convert.ToInt32(count);

            ch2.Visible = true;
            ch2.Text = charge.ToString();
        }

        private void checkBox5_Leave(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
        }

        private void checkBox4_Leave(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox2.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox3.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox4.Text)) / 100) * Convert.ToInt32(count);

            ch2.Visible = true;
            ch2.Text = charge.ToString();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox3.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox4.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox9.Text)) / 100) * Convert.ToInt32(count);

            ch3.Visible = true;
            ch3.Text = charge.ToString();
        }

        private void checkBox9_Leave(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox2.Visible = true;
                dam1.Visible = true;

                string name = comboBox1.Text;
                string ch = checkBox1.Text;
                string sql = "select count from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

                DBConnect b1 = new DBConnect();
                DataSet valu = b1.GetFromDB(sql);
               


                for (int i = 0; i < valu.Tables[0].Rows.Count; i++)
                {
                   // MessageBox.Show(valu.Tables[0].Rows[i][0].ToString());
                    int cunt = Convert.ToInt32(valu.Tables[0].Rows[i][0].ToString());
                    label27.Text = valu.Tables[0].Rows[i][0].ToString();

                    for (int j = 1; j <= cunt; j++)
                    {
                        comboBox2.Items.Add(j);
                    }
                }
                       
                type = "LED screen";
                Type[count] = type;
                count++;
                
            }

          

            if (checkBox1.Checked == false)
            {
                comboBox2.Visible = false;
                dam1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            erate1.Visible = false;

            if (checkBox2.Checked == true)
            {
                comboBox3.Visible = true;
                dam2.Visible = true;

                string name = comboBox1.Text;
                string ch = checkBox2.Text;
                string sql = "select count from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

                DBConnect b1 = new DBConnect();
                DataSet valu = b1.GetFromDB(sql);
         
                for (int i = 0; i < valu.Tables[0].Rows.Count; i++)
                {
                   // MessageBox.Show(valu.Tables[0].Rows[i][0].ToString());
                    int cunt = Convert.ToInt32(valu.Tables[0].Rows[i][0].ToString());
                    label28.Text = valu.Tables[0].Rows[i][0].ToString();

                    for (int j = 1; j <= cunt; j++)
                    {
                        comboBox3.Items.Add(j);
                    }
                }

                type = "Interactive screen";
                Type[count] = type;
                count++;
            }

            if (checkBox2.Checked == false)
            {
                comboBox3.Visible = false;
                dam2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            erate2.Visible = false;

            if (checkBox3.Checked == true)
            {
                comboBox4.Visible = true;
                dam3.Visible = true;

                string name = comboBox1.Text;
                string ch = checkBox3.Text;
                string sql = "select count from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

                DBConnect b1 = new DBConnect();
                DataSet valu = b1.GetFromDB(sql);

                for (int i = 0; i < valu.Tables[0].Rows.Count; i++)
                {
                    // MessageBox.Show(valu.Tables[0].Rows[i][0].ToString());
                    int cunt = Convert.ToInt32(valu.Tables[0].Rows[i][0].ToString());
                    label29.Text = valu.Tables[0].Rows[i][0].ToString();

                    for (int j = 1; j <= cunt; j++)
                    {
                        comboBox4.Items.Add(j);
                    }
                }

                type = "Display screen";
                Type[count] = type;
                count++;
            }
            if (checkBox3.Visible == false)
            {
                comboBox4.Visible = false;
                dam3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ch5.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ch6.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ch6.Visible = false;

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox3.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox4.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox8.Text)) / 100) * Convert.ToInt32(count);

            ch3.Visible = true;
            ch3.Text = charge.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = checkBox3.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox4.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox7.Text)) / 100) * Convert.ToInt32(count);

            ch3.Visible = true;
            ch3.Text = charge.ToString();
        }

        private void checkBox8_Leave(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
        }

        private void checkBox7_Leave(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Event name")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;

            }

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            // if()
            string name1 = comboBox1.Text;
            string ch = textBox1.Text;
            string s1 = "select count from Hired_Compo_Details where event_name='" + name1 + "' and hired_compo='" + ch + "'";

            DBConnect b3 = new DBConnect();
            DataSet valu2 = b3.GetFromDB(s1);

            for (int k = 0; k < valu2.Tables[0].Rows.Count; k++)
            {
                // MessageBox.Show(valu.Tables[0].Rows[i][0].ToString());
                int cunt = Convert.ToInt32(valu2.Tables[0].Rows[k][0].ToString());

                for (int j = 1; j <= cunt; j++)
                {
                    comboBox5.Items.Add(j);
                }
            }

            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Event name";
                comboBox1.ForeColor = Color.Silver;
            }


            if (comboBox1.Text == "Event name")
            {
                errorProvider1.SetError(comboBox1, "Please enter the event name");
                errorProvider1.Icon = Properties.Resources.wrong;
               
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
            }
            else 
            {
                errorProvider1.Dispose();
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                errorProvider1.Icon = Properties.Resources.message;
                errorProvider1.SetError(comboBox1, "Please select the event name");
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                errorProvider1.Icon = Properties.Resources.message;
                errorProvider1.SetError(comboBox2, "Please select the lost count");
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {

            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                errorProvider1.Icon = Properties.Resources.message;
                errorProvider1.SetError(comboBox3, "Please select the lost count");
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                errorProvider1.SetError(comboBox3, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                errorProvider1.Icon = Properties.Resources.message;
                errorProvider1.SetError(comboBox4, "Please select the lost count");
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                errorProvider1.SetError(comboBox4, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void ch4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ch4_Leave(object sender, EventArgs e)
        {
            if (ch4.Text == "")
            {
                errorProvider1.SetError(ch4, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void ch5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ch5_Leave(object sender, EventArgs e)
        {
            if (ch5.Text == "")
            {
                errorProvider1.SetError(ch5, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void ch6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ch6_Leave(object sender, EventArgs e)
        {
            if (ch6.Text == "")
            {
                errorProvider1.SetError(ch6, "Please enter the lost details");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.Text != "No")
            {
                erate4.Visible = true;
            }

            if (comboBox5.Text == "No")
            {
                erate4.Visible = false;
                ch7.Clear();
                ch7.Visible = false;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = textBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox5.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox12.Text)) / 100) * Convert.ToInt32(count);

            ch7.Visible = true;
            ch7.Text = charge.ToString();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = textBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox5.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox11.Text)) / 100) * Convert.ToInt32(count);

            ch7.Visible = true;
            ch7.Text = charge.ToString();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            string ch = textBox1.Text;
            string sql = "select price from Hired_Compo_Details where event_name='" + name + "' and hired_compo='" + ch + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            string a = valu.Tables[0].Rows[0][0].ToString();
            string count = comboBox5.Text;
            int charge = ((Convert.ToInt32(a) * Convert.ToInt32(checkBox10.Text)) / 100) * Convert.ToInt32(count);

            ch7.Visible = true;
            ch7.Text = charge.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = false;
        }

        private void ch6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_Leave(object sender, EventArgs e)
        {
            string w = textBox1.Text;

            if (textBox1.Text == w)
            {
                type = textBox1.Text;
                Type[count] = type;
                count++;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ch5.Visible = false;
        }

    }
}
