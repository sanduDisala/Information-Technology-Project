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
    class  Project
    {

        public  static String ProjectID;
        String ClientID;
        String Title;
        String Type;
        string StartDate;
        string EndDate;
        int Duration;
        int NoOfSubtask;
        string sql;
       
        DBConnect con = new DBConnect();
        static int count=100;

     public void setdata(string clcmp,string clid,string title,string type,DateTime sdate,DateTime edate,int nosub,int duration,int color)
     {
      
         ProjectID = GetProjectID(title);
         AddProject.objpid = ProjectID;
         
         ClientID = clid;
         Title = title;
         Type = type;
         //StartDate = sdate;
         //EndDate = edate;
         Duration = duration;
         NoOfSubtask = nosub;

         sql = "Insert into Project(ProjectID,Title,type,ClientCompany,ClientID,StartDate,EndDate,Duration,NumberOfSubtasks,ProjectColor) values('" + ProjectID + "','" + Title + "','" + Type + "','"+clcmp+"','" + ClientID + "','" + sdate + "','" + edate + "','" + Duration + "','" + NoOfSubtask + "','"+color+"')";
         con.SendToDB(sql);
        
     
     
     
     }
     public void setobjectives(string pid, string obj, string str) {


         try
         {
             sql = "Insert into ProjectObjectives(ProjectID,Objectives,Stratergies) values('" +pid+ "','" + obj + "','" + str+ "')";

             con.SendToDB(sql);
         }
         catch(SqlException ex){
         
         MessageBox.Show(ex.ToString());
         
         }
         
         
     }
     public DataSet getobjectives(string pid) {

         sql = "select * from ProjectObjectives where ProjectID='" + pid + "'";
         return con.GetFromDB(sql);

     
     }
        
    public DataSet getData(string pid)
    {
    
       sql="Select * from Project where ProjectID='"+pid+"'";

       return con.GetFromDB(sql);
    
    }
     
     
     public DataSet getData() 
     { 
        sql="Select * from Project";

        return con.GetFromDB(sql);
     }

     public String GetProjectID(string title)
     {

         count++;
         return ("EM"+" "+title.Substring(0,1)+count);
     
     }

    public void Delete(String pid)
    {

        try
        {
                sql = "Delete from Project_Progress where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "Delete from ProgressEvaluator where ProjectID='" + pid + "'";
                con.SendToDB(sql);
                
                sql = "Delete from ProjectObjectives where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "Delete from ProjectBudget where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "Delete from Staff where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "Delete from Material where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "Delete from Subtask where ProjectID='" + pid + "'";
                con.SendToDB(sql);

                sql = "delete from ProjectObjectives where ProjectID='" + pid + "'";
                con.SendToDB(sql);
                sql = "Delete from Project where ProjectID='" + pid + "'";
                con.SendToDB(sql);
            }
            catch (SqlException ex1) 
            {

                MessageBox.Show(ex1.ToString());
                
            
            
            }


    
    }

    public void Update(string proid,string clid, string title, string type, string sdate, string edate,  int duration,int argb)
    {
       
        
        ClientID = clid;
        Title = title;
        Type = type;
        StartDate = sdate;
        EndDate = edate;
        Duration = duration;
       // NoOfSubtask = nosub;
        sql = "Update Project set Title='" + Title + "',Type='" + Type + "',StartDate='" + StartDate + "',EndDate='" + EndDate + "',Duration='" + Duration + "',ProjectColor='"+argb+"' where ProjectID='" + proid + "'";
        con.SendToDB(sql);
    }



    //class ProjectEvaluator
    //{


        


    //}
        
        

    
   
    
    
    
    
    
    }
}
