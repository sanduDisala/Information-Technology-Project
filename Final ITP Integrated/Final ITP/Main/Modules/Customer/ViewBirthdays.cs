using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Customer
{
    public partial class ViewBirthdays : Form
    {
        public ViewBirthdays()
        {
         
            InitializeComponent();
        }

        DataSet birthdays;
        public static string ccmails = null;
        private void rbtweek_CheckedChanged(object sender, EventArgs e)
        {
            //DateTime date = getdate

            int currentDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int currentMonth = Convert.ToInt32( DateTime.Now.ToString("MM"));

           

            birthdays = new DBConnect().GetFromDB("select Fname,Lname,DOB,Email from customer WHERE Datepart(day,DOB) between datepart(day," +  (currentDay - 1).ToString() + ") and Datepart(day," + (currentDay + 7).ToString() + ") and Datepart(month,DOB) = "+ (currentMonth).ToString()+"");
            dataGridView1.DataSource = birthdays.Tables[0];
        }

        private void rbttoday_CheckedChanged(object sender, EventArgs e)
        {
            int currentDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));

           

            birthdays = new DBConnect().GetFromDB("select Fname,Lname,DOB,Email from customer WHERE Datepart(day,DOB) = " + currentDay.ToString() + " and Datepart(month,DOB) = " + (currentMonth).ToString() + "");
            dataGridView1.DataSource = birthdays.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbttoday.Checked == true)
            {
                birthdayEmail be = new birthdayEmail();
                be.Show();
            }

            else
            {
                MessageBox.Show("You can send message only for today birthdays");
            }
        }

        private void selectBd()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            ccmails = ccmails + dataGridView1.Rows[index].Cells[3].Value.ToString() + ",";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectBd();
        }

    }
}
