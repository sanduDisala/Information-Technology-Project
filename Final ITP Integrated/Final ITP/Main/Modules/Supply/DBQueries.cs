using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Text.RegularExpressions;

using System.Windows.Forms;
using System.Net.Mail;

namespace Main.Modules.Supply
{
    class DBQueries
    {
        public static string sup_name;
        public string GenerateSupplierID()
        {
          //  string supplierID = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_supplier_details").Tables[0].Rows[1][0]).ToString();
            return "1";
        }
        public void SaveSupplierInformation(string supplierName, string country, int countryCode, string phoneNumber, string emailAddress, string bankName, int accountNumber)
        {
            MessageBox.Show(supplierName + " " + country + " " + countryCode.ToString() + " " + phoneNumber + " " + emailAddress + " " + bankName + " " + accountNumber.ToString());
            

            string supplierID = GenerateSupplierID();
            new DBConnect().SendToDB("INSERT INTO tbl_supplier_details ( Supplier_Name, Country, Country_Code, Phone_Number, Email_Address, Bank_Name, Account_Number) VALUES(" + "'" + supplierName + "', '" + country + "', " + countryCode + ", " + phoneNumber + ", '" + emailAddress + "', '" + bankName + "', '" + accountNumber + "')");
            MessageBox.Show("Saved Succeeded!!!");
        }

       /* public string ItemNo()
        {
            //string ItemNo = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_items").Tables[0].Rows[0][0]).ToString();
            //return ItemNo;
        }*/

        public string CheckSupplierID(string supplierName, string country)
        {
            MessageBox.Show("SELECT Supplier_ID FROM tbl_supplier_details WHERE Supplier_Name = '" + supplierName + "' AND Country= '" + country + "'", "SQL");
            string supplierID = new DBConnect().GetFromDB("SELECT Supplier_ID FROM tbl_supplier_details WHERE Supplier_Name = '" + supplierName + "' AND Country= '" + country + "'").Tables[0].Rows[0][0].ToString();
            return supplierID;
        }
        public void SaveItemInformation(string Model, string brand, string itemType, string itemName, string customerCategory, string supplierName, string country, string goodRecipient)
        {
            MessageBox.Show(Model + " " + brand + " " + itemType + " " + itemName + " " + customerCategory + " " +supplierName + " " + country + " " + goodRecipient);

            int supplierID = -1;
            supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));
            //string itemNo = GenerateItemNo();

            if (supplierID == -1)
            {
                MessageBox.Show("No Supplier Information Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new DBConnect().SendToDB("INSERT INTO tbl_items (Model, brand, Category, Type, Coustomer_Category, Supplier_ID, Country, Good_Recipient) VALUES(" + "'" + Model + "' , '" + brand + "','" + itemType + "' , '" + itemName + "' , '" + customerCategory + "' , '" + supplierID + "' , '" + country + "' , '" + goodRecipient + "')");
            }
            MessageBox.Show("Saved Succeeded!!!");
        }


        public string GenerateInvoiceNumber()
        {
            string InvoiceNumber = Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM tbl_payment").Tables[0].Rows[0][0]).ToString();
            return InvoiceNumber;
        }

        public string CheckItemNo(string itemType, string itemName)
        {
            string itemNumber = new DBConnect().GetFromDB("SELECT Item_No FROM tbl_items WHERE Item_Type = '" + itemType + "' AND Item_Name = '" + itemName + "'").Tables[0].Rows[0][0].ToString();
            return itemNumber;
        }

        //public string CheckSupplierID(string supplierName, string country)
        //{
            //string supplierID = new DBConnect().GetFromDB("SELECT Supplier_ID FROM tbl_supplier_details WHERE Supplier_Name = '" + supplierName + "' AND Country = '" + country + "'").Tables[0].Rows[0][0].ToString();
            //return supplierID;
        //}


