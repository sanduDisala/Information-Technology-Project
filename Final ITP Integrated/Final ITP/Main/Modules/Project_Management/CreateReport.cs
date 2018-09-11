using System;
using System.Data;
using System.Windows.Forms;
//using Main.Modules.Project;




namespace Main.Modules.Project_Management
{
    public partial class CreateReport : Form
    {
        public CreateReport()
        {
            InitializeComponent();
        }
        string projectid;
        private void CreateReport_Load(object sender, EventArgs e)
        {
            projectid = Budget.proid;
            MessageBox.Show(projectid.ToString());
            ProjectProposal pr = new ProjectProposal();
            Project proj = new Project();
            DataSet data = proj.getData(projectid);
           // MessageBox.Show(data.Tables[0].Rows[0][1].ToString());
            //pr.SetParameterValue("PDATE", data.Tables[0].Rows[0][5].ToString() + " to " + data.Tables[0].Rows[0][6].ToString());
            pr.SetParameterValue("projectid", data.Tables[0].Rows[0][0].ToString());
            pr.SetParameterValue("ptitle", data.Tables[0].Rows[0][1].ToString());
            pr.SetParameterValue("ptype", data.Tables[0].Rows[0][2].ToString());
            pr.SetParameterValue("pclient",data.Tables[0].Rows[0][3].ToString());
            pr.SetParameterValue("pimpdate", data.Tables[0].Rows[0][5].ToString() + " / " + data.Tables[0].Rows[0][7].ToString()+" Days"); 
           

            DataSet probj = proj.getobjectives(projectid);
            pr.SetParameterValue("pobj", probj.Tables[0].Rows[0][1].ToString());
            pr.SetParameterValue("pstra", probj.Tables[0].Rows[0][2].ToString());

            crystalReportViewer1.ReportSource = pr;
        }
    }
}
