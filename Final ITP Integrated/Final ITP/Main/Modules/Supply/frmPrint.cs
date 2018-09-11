//using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Supply
{
    public partial class frmPrint : Form
    {
        //public static string connection = @"Data Source=DESKTOP-960TD46;Initial Catalog=Supplier_Management;Integrated Security=True";
        //private object crystalreportViewer1;
        //private object crystalreportViewer2;
        //private object ds;

        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            VB_Supplier.order or = new VB_Supplier.order();

            string Order_ID= order_details.Order_ID;
            string Model= order_details.Model;
            string Quantity= order_details.Quantity;
            string Email = order_details.Email;
            MessageBox.Show(Order_ID + Model + Quantity + Email);
            // or.SetParameterValue("pOrderID", order_details.Order_ID);
            // or.SetParameterValue("pModel", order_details.Model);
            //or.SetParameterValue("pQuantity", order_details.Quantity);
            //or.SetParameterValue("pEmail", order_details.Email);
            or.SetParameterValue("pOrderID", Order_ID);
            or.SetParameterValue("pModel", Model);
            or.SetParameterValue("pQuantity", Quantity);
            or.SetParameterValue("pEmail", Email);

            crystalReportViewer1.ReportSource = or;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
    





   
       


