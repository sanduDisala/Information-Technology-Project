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
    public partial class Resource_Allocation : Form
    {
        public static int op;
        string sql,sql1,sql2;
        DataSet data;//,set;
        DBConnect con = new DBConnect();
        DialogResult dialogbox = new DialogResult();
            
        
        public Resource_Allocation()
        {
            InitializeComponent();

                getdata();
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (mater.Checked)
            {
                op = 1;
                Resourceallocation.Text = "Material";
                panel2.Visible = true;
                panel1.Visible = false;
               

                //designation.Visible = false;
                //designationcombo.Visible = false;
                //role.Visible = false;
                //rolecombo.Visible = false;
                //empname.Visible = false;
                //empnamecombo.Visible = false;
                //empcheck.Visible = false;
                
                AllocateResource.Show();
                
            }
            else if (emp.Checked)
            {
                op = 2;

                Resourceallocation.Text = "Staff";
                panel2.Visible = true;
                panel1.Visible = true;
                //panel1.Location = new Point(0, 97);
               
                //type.Visible = false;
                //itemcom.Visible = false;
                //itemid.Visible = false;
                //charg.Visible = true;
                //charg.Location = new Point(117, 303);
                //label5.Visible = true;
                //label5.Location = new Point(12, 303);
                //empcheck.Location = new Point(117, 190);
                ////resc.Visible = false;
                //resourcecombo.Visible = false;
                
               
                //matcheck.Visible = false;
                //label3.Visible = false;
                //label2.Visible = false;
                //designation.Location = new Point(12, 211);
                //designationcombo.Location = new Point(117, 206);
                //empname.Location = new Point(12, 293);
                //empnamecombo.Location = new Point(117, 285);
                //role.Location = new Point(12, 346);
                //rolecombo.Location = new Point(117, 312);
                
                AllocateResource.Show();
               
                

               
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
          
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            AllocateResource.Visible = false;
            resourcesmain.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void finish_Click(object sender, EventArgs e)
        {

        }

        private void back1_Click(object sender, EventArgs e)
        {
            //empl.Visible = false;
        }

        private void cancel1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm = new Form1();
            frm.Show();

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            AllocateResource.Visible = false;
            
        }

        private void empl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        //    CreateTable(1);
        }

        private void Back1_Click_1(object sender, EventArgs e)
        {
            AllocateResource.Visible = false;
            //empl.Visible = false;
            resourcesmain.Show();

        }

        private void cancel1_Click_1(object sender, EventArgs e)
        {
            Form1 form=new Form1();
            this.Dispose();
            form.Show();
        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
           Form1 form= new Form1();
            this.Dispose();
            form.Show();
        }


        private void finish_Click_1(object sender, EventArgs e)
        {
            
            ResourceAllocation obj = new ResourceAllocation();


            if (op == 1)
            {
                sql1 = "select  Price	 from tbl_ordered_item_details where Item_ID='" + itemid.SelectedItem.ToString() + "'";
                

                DataSet data1 = new DataSet();

                data1 = con.GetFromDB(sql1);

                double price = Convert.ToDouble(data1.Tables[0].Rows[0][0].ToString());
                string r = resourcecombo.SelectedItem.ToString();
                obj.AddData(comboBox1.SelectedItem.ToString(), subtaskcombo.SelectedItem.ToString(), itemcom.SelectedItem.ToString(), resourcecombo.SelectedItem.ToString(), itemid.SelectedItem.ToString(), price);
                MessageBox.Show("Allocation Succesfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            else if (op == 2)
            {
                string desig = designationcombo.SelectedItem.ToString();
                

                obj.AddData(comboBox1.SelectedItem.ToString(), subtaskcombo.SelectedItem.ToString(), empnamecombo.SelectedItem.ToString(), desig,rolecombo.SelectedItem.ToString(),charg.Text);
                MessageBox.Show("Job Assigned","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                dialogbox = MessageBox.Show("Send an E-mail to the Employee ", "Notification", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogbox == DialogResult.Yes)
                {

          


                    sql = "Select Title,StartDate,EndDate,ClientCompany from Project where ProjectID='" + comboBox1.SelectedItem.ToString() + "'";
                    DataSet set = con.GetFromDB(sql);


                    string pname = set.Tables[0].Rows[0][0].ToString();
                    string sdate = set.Tables[0].Rows[0][1].ToString();
                    string edate = set.Tables[0].Rows[0][2].ToString();
                    string clcmp = set.Tables[0].Rows[0][3].ToString();

                    sql1 = "select full_name from employee_details where emp_code='" + empnamecombo.SelectedItem.ToString() + "'";
                    set = con.GetFromDB(sql1);
                    string empname = set.Tables[0].Rows[0][0].ToString();

                    sql = "select SubtaskName from Subtask where SubtaskID='" + subtaskcombo.SelectedItem.ToString() + "'";
                    set = con.GetFromDB(sql);
                    string subname = set.Tables[0].Rows[0][0].ToString();

                    sql2 = "select office_email from employee_contacts where emp_code='" + empnamecombo.SelectedItem.ToString() + "'";
                    set = con.GetFromDB(sql2);
                    string email = set.ToString();

                    String body = "<img src = https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL ></img><h3>Job Status</h3><p>Employee Name:"+empname+"</p><p = " + "display:inline-block;>Project Name 	:" + pname + " </p> <p>Period: " + sdate + "\t to \t" + edate + "</p></br><p>Client Company	: " + clcmp + "</p><br/><p>Subtask Name: " + subname + " </p><p>Team Role	:" + rolecombo.SelectedItem.ToString() + "</p>";

                    con.sendMail("projectmanager.emergingmedia@gmail.com", email, "You Job Details", body, "lxjxiuumhsvkfieo");
                    MessageBox.Show("Email sent to " + empname + " Successfully","Sent",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
           
    
           

        }

        private void Resource_Allocation_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            try {

                sql = "select SubtaskID from Subtask where ProjectID='" + comboBox1.SelectedItem.ToString() + "'";
                data=con.GetFromDB(sql);
                
                }
            catch(SqlException ex){
             MessageBox.Show(ex.ToString());
            
            }
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                subtaskcombo.Items.Add(data.Tables[0].Rows[i][0].ToString());
            }
            
            
        }

        public void getdata()
        {
            DBConnect con = new DBConnect();

            sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(set.Tables[0].Rows[i][0].ToString());
                proid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }


            data = con.GetFromDB(sql);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                proid.Items.Add(data.Tables[0].Rows[i][0].ToString());
            }

            sql = "select distinct Category from tbl_items";
            set = con.GetFromDB(sql);

            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                ctgory.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }

            //sql1 = "select Type from tbl_items where Category='" + ctgory.SelectedItem.ToString()+ "'";
            //    DataSet set1 = new DataSet();
            //    set1 = con.GetFromDB(sql1);

            //    for (int i = 0; i < set1.Tables[0].Rows.Count; i++)
            //    {
            //        itemcom.Items.Add(set1.Tables[0].Rows[i][0].ToString());
            //    }


           
           

                sql2 = "select designation from office_detail ";
                DataSet set2 = new DataSet();
                set2 = con.GetFromDB(sql2);

                for (int i = 0; i < set2.Tables[0].Rows.Count; i++)
                {
                    designationcombo.Items.Add(set2.Tables[0].Rows[i][0].ToString());
                }

           
        }

         private void matcheck_CheckedChanged(object sender, EventArgs e)
         {

             sql = "select Model from tbl_Items where Type='" + itemcom.SelectedItem.ToString() + "' and Category='"+ctgory.SelectedItem.ToString()+"'";
            DataSet set = new DataSet();
            data = con.GetFromDB(sql);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                resourcecombo.Items.Add(data.Tables[0].Rows[i][0].ToString());
            }

            
         }

         private void designationcombo_SelectedIndexChanged(object sender, EventArgs e)
         {
            
            

         }

         private void AllocateResource_Paint(object sender, PaintEventArgs e)
         {
             this.BackColor = Color.FromArgb(0, 102, 153);
         }

         private void itemid_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void resourcecombo_SelectedIndexChanged(object sender, EventArgs e)
         {
             sql = "select Item_ID from tbl_ordered_Item_details where Model='" + resourcecombo.SelectedItem.ToString() + "'";
             DataSet set = new DataSet();
             data = con.GetFromDB(sql);
             for (int i = 0; i < data.Tables[0].Rows.Count; i++)
             {
                itemid.Items.Add(data.Tables[0].Rows[i][0].ToString());
             }
         }

         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             
             sql = "select SubtaskID from Subtask where ProjectID='" + comboBox1.SelectedItem.ToString() + "'";
             DataSet set3 = new DataSet();
             set3 = con.GetFromDB(sql);
            

             for (int i = 0; i < set3.Tables[0].Rows.Count; i++)
             {
                 subtaskcombo.Items.Add(set3.Tables[0].Rows[i][0].ToString());
             }
         }

         private void finish2_Click(object sender, EventArgs e)
         {
            
         }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
         {
             proid.Items.Clear();
             p_id.Visible = true;
             proid.Visible = true;
         }

         private void radioButton2_CheckedChanged(object sender, EventArgs e)
         {
             proid.Items.Clear();
             p_id.Visible = true;
             proid.Visible = true;
             selectid.Visible = true;
             button3.Visible = true;
             label4.Visible = true;
             if (op == 1) {
                 label4.Text = " AllocatedID";
                 sql1 = "select AllocatedID from Material";
                 DataSet data = new DataSet();
                 data = con.GetFromDB(sql1);

                 for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                 {
                     selectid.Items.Add(data.Tables[0].Rows[i][0].ToString());
                 }
             
             }
             else if (op == 2) {
                 label4.Text = "JobID";
                 sql = "select JobID from Staff";
                 DataSet data1 = new DataSet();
                 data1 = con.GetFromDB(sql);

                 for (int i = 0; i < data1.Tables[0].Rows.Count; i++)
                 {
                     selectid.Items.Add(data1.Tables[0].Rows[i][0].ToString());
                 }
             }

             
         }

         private void radioButton3_CheckedChanged(object sender, EventArgs e)
         {
             proid.Items.Clear();
             p_id.Visible = false;
             proid.Visible = false; 
         }

         private void itemcom_SelectedIndexChanged(object sender, EventArgs e)
         {

         }

         private void empcheck_CheckedChanged(object sender, EventArgs e)
         {
             sql = "select emp_code from office_detail where designation='" + designationcombo.SelectedItem.ToString() + "'";
             DataSet data = new DataSet();
             data = con.GetFromDB(sql);

             for (int i = 0; i < data.Tables[0].Rows.Count; i++)
             {
                 empnamecombo.Items.Add(data.Tables[0].Rows[i][0].ToString());
             }
         }
      

        private void button4_Click_2(object sender, EventArgs e)
        {
            if(op==1)
            {
                sql = "select * from Material";
                DataSet set1 = new DataSet();
                set1=con.GetFromDB(sql);
                if (set1.Tables[0].Rows.Count==0) {

                    MessageBox.Show("No resources been allocated at the moment", "None", MessageBoxButtons.OK);
                
                }
                
                view.DataSource = set1.Tables[0];
                
            
            }
            else if (op==2) {
                sql2 = "select * from Staff";
                DataSet set2 = new DataSet();
                set2 = con.GetFromDB(sql2);
                view.DataSource = set2.Tables[0];
            
            
            
            
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ResourceAllocation obj = new ResourceAllocation();
            dialogbox = MessageBox.Show("Deleting the subtask will result in removal of all related information to it \n Click Yes to continue", "Warning ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogbox == DialogResult.Yes)
            {
                if (selectid.Text == "")
                {
                    MessageBox.Show("Please select an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (op == 1)
                    {
                        obj.removematerial(selectid.SelectedItem.ToString());
                        MessageBox.Show("Deleted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (op == 2)
                    {
                        obj.removeemp(selectid.SelectedItem.ToString());
                        MessageBox.Show("Deleted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void selectid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            sql="select ProjectID from Project where Title='"+name.Text+"'";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            if (set.Tables[0].Rows.Count == 0)
            {

            }
            else
            {
                string id = set.Tables[0].Rows[0][0].ToString();

                if (op == 2)
                {
                    sql1 = "select * from Staff where ProjectID='" + id + "'";
                    set = con.GetFromDB(sql1);
                    view.DataSource = set.Tables[0];
                }
                else if (op == 1)
                {

                    sql1 = "select * from Material where ProjectID='" + id + "'";
                    set = con.GetFromDB(sql1);
                    view.DataSource = set.Tables[0];


                }
            }

        }

        private void charg_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_id_Click(object sender, EventArgs e)
        {

        }

        private void subtaskcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctegory_Click(object sender, EventArgs e)
        {

        }

        private void ctgory_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql1 = "select distinct Type from tbl_items where Category='" + ctgory.SelectedItem.ToString() + "'";
            DataSet set1 = new DataSet();
            set1 = con.GetFromDB(sql1);

            for (int i = 0; i < set1.Tables[0].Rows.Count; i++)
            {
                itemcom.Items.Add(set1.Tables[0].Rows[i][0].ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resourcesmain_Paint(object sender, PaintEventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, 102, 153);
        }

        private void proid_Leave(object sender, EventArgs e)
        {
            
        }
    }
   
}
