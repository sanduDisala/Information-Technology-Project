using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main.Modules.Customer
{
    public partial class Form1 : Form
    {

        /*SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=CustomerMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader mdr;*/


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Search main = new Search();
            panel1.Controls.Clear();
            main.TopLevel = false;
            main.Dock = DockStyle.Fill;
            panel1.Controls.Add(main);
            main.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customer_reg_Click(object sender, EventArgs e)
        {
            Customer_Info a1 = new Customer_Info();
            //this.MdiChildren = a1;
            a1.TopLevel = false;
            a1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(a1);
            a1.Show();
            //this.Hide();
        }

        private void get_order_Click(object sender, EventArgs e)
        {
            Make_Order_Copy m1 = new Make_Order_Copy();
            m1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(m1);
            m1.Show();
        }

        private void payment_Click(object sender, EventArgs e)
        {
            Payments p1 =  new Payments();
            p1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(p1);
            p1.Show();
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            Email f1 = new Email();
            f1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(f1);
            f1.Show();
        }

        private void view_bd_Click(object sender, EventArgs e)
        {
            ViewBirthdays v1 = new ViewBirthdays();
            v1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(v1);
            v1.Show();
        }

        private void search_cus_Click(object sender, EventArgs e)
        {
             
            try
            {

                /*con.Open();

                String selectQuery = "SELECT Fname,Address1,Contact_number FROM customer WHERE NIC_number=" + txtsearch.Text;
                cmd = new SqlCommand(selectQuery, con);
                mdr = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();

                if (mdr.Read())
                {
                    //get values from database to textbox
                   textBox2.Text = (mdr["Fname"].ToString());
                   textBox3.Text = (mdr["Address1"].ToString());
                   textBox4.Text = (mdr["Contact_number"].ToString());
                }

                else
                {
                    textBox2.Text = " ";
                    textBox2.Text = " ";
                    textBox2.Text = " ";
                    MessageBox.Show("No data for this NIC");
                }

              con.Close();*/

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error message");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search s1 = new Search();
            //this.MdiChildren = a1;
            s1.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(s1);
            s1.Show();
            //this.Hide();
        }
    }
}
