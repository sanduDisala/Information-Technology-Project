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
    public partial class Vehicle_Info : Form
    {
        public Vehicle_Info()
        {
            InitializeComponent();
        }
        InterfaceValidator n1 = new InterfaceValidator();
        private void Informations_Load(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Vehicle_Details");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewTable(DataGridView gridView,string query) {
            DataSet data = new DBConnect().GetFromDB(query);
            gridView.DataSource = data.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
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
                registrationNo = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Vehicle_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString());//dataGridView1.Rows[selected].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString());


                if (registrationNo == 0)
                {

                    DataSet count = new DBConnect().GetFromDB("SELECT * FROM Vehicle_Details");
                    int vehicleNumber = count.Tables[0].Rows.Count + 1;
                    new DBConnect().SendToDB("INSERT INTO Vehicle_Details VALUES(" + vehicleNumber + "," + textBox1.Text + ",'" + comboBox2.Text + "','" + comboBox1.Text + "','" + comboBox3.Text + "'," + textBox4.Text + ",'" + comboBox4.Text + "')");

                    MessageBox.Show("Records Save Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Records Is Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                viewTable(dataGridView1, "SELECT * FROM Vehicle_Details");


            }
            else
            {
                MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet VehicleNumber = new DBConnect().GetFromDB("SELECT VehicleNo FROM Vehicle_Details WHERE RegistrationNo = " + textBox1.Text);//set.Tables[0].Rows.Count + 1;
            string vehicleNumber = VehicleNumber.Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("UPDATE Vehicle_Details SET RegistrationNo = " + textBox1.Text + ",VehicleType = '" + comboBox2.Text + "',ModelName = '" + comboBox1.Text + "',BrandName = '" + comboBox3.Text + "',SeatCapacity = " + textBox4.Text + ",FuelType = '" + comboBox4.Text + "' WHERE VehicleNo = " + vehicleNumber);

            MessageBox.Show("Records Update Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            viewTable(dataGridView1, "SELECT * FROM Vehicle_Details");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes) {
                DataSet VehicleNumber = new DBConnect().GetFromDB("SELECT VehicleNo FROM Vehicle_Details WHERE RegistrationNo = " + textBox1.Text);//set.Tables[0].Rows.Count + 1;
                string vehicleNumber = VehicleNumber.Tables[0].Rows[0][0].ToString();
                new DBConnect().SendToDB("DELETE FROM Vehicle_Details WHERE VehicleNo = " + vehicleNumber);

                MessageBox.Show("Records Delete Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewTable(dataGridView1, "SELECT * FROM Vehicle_Details");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {   
          viewTable(dataGridView1,"SELECT * FROM Vehicle_Details where RegistrationNo = " + textBox1.Text);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("RegistrationNo is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox2.Text);

            if (isEmpty)
            {
                MessageBox.Show("VehicleType is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox1.Text);

            if (isEmpty)
            {
                MessageBox.Show("ModelName is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox3.Text);

            if (isEmpty)
            {
                MessageBox.Show("BrandName is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox4.Text);

            if (isEmpty)
            {
                MessageBox.Show("SeatCapacity is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(comboBox4.Text);

            if (isEmpty)
            {
                MessageBox.Show("FuelType is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
