using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Net.Mail;
using System.Net;

using System.Data;

namespace Main
{
    class DBConnect
    {
        private SqlConnection databaseConnection = new SqlConnection("Data Source=.;Initial Catalog=ITP_Final;Integrated Security=True");

        public SqlConnection getconnection()
        {
            return databaseConnection;
        }
        
        public Boolean ConnectToDatabase()
        {            
            if (databaseConnection.State == System.Data.ConnectionState.Closed)
            {
                databaseConnection.Open();
                return true;
            }
            else{
                MessageBox.Show("Database connection is already opened", "Operation not successful");
                return false;
            }
        }

        public Boolean DisconnectFromDatabase() {
            if (databaseConnection.State == System.Data.ConnectionState.Open)
            {
                databaseConnection.Close();
                return true;
            }
            else {
                MessageBox.Show("Database connection is already closed", "Operation not successful");
                return false;
            }
        }

        public void SendToDB(string query)
        {
            SqlCommand executer = new SqlCommand(query, databaseConnection);
            try
            {
                ConnectToDatabase();
                executer.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message, "SQLException Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (TimeoutException error)
            {
                MessageBox.Show(error.Message, "TimeOutException Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (InvalidOperationException error) {
                MessageBox.Show(error.Message, "InvalidOperationException Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            executer.CommandTimeout = 30;
            DisconnectFromDatabase();
        }

        public DataSet GetFromDB(string query) {
            SqlDataAdapter data = new SqlDataAdapter(query, databaseConnection);                      
            DataSet dataset = new DataSet();

            if (data != null)
            {
                
                data.Fill(dataset);
            }
            else {
                dataset = null;
            }            
            return dataset;
        }

        public void sendMail(string sender,string receiver,string subject,string messageBody,string senderAccountPassword) {
            MailMessage mail = new MailMessage(sender, receiver, subject, messageBody);
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            NetworkCredential netcred = new NetworkCredential(sender, senderAccountPassword);
            client.Credentials = netcred;
            client.EnableSsl = true;

            try
            {
                client.Send(mail);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message, "Error - SMTPException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
