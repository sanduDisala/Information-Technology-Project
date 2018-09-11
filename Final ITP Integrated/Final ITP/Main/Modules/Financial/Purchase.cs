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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }


        DBConnect k1 = new DBConnect();
        DataSet ce = new DataSet();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            amountcal();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            DataSet productname = k1.GetFromDB("select Product_name from product");
            comboBox1.DataSource = productname.Tables[0];
            comboBox1.DisplayMember = "Product_name";



            DataSet suppliername = k1.GetFromDB("select supplier_name from suppliers");
            comboBox2.DataSource = suppliername.Tables[0];
            comboBox2.DisplayMember = "supplier_name";

            showdata();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {



            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        void amountcal()
        {

            try
            {
                textBox4.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox2.Text)).ToString();

            }
            catch (FormatException x)
            {

            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            amountcal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showdata()
        {


            DataSet tableDetails = k1.GetFromDB("select invoice_no as 'Invoice No',supplier_name as 'Supplier Name',date1 as 'Date',product_name as 'Product name',qty as 'Quantity',Rate as 'Rate',amount as 'Amount' from purchase");
            dataGridView1.DataSource = tableDetails.Tables[0];




        }

        private void itemclear()
        {


            textBox1.Text = "";

            dateTimePicker1.Text = "";

            textBox3.Text = "";

            textBox2.Text = "";
            textBox4.Text = "";







        }




        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {


                MessageBox.Show("enter data to all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                    //DataSet tableDetails = k1.GetFromDB("select invoice_no as 'Invoice No',supplier_name as 'Supplier Name',date1 as 'Date',product_name as 'Product name',qty as 'Quantity',Rate as 'Rate',amount as 'Amount' from purchase");
                    //dataGridView1.DataSource = tableDetails.Tables[0];

                    k1.SendToDB("insert into purchase values(" + textBox1.Text + ",'" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "'," + textBox3.Text + "," + textBox2.Text + "," + textBox4.Text + ")");

                    //DataSet tableDetails = k1.GetFromDB("select invoice_no as 'Invoice No',supplier_name as 'Supplier Name',date1 as 'Date',product_name as 'Product name',qty as 'Quantity',Rate as 'Rate',amount as 'Amount' from purchase");
                    //dataGridView1.DataSource = tableDetails.Tables[0];
                    showdata();

                    MessageBox.Show("Saved Successfully", "save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    itemclear();

                }







            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;


            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();

            textBox2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || comboBox2.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {


                MessageBox.Show("enter data to all blank fields to update without changing invoice no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {




                k1.SendToDB("UPDATE purchase SET supplier_name = '" + comboBox2.Text + "',date1= '" + dateTimePicker1.Text + "',product_name  = '" + comboBox1.Text + "',qty  = " + textBox3.Text + ",Rate = " + textBox2.Text + ",amount = " + textBox4.Text + " WHERE invoice_no  = " + textBox1.Text);

                showdata();
                MessageBox.Show("UpdateD Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                itemclear();













            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count == 0)
            {


                MessageBox.Show("there are no record to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            else
            {


                DialogResult confirm = MessageBox.Show("Do you want to remove", "Remove Option", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirm == DialogResult.Yes)
                {





                    k1.SendToDB("DELETE FROM purchase WHERE invoice_no  = " + textBox1.Text);
                    showdata();
                    MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemclear();
                }



            }











            //if (dataGridView1.Rows.Count == 0)
            //{


            //    MessageBox.Show("there are no record to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            //}






























        }
    }
}
