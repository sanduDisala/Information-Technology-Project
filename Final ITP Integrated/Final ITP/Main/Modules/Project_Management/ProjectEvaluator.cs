using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Project_Management
{
    public partial class ProjectEvaluator : Form
    {
        string update;
       
        public ProjectEvaluator()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

            update = up_date.Value.ToString("yyyy-MM-dd ");
            ProjectEvaluation ev = new ProjectEvaluation();
            double percentage = Convert.ToDouble(percent.Text);
            if (percentage < 0 || percentage > 100)
            {

                errorProvider1.SetError(percent, "Error! select a value between 0 and 100");
            }

            else
            {
                errorProvider1.Clear();
                ev.adddata(pid.SelectedItem.ToString(), subid.SelectedItem.ToString(), update, percent.Text);
                
                DataSet data = ev.getdata();
                panels.DataSource = data.Tables[0];
            }

            
            
        }

        private void ProjectEvaluator_Load(object sender, EventArgs e)
        {

        }

        private void pid_SelectedIndexChanged(object sender, EventArgs e)
        {
            subid.Items.Clear();
            string sql = "select SubtaskID from Subtask where ProjectID='" +pid.SelectedItem.ToString() + "'";
            DBConnect con = new DBConnect();
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                subid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form = new Form1();
            form.Show();
        }

        private void percent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void percent_Validating(object sender, CancelEventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectEvaluation_GraphicalRepresentation rep = new ProjectEvaluation_GraphicalRepresentation();
            rep.Show();
            this.Dispose();
        }
    }
}
