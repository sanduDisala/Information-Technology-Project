using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Financial
{
    public partial class FinancialMain : Form
    {
        public FinancialMain()
        {
            InitializeComponent();
        }


        private void FinancialMain_Load(object sender, EventArgs e)
        {
            pnlDashBoard.BackColor = Color.FromArgb(128, 255, 255, 255);
            pnlBody.BackColor = Color.FromArgb(128, 255, 255, 255);

            int width = Screen.PrimaryScreen.WorkingArea.Width;
            int length = Screen.PrimaryScreen.WorkingArea.Height;

            MessageBox.Show(pnlBody.Width.ToString() + "x" + pnlBody.Height.ToString());
        }

        Expenditures expenditure = null;
        Income income = null;
        Purchase purchase = null;
        sales sales = null;
        Reports.Income_statement incomeStatement = new Reports.Income_statement(); 

        private void btnSales_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (sales == null)
            {
                sales = new sales();
                sales.TopLevel = false;
                sales.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(sales);
                sales.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                sales.Show();
            }
            else {
                pnlBody.Controls.Add(sales);
                sales.Activate();
            }
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (purchase == null)
            {
                purchase = new Purchase();
                purchase.TopLevel = false;
                purchase.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(purchase);
                purchase.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                purchase.Show();
            }
            else
            {
                pnlBody.Controls.Add(purchase);
                purchase.Activate();
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (income == null)
            {
                income = new Income();
                income.TopLevel = false;
                income.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(income);
                income.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                income.Show();
            }
            else
            {
                pnlBody.Controls.Add(income);
                income.Activate();
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (expenditure == null)
            {
                expenditure = new Expenditures();
                expenditure.TopLevel = false;
                expenditure.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(expenditure);
                expenditure.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                expenditure.Show();
            }
            else
            {
                pnlBody.Controls.Add(expenditure);
                expenditure.Activate();
            }
        }

        private void btnIncomeStatement_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            if (incomeStatement == null)
            {
                incomeStatement = new Reports.Income_statement();
                incomeStatement.TopLevel = false;
                incomeStatement.Dock = DockStyle.Fill;
                pnlBody.Controls.Add(incomeStatement);
                incomeStatement.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                incomeStatement.Show();
            }
            else
            {
                incomeStatement.TopLevel = false;
                pnlBody.Controls.Add(incomeStatement);
                incomeStatement.Activate();
            }
        }       
    }
}
