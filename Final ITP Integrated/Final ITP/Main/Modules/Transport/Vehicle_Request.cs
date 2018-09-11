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
using System.Collections;

namespace Main
{
    public partial class Vehicle_Request : Form
    {
        public Vehicle_Request()
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
                registrationNo = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Vehicle_Request_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString());//dataGridView1.Rows[selected].Cells[0].Value.ToString()).Tables[0].Rows[0][0].ToString());
               // MessageBox.Show("SELECT COUNT(*) FROM Vehicle_Request_Details WHERE RegistrationNo = " + textBox1.Text,"SQL");
                MessageBox.Show(registrationNo.ToString(), "requestNo");
                if (registrationNo == 0)
                {
                    DataSet count = new DBConnect().GetFromDB("SELECT * FROM Vehicle_Request_Details");

                    int requestNumber = count.Tables[0].Rows.Count + 1;
                    new DBConnect().SendToDB("INSERT INTO Vehicle_Request_Details VALUES(" + requestNumber + ",'" + comboBox1.Text + "'," + textBox1.Text + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("HH:mm:00") + "','" + textBox4.Text + "','" + textBox5.Text + "')");

                    MessageBox.Show("Records Save Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                   MessageBox.Show("Records Is Duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
                viewTable(dataGridView1, "SELECT * FROM Vehicle_Request_Details");

            }
            else
            {
                MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vehicle_Request_Load(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Vehicle_Request_Details");
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string requestnumber = new DBConnect().GetFromDB("SELECT RequestNo FROM Vehicle_Request_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString();
            new DBConnect().SendToDB("UPDATE Vehicle_Request_Details SET Type = '" + comboBox1.Text + "',RequestDate = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',RequestTime='" + dateTimePicker2.Value.ToString("HH:mm:00") + "',PlaceOfArrival='" + textBox4.Text + "',PlaceOfDepature='" + textBox5.Text + "' WHERE RequestNo = " + requestnumber);

            MessageBox.Show("Records Update Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            viewTable(dataGridView1, "SELECT * FROM Vehicle_Request_Details");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete ? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(dialog == DialogResult.Yes)
            {
                string requestnumber = new DBConnect().GetFromDB("SELECT RequestNo FROM Vehicle_Request_Details WHERE RegistrationNo = " + textBox1.Text).Tables[0].Rows[0][0].ToString();
                new DBConnect().SendToDB("DELETE FROM Vehicle_Request_Details WHERE RequestNo = " + requestnumber);

                MessageBox.Show("Records Delete Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewTable(dataGridView1, "SELECT * FROM Vehicle_Request_Details");
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewTable(dataGridView1, "SELECT * FROM Vehicle_Request_Details where RegistrationNo = " + textBox1.Text);
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
                MessageBox.Show("Type is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox4.Text);

            if (isEmpty)
            {
                MessageBox.Show("PlaceOfArrival is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            bool isEmpty = n1.checkIsEmpty(textBox5.Text);

            if (isEmpty)
            {
                MessageBox.Show("PlaceOfDeparture is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[3].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[selected].Cells[4].Value.ToString());
            textBox4.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

      
    }
}
