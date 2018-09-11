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

namespace Main.Modules.Financial
{
    public partial class Income : Form
    {
        DBConnect k1 = new DBConnect();
        
        DataSet ce = new DataSet();

        public Income()
        {
            InitializeComponent();
        }

        private void Income_Load(object sender, EventArgs e)
        {
            showdatagrid();
            //TotalIncome();
        }


        void itemclear()
        {

            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
           dateTimePicker1.Text = "";





        }


       
      //void TotalIncome()
      //  {
      //     DataSet set=new DataSet();
      //     set=k1.GetFromDB("select sum(amount) from income");
      //     label5.Text = (set.Tables[0].Rows[0][0].ToString());
      //  }


          





















      private void button1_Click(object sender, EventArgs e)
      {
          if (textBox1.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || textBox4.Text == "")
          {


              MessageBox.Show("enter data to all field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

          else
          {




              DataSet checkIncomeNo = k1.GetFromDB("SELECT * FROM income WHERE incomeNo = " + textBox3.Text);
              if (checkIncomeNo.Tables[0].Rows.Count != 0)
              {

                  MessageBox.Show("Income  Number Is Duplicate", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {





                  k1.SendToDB("insert into income values(" + textBox3.Text + ",'" + textBox1.Text + "'," + textBox4.Text + ",'" + dateTimePicker1.Text + "')");
                

                  MessageBox.Show("Saved Succesfully", "saving process", MessageBoxButtons.OK);

                  showdatagrid();
                  //TotalIncome();
                  
                  itemclear();






              }



          }
      }

        





        void showdatagrid() {
            DataSet acc = new DataSet();

            dataGridView1.Columns.Clear();

            acc = k1.GetFromDB("select * from income");
            
            dataGridView1.DataSource = acc.Tables[0];
          
           

                  
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || textBox4.Text == "")
            {


                MessageBox.Show("Select row to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new DBConnect().SendToDB("UPDATE income SET name = '" + textBox1.Text + "',amount = '" + textBox4.Text + "',date1 = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE incomeNo ='" + textBox3.Text + "'");

                DataSet acc = new DataSet();

                dataGridView1.Columns.Clear();


                acc = k1.GetFromDB("select * from income");
                dataGridView1.DataSource = acc.Tables[0];

                //TotalIncome();

                MessageBox.Show("Record Succesfully updated","Update",MessageBoxButtons.OK,MessageBoxIcon.Information);
                itemclear();

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            textBox3.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();



            //TotalIncome();

        }

        private void button2_Click(object sender, EventArgs e)
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


                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                        k1.SendToDB("delete from income where IncomeNo="+textBox3.Text);
                       MessageBox.Show("removed succesfully");
                       itemclear();
                }

            }
            //try
            //{
            //    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            //    k1.SendToDB("delete from income where IncomeNo="+textBox3.Text);
            //    MessageBox.Show("removed succesfully");
            //}

            //catch  {
            //    MessageBox.Show("select arrow head  and click remove button to remove the row","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}


            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {











        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }

        }




        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                



            }
            else
            {

                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    
    
    
    
    
    
    }

}