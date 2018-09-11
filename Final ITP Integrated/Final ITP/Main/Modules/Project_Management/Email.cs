using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Project_Management
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect con = new DBConnect();
            con.sendMail("projectmanager.emergingmedia@gmail.com", textBox1.Text, textBox3.Text, richTextBox1.Text, "lxjxiuumhsvkfieo");
            MessageBox.Show("Email sent Successfully", "Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
