using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrystalDecisions.CrystalReports.Engine;

namespace Main.Module.Employee
{
    public partial class Salary_Report_Details : Form
    {
        FormValidation fv = new FormValidation();
        DBConnect setter = new DBConnect();
        DataSet ds = new DataSet();

        public static string re_month = "";
        public static string re_code = "";
        public static string re_name = "";
        public static string re_designation = "";
        public static double re_bsal = 0;
        public static double re_allowances = 0;
        public static double re_gross = 0;
        public static double re_epf = 0;
        public static double re_paye = 0;
        public static double re_loan = 0;
        public static double re_bonus = 0;
        public static double re_nopay = 0;
        public static double re_paycut = 0;
        public static double re_other = 0;
        public static double re_net = 0;
        public static double re_deduction = 0;
        public static double re_epfP = 0;
        public static double re_etf = 0;
        public static double re_sal_ad = 0;

        public Salary_Report_Details()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sr_empcode_Leave(object sender, EventArgs e)
        {
            fv.empcode_validator(sr_empcode.Text, sr_err_code);
        }

        private void sr_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void sr_month_Leave(object sender, EventArgs e)
        {
            fv.checkEmpty(sr_month.Text, sr_err_month);
        }

        private void sr_loan_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_loan.Text, err_loan);
        }

        private void sr_nopay_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_nopay.Text, err_nopay);
        }

        private void sr_pcut_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_pcut.Text, err_pcut);
        }

        private void sr_other_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_other.Text, err_other);
        }

        private void sr_bonus_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_bonus.Text, err_bonus);
        }

        private void sr_salAdvance_Leave(object sender, EventArgs e)
        {
            fv.decimal_Validator(sr_salAdvance.Text, err_salAd);
        }

        private void view_Click(object sender, EventArgs e)
        {
            Boolean c1 = fv.empcode_validator(sr_empcode.Text, sr_err_code);
            Boolean c2 = fv.checkEmpty(sr_month.Text, sr_err_month);
            Boolean c3 = fv.decimal_Validator(sr_loan.Text, err_loan);
            Boolean c4 = fv.decimal_Validator(sr_nopay.Text, err_nopay);
            Boolean c5 = fv.decimal_Validator(sr_pcut.Text, err_pcut);
            Boolean c6 = fv.decimal_Validator(sr_other.Text, err_other);
            Boolean c7 = fv.decimal_Validator(sr_salAdvance.Text, err_salAd);
            Boolean c8 = fv.decimal_Validator(sr_bonus.Text, err_bonus);

            

            if ((c1 || c2 || c3 || c4 || c5 || c6 || c7 || c8) == false)
            {
                re_code = sr_empcode.Text;
                ds = setter.GetFromDB("SELECT name_initials FROM employee_details WHERE emp_code = '"+ re_code +"'");
                re_name = ds.Tables[0].Rows[0][0].ToString();
                //MessageBox.Show("name = "+name);
                ds = setter.GetFromDB("SELECT designation FROM office_detail WHERE emp_code = '" + re_code + "'");
                re_designation = ds.Tables[0].Rows[0][0].ToString();
                //MessageBox.Show("designation = " + designation);
                ds = setter.GetFromDB("SELECT * FROM salary_and_tax_details WHERE emp_code = '" + re_code + "'");
                re_bsal = Double.Parse(ds.Tables[0].Rows[0].ItemArray[1].ToString());
                re_allowances = Double.Parse(ds.Tables[0].Rows[0].ItemArray[8].ToString());
                //MessageBox.Show("bsal = "+bsal+" allow"+ allowances);
                re_bonus = Double.Parse(sr_bonus.Text);
                re_gross = re_bsal + re_allowances + re_bonus;
                re_epf = Double.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
                re_paye = Double.Parse(ds.Tables[0].Rows[0].ItemArray[6].ToString());
                re_loan = Double.Parse(sr_loan.Text);
                re_sal_ad = Double.Parse(sr_salAdvance.Text);
                re_nopay = Double.Parse(sr_nopay.Text);
                re_paycut = Double.Parse(sr_pcut.Text);
                re_other = Double.Parse(sr_other.Text);
                re_deduction = re_epf + re_paye + re_loan + re_sal_ad + re_nopay + re_paycut + re_other;
                re_net = re_gross - re_deduction;
                re_epfP = re_bsal * 0.12;
                re_etf = Double.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                //MessageBox.Show("gross"+gross+" epf"+epf+" paye"+paye+" loan"+loan+" salad"+sal_ad+" nopay="+nopay+" paycut"+paycut+" other"+other+" deduction"+deduction+" net"+net+" epfP"+epfP+" etf"+etf);

                lb_name.Text = re_name;
                lb_code.Text = re_code;
                lb_desig.Text = re_designation;
                lb_bsal.Text = Math.Round(re_bsal, 2).ToString() + ".00";
                lb_allowance.Text = Math.Round(re_allowances, 2).ToString() + ".00";
                lb_bonus.Text = Math.Round(re_bonus, 2).ToString() + ".00";
                lb_gross.Text = Math.Round(re_gross, 2).ToString() + ".00";
                lb_epf.Text = Math.Round(re_epf, 2).ToString() + ".00";
                lb_paye.Text = Math.Round(re_paye, 2).ToString() + ".00";
                lb_loan.Text = Math.Round(re_loan, 2).ToString() + ".00";
                lb_sal_ad.Text = Math.Round(re_sal_ad, 2).ToString() + ".00";
                lb_nopay.Text = Math.Round(re_nopay, 2).ToString() + ".00";
                lb_paycut.Text = Math.Round(re_paycut, 2).ToString() + ".00";
                lb_other.Text = Math.Round(re_other, 2).ToString() + ".00";
                lb_ded.Text = Math.Round(re_deduction, 2).ToString() + ".00";
                lb_net.Text = Math.Round(re_net, 2).ToString() + ".00";
                lb_epfP.Text = Math.Round(re_epfP, 2).ToString() + ".00";
                lb_etf.Text = Math.Round(re_etf, 2).ToString() + ".00";
                report.Visible = true;

                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            Boolean c1 = fv.empcode_validator(sr_empcode.Text, sr_err_code);
            Boolean c2 = fv.checkEmpty(sr_month.Text, sr_err_month);
            Boolean c3 = fv.decimal_Validator(sr_loan.Text, err_loan);
            Boolean c4 = fv.decimal_Validator(sr_nopay.Text, err_nopay);
            Boolean c5 = fv.decimal_Validator(sr_pcut.Text, err_pcut);
            Boolean c6 = fv.decimal_Validator(sr_other.Text, err_other);
            Boolean c7 = fv.decimal_Validator(sr_salAdvance.Text, err_salAd);
            Boolean c8 = fv.decimal_Validator(sr_bonus.Text, err_bonus);



            if ((c1 || c2 || c3 || c4 || c5 || c6 || c7 || c8) == false)
            {
                re_code = sr_empcode.Text;
                ds = setter.GetFromDB("SELECT name_initials FROM employee_details WHERE emp_code = '" + re_code + "'");
                re_name = ds.Tables[0].Rows[0][0].ToString();
              //  MessageBox.Show("name = " + re_name);
                ds = setter.GetFromDB("SELECT designation FROM office_detail WHERE emp_code = '" + re_code + "'");
                re_designation = ds.Tables[0].Rows[0][0].ToString();
              //  MessageBox.Show("designation = " + re_designation);
                ds = setter.GetFromDB("SELECT * FROM salary_and_tax_details WHERE emp_code = '" + re_code + "'");
                re_bsal = Double.Parse(ds.Tables[0].Rows[0].ItemArray[1].ToString());
                re_allowances = Double.Parse(ds.Tables[0].Rows[0].ItemArray[8].ToString());
              //  MessageBox.Show("bsal = " + re_bsal + " allow" + re_allowances);
                re_bonus = Double.Parse(sr_bonus.Text);
                re_gross = re_bsal + re_allowances + re_bonus;
                re_epf = Double.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
                re_paye = Double.Parse(ds.Tables[0].Rows[0].ItemArray[6].ToString());
                re_loan = Double.Parse(sr_loan.Text);
                re_sal_ad = Double.Parse(sr_salAdvance.Text);
                re_nopay = Double.Parse(sr_nopay.Text);
                re_paycut = Double.Parse(sr_pcut.Text);
                re_other = Double.Parse(sr_other.Text);
                re_deduction = re_epf + re_paye + re_loan + re_sal_ad + re_nopay + re_paycut + re_other;
                re_net = re_gross - re_deduction;
                re_epfP = re_bsal * 0.12;
                re_etf = Double.Parse(ds.Tables[0].Rows[0].ItemArray[4].ToString());
               // MessageBox.Show("gross" + re_gross + " epf" + re_epf + " paye" + re_paye + " loan" + re_loan + " salad" + re_sal_ad + " nopay=" + re_nopay + " paycut" + re_paycut + " other" + re_other + " deduction" + re_deduction + " net" + re_net + " epfP" + re_epfP + " etf" + re_etf);

                re_month = sr_month.Text; 
                // MessageBox.Show("month = " + re_month);
                Salary_Report_View view = new Salary_Report_View();
                //view.set_values(month, name, code, designation,bsal, allowances, bonus, gross, epf, paye, loan, sal_ad, nopay, paycut, other, deduction, net, epfP, etf);
                view.Show();
            }
        }

        private void demo_Click(object sender, EventArgs e)
        {
            sr_empcode.Text = "E0006";
            sr_month.Text = "September";
            sr_bonus.Text = "2000";
            sr_loan.Text = "1000";
            sr_nopay.Text = "0";
            sr_pcut.Text = "0";
            sr_salAdvance.Text = "500";
            sr_other.Text = "0";
        }

        

        

    }
}
