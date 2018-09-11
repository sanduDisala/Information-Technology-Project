using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Customer
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }
        string count, Pay_Id;
        decimal total;
        decimal total_amount;      
        public static double test_totalAmount;
        public static string test_billNo;
        public static int conNo;
        public static string comName;
        public static string Add1;
        public static string Bill;
        public static double advance;
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdvance.Text == string.Empty) 
            {
                MessageBox.Show("Enter Advance payment ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //call auto increment pay id
                Pay_Id = GetPaymentId();

                // save data to Advance_Pay database
                new DBConnect().SendToDB("INSERT INTO Pay_Advance (Payment_Id, Bill_No, Advance, Total_Amount, Pay_Date) VALUES ('" + Pay_Id + "','" + txtsearch.Text + "' ,'" + txtAdvance.Text + "','" + totalAmount.Text + "','" + dtpPayDate.Value.ToString() + "')");

                MessageBox.Show("Payment Is Successful", "Advance Done Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if ((txtsearch.Text == string.Empty) || (txtsearch.Text == "No"))
            {
                MessageBox.Show("Enter Bill Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                 DataSet data = new DBConnect().GetFromDB("SELECT * FROM Advance_Bill WHERE Bill_No = '" + txtsearch.Text + "'");
                dataGridView1.DataSource = data.Tables[0];

               //Send total amount to lable
                total_amount = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    total_amount = total_amount + Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }
                totalAmount.Text = total_amount.ToString()+".00";

            }
        }

        private void Search_Click(object sender, EventArgs e)
        {

            if ((txtPhoneSearch.Text == string.Empty) || (txtPhoneSearch.Text == "Contact Number"))
            {
                MessageBox.Show("Enter Contact Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                DataSet data = new DBConnect().GetFromDB("SELECT Bill_No , Return_Date FROM Customer_order WHERE Contact_Number = " + txtPhoneSearch.Text + "");
                dataGridView3.DataSource = data.Tables[0];
            }
        }


        //auto increment pay_id
        public String GetPaymentId()
        {
            count = (Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Pay_Advance").Tables[0].Rows[0][0]) + 1).ToString();
             return ("No" + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox3.Text == string.Empty) || (textBox3.Text == "No"))
            {
                MessageBox.Show("Enter Bill Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                DataSet data = new DBConnect().GetFromDB("SELECT * FROM Pay_Advance WHERE Bill_No = '" + textBox3.Text + "'");
                dataGridView2.DataSource = data.Tables[0];

                //calculate remaining payment
                total = Convert.ToDecimal(dataGridView2.Rows[0].Cells[3].Value) - Convert.ToDecimal(dataGridView2.Rows[0].Cells[2].Value);
                lblPayment.Text = total.ToString()+".00";
            }
        }

       
        private void button4_Click_1(object sender, EventArgs e)
        {
            //validatig payment amount
            if (txtAddPayment.Text == string.Empty)
                {
                    MessageBox.Show("Please Add Payment ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            else
            {
                if (lblPayment.Text.ToString() != txtAddPayment.Text.ToString())
                {
                    MessageBox.Show("Please Add Full Payment ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new DBConnect().SendToDB("INSERT INTO Pay (Payment_Id,Bill_No,Advance,Full_payment,Total_Amount,pay_Date) VALUES ('" + dataGridView2.Rows[0].Cells[0].Value.ToString() + "','" + dataGridView2.Rows[0].Cells[1].Value.ToString() + "','" + dataGridView2.Rows[0].Cells[2].Value.ToString() + "','" + txtAddPayment.Text + "','" + dataGridView2.Rows[0].Cells[3].Value.ToString() + "','" + dtpFullPay.Value.ToString() + "')");

                    MessageBox.Show("Payment Done", "Payment Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        
        }

        private void txtPhoneSearch_Enter(object sender, EventArgs e)
        {
            if (txtPhoneSearch.Text == "Contact Number")
            {
                txtPhoneSearch.Text = "";
                txtPhoneSearch.ForeColor = Color.Black;
            }
        }

        private void txtPhoneSearch_Leave(object sender, EventArgs e)
        {
            if (txtPhoneSearch.Text == string.Empty)
            {
                txtPhoneSearch.Text = "Contact Number";
                txtPhoneSearch.ForeColor = Color.DimGray;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_receipt ar = new Add_receipt();
            ar.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            view_receipt vr = new view_receipt();
            vr.Show();

        }

       //print receipt
        private void button2_Click(object sender, EventArgs e)
        {
            Bill = txtsearch.Text;

            DataSet a = new DBConnect().GetFromDB("select Contact_Number from Customer_order where Bill_No = '"+txtsearch.Text+"'");
            conNo = Convert.ToInt32(a.Tables[0].Rows[0][0].ToString());

            DataSet b = new DBConnect().GetFromDB("Select Company_Name from customer where Contact_Number = "+conNo+"");
            comName = b.Tables[0].Rows[0][0].ToString();

            DataSet c = new DBConnect().GetFromDB("Select Address1 from customer where Contact_Number = " + conNo + "");
            Add1 = c.Tables[0].Rows[0][0].ToString();
          
            test_totalAmount = Double.Parse(totalAmount.Text.ToString());
            advance = Double.Parse(txtAdvance.Text.ToString());

            report re = new report();
            re.Show();


        }

        private void Payments_Load(object sender, EventArgs e)
        {
            
        }
    }
}