        public void SavePaymentInformation(string invoiceNumber, string orderID, string supplierName, string country, string paymentMethod, string paymentDate, int quantity, int price, double totalAmount)
        {
            MessageBox.Show(invoiceNumber + " " + orderID + " " + supplierName + " " + country + " " + paymentMethod + " " + paymentDate + " " + quantity + " " + price + " " + totalAmount);

            //int supplierID = Convert.ToInt32(CheckSupplierID(supplierName,country));


            //int itemNo = Convert.ToInt32(CheckItemNo(itemType, itemName));
            //string invoiceNumber = InvoiceNumber();

            //if (supplierID == 0)
            //{
                //MessageBox.Show("No Supplier Information Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            {
                new DBConnect().SendToDB("INSERT INTO tbl_payment (Invoice_No, Order_ID, Supplier_Name, Country, Payment_Method, Payment_Date, Quantity, Price, Total_Amount) VALUES("+"'" + invoiceNumber + "', '" + orderID + "','" + supplierName + "','" + country + "','" + paymentMethod + "','" + paymentDate + "' ,'" + quantity.ToString() + "', '" + price.ToString() + "','" + totalAmount.ToString() + "')");
            }

            MessageBox.Show("Saved Succeeded!!!");
        }

        public void UpdateSupplierInformation( string supplierName, string country, int countryCode, string phoneNumber, string emailAddress, string bankName, int accountNumber)
        {
            MessageBox.Show(supplierName + " " + country + " " + countryCode.ToString() + " " + phoneNumber + " " + emailAddress + " " + bankName + " " + accountNumber.ToString());

            int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));
            
            //MessageBox.Show(supplierID);

            new DBConnect().SendToDB("UPDATE tbl_supplier_details SET Supplier_Name = '" + supplierName + "', Country = '" + country + "', Country_Code = " + countryCode + ", Phone_Number = " + phoneNumber + ", Email_Address = '" + emailAddress + "', Bank_Name = '" + bankName + "', Account_Number = " + accountNumber.ToString() + " WHERE Supplier_ID = " + supplierID.ToString());
            //new DBConnect().SendToDB("UPDATE tbl_supplier_details set Supplier_Name = '" + supplierName + "', Country = '" + country + "', Phone_Number = '" + phoneNumber.ToString() + "', Email_Address = '" + emailAddress + "', Account_Number = '" + accountNumber.ToString() + "' WHERE Supplier_ID = '" + supplierID + "'");
            MessageBox.Show("Updated Succeeded!!!");
        }

        public  string getsupname(string id)
        {
            try
            {
            DataSet a = new DBConnect().GetFromDB("select Supplier_Name from tbl_supplier_details where Supplier_ID=" + id + "");
            return a.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception)
            {

                return "";
            }
            
        }

        public void UpdateItemInformation(string Model, string brand, string itemType, string itemName, string customerCategory, string supplierName, string country, string goodsRecipient)
        {
            //Form1 fm = new Form1();
            //int id = Convert.ToInt32(fm.dataGridView2.SelectedRows[0].Cells[5].Value.ToString());
            //DataSet a = new DBConnect().GetFromDB("select Supplier_Name from tbl_supplier_details where Supplier_ID = "+id+"");
            //sup_name = a.Tables[0].Rows[0][0].ToString();

            MessageBox.Show(Model + " " + brand + " " + itemType + " " + itemName + " " + customerCategory + " " + supplierName + " " + country + " " + goodsRecipient);

            int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));  
            
                  

            //string item_No = GenerateItemNo();
            new DBConnect().SendToDB("UPDATE tbl_items set Model='" + Model + "', Brand='" + brand + "', Category='" + itemType + "', Type='" + itemName + "', Coustomer_Category='" + customerCategory + "', Supplier_ID='" + supplierID + "', Country='" + country + "', Good_Recipient='" + goodsRecipient + "' WHERE Supplier_ID=" + supplierID.ToString()+" AND Model='"+Model+"'");
            MessageBox.Show("Updated Succeeded!!!");
        }

        

        public void UpdatePaymentInformation(string invoiceNumber, string orderID, string supplierName, string country, string paymentMethod, string paymentDate, int quantity, int price, double totalAmount)
        {
            MessageBox.Show(invoiceNumber + " " + orderID + " " + supplierName + " " + country + " "  + paymentMethod + " " + paymentDate + " " + quantity + " " + price + " " + totalAmount.ToString());
            //int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));


            //string invoice_Number = GenerateInvoiceNumber();
            new DBConnect().SendToDB("UPDATE tbl_payment set Invoice_No='" + invoiceNumber + "', Order_ID='" + orderID + "' , Supplier_Name='" + supplierName + "' , Country='" + country + "' , Payment_Method='" + paymentMethod + "',  Payment_Date='" + paymentDate +  "', Quantity='" + quantity.ToString() + "', Price='" + price.ToString() + "', Total_Amount='" + totalAmount.ToString() + "' WHERE Invoice_No='" + invoiceNumber+"'");
            MessageBox.Show("Updated Succeeded!!!");
        }   
        
        public void DeleteSupplierInformation(string supplierName, string country, int countryCode, string phoneNumber, string emailAddress, string bankName, int accountNumber)
        {
            MessageBox.Show(supplierName + " " + country + " " + countryCode.ToString()+ phoneNumber +  emailAddress + bankName + accountNumber.ToString());
            int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));

            MessageBox.Show(supplierID.ToString());
            new DBConnect().SendToDB("DELETE FROM tbl_supplier_details WHERE Supplier_ID="+ supplierID.ToString()) ;

         
            MessageBox.Show("Deleted Succeeded!!!");

        }

        public void DeleteItemInformation(string Model, string brand, string itemType, string itemName, string customerCategory, string supplierName , string country, string goodsRecipient)
        {
            MessageBox.Show(Model + " " + brand + " " + itemType + " " + itemName + " " + customerCategory + " " + supplierName + " " + country + " " + goodsRecipient);
            int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));

            new DBConnect().SendToDB("DELETE FROM tbl_items WHERE Supplier_ID=" + supplierID.ToString() + " AND Model='" + Model + "'");


            MessageBox.Show("Deleted Succeeded!!!");

        }

        public void DeletePaymentInformation(string invoiceNumber, string orderID, string supplierName, string country, string paymentMethod, string paymentDate, int quantity, int price, double totalAmount)
        {
            MessageBox.Show(invoiceNumber + " " + orderID + " " + supplierName + " " + country + " " + paymentMethod + " " + paymentDate + " " + quantity + " " + price + " " + totalAmount.ToString());
            int supplierID = Convert.ToInt32(CheckSupplierID(supplierName, country));

            new DBConnect().SendToDB("DELETE FROM tbl_payment WHERE Invoice_No='" + invoiceNumber +"'");

            MessageBox.Show("Deleted Succeeded!!!");

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




    }
    }



        
        /*

        /*

        /*public void DeleteSupplierInformation(int supplier_ID)
        {

            //DBAccess db = new DBAccess();
            //db.connect();

        
            string query = "DELETE FROM tbl_supplier_details WHERE supplierID = '" + supplier_ID + "'";

            /*if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();*/

        //}

        /*public void DeleteItemInformation(int item_No)
        {

            //DBAccess db = new DBAccess();
            //db.connect();


            string query = "DELETE FROM tbl_items WHERE itemNo = '" + item_No + "'";

            /*if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();*/

        //}

        /*public void DeletePaymentInformation(int invoice_Number)
        {

            //DBAccess db = new DBAccess();
            //db.connect();


            string query = "DELETE FROM tbl_payment WHERE invoiceNumber = '" + invoice_Number + "'";

            /*if (db.connection.State == System.Data.ConnectionState.Closed)
            {
                db.connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();*/

       // }







    //}
//}
