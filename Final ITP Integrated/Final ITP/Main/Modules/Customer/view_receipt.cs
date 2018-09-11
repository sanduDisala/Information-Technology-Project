using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Main.Modules.Customer
{
    public partial class view_receipt : Form
    {
        public view_receipt()
        {
            InitializeComponent();
        }

        //search bill no
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet data = new DBConnect().GetFromDB("SELECT Bill_No , Return_Date FROM Customer_order WHERE Contact_Number = " + txtConNo.Text + "");
            dataGridView1.DataSource = data.Tables[0];
        }



        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            String id = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
         
            DBConnect con = new DBConnect();
            SqlConnection conn = con.getconnection();

           string sql1 = "select img from Receipt where bill_no = '"+id+"'";

           if (conn.State != ConnectionState.Open)
               conn.Open();

           SqlCommand cmd = new SqlCommand(sql1 , conn);
           SqlDataReader rd = cmd.ExecuteReader();
           rd.Read();

            if(rd.HasRows)
           {
               byte[] img = (byte[])(rd[0]);
               if (img == null)
                   pictureBox1.Image = null;

               else
               {
                   MemoryStream ms = new MemoryStream(img);
                   pictureBox1.Image = Image.FromStream(ms);
               }
           }

        }

        
    }
}
