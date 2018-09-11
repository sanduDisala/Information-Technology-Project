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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        DBConnect db = new DBConnect();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {

            Custome_Management_System.Bill_Report br = new Custome_Management_System.Bill_Report();
            Payments pm = new Payments();
            //get current date
            String current = DateTime.Now.Date.ToString();

            //pass parameter values       
            br.SetParameterValue("totalAmount", Payments.test_totalAmount);
            br.SetParameterValue("ConNo", Payments.conNo);
            br.SetParameterValue("CName", Payments.comName);
            br.SetParameterValue("Add1", Payments.Add1);
            br.SetParameterValue("Bill", Payments.Bill);
            br.SetParameterValue("Advance", Payments.advance);
            br.SetParameterValue("PDate", current);

           DataSet a = new DBConnect().GetFromDB("select Item_No , Quantity , Unit_Price ,Total_Amount from Advance_Bill where Bill_No = '"+ Payments.Bill+"' ");

           if (a.Tables[0].Rows.Count > 0)
           {
               br.SetParameterValue("item1",  a.Tables[0].Rows[0][0].ToString());
               br.SetParameterValue("quantity1", a.Tables[0].Rows[0][1].ToString());
               br.SetParameterValue("unitPrice1",a.Tables[0].Rows[0][2].ToString());
               br.SetParameterValue("amount1",a.Tables[0].Rows[0][3].ToString());
               br.SetParameterValue("item2", "");
               br.SetParameterValue("quantity2","");
               br.SetParameterValue("unitPrice2", "");
               br.SetParameterValue("amount2", "");
               br.SetParameterValue("item3", "");
               br.SetParameterValue("quantity3", "");
               br.SetParameterValue("unitPrice3", "");
               br.SetParameterValue("amount3", "");
               br.SetParameterValue("item4", "");
               br.SetParameterValue("quantity4","");
               br.SetParameterValue("unitPrice4", "");
               br.SetParameterValue("amount4","");
           }

           if (a.Tables[0].Rows.Count > 1)
           {
               br.SetParameterValue("item2", a.Tables[0].Rows[1][0].ToString());
               br.SetParameterValue("quantity2", a.Tables[0].Rows[1][1].ToString());
               br.SetParameterValue("unitPrice2", a.Tables[0].Rows[1][2].ToString());
               br.SetParameterValue("amount2", a.Tables[0].Rows[1][3].ToString());
               br.SetParameterValue("item3", "");
               br.SetParameterValue("quantity3", "");
               br.SetParameterValue("unitPrice3", "");
               br.SetParameterValue("amount3", "");
               br.SetParameterValue("item4", "");
               br.SetParameterValue("quantity4", "");
               br.SetParameterValue("unitPrice4", "");
               br.SetParameterValue("amount4", "");
           }

           if (a.Tables[0].Rows.Count > 2)
           {
               br.SetParameterValue("item3", a.Tables[0].Rows[2][0].ToString());
               br.SetParameterValue("quantity3", a.Tables[0].Rows[2][1].ToString());
               br.SetParameterValue("unitPrice3", a.Tables[0].Rows[2][2].ToString());
               br.SetParameterValue("amount3", a.Tables[0].Rows[2][3].ToString());
               br.SetParameterValue("item4", "");
               br.SetParameterValue("quantity4", "");
               br.SetParameterValue("unitPrice4", "");
               br.SetParameterValue("amount4", "");
           }

           if (a.Tables[0].Rows.Count > 3)
           {
               br.SetParameterValue("item4", a.Tables[0].Rows[3][0].ToString());
               br.SetParameterValue("quantity4", a.Tables[0].Rows[3][1].ToString());
               br.SetParameterValue("unitPrice4", a.Tables[0].Rows[3][2].ToString());
               br.SetParameterValue("amount4", a.Tables[0].Rows[3][3].ToString());
           }
           
            crystalReportViewer1.ReportSource = br;

            
            
        }
    }
}
