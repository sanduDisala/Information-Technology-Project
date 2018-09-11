using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Main
{
    public partial class External_Travel : Form
    {
        public External_Travel()
        {
            InitializeComponent();
        }
        InterfaceValidator n1 = new InterfaceValidator();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Dispose();
        }
        private void viewTable(DataGridView gridView, string query)
        {
            DataSet data = new DBConnect().GetFromDB(query);
            gridView.DataSource = data.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValidated = new InterfaceValidator().validateInputDateTime(dateTimePicker1.Value, dateTimePicker2.Value);

            if (!isValidated)
            {
                MessageBox.Show("Error");
                return;
            }

            ArrayList errors = new ArrayList();
            string errorMessage = null;
            bool isEmpty = false;
            InterfaceValidator validator = new InterfaceValidator();
            isEmpty = validator.checkIsEmpty(textBox3.Text);
            errors.Add("Contact Number,");

            for(int i=0;i<errors.Count;i++){
                errorMessage = errorMessage + errors[i].ToString();
            }

            if (!isEmpty)
            {
                int selected = dataGridView1.CurrentCell.RowIndex;
                int contactNo = 0;
                contactNo= Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM External_Travel_Agencies WHERE ContactNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString());// dataGridView1.Rows[selected].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString());
    
               
               if (contactNo == 0)
               {
                DataSet count = new DBConnect().GetFromDB("SELECT * FROM External_Travel_Agencies");

                int contractorcode = count.Tables[0].Rows.Count + 1;
                new DBConnect().SendToDB("INSERT INTO External_Travel_Agencies VALUES(" + contractorcode + ",'" + comboBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')");

                MessageBox.Show("Records Save Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show("Records Is Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }              
                viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies");
            }
            else { 
                MessageBox.Show(errorMessage.Substring(0,errorMessage.Length -1) + " Is Empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void External_Travel_Agencies_Load(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies");
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string contractorNumber = new DBConnect().GetFromDB("SELECT ContractorCode FROM External_Travel_Agencies WHERE ContactNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("UPDATE External_Travel_Agencies SET Type = '" + comboBox1.Text + "',OwnerName = '" + textBox2.Text + "',AgreementDate = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',AgreementExpiryDate='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' WHERE ContractorCode = " + contractorNumber);

            MessageBox.Show("Records Update Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies");
        }


        private void External_Travel_Load(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete ? ", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(dialog == DialogResult.Yes){
            string contractorNumber = new DBConnect().GetFromDB("SELECT ContractorCode FROM External_Travel_Agencies WHERE ContactNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("DELETE FROM External_Travel_Agencies WHERE ContractorCode = " + contractorNumber);

            MessageBox.Show("Records Delete Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM External_Travel_Agencies where ContactNo = " + textBox3.Text);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox3.Text);

            if (isEmpty) {
                MessageBox.Show("Contact Number is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("Type is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox2.Text);

            if (isEmpty)
            {
                MessageBox.Show("OwnerName is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox3.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[4].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[5].Value.ToString());
            
            
        }

        
    }
}
