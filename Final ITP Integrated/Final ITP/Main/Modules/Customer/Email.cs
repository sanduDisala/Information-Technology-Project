using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Main.Modules.Customer
{
    public partial class Email : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Email()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
           
           
            msg.To.Add(new MailAddress(txtto.Text));

            if (!string.IsNullOrEmpty(txtcc.Text))
            {
                msg.To.Add(new MailAddress(txtcc.Text));
            }
            msg.Subject = txtsub.Text;
            msg.Body = txtmsg.Text;
           
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendComletedCallBack);
            string userstate = "Sending ...";
            client.SendAsync(msg,userstate);
        }

        private static void SendComletedCallBack (object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send cancelled",e.UserState),"Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtcc.Text == string.Empty && txtto.Text == string.Empty)
            {
                MessageBox.Show("Enter recivers email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(txtmsg.Text==string.Empty)
                {
                    MessageBox.Show("Enter a message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               else  if (txtcc.Text == string.Empty)
                {
                    new DBConnect().sendMail("customer.management.em@gmail.com", txtto.Text, txtsub.Text, txtmsg.Text, "CusMan12345!@#$%");
                    MessageBox.Show("message send successfully  " , "send Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // send mails to cc group
                {
                    string[] arr = txtcc.Text.Split(',');

                    for (int i = 0; i < arr.Length; i++)
                    {
                        new DBConnect().sendMail("customer.management.em@gmail.com", arr[i], txtsub.Text, txtmsg.Text, "CusMan12345!@#$%");
                        MessageBox.Show("message send successfully to " + arr[i], "send Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                }
            }
            
        }

        private void Email_Load(object sender, EventArgs e)
        {
            
        }
    }
}
