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
    public partial class Insurance : Form
    {
        public Insurance()
        {
            InitializeComponent();
        }

        InterfaceValidator n1 = new InterfaceValidator();

        private void Insurance_Load1(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Insurance_Details");
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
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

            if (!isValidated) {
                MessageBox.Show("Error");
                return;
            }

            ArrayList errors = new ArrayList();
            string errorMessage = null;
            bool isEmpty = false;
            InterfaceValidator validator = new InterfaceValidator();
            isEmpty = validator.checkIsEmpty(textBox1.Text);
            errors.Add("Registration No,");

            for (int i = 0; i < errors.Count; i++)
            {
                errorMessage = errorMessage + errors[i].ToString();
            }
            if (!isEmpty)
            {
                int selected = dataGridView1.CurrentCell.RowIndex;
                int registrationNo = 0;
                registrationNo = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Insurance_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString()); //dataGridView1.Rows[selected].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString());


                if (registrationNo == 0)
                {
                    DataSet count = new DBConnect().GetFromDB("SELECT * FROM Insurance_Details");

                    int insurancenumber = count.Tables[0].Rows.Count + 1;
                    new DBConnect().SendToDB("INSERT INTO Insurance_Details VALUES(" + insurancenumber + ",'" + comboBox1.Text + "','" + comboBox2.Text + "'," + textBox1.Text + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')");

                    MessageBox.Show("Records Save Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Records Is Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                     viewTable(dataGridView1, "SELECT * FROM Insurance_Details");

            }
            else
            {
                MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string insurancenumber = new DBConnect().GetFromDB("SELECT InsuranceNo FROM Insurance_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("UPDATE Insurance_Details SET InsuranceCompanyName = '" + comboBox1.Text + "', InsuranceType= '" + comboBox2.Text + "',StartDate = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',EndDate='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' WHERE InsuranceNo = " + insurancenumber);

            MessageBox.Show("Records Update Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            viewTable(dataGridView1, "SELECT * FROM Insurance_Details");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes) {
                string insurancenumber = new DBConnect().GetFromDB("SELECT InsuranceNo FROM Insurance_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString();
                new DBConnect().SendToDB("DELETE FROM Insurance_Details WHERE InsuranceNo = " + insurancenumber);

                MessageBox.Show("Records Delete Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewTable(dataGridView1, "SELECT * FROM Insurance_Details");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Insurance_Details where RegistrationNo = " + textBox1.Text);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("RegistrationNo is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("InsuranceCompanyName is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox2.Text);

            if (isEmpty)
            {
                MessageBox.Show("InsuranceType is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            comboBox2.Text= dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[4].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[5].Value.ToString());
            
        }
       
    }
}
