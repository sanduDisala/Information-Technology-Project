using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

using System.Data;

namespace Main.Modules.Project_Management
{
    class ResourceAllocation
    {
        string sql,sql1,sql2;
        public static int count = 0;
        DBConnect con = new DBConnect();
        double charges;
        double charge;
        string valu; 
        public void AddData(string pid, string subid, string eid, string desig, string role,string charg)
        {
            sql1 = "select  Staffing from ProjectBudget where ProjectID='" + pid + "' and Staffing is not null";
            DataSet set1 = new DataSet();
            set1=con.GetFromDB(sql1);
            

            charges = Convert.ToDouble(charg);
            try
            {
                sql = "insert into Staff(JobID,ProjectID,SubtaskID,EmployeeID,Designation,Role,Charges) values('" + JobID(pid, subid) + "','" + pid + "','" + subid + "','" + eid + "','" + desig + "','" + role + "','"+charges+"')";
                con.SendToDB(sql);
                if (set1.Tables[0].Rows.Count == 0)
                {

                    sql2 = "insert into ProjectBudget(ProjectID,Staffing,Material) values('" + pid + "','" + charges + "','0')";
                    con.SendToDB(sql2);

                }
                else {
                    valu = set1.Tables[0].Rows[0][0].ToString();
                    charge = Convert.ToDouble(valu);
                  sql2="update ProjectBudget set Staffing='"+(charges+charge)+"' where ProjectID='"+pid+"'";
                  con.SendToDB(sql2);
                
                }
                



            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        public void AddData(string pid, string subid, string type, string desc, string itemid, double unitprice) 
        {

            sql1 = "select  Material from ProjectBudget where  ProjectID='" + pid + "' and Material is not null";
            DataSet set1 = new DataSet();
            set1 = con.GetFromDB(sql1);
            if (set1.Tables[0].Rows.Count == 0)
            {

                sql2 = "insert into ProjectBudget(ProjectID,Staffing,Material) values('" + pid + "','0','" + unitprice + "')";
                con.SendToDB(sql2);

            }
            else
            {
                valu = set1.Tables[0].Rows[0][0].ToString();
                charge = Convert.ToDouble(valu);
                sql2 = "update ProjectBudget set Material='" + (charge+unitprice ) + "' where ProjectID='" + pid + "'";
                con.SendToDB(sql2);

            }
                

            try
            {

                sql = "Insert into Material(AllocatedID,ProjectID,SubtaskID,Type,Description,ItemID,Amount) values('" + AllocateID(pid,subid) + "','" + pid + "','" + subid+ "','" + type + "','"+desc+"','" + itemid + "','" + unitprice + "')";
                con.SendToDB(sql);
                
            }
            catch (SqlException ex) {


                MessageBox.Show(ex.ToString());
            
            
            }
        
        
        }
        public string AllocateID(string pname, string subid) {
            count++;
            string id = pname + "_"+subid.Substring(0,4)+count;
            return id;
        
        }

        public string JobID(string pname, string subid) {


            count++;
            string jid = pname + "_" + subid + count;
            return jid;
        
        
        }

        public void removeemp(string jid) {
            double tot = 0;
            sql = "select Charges,ProjectID from Staff where JobID='" + jid + "'";
             DataSet set=new DataSet();
            set=con.GetFromDB(sql);
            string id=set.Tables[0].Rows[0][1].ToString();
            double amt = Convert.ToDouble(set.Tables[0].Rows[0][0].ToString());

            sql = "select Staffing,Total from ProjectBudget where ProjectID='" + id + "' ";
            set = con.GetFromDB(sql);
            double pre = Convert.ToDouble(set.Tables[0].Rows[0][0].ToString());

            if(set.Tables[0].Rows[0][1].ToString()!=""){
                //MessageBox.Show(set.Tables[0].Rows[0][1].ToString());
                
                tot = Convert.ToDouble(set.Tables[0].Rows[0][1].ToString());
                sql = "update ProjectBudget set Staffing='" + (pre - amt) + "' where ProjectID='" + id + "'";
                con.SendToDB(sql);
                if (tot != 0)
                {

                    sql = "Update ProjectBudget set Total='" + (tot - amt) + "' where ProjectID='" + id + "'";
                    con.SendToDB(sql);
                }
            
            }
            else
            {
              

            
            }

            try
            {
                sql = "delete from Staff where JobID='" + jid + "'";
                con.SendToDB(sql);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        public void removematerial(string allcid)
        {
            double tot = 0;
            sql = "select Amount,ProjectID from Material where AllocatedID='" + allcid + "'";
             DataSet set=new DataSet();
            set=con.GetFromDB(sql);
            string id=set.Tables[0].Rows[0][1].ToString();
            double amt = Convert.ToDouble(set.Tables[0].Rows[0][0].ToString());

            sql = "select Material,Total from ProjectBudget where ProjectID='" + id + "' ";
            set=con.GetFromDB(sql);
            double pre = Convert.ToDouble(set.Tables[0].Rows[0][0].ToString());

            if(set.Tables[0].Rows[0][1].ToString()!=""){
                MessageBox.Show(set.Tables[0].Rows[0][1].ToString());

                tot = Convert.ToDouble(set.Tables[0].Rows[0][1].ToString());
            
            }
            else
            {
              

            
            }
            sql="Update ProjectBudget set Material='"+(pre-amt)+"' where ProjectID='"+id+"'";
            con.SendToDB(sql);
            if (tot != 0) {

                sql = "Update ProjectBudget set Total='" + (tot-amt) + "' where ProjectID='" + id + "'";
                con.SendToDB(sql);
            }
            try
            {
                sql = "delete from Material where AllocatedID='" + allcid + "'";
                con.SendToDB(sql);
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
    }
}
