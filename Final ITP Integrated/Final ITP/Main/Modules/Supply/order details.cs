using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VB_Supplier.com.mail;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace Main.Modules.Supply
{
    public partial class order_details : Form
    {
        //private order_details order_detailsBindingSource;
        //private object configu;
        //private object configurationManager;

        //public order_details Current { get; private set; }
        //public object DataSource { get; private set; }

        public static string Order_ID;
        public static string Model;
        public static string Quantity;
        public static string Email;

        public order_details()
        {
            InitializeComponent();
            //Add your Email & Password
            //MailController mailCon = new MailController("devindididdugoda2@gmail.com", "devindi123456");
            //List<Mail> mailList = mailCon.GetAllMails();
            //foreach (Mail temp in mailList)
            //{
            //    MailReader mailReader = new MailReader(temp.Summary);
            //    OrderIDTextBox.Text = mailReader.getOrderID();
            //    ModelTextBox.Text = mailReader.getModel();
            //    QuanityTextBox.Text = mailReader.getQuentity();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create a queary to get email from userID
            if (label.Text != String.Empty)
            {
                if (IsValidEmail(email.Text))
                {
                    String supplierEmail = email.Text;

                    try
                    {
                        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                        client.EnableSsl = true;
                        client.Timeout = 100000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("supplymanager6@gmail.com", "awrzdccyaovalcqz");// "supplyManager1234");
                        MailMessage msg = new MailMessage();
                        msg.To.Add(supplierEmail);
                        msg.From = new MailAddress("supplymanager6@gmail.com");
                        msg.Subject = ("New Order");

                        msg.Body = "Order ID : "+OrderIDTextBox.Text +System.Environment.NewLine+ "Item Model : " + ModelTextBox.Text+ System.Environment.NewLine+ "Quantity Needed : "  + QuanityTextBox.Text;
                        client.Send(msg);

                        MessageBox.Show("Successfully send");
                }
                    catch (Exception ex)
                {
                    MessageBox.Show("Sending Error!!");
                }
            }
                else {
                    MessageBox.Show("Invalid Email");
                }
            }
            else {
                MessageBox.Show("Supplier Email Cannot be Empty");
            }
        }

        private void QuanityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OrderIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ModelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void OrderIDTextBox_TextChanged(object sender, EventArgs e)
        {
            //try {
            //    string query = "select O.Model,P.Quantity FROM tbl_orders O,tbl_payment P WHERE O.Order_ID='" + OrderIDTextBox.Text + "' AND P.Order_ID=O.Order_ID";
            //    DBConnect db = new DBConnect();
            //    DataSet dataset = db.GetFromDB(query);

            //    if (dataset.Tables[0].Rows.Count > 0)
            //    {
            //        DataRow row = dataset.Tables[0].Rows[0];
            //        //ModelComboBox.DataSource = dataset.Tables[0];
            //        //ModelTextBox.Text = row[0].ToString();
            //        //QuanityTextBox.Text = row[1].ToString();
            //    }
            //}
            //catch(Exception){}
            //try
            //{

            //    string query = "select O.Model,P.Quantity FROM tbl_orders O,tbl_payment P WHERE O.Order_ID='"+ OrderIDTextBox .Text+ "' AND P.Order_ID=O.Order_ID";
            //    DBConnect db = new DBConnect();
            //    DataSet dataset = db.GetFromDB(query);

            //    if (dataset.Tables[0].Rows.Count > 0)
            //    {
            //        DataRow row = dataset.Tables[0].Rows[0];
            //        ModelTextBox.Text = row[0].ToString();
            //        QuanityTextBox.Text = row[1].ToString();
            //    }
            //}
            //catch (Exception)
            //{

            //   // throw;
            //}
            
               
            


        }

        private void order_details_Load(object sender, EventArgs e)
        {

        }

        bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
        }
            catch (FormatException)
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order_ID = OrderIDTextBox.Text;
            Model = ModelTextBox.Text;
            Quantity = QuanityTextBox.Text;
            Email = email.Text;
            frmPrint form = new frmPrint();
            form.Show();
            //order_details obj = order_detailsBindingSource.Current as order_details;
            //if (obj != null) { }

            //using(IDbConnection db = new sqlConnection(configurationManager.ConnectionStrings["cn"].ConnectionString))
            //{
                //if (db.State == ConnectionState.Closed)
                    //db.Open();
                //string query = "select O.Model,P.Quantity FROM tbl_orders O, tbl_payment P WHERE O.Order_ID = '"+ OrderIDTextBox .Text+ "' AND P.Order_ID = O.Order_ID'";
                //order_detailsBindingSource.DataSource = db.Query<ord>(query, CommandType: CommandType.Text);
           // }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "select DISTINCT O.Model,P.Quantity FROM tbl_ordered_Item_details O,tbl_payment P WHERE O.Order_ID='" + OrderIDTextBox.Text + "' AND P.Order_ID=O.Order_ID";// "select O.Model,P.Quantity FROM tbl_ordered_Item_details O,tbl_payment P WHERE O.Order_ID='" + OrderIDTextBox.Text + "' AND P.Order_ID=O.Order_ID";
                DBConnect db = new DBConnect();
                DataSet dataset = db.GetFromDB(query);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dataset.Tables[0].Rows[0];
                    ModelTextBox.Text = row[0].ToString();
                    QuanityTextBox.Text = row[1].ToString();
                }
            }
            catch (Exception)
            {

                // throw;
            }
        }
    }
}
