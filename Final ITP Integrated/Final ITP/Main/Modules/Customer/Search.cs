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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void search_cus_Click(object sender, EventArgs e)
        {

            if ((txtsearch.Text == string.Empty) || (txtsearch.Text == "Company Name"))
            {
                MessageBox.Show("Enter Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                DataSet data = new DBConnect().GetFromDB("SELECT * FROM customer WHERE Company_Name = '" + txtsearch.Text + "'");
                dataGridView1.DataSource = data.Tables[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtsearchC.Text == string.Empty) || (txtsearchC.Text == "Category Name"))
            {
                MessageBox.Show("Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataSet data = new DBConnect().GetFromDB("SELECT * FROM customer WHERE Category = '" + txtsearchC.Text + "'");
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Company Name") 
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "Company Name";
                txtsearch.ForeColor = Color.DimGray;
            }
        }

        private void txtsearchC_Enter(object sender, EventArgs e)
        {
            if (txtsearchC.Text == "Category Name")
            {
                txtsearchC.Text = "";
                txtsearchC.ForeColor = Color.Black;
            }
        }

        private void txtsearchC_Leave(object sender, EventArgs e)
        {
            if (txtsearchC.Text == "")
            {
                txtsearchC.Text = "Category Name";
                txtsearchC.ForeColor = Color.DimGray;
            }
        }

        
    }
}
