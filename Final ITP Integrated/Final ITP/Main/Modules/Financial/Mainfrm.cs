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
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Income ic = new Income();
            ic.Show();
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    Form ProductEntry = new ProductEntry();
        //    ProductEntry.Show();
        }

        private void masterbt_Click(object sender, EventArgs e)
        {
        //    mstr_entry.Show(master_bt, 0, master_bt.Height);//
        }

        private void mstrsub_Click(object sender, EventArgs e)
        {
            //ProductEntry p = new ProductEntry();
            //p.Show();
        }

        private void pedetails_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sales_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void sales_Click(object sender, EventArgs e)
        {
            sales s1 = new sales();
            s1.Show();
        }

        private void sales_MouseEnter(object sender, EventArgs e)
        {

        }

        private void bsheet_Click(object sender, EventArgs e)
        {
           

        }

        private void ist_Click(object sender, EventArgs e)
        {
            Reports.Income_statement i1 = new Reports.Income_statement();
            i1.Show();
        }

        private void cfs_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            Main.Modules.Financial.Purchase kk = new Main.Modules.Financial.Purchase();
            kk.Show();
            //Forms.Purchase hh = new Forms.Purchase();
            //hh.Show();
        }

        private void expenses_Click(object sender, EventArgs e)
        {
            Main.Modules.Financial.Expenditures kk = new Main.Modules.Financial.Expenditures();
            kk.Show();
        }
    }
}
