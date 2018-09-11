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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Collections;

namespace Main.Modules.Event
{
    public partial class Report : Form
    {
        EventManagement.PayementRt r1 = new EventManagement.PayementRt();

        private string p;
        string sql, sql1;
        DBConnect con = new DBConnect();
        DataSet set;
        DataSet set1;

        public Report()
        {
            InitializeComponent();
        }


        private void Report_Load(object sender, EventArgs e)
        {
            EventManagement.PayementRt rt1 = new EventManagement.PayementRt();
            //rt1.SetParameterValue("ename",p);
            //crystalReportViewer1.ReportSource = rt1;
            payment p1 = new payment();

           // MessageBox.Show(p1.hir_id.Text);
            sql = "select hired_compo, price, count, no_of_date from Hired_Compo_Details where hire_id='" + payment.id + "'";
            set=con.GetFromDB(sql);


            sql1 = "select deposit, hired_compo_charges, extra_charge, Transpotation,Total_amount from Payment where hired_id='" + payment.id + "'";
            set1 = con.GetFromDB(sql1);

            rt1.SetParameterValue("Hid", payment.id);
             rt1.SetParameterValue("pdate", payment.dt);
            rt1.SetParameterValue("Name", payment.nme);
            rt1.SetParameterValue("ename", payment.enme);

          //  rt1.SetParameterValue("no", " "+"1" + " \n" + "\n"+ " " + "2 ");
            if (set.Tables[0].Rows.Count > 0 )
            {
                rt1.SetParameterValue("no", " " + "1");
                rt1.SetParameterValue("para", " " + set.Tables[0].Rows[0][0].ToString());
                rt1.SetParameterValue("price", set.Tables[0].Rows[0][1].ToString());
                rt1.SetParameterValue("unit", " " + set.Tables[0].Rows[0][2].ToString());
                rt1.SetParameterValue("day", " " + set.Tables[0].Rows[0][3].ToString());
            }
            
            if (set.Tables[0].Rows.Count > 1)
            {
                rt1.SetParameterValue("no1", " " + "2");
                rt1.SetParameterValue("para1", " " + set.Tables[0].Rows[1][0].ToString());
                rt1.SetParameterValue("price1", set.Tables[0].Rows[1][1].ToString());
                rt1.SetParameterValue("unit1", " " + set.Tables[0].Rows[1][2].ToString());
                rt1.SetParameterValue("day1", " " + set.Tables[0].Rows[1][3].ToString());
            }

            if (set.Tables[0].Rows.Count > 2)
            {
                rt1.SetParameterValue("no2", " " + "3");
                rt1.SetParameterValue("para2", " " + set.Tables[0].Rows[2][0].ToString());
                rt1.SetParameterValue("price2", set.Tables[0].Rows[2][1].ToString());
                rt1.SetParameterValue("unit2", " " + set.Tables[0].Rows[2][2].ToString());
                rt1.SetParameterValue("day2", " " + set.Tables[0].Rows[2][3].ToString());
            }

            if (set.Tables[0].Rows.Count > 3)
            {
                rt1.SetParameterValue("no3", " " + "4");
                rt1.SetParameterValue("para3", " " + set.Tables[0].Rows[3][0].ToString());
                rt1.SetParameterValue("price3", set.Tables[0].Rows[3][1].ToString());
                rt1.SetParameterValue("unit3", " " + set.Tables[0].Rows[3][2].ToString());
                rt1.SetParameterValue("day3", " " + set.Tables[0].Rows[3][3].ToString());

            }


           // if ((set1.Tables[0].Rows[0][0].ToString() != null) && (Convert.ToDouble(set1.Tables[0].Rows[0][0].ToString()) != 0))
           // if (set1.Tables[0].Rows.Count == 0)
            if((Convert.ToDouble(set1.Tables[0].Rows[0][0].ToString()) != 0))
            {
               // MessageBox.Show("Null");
                rt1.SetParameterValue("depo", " " + set1.Tables[0].Rows[0][0].ToString());
            }
            else
            {
                rt1.SetParameterValue("depo", " " + " - ");
            }

            rt1.SetParameterValue("ch", " " + set1.Tables[0].Rows[0][1].ToString());

            if ((Convert.ToDouble(set1.Tables[0].Rows[0][2].ToString())) != 0)
            {
                rt1.SetParameterValue("ex", " " + set1.Tables[0].Rows[0][2].ToString());
            }
            else
            {
                rt1.SetParameterValue("ex", " " + " - ");
            }

            rt1.SetParameterValue("trans", " " + set1.Tables[0].Rows[0][3].ToString());
            rt1.SetParameterValue("tot", " " + set1.Tables[0].Rows[0][4].ToString());

            crystalReportViewer1.ReportSource = rt1;

       
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
