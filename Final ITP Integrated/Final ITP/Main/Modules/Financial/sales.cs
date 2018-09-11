using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Financial
{

    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        DBConnect k1 = new DBConnect();
        DataSet ce = new DataSet();

        //void itemclear()
        //{

        //    textBox1.Text = "";
        //    textBox2.Text = "";
        //    textBox3.Text = "";


        //    textBox5.Text = "";
        //    textBox7.Text = "";
        //}

        //void TotalNetSale()
        //{
        //    DataSet set = new DataSet();
        //    set = k1.GetFromDB("select sum(Net_Sales) from sales");
        //}


        //void showdatagrid()
        //{
        //    DataSet acc = new DataSet();

        //    dataGridView1.Columns.Clear();

        //    acc = k1.GetFromDB("select * from sales");

        //    dataGridView1.DataSource = acc.Tables[0];
        //}

        private void displayTable()
        {
            DataSet tableDetails = k1.GetFromDB("SELECT sales_invoiceNo AS 'Sales Invoice',time_ AS 'Time',type_ AS 'Type',location AS 'Location' ,channelname AS 'Channel Name',client_name AS 'Client Name',costperday AS 'Cost Per Day',duration AS 'Duration',no_of_spot AS 'No of Spots',net_amount AS 'Net Amount' FROM sales");
            dataGridView1.DataSource = tableDetails.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "" || /*comboBox3.Text == "" || comboBox2.Text == "" ||*/ textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("enter data to all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DataSet checkInvoice = k1.GetFromDB("SELECT * FROM sales WHERE sales_invoiceNo = '" + textBox1.Text + "'");
                if (checkInvoice.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Invoice Number Is Duplicate", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        k1.SendToDB("INSERT INTO sales(sales_invoiceNo,time_,type_,channelname,client_name,costperday,duration,no_of_spot,net_amount) VALUES(" + textBox1.Text + ",'" + dateTimePicker1.Text + "','" + radioButton1.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "'," + textBox3.Text + "," + textBox5.Text + "," + textBox2.Text + "," + textBox7.Text + ")");
                    }
                    else if (radioButton2.Checked)
                    {
                        k1.SendToDB("INSERT INTO sales(sales_invoiceNo,time_,type_,location,client_name,costperday,duration,no_of_spot,net_amount) VALUES(" + textBox1.Text + ",'" + dateTimePicker1.Text + "','" + radioButton2.Text + "','" + comboBox3.Text + "','" + comboBox1.Text + "'," + textBox3.Text + "," + textBox5.Text + "," + textBox2.Text + "," + textBox7.Text + ")");
                    }

                    displayTable();
                    MessageBox.Show("Saved Successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //void CalcNetSale()
        //{
        //    try
        //    {

        //    }
        //    catch (FormatException x)
        //    {

        //    }
        //}

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(textBox5, textBox3);
        }

        //private void textBox7_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //    //CalcNetSale();

        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //    //CalcNetSale();

        //}

        private void button3_Click(object sender, EventArgs e)
        {
            // DialogResult confirm = MessageBox.Show("Do you want to remove", "Remove Option", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //   if (confirm == DialogResult.Yes)
            // {


            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("there are no record to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Do you want to remove", "Remove Option", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirm == DialogResult.Yes)
                {
                    k1.SendToDB("DELETE FROM sales WHERE sales_invoiceNo = " + textBox1.Text);
                    displayTable();
                    MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        //  private void button1_Click(object sender, EventArgs e)
        //  {



        ////  }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                else
                {
                    calculateTotal(textBox5, textBox3);
                }

            }
            else
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {

                MessageBox.Show("enter data to all blank field without changin invoice no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // MessageBox.Show("UPDATE sales SET time_ = '" + dateTimePicker1.Text + "',type_ = '" + radioButton1.Text + "',channelname = '" + comboBox2.Text + ",client_name = '" + comboBox1.Text + "',costperday = " + textBox3.Text + ",duration = " + textBox5.Text + ",no_of_spot = " + textBox2.Text + ",net_amount = " + textBox7.Text + " WHERE sales_invoiceNo = " + textBox1.Text, "sql");
                string type = null;

                k1.SendToDB("UPDATE sales SET time_ = '" + dateTimePicker1.Text + "',type_ = '" + type + "',channelname = '" + comboBox2.Text + "',location = '" + comboBox3.Text + "',client_name = '" + comboBox1.Text + "',costperday = " + textBox3.Text + ",duration = " + textBox5.Text + ",no_of_spot = " + textBox2.Text + ",net_amount = " + textBox7.Text + " WHERE sales_invoiceNo = " + textBox1.Text);

                if (radioButton1.Checked)
                {
                    type = radioButton1.Text;
                    k1.SendToDB("UPDATE sales SET location = NULL,type_ = '" + radioButton1.Text + "'  WHERE sales_invoiceNo = " + textBox1.Text);
                }

                if (radioButton2.Checked)
                {
                    type = radioButton2.Text;
                    k1.SendToDB("UPDATE sales SET channelname = NULL,type_ = '" + radioButton2.Text + "'  WHERE sales_invoiceNo = " + textBox1.Text);
                }
                displayTable();
                MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
        }

        private void clearForm()
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }

        private void sales_Load(object sender, EventArgs e)
        {
            radioButton2.Location = comboBox2.Location;
            DataSet indoorCategory = k1.GetFromDB("select Name from channelname");
            comboBox2.DataSource = indoorCategory.Tables[0];
            comboBox2.DisplayMember = "Name";

            DataSet outdoorCategory = k1.GetFromDB("SELECT Name FROM location");
            comboBox3.DataSource = outdoorCategory.Tables[0];
            comboBox3.DisplayMember = "Name";

            DataSet client = k1.GetFromDB("select name from client");
            comboBox1.DataSource = client.Tables[0];
            comboBox1.DisplayMember = "name";

            displayTable();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;


            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[8].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();

            textBox5.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[selected].Cells[9].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();

            if (dataGridView1.Rows[selected].Cells[4].Value.ToString() != "")
            {
                radioButton1.Checked = true;
                comboBox2.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            }

            if (dataGridView1.Rows[selected].Cells[3].Value.ToString() != "")
            {
                radioButton2.Checked = true;
                comboBox3.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBox2.Visible = true;
                radioButton2.Location = new Point(15, 418);
            }
            else
            {
                comboBox2.Visible = false;
                radioButton2.Location = comboBox2.Location;
            }
        }

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                comboBox3.Location = new Point(15, 418);

                comboBox3.Visible = true;
            }
            else
            {
                comboBox3.Visible = false;
            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void calculateTotal(TextBox text1, TextBox text2)
        {
            if (text2.Text == "")
            {
                textBox7.Text = "0";

            }
            else
            {
                if (text2.Text.Length == 0)
                {
                    textBox7.Text = (Convert.ToInt32(text1.Text) * 0).ToString();
                }
                else
                {

                    try
                    {
                        textBox7.Text = (Convert.ToInt32(text1.Text) * Convert.ToInt32(text2.Text)).ToString();
                    }
                    catch (FormatException ex)
                    {

                    }
                }
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        //private void textBox2_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            calculateTotal(textBox3, textBox5);
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            calculateTotal(textBox5, textBox3);
        }

        private void textBox3_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
