using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Main.Modules.Project_Management
{
    class ProjectEvaluation
    {

        double percent;
        string sql, sql1;
        DBConnect con2 = new DBConnect();
        public void adddata(string pid, string subid, string date, string percentage)
        {
            DBConnect con = new DBConnect();
            sql1 = "select Percentage from ProgressEvaluator where SubtaskID='" + subid + "'";
            
            DataSet set = con.GetFromDB(sql1);
            //MessageBox.Show("I have no errors 1st");
            percent = Convert.ToDouble(percentage);
           
            if (set.Tables[0].Rows.Count == 0)
            {
                try
                {

                    sql = "insert into ProgressEvaluator(ProjectID,SubtaskID,UpdateDate,Percentage) values('" + pid + "','" + subid + "','" + date + "','" + percent + "')";
              
                    DBConnect con1 = new DBConnect();
                  
                    con1.SendToDB(sql);

                   
                    MessageBox.Show("Recorded");
                   
                    projectprogress(pid);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            else
            {
                try
                {
                    sql = "Update ProgressEvaluator set Percentage='" + percent + "'  where SubtaskID= '" + subid + "'";
                    con.SendToDB(sql);
                    MessageBox.Show("Recorded");
                    projectprogress(pid);
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public DataSet getprojectdata(string pid)
        {
            DBConnect con = new DBConnect();
            sql = "select p.Percentage,s.SubtaskName from ProgressEvaluator p,Subtask s where p.SubtaskID=s.SubtaskID and p.ProjectID='"+pid+"'";
            DataSet set;
            set = con.GetFromDB(sql);
            return set;


        }
        public DataSet getprojectsdata()
        {

            DBConnect con = new DBConnect();
            sql = "select p2.Title,p1.Percentage,p2.ProjectColor from Project_Progress p1,Project p2 where p1.ProjectID=p2.ProjectID";

            DataSet set = con.GetFromDB(sql);
            return set;


        }
        public DataSet getdata(){
        
        DBConnect con=new DBConnect();
            sql="select * from ProEvaluator";
            DataSet set=con.GetFromDB(sql);
            return set;
        
        }
        
        public void projectprogress(string pid)
        {
            
            sql = "select NumberOfSubtasks from Project where ProjectID='" + pid + "'";
            DataSet data = new DataSet();
            data = con2.GetFromDB(sql);
           // MessageBox.Show("I have no errors 1");
            string no = data.Tables[0].Rows[0][0].ToString();
            int num = Convert.ToInt32(no);
            MessageBox.Show(num.ToString());

            sql1 = "select Percentage from Project_Progress where ProjectID='" + pid + "'";
            DataSet data1 = new DataSet();
            data1 = con2.GetFromDB(sql1);
            //MessageBox.Show("I have no errors 2");

            sql = "select Percentage from ProgressEvaluator where ProjectID='" + pid + "'";
            
            data = con2.GetFromDB(sql);
            //MessageBox.Show("I have no errors 3 good");
            double final = 0 ;
           
            
            double value1;
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {

                value1=Convert.ToDouble(data.Tables[0].Rows[i][0].ToString());
                if (data1.Tables[0].Rows.Count == 0)
                {



                    final = (value1 / num);
                    
                    MessageBox.Show(value1.ToString() + num.ToString() + final.ToString());
                    try
                    {
                        sql1 = "Insert into Project_Progress(ProjectID,Percentage) values('" + pid + "','" + final + "')";
                        con2.SendToDB(sql1);
                      

                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.ToString());

                    }
                }

                else
                {
                    string curr = data1.Tables[0].Rows[0][0].ToString();

                    final = final + (value1 / num);
                    MessageBox.Show(value1.ToString() + num.ToString() + final.ToString());
                    try
                    {
                        sql1 = "Update Project_Progress set Percentage='" + final + "' where ProjectID='"+pid+"'";
                        con2.SendToDB(sql1);
                      
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.ToString());

                    }
                }
            }
            }










        }
    
}
