using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Project_Management
{
    public partial class Budget : Form
    {

        DataSet set = new DataSet();
        DBConnect con = new DBConnect();
        string material, staff;
        double percentage,mat, staf,tot;
        public static string proid;
        public Budget()
        {
            InitializeComponent();
            BudgetInitializer();
            proid = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a ProjectID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (taxper.Text == "") {

                MessageBox.Show("Please enter a percentage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {
                string sql = "select Staffing , Material from ProjectBudget where ProjectID='" + comboBox1.SelectedItem.ToString() + "'";
                set = con.GetFromDB(sql);
                if (set.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("There are no charges for the project \n Check the resource table for expenses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {

                    staff = set.Tables[0].Rows[0][0].ToString();
                    material = set.Tables[0].Rows[0][1].ToString();
                    staf = Convert.ToDouble(staff);
                    mat = Convert.ToDouble(material);
                    percentage = (Convert.ToDouble(taxper.Text));
                    if (percentage < 0 || percentage > 100)
                    {

                        MessageBox.Show("Select a percentage value between 0 and 100 for tax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        tot = (staf + mat) + (staf + mat) * percentage / 100;
                        sql = "Update ProjectBudget set Tax='" + percentage + "',Total='" + tot + "' where ProjectID='" + comboBox1.SelectedItem.ToString() + "'";

                        try
                        {

                            con.SendToDB(sql);
                            MessageBox.Show("Budget Calculated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            set = getdata();
                            dataGridView1.DataSource = set.Tables[0];

                        }
                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }


                    }
                }
            }
        }
       
        public void BudgetInitializer() {

            DBConnect con = new DBConnect();
            string sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }

        
        }

        private void Budget_Load(object sender, EventArgs e)
        {

        }
        public DataSet getdata()
        {

            string sql = "select * from ProjectBudget";
            DataSet set;
            set = con.GetFromDB(sql);
            return set;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select ProjectID from Project where Title='" + name.Text + "'";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            if (set.Tables[0].Rows.Count == 0)
            {

            }
            else
            {
                string id = set.Tables[0].Rows[0][0].ToString();

               
                    string sql1 = "select * from ProjectBudget where ProjectID='" + id + "'";
                    set = con.GetFromDB(sql1);
                    dataGridView1.DataSource = set.Tables[0];
              
                    


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateReport report = new CreateReport();
            if (comboBox1.SelectedItem == null)
            {

                MessageBox.Show("Please select a projectID", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            proid = comboBox1.SelectedItem.ToString();
            report.Show();
        }
    }
}
