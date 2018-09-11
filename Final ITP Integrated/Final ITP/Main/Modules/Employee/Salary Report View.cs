using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Module.Employee
{
    public partial class Salary_Report_View : Form
    {
        //string month = "";
        //string code = "";
        //string name = "";
        //string designation = "";
        //double bsal = 0;
        //double allowances = 0;
        //double gross = 0;
        //double epf = 0;
        //double paye = 0;
        //double loan = 0;
        //double bonus = 0;
        //double nopay = 0;
        //double paycut = 0;
        //double other = 0;
        //double net = 0;
        //double deduction = 0;
        //double epfP = 0;
        //double etf = 0;
        //double sal_ad = 0;

        public Salary_Report_View()
        {
            InitializeComponent();
            
        }

        private void Salary_Report_View_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("report window loading");
            HRM1.Salary_Report report = new HRM1.Salary_Report();
            //MessageBox.Show("month ="+ Salary_Report_Details.re_month);
            report.SetParameterValue("month", Salary_Report_Details.re_month);
            report.SetParameterValue("name", Salary_Report_Details.re_name);
            report.SetParameterValue("code", Salary_Report_Details.re_code);
            report.SetParameterValue("designation", Salary_Report_Details.re_designation);
           // MessageBox.Show("bsal =" + Salary_Report_Details.re_bsal);
            report.SetParameterValue("basic_sal", Salary_Report_Details.re_bsal);
            report.SetParameterValue("allowances", Salary_Report_Details.re_allowances);
            report.SetParameterValue("bonus", Salary_Report_Details.re_bonus);
            report.SetParameterValue("gross", Salary_Report_Details.re_gross);
            report.SetParameterValue("epf", Salary_Report_Details.re_epf);
            report.SetParameterValue("paye", Salary_Report_Details.re_paye);
            report.SetParameterValue("loan", Salary_Report_Details.re_loan);
            report.SetParameterValue("sal_ad", Salary_Report_Details.re_sal_ad);
            report.SetParameterValue("nopay", Salary_Report_Details.re_nopay);
            report.SetParameterValue("paycut", Salary_Report_Details.re_paycut);
            report.SetParameterValue("other", Salary_Report_Details.re_other);
            report.SetParameterValue("tot_deduction", Salary_Report_Details.re_deduction);
            report.SetParameterValue("net_sal", Salary_Report_Details.re_net);
            report.SetParameterValue("epfP", Salary_Report_Details.re_epfP);
            report.SetParameterValue("etf", Salary_Report_Details.re_etf);
            crystalReportViewer1.ReportSource = report;

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        //public void set_values(string m, string n, string id, string d, double sal, double a, double bon, double gros, double epf, double paye, double loan, double sal_ad, double nopay, double pcut, double other, double tot, double net, double epfP, double etf)
        //{
        //    this.month = m;
        //    this.name = n;
        //    this.code = id;
        //    this.designation = d;
        //    this.bsal = sal;
        //    this.allowances = a;
        //    this.bonus = bon;
        //    this.gross = gros;
        //    this.epf = epf;
        //    this.paye = paye;
        //    this.loan = loan;
        //    this.sal_ad = sal_ad;
        //    this.nopay = nopay;
        //    this.paycut = pcut;
        //    this.deduction = tot;
        //    this.net = net;
        //    this.epfP = epfP;
        //    this.etf = etf;

        //}

    }
}
