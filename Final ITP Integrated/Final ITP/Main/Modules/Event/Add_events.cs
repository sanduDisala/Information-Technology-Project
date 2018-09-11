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



namespace Main.Modules.Event
{
    public partial class Add_events : Form
    {
       // List<Event_Details> list;

        public Add_events()
        {
            InitializeComponent();

        }

        string type;
        string spon;
        string imgloc = "";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_events_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Select Item
            DataSet dataset = new DBConnect().GetFromDB("select COUNT(*) from Event_Details");
            int eventID = Convert.ToInt32(dataset.Tables[0].Rows[0][0]) + 1;
            string id = cat.Text.Substring(0, 2) + "-" + "EI0" + eventID;
            event_id.Text = id;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void full_CheckedChanged(object sender, EventArgs e)
        {
            spon = "Full coverage";
            if (full.Checked == true)
            {
                price.Visible = true;

            }
            else
            {
                price.Visible = false;
            }
        }

        private void part_CheckedChanged(object sender, EventArgs e)
        {
            spon = "Partnership";

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //byte[] ConvertImageToBinary(Image img)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        return ms.ToArray();
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            

            assign.Visible = true;

            if (indoor.Checked == true)
            {
                type = "Indoor";
            }

            if (outdoor.Checked == true)
            {
                type = "Outdoor";
            }

            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(event_name.Text, "Event name");
            Boolean c2 = v1.validateInput(cat.Text, "Category");
            Boolean c3 = v1.validateInput(venu.Text, "Venu");
            Boolean c4;

            if (price.Visible == true)
            {
                c4 = v1.validateInput(price.Text, "");

            }

            if (c1 == true || c2 == true || c3 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                
            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    byte[] images = null;
                    FileStream strm = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(strm);
                    images = brs.ReadBytes((int)strm.Length);

    
                    DBConnect b1 = new DBConnect();
                    b1.ConnectToDatabase();
                  //  Image pic = ConvertImageToBinary(pictureBox1.Image);
                 //   b1.SendToDB("insert into Event_Details (event_id,event_name,category,type,venu,date,time,spon_type,T_price,img) values('" + this.event_id.Text + "','" + this.event_name.Text + "','" + this.cat.Text + "','" + type + "','" + this.venu.Text + "','" + this.datepick.Text + "','" + this.timepick.Text + "','" + spon + "','" + this.price.Text +"',@images");
                   string sql = "insert into Event_Details (event_id,event_name,category,type,venu,date,time,spon_type,T_price,img) values('" + this.event_id.Text + "','" + this.event_name.Text + "','" + this.cat.Text + "','" + type + "','" + this.venu.Text + "','" + this.datepick.Text + "','" + this.timepick.Text + "','" + spon + "','" + this.price.Text +"',@images)";
                  

            SqlConnection conn = b1.getconnection();
            if(conn.State != ConnectionState.Open)
                   conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int x = cmd.ExecuteNonQuery();
             MessageBox.Show("Saved");
             conn.Close();

                }

                else if (dia == DialogResult.No)
                {

                }

                MessageBox.Show("Assign staff members to the event ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



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

        private void cat_Enter(object sender, EventArgs e)
        {
            if (cat.Text == "Category")
            {
                cat.Text = "";
                cat.ForeColor = Color.Black;

            }
        }

        private void cat_Leave(object sender, EventArgs e)
        {
            if (cat.Text == "")
            {
                cat.Text = "Category";
                cat.ForeColor = Color.Silver;
            }

            if (cat.Text == "Category")
            {
                ecat.Icon = Properties.Resources.wrong;
                ecat.SetError(cat, "Please enter the category");
            }
            else
            {
                ecat.Dispose();
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

        private void venu_Leave(object sender, EventArgs e)
        {
            if (venu.Text == "")
            {
                venu.Text = "Venu";
                venu.ForeColor = Color.Silver;
            }

            if (venu.Text == "Venu")
            {
                evenu.Icon = Properties.Resources.wrong;
                evenu.SetError(venu, "Please enter the venu");
            }
            else
            {
                evenu.Dispose();
            }

        }

        private void date_Enter(object sender, EventArgs e)
        {
            if (datepick.Text == "DD/MM/YYYY")
            {
                datepick.Text = "";
                datepick.ForeColor = Color.Black;

            }
        }

        private void date_Leave(object sender, EventArgs e)
        {
            if (datepick.Text == "")
            {
                datepick.Text = "Venu";
                datepick.ForeColor = Color.Silver;
            }
        }

        private void time_Enter(object sender, EventArgs e)
        {
            if (timepick.Text == "Time")
            {
                timepick.Text = "";
                timepick.ForeColor = Color.Black;

            }
        }

        private void time_Leave(object sender, EventArgs e)
        {
            if (timepick.Text == "")
            {
                timepick.Text = "Venu";
                timepick.ForeColor = Color.Silver;
            }
        }

        private void event_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void cat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
                ecat.Icon = Properties.Resources.message;
                ecat.SetError(cat, "Please select the category");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void venu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void indoor_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void outdoor_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void indoor_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Assign s1 = new Staff_Assign();
            s1.Show();
            // Staff_Assign s1 = new Staff_Assign();
            s1.textBox1.Text = event_name.Text;
            s1.textBox1.ForeColor = Color.Black;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            //event_id.Text = "In-EI00";
            ename.Dispose();
            event_name.Text = "Info Tel";
            event_name.ForeColor = Color.Black;
            cat.Text = "Exhibition";
            cat.ForeColor = Color.Black;
            indoor.Checked = true;
            venu.Text = "BMICH";
            venu.ForeColor = Color.Black;
            //timepick.Text = "10.00 AM";
            part.Checked = true;



        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void event_id_Click(object sender, EventArgs e)
        {

        }
        //public string geteventid()
        //{

        //    DataSet dataset = new DBConnect().GetFromDB("select COUNT(*) from Event_Details");
        //    int eventID = Convert.ToInt32(dataset.Tables[0].Rows[0][0]) + 1;
        //    string id = cat.Text.Substring(0, 2) + "-" + "EI0" + eventID;
        //    return id;
        //}

        private void outdoor_Leave(object sender, EventArgs e)
        {

        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                eprice.Icon = Properties.Resources.wrong;
                eprice.SetError(price, "Please enter the venu");
            }
            else
            {
                eprice.Dispose();
            }
        }

        private void event_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bupdate_Click(object sender, EventArgs e)
        {

            if (indoor.Checked == true)
            {
                type = "Indoor";
            }

            if (outdoor.Checked == true)
            {
                type = "Outdoor";
            }

            DBConnect b1 = new DBConnect();
            // b1.ConnectToDatabase();
            string sql = " Update Event_Details set event_name='" + event_name.Text + "',category='" + cat.Text + "',type='" + type + "',venu='" + venu.Text + "',date='" + datepick.Text + "',time='" + timepick.Text + "',spon_type='" + spon + "' where event_id='" + event_id.Text + "'";
            b1.SendToDB(sql);
            MessageBox.Show(venu.Text);
            MessageBox.Show("Update !");

            //DataSet set = new DataSet();
            //set = con.GetFromDB(sql);
            //View_event_D v = new View_event_D();
            //view.DataSource = set.Tables[0];

        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void brws_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dia.ShowDialog() == DialogResult.OK)
            {
                
                imgloc = dia.FileName;
                pictureBox1.ImageLocation = imgloc;
                
            }



        }
    }
}
