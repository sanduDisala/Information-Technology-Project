using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.Common;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Main.Modules.Event
{
    public partial class Bookings : Form
    {
       // public event EventHandler Leave;
        public string eventid;
        public Bookings()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string body = "<body><div style=" + "text-align:left padding-top:80" + "><p><b> Date: 15/11/2017 </b> </p><div class = " + "img1" + "><img src=https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL" + " width=" + "400" + "height=" + "100" + "style=" + "padding-left:80" + "></div></div><p><b> Dear Customer </b></p>" + cus_name.Text + "<p> Ticket count: " + cunt.Text + "</p><p>Amount : " + amt.Text + "</p></body>";

            new DBConnect().sendMail("event.management.em17@gmail.com", textto.Text, "Booking Information", body, "qkxlhdoqxadmhcap");
         //   new DBConnect().sendMailTest("event.management.em17@gmail.com", "lavasw95@gmail.com", body, "Lavanga", "Booking Info", "smtp.google.com", 587);
            MessageBox.Show("Email send successfully");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(event_name.Text, "Event name");
            Boolean c2 = v1.validateInput(cus_name.Text, "Customer name");
           Boolean c3 = v1.validateInput(cunt.Text, "Ticket count");

            if (c1 == true || c2 == true || c3 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    //Application.Exit();
                    DBConnect b2 = new DBConnect();
                    b2.ConnectToDatabase();
                 b2.SendToDB("insert into Booking_Details (booking_id,event_name,event_id,cus_name,count,date,amount) values('" + this.booking_id.Text + "','" + this.event_name.Text + "','" + this.event_id.Text + "','" + this.cus_name.Text + "','" + this.cunt.Text + "','" + this.dateTimePicker1.Text + "','" + this.amt.Text + "')");
                    MessageBox.Show("Saved");
                    button2.Visible = true;
                    
                }

                else if (dia == DialogResult.No)
                {

                }
            }

        }



        private void Bookings_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
            cunt.Visible = false;
            string sql = "select event_name from Event_Details where T_price is not null and T_price!='" + 0 + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();

            b1.SendToDB(sql);
            DataSet valu = b1.GetFromDB(sql);
     
            for (int i = 0; i < valu.Tables[0].Rows.Count; i++)
            {
                event_name.Items.Add(valu.Tables[0].Rows[i][0].ToString());
            }
        } 

        private void event_name_Enter(object sender, EventArgs e)
        {

            if (event_name.Text == "Event name")
            {
                event_name.Text = "";
                event_name.ForeColor = Color.Black;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (cus_name.Text == "Customer name")
            {
                cus_name.Text = "";
                cus_name.ForeColor = Color.Black;

            }
        }

        private void amt_Enter(object sender, EventArgs e)
        {
            if (amt.Text == "Total amount")
            {
                amt.Text = "";
                amt.ForeColor = Color.Black;

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
                ename.Icon = Properties.Resources.wrong;
                ename.SetError(event_name, "Please enter the event name");
            }
            else
            {
                cunt.Visible = true;
                ename.Dispose();
            }

            DataSet dataset1 = new DBConnect().GetFromDB("select COUNT(*) from Booking_Details");
            int eventID = Convert.ToInt32(dataset1.Tables[0].Rows[0][0]) + 1;
            string id = event_name.Text.Substring(0, 2) + "-" + "BI0" + eventID;
            booking_id.Text = id;
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

        private void amt_Leave(object sender, EventArgs e)
        {
            if (amt.Text == "")
            {
                amt.Text = "Total amount";
                amt.ForeColor = Color.Silver;
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

        private void cunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
          string sql = " Update Booking_Details set event_name='" + event_name.Text + "',event_id='" + event_id.Text + "',cus_name='" + cus_name.Text + "',count='" + cunt.Text + "',date='" + dateTimePicker1.Text + "',amount='" + amt.Text + "' where booking_id='" + booking_id.Text + "'";
            b1.SendToDB(sql);
            MessageBox.Show("Update !");
        }

        private void cunt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Count");
        }

        private void event_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = event_name.SelectedItem.ToString();
            string sql = "select event_id from Event_Details where event_name='" + name + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();

          //  b1.SendToDB(sql);
            DataSet valu = b1.GetFromDB(sql);
            event_id.Text = valu.Tables[0].Rows[0][0].ToString();

            DBConnect con = new DBConnect();
            SqlConnection conn = con.getconnection();
            //conn.Open();
           // SqlCommand cmd = new SqlCommand("select img from Event_Details where event_name='" + name + "'", conn);
            string sql1 = "select img from Event_Details where event_name='" + name + "'";

            if (conn.State != ConnectionState.Open)
                conn.Open();

            SqlCommand cmd = new SqlCommand(sql1, conn);

            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                byte[] img = (byte[])(rd[0]);
                if (img == null)
                    pictureBox1.Image = null;

                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            conn.Close();

           // SqlDataReader reader = cmd.ExecuteReader();
           // reader.Read();
           // MessageBox.Show(reader.ToString());
            //if (reader.HasRows)
            //{
                //byte[] pic = ((byte[])reader[0]);
              //  byte[] pic = (byte[])cmd.ExecuteScalar();


                //MemoryStream ms = new MemoryStream();
               
                //ms.Write(pic, 0, Convert.ToInt32(pic.Length));

                //BinaryWriter br = new BinaryWriter(ms);
              //  Bitmap bmp = new Bitmap(ms);//(ms, false);
               
                
                //if (pic == null)
                //{
                 //   pictureBox1.Image = null;
                //}
                //else
                //{
               //     //MemoryStream mstr = new MemoryStream(pic);
               // MemoryStream str = new MemoryStream();
               // str.Write(pic, 0, pic.Length);
               // Bitmap bit = new Bitmap(str);
                
               //// MemoryStream mstr = new MemoryStream(reader[0].GetHashCode());
               // //MessageBox.Show(reader[0].GetHashCode().ToString());
               //     // System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(mstr);
                
                    //pictureBox1.Image = Image.FromStream(mstr);
                //}
            //}


        }     
        
           // string sql1 = "select img from Event_Details where event_name='" + name + "'";
          //  DataSet valu1 =  b1.GetFromDB(sql1);
          //  //SqlDataReader dr = new SqlDataReader();
          //  //dr.Read();

          //  //for (int i = 0; i < valu.Tables[0].Columns.Count; i++)
          //  //{
          //     // event_name.Items.Add(valu.Tables[0].Rows[i][0].ToString());

          //  DataTable dt = new DataTable();
          ////  da = new SqlDataAdapter(valu1);
          //  da.Fill(dt);

          //      byte[] img = ((byte[])valu1.Tables[0].Rows[0][3]);
          //      MemoryStream mstr = new MemoryStream(img);
          //      pictureBox1.Image = Image.FromStream(mstr);

            //}
  
        
      

        private void cunt_Leave(object sender, EventArgs e)
        {
            if (cunt.Text == "")
            {
                cunt.Text = "Count";
                cunt.ForeColor = Color.Silver;
            }

            if (cunt.Text == "Count")
            {
                tcu.Icon = Properties.Resources.wrong;
                tcu.SetError(cunt, "Please enter the customer name");
            }
            else
            {
                tcu.Dispose();
                string eid = event_id.Text;

                DBConnect b1 = new DBConnect();

                DataSet valu = new DataSet();
                string sql = "select T_price from Event_Details where event_id= '" + eid + "' ";
                valu = b1.GetFromDB(sql);
                string price = valu.Tables[0].Rows[0][0].ToString();
                //  MessageBox.Show(valu.Tables[0].Rows[0][0].ToString());

                int amount = Convert.ToInt32(price) * Convert.ToInt32(cunt.Text);
                amt.Text = amount.ToString();
                amt.ForeColor = Color.Black;
            }

        }

        private void cunt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void event_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                ename.Icon = Properties.Resources.message;
                ename.SetError(event_name, "Please select the event name");
            }
        }

        private void cunt_Enter(object sender, EventArgs e)
        {
            if (cunt.Text == "Count")
            {
                cunt.Text = "";
                cunt.ForeColor = Color.Black;

            }
        }

        private void cunt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void booking_id_Click(object sender, EventArgs e)
        {

        }

        private void textto_Leave(object sender, EventArgs e)
        {
            string email = textto.Text;

            Validation v1 = new Validation();
            v1.emailIsValid(email);

            if (v1.emailIsValid(email))
            {
               // MessageBox.Show("Successfull");
            }
            else
              //  MessageBox.Show("Error");
            ename.Icon = Properties.Resources.wrong;
            ename.SetError(textto, "Please enter the correct email");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void amt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
