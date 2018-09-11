
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

namespace Main.Modules.Project_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resource_Allocation form = new Resource_Allocation();
            form.AllocateResource.Visible = false;
            form.resourcesmain.Visible = true;
            
           
            form.Show();
      
        }

        private void Assign_Pemp_Click(object sender, EventArgs e)
        {

           
        }

        private void Add_subtask_Click(object sender, EventArgs e)
        {

            //Add_Subtask sub = new Add_Subtask();
           
            Add_Subtask sub = new Add_Subtask();
            this.Hide();
            sub.sproid.Visible = true;
            sub.pid.Visible=true;
            sub.add.Visible = false;
            sub.add2.Visible = true;
            sub.add2.Location = new Point(25, 355);


           // Add_Subtask.subcnt = 0;
            sub.Show();
          
            DBConnect con = new DBConnect();
            string sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            sub.sproid.Items.Clear();
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                sub.sproid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }
           
        }

        private void Add_project_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddProject add = new AddProject();
            add.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Calcualte_budget_Click(object sender, EventArgs e)
        {
            Budget bud = new Budget();
            bud.Show();
        }

        private void Evaluate_progress_Click(object sender, EventArgs e)
        {
            ProjectEvaluator pro = new ProjectEvaluator();
            pro.Show();
            DBConnect con = new DBConnect();
            string sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            pro.pid.Items.Clear();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
               pro.pid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }
        }

        private void semail_Click(object sender, EventArgs e)
        {
            Email em=new Email();
            em.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateReport rep = new CreateReport();
            rep.Show();
        }

       
    }
}
