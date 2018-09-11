using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//pnamespace Project_Management { }
namespace Main.Modules.Event
{
    public partial class Email : Form
    {
        
        public Email()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textto.Text == "")
            {
                MessageBox.Show("Please specify at least one recipient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new DBConnect().sendMail("event.management.em17@gmail.com", textto.Text, textsub.Text, textmsg.Text, "Event@123");
               
                MessageBox.Show("Sucesse");
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {
           // textmsg.Text = "Dear Sir/Madam";
        }
    }
}
