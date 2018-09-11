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
    public partial class Expenditures : Form
    {



        DBConnect k1 = new DBConnect();
        DataSet ce = new DataSet();



        public Expenditures()
        {
            InitializeComponent();
        }

        private void Expenditures_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            showdatagrid();
            TotalIncome();


        }

        void itemclear()
        {

           textBox1.Text = "";
            textBox2.Text= "";
            textBox3.Text = "";
           
        }

     








        void TotalIncome()
        {
            DataSet set = new DataSet();
            set = k1.GetFromDB("select sum(amount) from expenditures");
          //  label6.Text = (set.Tables[0].Rows[0][0].ToString());
        }











        void showdatagrid()
        {
            DataSet acc = new DataSet();
            dataGridView1.Columns.Clear();
            acc = k1.GetFromDB("select expense_no as 'Expense No',name as 'Name',amount as 'Amount',receiver as 'Reciever',description1 as 'Description',dates as 'Date'from expenditures");
            dataGridView1.DataSource = acc.Tables[0];
            textBox1.Text = (acc.Tables[0].Rows.Count + 1).ToString();






        }


        private void itemsclear() { 
        
        textBox1.Text="";
        textBox2.Text ="";
        textBox4.Text = "";
        textBox3.Text = "";
        textBox5.Text = "";
       

        
        
        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text=="")
            {

                MessageBox.Show("enter data to all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //DataSet checkInvoice = k1.GetFromDB("SELECT * FROM expenditures WHERE expense_no = '" + textBox1.Text + "'");
                ////if (checkInvoice.Tables[0].Rows.Count != 0)
                ////{
                ////    MessageBox.Show("Expense Number Is Duplicate", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ////}
                //else
                //{
                    k1.SendToDB("insert into expenditures(name ,amount,Receiver,description1,dates) values('" + textBox2.Text + "'," + textBox4.Text + ",'" + textBox3.Text + "','" +textBox5.Text + "','" + dateTimePicker1.Text + "')");
                    //k1.SendToDB("insert into expenditures values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + dateTimePicker1.Text + "')");
                    DataSet cc = k1.GetFromDB("select * from expenditures ");
                    dataGridView1.DataSource = cc.Tables[0];
                    
                    MessageBox.Show("Saved Succesfully", "saving process", MessageBoxButtons.OK);

                    itemsclear();


                }
            
        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar==(char)Keys.Enter)
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


                    k1.SendToDB("DELETE FROM expenditures WHERE expense_no = " + textBox1.Text);
                         dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                            MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            itemsclear();
                }

            }








            //DialogResult confirm = MessageBox.Show("Do you want to remove", "Remove Option", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //if (confirm == DialogResult.Yes)
            //{

            //    try
            //    {
            //        k1.SendToDB("DELETE FROM expenditures WHERE expense_no = " + textBox1.Text);
            //        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //        MessageBox.Show("Record Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        itemsclear();
            //    }
            //    catch(Exception y) { 
                
                
            //    }
            


            //try
            //{
            //    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //    k1.SendToDB("delete from expenditures where expense_no=" + textBox1.Text);
            //    MessageBox.Show("removed succesfully");
              
            //}

            //catch
            //{
            //    MessageBox.Show("select arrow head  and click remove button to remove the row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //TotalIncome();
      

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int selectedkey = dataGridView1.CurrentCell.RowIndex;
            //string expenseNo = dataGridView1.Rows[selectedkey].Cells[0].Value.ToString();
            
            //k1.SendToDB("UPDATE expenditures SET name = '" + textBox2.Text + "',amount = '" + textBox3.Text + "',dates = '" + dateTimePicker1.Text + "' WHERE expense_no = " + expenseNo);
            //DataSet dataset = k1.GetFromDB("SELECT * FROM expenditures");
            //dataGridView1.DataSource = dataset;
            
            
            //TotalIncome();


            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {

                MessageBox.Show("enter data to blankfield for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                new DBConnect().SendToDB("UPDATE expenditures SET name = '" + textBox2.Text + "',amount = '" + textBox4.Text + "',receiver='"+textBox3.Text+"',description1='"+textBox5.Text+"',dates = '" + dateTimePicker1.Text + "' WHERE expense_no = " + textBox1.Text);

                DataSet acc = new DataSet();


                dataGridView1.Columns.Clear();


                acc = k1.GetFromDB("select * from expenditures");
                dataGridView1.DataSource = acc.Tables[0];
                MessageBox.Show(" updateted succesfully");
                //TotalIncome();
                itemclear();


            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();



            //TotalIncome();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
