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
    public partial class Update_Customer : Form
    {
        public Update_Customer()
        {
            InitializeComponent();
        }

        // search values and show in datagrid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((txtsearch.Text == string.Empty) || (txtsearch.Text == "Company Name" ))
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

        // get valuse from datagrid to text boxes
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtComName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAdd1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtAdd2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();              
                txtConNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dtpDOB.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("please first search records","Error" ,MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        //update values
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            new DBConnect().SendToDB("UPDATE customer SET Fname = '"+txtFName.Text+"' , Lname ='"+txtLName.Text+"', Address1 ='"+txtAdd1.Text+"',Address2 ='"+txtAdd2.Text+"',Email ='"+txtEmail.Text+"' WHERE Contact_Number = "+txtConNo.Text+"");
            MessageBox.Show("Update Successfully !!", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        // search records
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

    }
}
