using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Customer
{
    public partial class birthdayEmail : Form
    {
       

        public birthdayEmail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtmsg.Text == "")
            {
                MessageBox.Show("Enter a message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtcc.Text == "")
            {
                MessageBox.Show("Enter reciver email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string[] arr = txtcc.Text.Split(',');

                for (int i = 0; i < arr.Length; i++)
                {
                    new DBConnect().sendMail("customer.management.em@gmail.com", arr[i], txtsub.Text, txtmsg.Text, "CusMan12345!@#$%");
                    MessageBox.Show("message send successfully to  "+ arr[i]);
                }
            }

        }
        

        private void birthdayEmail_Load(object sender, EventArgs e)
        {
            
            string emailcc = ViewBirthdays.ccmails;
            emailcc = emailcc.Substring(0, emailcc.Length - 1);
            txtcc.Text = emailcc;
        }
    }
}
