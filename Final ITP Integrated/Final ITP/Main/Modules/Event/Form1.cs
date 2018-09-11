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

namespace Main.Modules.Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_events f1 = new Add_events();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings f2 = new Bookings();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return f3 = new Return();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hire f4 = new Hire();
            f4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ve_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_event_D v1 = new View_event_D();
            v1.Show();
            //string sql = "select * from Event_Details";
            //DBConnect con = new DBConnect();
            
            //DataSet set = new DataSet();
            //set = con.GetFromDB(sql);
            //View_event_D v = new View_event_D();
            //v.view.DataSource = set.Tables[0];

        }

       
    }
}
