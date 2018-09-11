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
    public partial class Staff_Assign : Form
    {
        public Staff_Assign()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(emp_name.Text, "Event name");
            Boolean c2 = v1.validateInput(textBox2.Text, "Customer nameDesignation");

            if (c1 == true || c2 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes ");

            }

            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    //Application.Exit();
                    DBConnect b2 = new DBConnect();
                    b2.ConnectToDatabase();
                    b2.SendToDB("insert into Assing_Staff (emp_id,event_name,emp_name,designation) values('" + this.label6.Text + "','" +this.textBox1.Text+"','"+ this.emp_name.Text + "','" + this.textBox2.Text + "')");
                    MessageBox.Show("Saved");
                    // (ename.IconEnabled)
                }

                else if (dia == DialogResult.No)
                {

                }
            }

        

        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Designation")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Designation";
                textBox2.ForeColor = Color.Silver;
            }

            if (textBox2.Text == "Designation")
            {
                desig.Icon = Properties.Resources.wrong;
                desig.SetError(textBox2, "Please enter the designation");
            }
        }

        private void Staff_Assign_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void event_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void emp_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void emp_name_Enter(object sender, EventArgs e)
        {
            if (emp_name.Text == "Employee name")
            {
                emp_name.Text = "";
                emp_name.ForeColor = Color.Black;

            }
        }

        private void emp_name_Leave(object sender, EventArgs e)
        {
            string name = emp_name.Text;
            //  MessageBox.Show(name);
           // string sql = "select emp_code from employee_details where full_name='" + name + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();

           // b1.SendToDB(sql);
           // DataSet valu = b1.GetFromDB(sql);
            //  eventid = valu.Tables[0].Rows[0][0].ToString();
         //   label6.Text = valu.Tables[0].Rows[0][0].ToString();

            if (emp_name.Text == "")
            {
                emp_name.Text = "Event name";
                emp_name.ForeColor = Color.Silver;
            }

            if (emp_name.Text == "Event name")
            {
                ename.Icon = Properties.Resources.wrong;
                ename.SetError(emp_name, "Please enter the event name");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string body = "<body><div style=" + "text-align:left padding-top:80" + "><p><b> Date: 15/11/2017 </b> </p><div class = " + "img1" + "><img src=https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL" + " width=" + "400" + "height=" + "100" + "style=" + "padding-left:80" + "></div></div><p><b> Dear " + emp_name.Text + "</b></p>"+ "<p> You have assigned to the"+ " " + textBox1.Text + " " + "</p><p> To get more information about the event come and meet Managing Director of the company </p></p></body>";

            new DBConnect().sendMail("event.management.em17@gmail.com", textto.Text, "Assign an event Information", body, "qkxlhdoqxadmhcap");
            //   new DBConnect().sendMailTest("event.management.em17@gmail.com", "lavasw95@gmail.com", body, "Lavanga", "Booking Info", "smtp.google.com", 587);
            MessageBox.Show("Email send successfully");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void textto_Enter(object sender, EventArgs e)
        {
            label7.Visible = true;
            panel3.Visible = true;
        }
    }
}
