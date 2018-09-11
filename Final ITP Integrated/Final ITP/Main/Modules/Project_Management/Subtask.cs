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
    class Subtask
    {
        //String ProjectID;
       // String SubtaskName;
        //int Duration;
        string sql;
       
        public static  string Projectid;
        string subtaskid;
        DBConnect con = new DBConnect();
        public static int count = 0;
        

        public void AddSubtask(string sname,DateTime sdate,DateTime edate,int dur) 
        {
            
                try
                {
                    subtaskid = GetSubtaskID(sname);
                    sql = "insert into Subtask(SubtaskID,ProjectID,SubtaskName,StartDate,EndDate,Duration) values('" + subtaskid + "','" + Projectid + "','" + sname + "','" + sdate + "','" + edate + "','" + dur + "')";
                    con.SendToDB(sql);
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());


                }
            
        }

        public void AddSubtask(string pid, string sname,DateTime sdate, DateTime edate, int dur) 
        {
            Projectid = pid;
          
            try
            {
                
                subtaskid = GetSubtaskID(sname);
                sql = "insert into Subtask(SubtaskID,ProjectID,SubtaskName,StartDate,EndDate,Duration) values('" + subtaskid + "','" + Projectid + "','" + sname + "','" + sdate + "','" + edate + "','" + dur + "')";
                con.SendToDB(sql);
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());


            }
        
        
        
        
        }

      
        public string GetSubtaskID(string sname) {

            count++;
          
            subtaskid = Projectid.Substring(0,1) +" "+sname.Substring(0,1)+count;
            Add_Subtask.count++;
            return subtaskid;
        }

        public DataSet getdata() {

            sql = "select * from Subtask";
            DataSet set;
            set=con.GetFromDB(sql);
            return set;


        }
        public void update(string pid,string Sid,string sname, string sdate, string edate, int dur) {
            try
            {

                sql = "update Subtask set SubtaskName='" + sname + "',StartDate='" + sdate + "',EndDate='" + edate + "',Duration='" + dur + "' where  SubtaskID='" + Sid + "'";
                con.SendToDB(sql);
               MessageBox.Show("Updated");
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.ToString());
            }
        
        }
        public void delete(string subid) {
            try
            {

                resourceup(subid);
                sql = "Delete from Staff where SubtaskID='" + subid + "'";
                con.SendToDB(sql);

                sql = "Delete from Material where SubtaskID='" + subid + "'";
                con.SendToDB(sql);

                progress_decre(subid);
                //sql = "Delete from ProgressEvaluator where SubtaskID='" + subid + "'";
                //con.SendToDB(sql);



                sql = "Delete from Subtask where SubtaskID='" + subid + "'";
                con.SendToDB(sql);

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            
            }
        }
        public void progress_decre(string subid) {
            try
            {
                sql = "select ProjectID from ProgressEvaluator where SubtaskID='" + subid + "' ";
                DataSet set = new DataSet();
                set = con.GetFromDB(sql);

                if (set.Tables[0].Rows.Count == 0)
                {



                }
                else
                {

                    string pid = set.Tables[0].Rows[0][0].ToString();
                    //string per=set.Tables[0].Rows[0][1].ToString();

                    //double percent=Convert.ToDouble(per);

                    sql = "select NumberOfSubtasks from Project where ProjectID='" + pid + "'";
                    set = con.GetFromDB(sql); ;
                    int no = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());


                    double[] arr;
                    double percentagenew = 0;
                    sql = "Delete from ProgressEvaluator where SubtaskID='" + subid + "'";
                    con.SendToDB(sql);
                    sql = "select Percentage from ProgressEvaluator where ProjectID='" + pid + "'";
                    set = con.GetFromDB(sql);

                    arr = new double[set.Tables[0].Rows.Count + 1];

                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {

                        arr[i] = (Convert.ToDouble(set.Tables[0].Rows[i][0].ToString())) / (no - 1);


                    }

                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {

                        percentagenew += arr[i];

                    }
                    sql = "update Project_Progress set Percentage='" + percentagenew + "' where ProjectID='" + pid + "'";
                    con.SendToDB(sql);

                    sql = "Update Project set NumberOfSubtasks='" + (no - 1) + "' where ProjectID='" + pid + "'";
                    con.SendToDB(sql);
                }
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.ToString());
            
            
            }
          
        }
        public void resourceup(string subid) { 
            try{
            sql = "select ProjectID from Staff where SubtaskID='" + subid + "' ";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);

            if(set.Tables[0].Rows.Count==0)
            {
            
            
            
            
            }
            else
            {
            
            
                string pid=set.Tables[0].Rows[0][0].ToString();
                
                set = con.GetFromDB(sql);

                double[] arr1;
                double staffing = 0;
                sql = "select Charges from Staff  where SubtaskID='" + subid + "'";
                set = con.GetFromDB(sql);

                arr1 = new double[set.Tables[0].Rows.Count + 1];

                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {

                    arr1[i] = Convert.ToDouble(set.Tables[0].Rows[i][0].ToString());


                }

                    
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {

                    staffing += arr1[i];

                }



                double[] arr2;
                double material = 0;
                sql = "select Amount from Material  where SubtaskID='" + subid + "'";
                set = con.GetFromDB(sql);

                arr2 = new double[set.Tables[0].Rows.Count + 1];

                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {

                    arr2[i] = Convert.ToDouble(set.Tables[0].Rows[i][0].ToString());


                }


                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {

                    material += arr2[i];

                }



                sql="select Staffing,Material from ProjectBudget where ProjectID='"+pid+"'";
               
                set=con.GetFromDB(sql);
                if (set.Tables[0].Rows.Count == 0)
                {

                    MessageBox.Show("I came here");

                }
                else
                {
                    double staffprev = Convert.ToDouble(set.Tables[0].Rows[0][0].ToString());
                    double materialprev = Convert.ToDouble(set.Tables[0].Rows[0][1].ToString());
                    double staffinal = (staffprev - staffing);
                    double materfinal = (materialprev - material);
                    sql = "update ProjectBudget set Staffing='" + staffinal + "',Material='" + materfinal + "',Total='" + (staffinal + materfinal) + "' where ProjectID='" + pid + "'";
                    con.SendToDB(sql);
                }
            }
            }
            catch(SqlException ex)
            {
            
                 MessageBox.Show(ex.ToString());
            
            }

        
        
        
        
        
        }
        

    }
}
