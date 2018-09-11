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
    public partial class Fuel : Form
    {
        public Fuel()
        {
            InitializeComponent();
        }

        InterfaceValidator n1 = new InterfaceValidator();

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
            //string errors = null;// new ArrayList();
            string errorMessage = null;
            bool isEmpty = false;
            //int index = -1;
            InterfaceValidator validator = new InterfaceValidator();

            //isEmpty = validator.checkIsEmpty(textBox3.
            //if (index >= 0) {
                isEmpty = validator.checkIsEmpty(textBox3.Text);

                if (isEmpty) {
                    errorMessage = errorMessage + "Registration No,";
                }
                
                
                MessageBox.Show(textBox3.Text,"text");
                //errors.Add("Registration No,");
            //}            

            //for (int i = 0; i < errors.Count; i++)
            //{
            //    errorMessage = errorMessage + errors[i].ToString();
            //}
            if (!isEmpty)
            {
                //int selected = dataGridView1.CurrentCell.RowIndex;
                int registrationNo = 0;
                registrationNo = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Fuel_Details WHERE RegistrationNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString());// dataGridView1.Rows[selected].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString());


                if (registrationNo == 0)
                {

                    DataSet count = new DBConnect().GetFromDB("SELECT * FROM Fuel_Details");

                    int receiptno = count.Tables[0].Rows.Count + 1;
                    new DBConnect().SendToDB("INSERT INTO Fuel_Details VALUES(" + receiptno + ",'" + comboBox1.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("HH:mm:00") + "'," + textBox4.Text + "," + textBox1.Text + "," + textBox5.Text + ")");

                    MessageBox.Show("Records Save Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Records Is Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                viewTable(dataGridView1, "SELECT * FROM Fuel_Details");


            }
            else
            {
                MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fuel_Load(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Fuel_Details");
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string receiptno = new DBConnect().GetFromDB("SELECT ReceiptNo FROM Fuel_Details WHERE RegistrationNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("UPDATE Fuel_Details SET FuelType = '" + comboBox1.Text + "',FuelStation = '" + textBox2.Text + "',Date = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',Time = '" + dateTimePicker2.Value.ToString("HH:mm:00") + "',MeterReading = '" + textBox4.Text + "',Efficiency = '" + textBox1.Text + "',Amount = '" + textBox5.Text + "', WHERE ReceiptNo = " + receiptno);

            MessageBox.Show("Records Update Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewTable(dataGridView1, "SELECT * FROM Fuel_Details");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes) {
                string receiptno = new DBConnect().GetFromDB("SELECT ReceiptNo FROM Fuel_Details WHERE RegistrationNo = " + textBox3.Text).Tables[0].Rows[0][0].ToString();
                new DBConnect().SendToDB("DELETE FROM Fuel_Details WHERE ReceiptNo = " + receiptno);

                MessageBox.Show("Records Delete Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewTable(dataGridView1, "SELECT * FROM Fuel_Details");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Fuel_Details where RegistrationNo = " + textBox3.Text);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox3.Text);

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
                MessageBox.Show("FuelType is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox2.Text);

            if (isEmpty)
            {
                MessageBox.Show("FuelStation is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox4.Text);

            if (isEmpty)
            {
                MessageBox.Show("MeterReading is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("Efficiency is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox3.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[4].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[5].Value.ToString());
            textBox4.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            textBox1.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox5.Text);

            if (isEmpty)
            {
                MessageBox.Show("Amount is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
