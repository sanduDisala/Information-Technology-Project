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
using System.Text.RegularExpressions;




namespace Main.Modules.Supply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-960TD46;Initial Catalog=Supplier_Management;Integrated Security=True");
        private int quantity;
        private int unitPrice;
        private bool warning6;
        double total=0;

        //private object strIn;



        /*SqlCommand command = new SqlCommand();
        SqlDataReader =  dataReader;*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;

            //CON.Open();
            //SqlConnection SDA = new SqlConnection("INSERT INTO Supplier (SupplierID, SupplierName, Address, PostalCode, Country, ContactFirstName, ContactLastName, PhoneNumber, EmailAddress, Bank_1, AccountNumber_1, Bank_2, AccountNumber_2, Details) VALUES('" + TextBox17.Text + "' , '" + TextBox20.Text + "' , '" + TextBox18.Text + "' , '" + TextBox16.Text + "' , '" + comboBox3.Text + "' , '" + TextBox14.Text + "' , '" + TextBox15.Text + "' , '" + TextBox4.Text + "' , '" + TextBox13.Text + "' , '" + TextBox36.Text + "' , '" + TextBox37.Text + "' , '" + TextBox33.Text + "' , '" + TextBox34.Text + "' , '" + TextBox35.Text + "' ,)", CON );
            //SDA.SelectCommand.ExecuteNonQuery();
            //CON.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //phone validation
            {
                if ((!txt_phone_number.Text.All(char.IsDigit)) || (txt_phone_number.Text.Length != 12))
                {
                    MessageBox.Show("Invalid Phone Number");
                    warning6 = true;
                }

                //new DBQueries().bool IsValidEmail(string email){
                    //DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
                    //dataGridView1.DataSource = data.Tables[0];
                //}

                else
                {

                    //email validation

                    /*{
                        bool IsValidEmail(string strIn)
                        {
                            // Return true if strIn is in valid e-mail format.
                            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                        }

                        //email
                        string email = txt_email.Text;

                        if (IsValidEmail(email) == false)
                        {
                            MessageBox.Show("Invalid Email");
                        }

                    }*/


                    if ((cmb_supplier_name.Text.Length > 0) && (txt_country.Text.Length > 0) && (Convert.ToInt32(txt_country_code.Text.Length) > 0) && (txt_phone_number.Text.Length > 0) && (txt_email.Text.Length > 0) && (txt_bank_name.Text.Length > 0) && (Convert.ToInt32(txt_account_number.Text.Length) > 0))
                    {
                        //string supplierID = GenerateSupplierID();
                        //int supplierID = Convert.ToInt32(textBox17.Text);
                        string suppliername = cmb_supplier_name.Text;
                        string country = txt_country.Text;
                        int countryCode = Convert.ToInt32(txt_country_code.Text);
                        string phone_number = txt_phone_number.Text;
                        string email = txt_email.Text;
                        string bank_name = txt_bank_name.Text;
                        int account_number = Convert.ToInt32(txt_account_number.Text);



                        //try
                        //{

                        //     DBConnect obj = new DBConnect();
                        //     SqlConnection DBConnect = obj.DBConnection();


                        //    string sql = "insert into tbl_supplier_details (Supplier_ID, Supplier_Name, Country, Phone_Number, Email_Address, Account_Number) values ('" + supplierID + "' , '" + suppliername + "','" + country + "','" + phone_number + "','" + email + "' , '" + account_number + "')";
                        //    SqlCommand command = new SqlCommand(sql, DBConnect);


                        //    command.ExecuteNonQuery();

                        //    MessageBox.Show("Your Messege has been Sent");

                        //    //string query = "SELECT Supplier_ID, Supplier_Name, Country, Phone_Number, Email_Address, Account_Number FROM tbl_supplier_details";
                        //    //SqlConnection sqlcon1 = new SqlConnection(sqlcon);

                        //    //sqlDataReader
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}

                        //try
                        //{
                        //    string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                        //    DBConnect obj = new DBConnect();
                        //    SqlConnection DBConnect = obj.DBConnection();
                        //    //  SqlConnection DBConnect12 = new SqlConnection(connection);

                        //    string query = "Select Supplier_ID, Supplier_Name, Country, Phone_Number, Email_Address, Account_Number from tbl_supplier_details  ";
                        //    using (SqlConnection conn = new SqlConnection(connection))
                        //    {
                        //        using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                        //        {
                        //            DataSet ds = new DataSet();
                        //            adapter.Fill(ds);
                        //            dataGridView1.DataSource = ds.Tables[0];
                        //        }
                        //    }
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}

                        new DBQueries().SaveSupplierInformation(cmb_supplier_name.Text, txt_country.Text, Convert.ToInt32(txt_country_code.Text), txt_phone_number.Text, txt_email.Text, txt_bank_name.Text, Convert.ToInt32(txt_account_number.Text));
                        DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
                        this.dataGridView1.DataSource = data.Tables[0];

                        // mail@mail.com   => ^([\w\+)@([\w]+)\.([\w]+)$
                        // Phone Number like : ^(8613)(([][0-9]{3}{3})$

                        //Form1p(@"^([\w\+)@([\w] +)\.([\w] +)$", txt_email, "Mail");
                        //Form1p(@"^(8613)(([][0-9]{3}{3})$", txt_phone_number, "Phone Number");

                    }
                    else
                    {
                        MessageBox.Show("Fill Empty Fields");
                    }

                }
            }
        }

         /*public void Form1p(string fo, TextBox tb, string s)
        {
            Regex form = new Regex(fo);
            if (form.IsMatch(tb.Text))
            {
                MessageBox.Show("Valid !");
            }
            else
            {
                MessageBox.Show("Invalid !");
            }

        }*/


        //}



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            new DBQueries().DeleteSupplierInformation(cmb_supplier_name.Text, txt_country.Text, Convert.ToInt32(txt_country_code.Text), txt_phone_number.Text, txt_email.Text, txt_bank_name.Text, Convert.ToInt32(txt_account_number.Text));
            DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
            this.dataGridView1.DataSource = data.Tables[0];

            /*int id = Convert.ToInt32(textBox17.Text);
            try
            {

                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();


                string sql = "DELETE FROM tbl_supplier_details WHERE Supplier_ID = '" + id + "';" ;



                SqlCommand command = new SqlCommand(sql, DBConnect);


                command.ExecuteNonQuery();

                MessageBox.Show("Data Deleted ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            /*try
            {
                string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                SqlConnection DBConnect = new SqlConnection(sqlcon);
                string sql = "delete from tbl_supplier_details where Supplier_Name ='" + txt_supplier_name.Text + "';";
                DBConnect.Open();
                SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                SqlCommand command1 = new SqlCommand(sql, DBConnect);
                SqlDataReader reader;
                reader = command1.ExecuteReader();


                MessageBox.Show("Data Deleted");
                while (reader.Read())
                {
                }
                DBConnect.Close();


                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                DataTable ds = new DataTable();
                adapter.Update(ds);
                dataGridView1.DataSource = ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/






        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to add?", "Confermation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do you want to do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do you want to do something
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            new DBQueries().UpdateItemInformation(txt_model.Text, txt_brand.Text, cmb_item_type.Text, txt_item_name.Text, cmb_customer.Text, txt_supplier_name_1.Text, txt_country_1.Text, txt_goods_recipient.Text);
            DataSet data = new DBConnect().GetFromDB("select * from tbl_items");
            this.dataGridView2.DataSource = data.Tables[0];
            /* try
             {
                 string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True";
                 SqlConnection DBConnect = new SqlConnection(sqlcon);
                 string sql = "update tbl_items set  = Item_No'" + textbox25.Text.ToString() + "', Item_Type ='" + txt_item_type.Text + "', Item_Name ='" + txt_item_name.Text + "', Supplier_ID ='" + txt_supplier_name_1.Text.ToString() + "', Country ='" + txt_country.Text + "', Quantity ='" + txt_quantity.Text.ToString() + "', Unit_Price ='" + txt_unit_price.Text.ToString() + "', Good_Recipient = '" + txt_goods_recipient.Text + "' where Item_No = '" + textbox25.Text + "';";
                 DBConnect.Open();
                 SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                 SqlCommand command1 = new SqlCommand(sql, DBConnect);
                 SqlDataReader reader;
                 reader = command1.ExecuteReader();


                 MessageBox.Show("Data Updated");
                 while (reader.Read())
                 {
                 }
                 DBConnect.Close();


                 SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                 DataTable ds = new DataTable();
                 adapter.Fill(ds);
                 dataGridView2.DataSource = ds;
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error Message");
             }*/



        }

        private void button11_Click(object sender, EventArgs e)
        {
            new DBQueries().DeleteItemInformation(txt_model.Text, txt_brand.Text, cmb_item_type.Text, txt_item_name.Text, cmb_customer.Text, txt_supplier_name_1.Text, txt_country_1.Text, txt_goods_recipient.Text);
            DataSet data = new DBConnect().GetFromDB("select * from tbl_items");
            this.dataGridView2.DataSource = data.Tables[0];

            /*int itemNum = Convert.ToInt32(textbox25.Text);
            try
            {

                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();


                string sql = "DELETE FROM tbl_items WHERE Item_No = '" + itemNum + "';";



                SqlCommand command = new SqlCommand(sql, DBConnect);


                command.ExecuteNonQuery();

                MessageBox.Show("Data Deleted ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            /*try
            {
                string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                SqlConnection DBConnect = new SqlConnection(sqlcon);
                string sql = "delete from tbl_items where Item_No ='" + textbox25.Text.ToString() + "';";
                DBConnect.Open();
                SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                SqlCommand command1 = new SqlCommand(sql, DBConnect);
                SqlDataReader reader;
                reader = command1.ExecuteReader();


                MessageBox.Show("Data Deleted");
                while (reader.Read())
                {
                }
                DBConnect.Close();


                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                DataTable ds = new DataTable();
                adapter.Update(ds);
                dataGridView2.DataSource = ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/

        }


        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void button16_Click(object sender, EventArgs e)
        {

            if ((txt_invoice_num.Text.Length > 0) && (txt_.Text.Length > 0) && (txt_supplier_name_2.Text.Length > 0) && (txt_country_2.Text.Length > 0) && (cmb_payment_method.Text.Length > 0) && (dateTime_payment_date.Text.Length > 0) && (Convert.ToInt32(txt_quantity.Text.Length) > 0) && (Convert.ToInt32(txt_unit_price.Text.Length) > 0) && (Convert.ToDouble(txt_total_amount.Text.Length) > 0))
            {
                string invoiceNumber = txt_invoice_num.Text;
                string orderID = txt_.Text;
                string supplierName = txt_supplier_name_2.Text;
                string country = txt_country_2.Text;
                string paymentMethod = cmb_payment_method.Text;
                string paymentDate = dateTime_payment_date.Text;
                int quantity = Convert.ToInt32(txt_quantity.Text);
                int unitPrice = Convert.ToInt32(txt_unit_price.Text);
                double totalAmount = Convert.ToDouble(txt_total_amount.Text);

                //MessageBox.Show(txt_invoice_num.Text + "," + txt_.Text + "," +  txt_supplier_name_2.Text + "," + txt_country_2.Text + "," + cmb_payment_method.Text + "," + dateTime_payment_date.Text + "," + Convert.ToDouble(txt_total_amount.Text));
                new DBQueries().SavePaymentInformation(txt_invoice_num.Text, txt_.Text, txt_supplier_name_2.Text, txt_country_2.Text, cmb_payment_method.Text, dateTime_payment_date.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(txt_quantity.Text), Convert.ToInt32(txt_unit_price.Text), Convert.ToDouble(txt_total_amount.Text));


                DataSet data = new DBConnect().GetFromDB("select * from tbl_payment");
                this.dataGridView4.DataSource = data.Tables[0];


                /* try
                 {

                     DBConnect obj = new DBConnect();
                     SqlConnection DBConnect = obj.DBConnection();


                     string sql = "insert into tbl_payment (Invoice_No, Supplier_ID, Item_No, Payment_Method, Payment_Date, Total_Amount) values ('" + invoiceNumber + "','" + supplierID + "','" + itemNo + "','" + paymentMethod + "' , '" + paymentDate +  "' , '" + txt_total_amount + "')";
                     SqlCommand command = new SqlCommand(sql, DBConnect);


                     command.ExecuteNonQuery();

                     MessageBox.Show("Your Message has been Sent ");
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }

                 try
                 {
                     string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                     DBConnect obj = new DBConnect();
                     SqlConnection DBConnect = obj.DBConnection();
                     //  SqlConnection DBConnect12 = new SqlConnection(connection);

                     string query = "Select Invoice_No, Supplier_ID, Item_No, Payment_Method, Payment_Date, Total_Amount from tbl_payment  ";
                     using (SqlConnection conn = new SqlConnection(connection))
                     {
                         using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                         {
                             DataSet ds = new DataSet();
                             adapter.Fill(ds);
                             dataGridView4.DataSource = ds.Tables[0];
                         }
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }*/
            }
            else {
                MessageBox.Show("Fill Empty Fields");
            }


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            new DBQueries().UpdatePaymentInformation(txt_invoice_num.Text, txt_.Text, txt_supplier_name_2.Text, txt_country_2.Text, cmb_payment_method.Text, dateTime_payment_date.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(txt_quantity.Text), Convert.ToInt32(txt_unit_price.Text), Convert.ToDouble(txt_total_amount.Text));
            DataSet data = new DBConnect().GetFromDB("select * from tbl_payment");
            this.dataGridView4.DataSource = data.Tables[0];
            /*try
           {

               DBConnect obj = new DBConnect();
               SqlConnection DBConnect = obj.DBConnection();




               string sql = "UPDATE tbl_payment SET Invoice_No ='" + txt_invoice_num + "', Item_No ='" + txt + "' , Payment_Method ='" + cmb_payment_method + "',  Payment_Date ='" + Convert.ToDateTime(dateTime_payment_date.Text) + "', Total_Amount = '" + txt_total_amount + "' WHERE  Supplier_ID = '" + txt_ + "'";



               SqlCommand command = new SqlCommand(sql, DBConnect);


               command.ExecuteNonQuery();

               MessageBox.Show("Data Updated ");
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }*/

            /*try
            {
                string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True";
                SqlConnection DBConnect = new SqlConnection(sqlcon);
                string sql = "update tbl_payment set Invoice_No ='" + txt_invoice_num.Text.ToString() + "', Supplier_ID ='" + txt_.Text.ToString() + "', Item_No ='" + txt.Text.ToString() + "', Payment_Method ='" + cmb_payment_method.Text + "', Payment_Date ='" + dateTime_payment_date.Value.ToString() + "', Total_Amount ='" + txt_total_amount.Text.ToString() + "' where Invoice_No = '" + txt_invoice_num.Text + "';";
                DBConnect.Open();
                SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                SqlCommand command1 = new SqlCommand(sql, DBConnect);
                SqlDataReader reader;
                reader = command1.ExecuteReader();


                MessageBox.Show("Data Updated");
                while (reader.Read())
                {
                }
                DBConnect.Close();


                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView4.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/


        }

        private void button14_Click(object sender, EventArgs e)
        {
            new DBQueries().DeletePaymentInformation(txt_invoice_num.Text, txt_.Text, txt_supplier_name_2.Text, txt_country_2.Text, cmb_payment_method.Text, dateTime_payment_date.Text, Convert.ToInt32(txt_quantity.Text), Convert.ToInt32(txt_unit_price.Text), Convert.ToDouble(txt_total_amount.Text));
            DataSet data = new DBConnect().GetFromDB("select * from tbl_payment");
            this.dataGridView4.DataSource = data.Tables[0];
            /*int num = Convert.ToInt32(txt_invoice_num.Text);
            try
            {

                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();


                string sql = "DELETE FROM tbl_payment WHERE Invoice_No = '" + num + "';";



                SqlCommand command = new SqlCommand(sql, DBConnect);


                command.ExecuteNonQuery();

                MessageBox.Show("Data Deleted ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            /*try
            {
                string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                SqlConnection DBConnect = new SqlConnection(sqlcon);
                string sql = "delete from tbl_supplier_details where Invoice_Num ='" + txt_invoice_num.Text.ToString() + "';";
                DBConnect.Open();
                SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                SqlCommand command1 = new SqlCommand(sql, DBConnect);
                SqlDataReader reader;
                reader = command1.ExecuteReader();


                MessageBox.Show("Data Deleted");
                while (reader.Read())
                {
                }
                DBConnect.Close();


                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                DataTable ds = new DataTable();
                adapter.Update(ds);
                dataGridView4.DataSource = ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/





        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //bool IsValidEmail(string strIn)
            //{
            // Return true if strIn is in valid e-mail format.
            //return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //}
            //string email = txt_email.Text;

            //if (IsValidEmail(email) == false)
            //{
            //MessageBox.Show("Invalid Email");
            //}


            /*static void Mail(string[] args){

                string EmailToCheck = Console.ReadLine();

                if (IsValidEmail(EmailToCheck))
                {
                    Console.WriteLine("Yes, that was a valid e-mail address!");
                }

                else
                {
                    Console.WriteLine("No, that was not a valid e-mail address");
                }

                Main(args);
            }
        

        private static bool IsValidEmail(string EmailToCheck)
        {
            try
            {
                MailAddress mail = new MailAddress(EmailToCheck);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }*/
            /*string pattern = "^([0-9a-zA-Z)([-\\.\\w] * ([0-9a-za-Z]) * @([0-9a-zA-Z][-\\w] * [0-9a-zA-Z]\\.) + [a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txt_email.Text, pattern))
            {
               errorProvider1.clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_email, "Plese provide valid Mail address");
                return;
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //command.Connection = CON;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if ((txt_model.Text.Length > 0) && (txt_brand.Text.Length > 0) && (cmb_item_type.Text.Length > 0) && (txt_item_name.Text.Length > 0) && (cmb_customer.Text.Length > 0) && (txt_supplier_name_1.Text.Length > 0) && (txt_country_1.Text.Length > 0) && (txt_goods_recipient.Text.Length > 0))
            {
                string Model = txt_model.Text;
                string brand = txt_brand.Text;
                string itemType = cmb_item_type.Text;
                string itemName = txt_item_name.Text;
                string customerCategory = cmb_customer.Text;
                //int Supplier_ID = Convert.ToInt32(txt_supplier_name_1.Text);
                string supplierName = (txt_supplier_name_1.Text);
                string country = txt_country_1.Text;
                string goodsRecipient = txt_goods_recipient.Text;

                /*try
                {

                    DBConnect obj = new DBConnect();
                    SqlConnection DBConnect = obj.DBConnection();

                    if (Supplier_ID == 0)
                    {
                        MessageBox.Show("No Supplier Information Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sql = "insert into tbl_items (Item_No, Item_Type, Item_Name, Supplier_ID, Country, Quantity, Price, Good_Recipient) values ('" + itemNo + "' , '" + itemType + "','" + itemName + "','" + Supplier_ID + "','" + country + "' , '" + quantity + "' , '" + unitPrice + "' , '" + goodsRecipient + "')";
                        SqlCommand command = new SqlCommand(sql, DBConnect);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Your Messege has been Sent");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                    DBConnect obj = new DBConnect();
                    SqlConnection DBConnect = obj.DBConnection();
                    //  SqlConnection DBConnect12 = new SqlConnection(connection);

                    string query = "Select Item_No, Item_Type, Item_Name, Supplier_ID, Country, Quantity, Price, Good_Recipient from tbl_items  ";
                    using (SqlConnection conn = new SqlConnection(connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            dataGridView2.DataSource = ds.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/

                new DBQueries().SaveItemInformation(txt_model.Text, txt_brand.Text, cmb_item_type.Text, txt_item_name.Text, cmb_customer.Text, txt_supplier_name_1.Text, txt_country_1.Text, txt_goods_recipient.Text);
                DataSet data = new DBConnect().GetFromDB("select * from tbl_items");
                this.dataGridView2.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("Fill Empty Fields");
            }
             

        }






        private void button13_Click(object sender, EventArgs e)
        {
            DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
            this.dataGridView1.DataSource = data.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1 data = sender as dataGridView1;
            //if (data.Selected)
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            DataSet data = new DBConnect().GetFromDB("select * from tbl_payment");
            this.dataGridView4.DataSource = data.Tables[0];
            /* try
             {
                 string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                 DBConnect obj = new DBConnect();
                 SqlConnection DBConnect = obj.DBConnection();
                 //  SqlConnection DBConnect12 = new SqlConnection(connection);

                 string query = "Select Invoice_No, Supplier_ID, Item_No, Payment_Method, Payment_Date, Total_Amount  ";
                 using (SqlConnection conn = new SqlConnection(connection))
                 {
                     using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                     {
                         DataSet ds = new DataSet();
                         adapter.Fill(ds);
                         dataGridView4.DataSource = ds.Tables[0];
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataSet data = new DBConnect().GetFromDB("select * from tbl_items");
            this.dataGridView2.DataSource = data.Tables[0];

            /*try
            {
                string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();
                //  SqlConnection DBConnect12 = new SqlConnection(connection);

                string query = "Select Item_No, Item_Type, Item_Name, Supplier_ID, Country, Quantity, Price, Good_Recipient from tbl_items  ";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
            this.dataGridView1.DataSource = data.Tables[0];
            /*try
            {
                string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5;
                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();
                //  SqlConnection DBConnect12 = new SqlConnection(connection);

                string query = "Select Supplier_ID, Supplier_Name, Country, Phone_Number, Email_Address, Account_Number from tbl_supplier_details  ";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new DBQueries().UpdateSupplierInformation(cmb_supplier_name.Text, txt_country.Text, Convert.ToInt32(txt_country_code.Text), txt_phone_number.Text, txt_email.Text, txt_bank_name.Text, Convert.ToInt32(txt_account_number.Text));
            DataSet data = new DBConnect().GetFromDB("select * from tbl_supplier_details");
            this.dataGridView1.DataSource = data.Tables[0];
            /*string suppliername = txt_supplier_name.Text;
            string country = txt_country.Text;
            int phone_number = Convert.ToInt32(txt_phone_number.Text);
            string email = txt_email.Text;
            int account_number = Convert.ToInt32(txt_account_number);*/


            /*try
            {

                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();


                
                string sql = "UPDATE tbl_supplier_details SET Supplier_Name ='" + txt_supplier_name + "', Country ='" + txt_country + "', Phone_Number ='" + txt_phone_number + "', Email ='" + txt_email + "', Account_Number ='" + txt_account_number + "' WHERE Supplier_ID = '" + textBox17 + "'";



                SqlCommand command = new SqlCommand(sql, DBConnect);


                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string sqlcon = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True";
                SqlConnection DBConnect = new SqlConnection(sqlcon);
                string sql = "update tbl_supplier_details set  Supplier_Name ='" + txt_supplier_name.Text + "', Country ='" + txt_country.Text + "', Phone_Number ='" + txt_phone_number.Text.ToString() + "', Email_Address ='" + txt_email.Text + "', Account_Number ='" + txt_account_number.Text.ToString() + "' where Supplier_ID = '" + textBox17.Text + "';";
                DBConnect.Open();
                SqlConnection sqlcon1 = new SqlConnection(sqlcon);
                SqlCommand command1 = new SqlCommand(sql, DBConnect);
                SqlDataReader reader;
                reader = command1.ExecuteReader();


                MessageBox.Show("Data Updated");
                while (reader.Read())
                {
                }
                DBConnect.Close();


                SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlcon1);

                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }*/

            //tableupdate();




        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*label24.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //radioButton1.Checked = true;
            txt_supplier_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_country.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_phone_number.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_account_number.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();*/


        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*label38.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            //textBox25.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_item_type.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_item_name.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_supplier_name.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmb_country.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_quantity.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_unit_price.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_goods_recipient.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();*/
        }

        private void tblLoad1_Click(object sender, EventArgs e)
        {
            /*try
            {
                string connection = @"Data Source=ASUS-PC;Initial Catalog=Supply_Management;Integrated Security=True", DBConnect5; 
                DBConnect obj = new DBConnect();
                SqlConnection DBConnect = obj.DBConnection();
                //  SqlConnection DBConnect12 = new SqlConnection(connection);

                string query = "Select Supplier_ID, Supplier_Name, Country, Phone_Number, Email_Address, Account_Number from tbl_supplier_details where supplier_ID ='" + txt_ + "'";
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/





        }

        private void txt_phone_number_TextChanged(object sender, EventArgs e)
        {
            if ((!txt_phone_number.Text.All(char.IsDigit)) || (txt_phone_number.Text.Length != 10))
            {
                MessageBox.Show("Invalid Phone Number");
                //warning6 = true;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //View(dataGridView1, " Select * from tbl_supplier_details where Supplier_ID = " + textBox17.Text );
            try
            {
                SqlConnection DBConnect2 = sqlcon;

                string query = "Select * from tbl_supplier_details where Supplier_Name like '%" + txt_search.Text + "%'";
                using (SqlConnection conn = sqlcon)
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e. KeyChar == (char) 13)
            {
                if (string.IsNullOrEmpty(textBox17.Text))
                {
                    dataGridView1.DataSource = supplyManagementDataSetBindingSource;
                }
                else
                {
                    //var query = from o in supplyManagementDataSetBindingSource.DataSource as List<>
                                //where o.Supplier_ID == button6.Text || o.Supplier_Name.Contains(button6.Text) || o.Country == button6.Text || o.Phone_Number == button6.Text || o.Email_Address == button6.Text || o.Account_Number == (button6.Text)
                                //select o;
                    //dataGridView1.DataSource = query.ToList(); 
                }

            }*/
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            /*string pattern = "^([0-9a-zA-Z)([-\\.\\w] * ([0-9a-za-Z]) * @([0-9a-zA-Z][-\\w] * [0-9a-zA-Z]\\.) + [a-zA-Z]{2,9})$";
            //string pattern = @"^([\w]+)@([\w]+)\.([\w]+)$)";
            if (Regex.IsMatch(txt_email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txt_email, "Plese Provide Valid Mail Address");
                return;
            }*/

            //mail@mail.com
            //Regex(@"^([\w]+)@([\w]+)\.([\w]+)$", txt_email, "Mail");

        }

        private void viewTable(DataGrid gridView, string query)
        {
            //DataSet data = new DBConnect().
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*void TotalAmount()
        {
            double totalAmt1 = 0;



            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                totalAmt1 = totalAmt1 + double.Parse((dataGridView1.Rows[i].Cells[4].Value.ToString()));

            }
            txt_total_amount.Text = totalAmt1.ToString("00.00");
        }*/





        private void txt_total_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digit + char + white space

            /*if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }*/
        }

        private void txt_total_amount_Enter(object sender, EventArgs e)
        {
            /*if (txt_total_amount.Text == "Total Amount")
            {


                txt_total_amount.Text = "";


                txt_total_amount.ForeColor = Color.Black;


            }*/
        }

        private void txt_country_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_supplier_name_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt__KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digit + char + white space

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_invoice_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digit + char + white space

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_supplier_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_country_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_account_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_model_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digit + char + white space

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_item_type_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_item_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_supplier_name_1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_country_1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_quantity_Enter(object sender, EventArgs e)
        {

            if (txt_quantity.Text == "Quantitiy")
            {


                txt_quantity.Text = "";


                txt_quantity.ForeColor = Color.Black;


            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_unit_price_Enter(object sender, EventArgs e)
        {
             /*(txt_unit_price.Text == "Unit Price")
            {


                txt_unit_price.Text = "";


                txt_unit_price.ForeColor = Color.Black;


            }*/
        }

        private void txt_unit_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_goods_recipient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_account_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_country_code_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_supplier_name_TextChanged(object sender, EventArgs e)
        {
            /*DataSet dataset = new DBConnect().GetFromDB("select COUNT(*) from tbl_supplier_details");
            int supplierID = Convert.ToInt32(dataset.Tables[0].Rows[0][0]) + 1;
            int id = txt_supplier_name.Text.Substring(0, 2) + "-" + "XI0" + supplierID;
            .Text = id;*/
        }

        private void txt_country_TextChanged(object sender, EventArgs e)
        {
            /*if(txt_country.Text == txt_country.Text)
            {
                label26.ForeColor = Color.Green;
                //label26.Text = 
            }
            else
            {
                label26.ForeColor = Color.Red;

            }*/

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DBConnect con = new DBConnect();

            bool x = con.ConnectToDatabase();

            //  MessageBox.Show("hfjksdjk");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            //Factory_management.email obj = new Factory_management.email();
            //obj.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bank_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bank_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            total = ((Double.Parse(txt_unit_price.Text)) * (Convert.ToInt32(txt_quantity.Text)));

            MessageBox.Show(""+total);

            txt_total_amount.Text = total.ToString();

            //for(int i = 0; i < )
            //calculate total(quantity * unit price)
            
            //total = Convert.ToDouble()
            //string invoiceNumber = txt_invoice_num.Text;
            string orderID = txt_.Text;
            string supplierName = txt_supplier_name_2.Text;
            string country = txt_country_2.Text;
            string paymentMethod = cmb_payment_method.Text;
            string paymentDate = dateTime_payment_date.Text;

            //item obj = new item();
            double totalAmount = unitPrice * quantity;

            txt_total_amount.Text = totalAmount.ToString();

           






            



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            Main.Modules.Supply.order_details obj = new Main.Modules.Supply.order_details();
            obj.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView4.Rows[dataGridView4.SelectedRows[0].Index];
                txt_invoice_num.Text = row.Cells[0].Value.ToString();
                txt_.Text = row.Cells[1].Value.ToString();
                txt_supplier_name_2.Text = row.Cells[2].Value.ToString();
                txt_country_2.Text = row.Cells[3].Value.ToString();
                cmb_payment_method.Text = row.Cells[4].Value.ToString();
                dateTime_payment_date.Text = row.Cells[5].Value.ToString();
                txt_quantity.Text = row.Cells[6].Value.ToString();
                txt_unit_price.Text = row.Cells[7].Value.ToString();
                txt_total_amount.Text = row.Cells[8].Value.ToString();

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index];
                cmb_supplier_name.Text = row.Cells[1].Value.ToString();
                txt_country.Text = row.Cells[2].Value.ToString();
                txt_country_code.Text = row.Cells[3].Value.ToString();
                txt_phone_number.Text = row.Cells[4].Value.ToString();
                txt_email.Text = row.Cells[5].Value.ToString();
                txt_bank_name.Text = row.Cells[6].Value.ToString();
                txt_account_number.Text = row.Cells[7].Value.ToString();

            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DBQueries query = new DBQueries();
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index];
                txt_model.Text = row.Cells[0].Value.ToString();
                txt_brand.Text = row.Cells[1].Value.ToString();
                cmb_item_type.Text = row.Cells[2].Value.ToString();
                txt_item_name.Text = row.Cells[3].Value.ToString();
                cmb_customer.Text = row.Cells[4].Value.ToString();
                txt_supplier_name_1.Text =query.getsupname(row.Cells[5].Value.ToString()) ;
                txt_country_1.Text = row.Cells[6].Value.ToString();
                txt_goods_recipient.Text = row.Cells[7].Value.ToString();
            }

           
        }

        private void txt_phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Demo_Click(object sender, EventArgs e)
        {
            txt_invoice_num.Text = "AS23";
            txt_.Text = "ORPA1";
            txt_supplier_name_2.Text = "Panasonic";
            txt_country_2.Text = "china";
            cmb_payment_method.Text = "Check";
            dateTime_payment_date.Text = "2017-11-22";
            txt_quantity.Text = "2";
            txt_unit_price.Text = "200";
        }

        private void button9_Click_3(object sender, EventArgs e)
        {
            cmb_supplier_name.Text = "Panasonic";
            txt_country.Text = "china";
            txt_country_code.Text = "86";
            txt_phone_number.Text = "132456789012";
            txt_email.Text = "panasonic@gmail.com";
            txt_bank_name.Text = "CC";
            txt_account_number.Text = "12345678";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txt_model.Text = "ABCX";
            txt_brand.Text = "LG";
            cmb_item_type.Text = "Indoor Screen";
            txt_item_name.Text = "screen";
            cmb_customer.Text = "Indoor Advertising";
            txt_supplier_name_2.Text = "Panasonic";
            txt_country_1.Text = "china";
            txt_goods_recipient.Text = "singhegiri";
        }
    }
}
    

