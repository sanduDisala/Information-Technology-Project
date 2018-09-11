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
    public partial class Delete_Customer : Form
    {
        public Delete_Customer()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Selectedrow = dataGridView1.CurrentCell.RowIndex; //get selected row         
            string contactNo = dataGridView1.Rows[Selectedrow].Cells[5].Value.ToString();
           
            if (MessageBox.Show("Are you sure to delete this customer", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //delete record from database
                 new DBConnect().SendToDB("DELETE FROM customer WHERE Contact_Number = " + contactNo);

                 MessageBox.Show("Delete Successfull", "Delete Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //after delete update datagrid
                 DataSet data = new DBConnect().GetFromDB("SELECT * FROM customer WHERE Company_Name = '" + txtsearch.Text + "'");
                 dataGridView1.DataSource = data.Tables[0];
  
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void Delete_Customer_Leave(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                txtsearch.Text = "Company Name";
                txtsearch.ForeColor = Color.DimGray;
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

        private void Delete_Customer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
