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
    public partial class Customer_Info : Form
    {
        public Customer_Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Customer u1= new Update_Customer();
            u1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Customer a1 = new Add_Customer();
            a1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_Customer d1 = new Delete_Customer();
            d1.Show();
        }

        private void Customer_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
