using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Windows.Forms.DataVisualization.Charting;

using System.Data.SqlClient;

namespace Main.Modules.Project_Management
{
    public partial class ProjectEvaluation_GraphicalRepresentation : Form
    {
        public ProjectEvaluation_GraphicalRepresentation()
        {
            InitializeComponent();
            DBConnect con = new DBConnect();
            string sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        ProjectEvaluation ev = new ProjectEvaluation();
        private void projects_Click(object sender, EventArgs e)
        {
            ProjectEvaluation ev=new ProjectEvaluation();

            DataSet set=ev.getprojectsdata();
            generateChart(projectschart,"projects",set,"Title",ChartValueType.String,"Percentage",ChartValueType.Double);
      

            //projectschart.Series["projects"].XValueMember = "Project Name";
            //projectschart.Series["projects"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //projectschart.Series["projects"].YValueMembers = "Percentage";
            //projectschart.Series["projects"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //DBConnect con1=new DBConnect();
            //SqlConnection con = con1.getconnection();
            ////SqlCommand cmd = new SqlCommand("select ProjectID,Percentage from Project_Progress",con);
            //SqlCommand cmd = new SqlCommand("select p2.Title,p1.Percentage,p2.ProjectColor from Project_Progress p1,Project p2 where p1.ProjectID=p2.ProjectID", con);
          
            //try
            //{
            //   con.Open();
            //   var myreader = cmd.ExecuteReader();
                
            //    while (myreader.Read())
            //    {
                   
            //        this.projectschart.Series["projects"].Points.AddXY(myreader.GetString(0), myreader.GetDouble(1));
                    

            //    }
            //}
            //catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
        }
        

        private void project_Click(object sender, EventArgs e)
        {

            string pid=comboBox1.SelectedItem.ToString();
            ProjectEvaluation ev = new ProjectEvaluation();
            
            DataSet set = ev.getprojectdata(pid);
            generateChart(projectchart, "project", set, "SubtaskName", ChartValueType.String, "Percentage", ChartValueType.Double);
            //projectchart.Series["project"].XValueMember = "SubtaskName";
            //projectchart.Series["project"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            //projectchart.Series["project"].YValueMembers = "Percentage";
            //projectchart.Series["project"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //DBConnect con1 = new DBConnect();
            //SqlConnection con = con1.getconnection();
            //string pid = comboBox1.SelectedItem.ToString();

            //SqlCommand cmd = new SqlCommand("select s.SubtaskName,p.Percentage from Subtask s,ProgressEvaluator p where s.SubtaskID=p.SubtaskID and S.SubtaskID='" + pid + "' ", con);
            //try
            //{
            //    con.Open();
            //    var myreader = cmd.ExecuteReader();
            //    while (myreader.Read())
            //    {

            //        this.projectchart.Series["project"].Points.AddXY(myreader.GetString(0), myreader.GetDouble(1));


            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void generateChart(Chart chartName, string seriesName, DataSet dataSource, string xValueMember, ChartValueType xValueType, string yValueMember, ChartValueType yValueType)
        {
            chartName.DataSource = dataSource.Tables[0];
            chartName.Series[seriesName].XValueMember = xValueMember;
            chartName.Series[seriesName].XValueType = xValueType;
            chartName.Series[seriesName].YValueMembers = yValueMember;
            chartName.Series[seriesName].YValueType = yValueType;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProjectEvaluation_GraphicalRepresentation_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
        }
    }
}
