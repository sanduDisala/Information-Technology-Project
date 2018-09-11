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
       public partial class Add_Subtask : Form
       {
           public static string spid;
         
           string Sname;
           string sdate;
           string edate;
           int duration;
           public static int count;
           Subtask sub = new Subtask();
           string sql;
           public static DateTime lastdate;
           string lstdate;
           public static int subcnt=0;
           static int i = 0;
           DialogResult dialogbox = new DialogResult();
           DataSet date = new DataSet();
           DBConnect con = new DBConnect();
           //DataSet set;
        public Add_Subtask() {

           
            InitializeComponent();
            //i = 0;
            label_pid.Text = Subtask.Projectid;
            //count = 1;
           
            
       
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void subtask_Paint(object sender, PaintEventArgs e)
        {
            
        }
      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                 
        
        }



        private void panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        

        private void add_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(i.ToString());
            if (startdate.Value > enddate.Value)
            {

                MessageBox.Show("You start date is ahead of end date", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                sql = "select NumberOfSubtasks from Project where ProjectID='" + Subtask.Projectid + "'";
                DataSet set = con.GetFromDB(sql);
                subcnt = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());
                sql = "select count(SubtaskID) from Subtask where ProjectID='" +Subtask.Projectid+ "'";
                set = con.GetFromDB(sql);

                int incount = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());
                if (incount < subcnt)
                {

                    Sname = title.Text;
                    //sdate = startdate.Value.ToString("yyyy-MM-dd ");
                    //edate = enddate.Value.ToString("yyyy-MM-dd");
                    TimeSpan timespan = enddate.Value - startdate.Value;
                    duration = timespan.Days;
                    Subtask sub = new Subtask();
                    if (enddate.Value > lastdate)
                    {
                        MessageBox.Show("ERROR! \n End Date of the above subtask exceeds the Dead Line of the project:" + lastdate.ToString());


                    }
                    else if (startdate.Value > lastdate)
                    {

                        MessageBox.Show("ERROR! \n End Date of the above subtask exceeds the Dead Line of the project:" + lastdate.ToString());
                    }
                    else
                    {
                        
                        Subtask.count = i;
                        sub.AddSubtask(Sname, startdate.Value, enddate.Value, duration);
                        DataSet data = new DataSet();
                        data = sub.getdata();
                        panel.DataSource = data.Tables[0];
                        MessageBox.Show("Subtask added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        i++;

                    }

                }
                else
                {
                    MessageBox.Show("You can enter " + " " + subcnt + " " + "Subtasks only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            
            
        }

        private void UpdateOp_CheckedChanged(object sender, EventArgs e)
        {
            subname.Visible = true;
            title.Visible = true;
            label1.Visible = true;
            startdate.Visible = true;
            enddate.Visible = true;
            sedate.Visible = true;

            subid.Visible = true;
            s_id.Visible = true;
            add.Visible = false;
            sDel.Visible = false;
            add2.Visible = false;
            update.Visible = true;
            update.Location = new Point(25, 355);
            AddSubtask.Text = "Update Subtask";
            newOp.Visible = true;
            pid.Visible = true;
            sproid.Visible = true;
            DBConnect con = new DBConnect();
            //sql = "select distinct ProjectID from Subtask";
            //DataSet set = new DataSet();
            //set = con.GetFromDB(sql);
            //for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            //{
            //    sproid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            //}

            
        }

        private void view_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data = sub.getdata();
           
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No recent projects added to the database","None",MessageBoxButtons.OK,MessageBoxIcon.None);


            }
            else
            {
                panel.DataSource = data.Tables[0];
            }
           
        }

        private void DelOp_CheckedChanged(object sender, EventArgs e)
        {
            subname.Visible = false;
            title.Visible = false;
            label1.Visible = false;
            startdate.Visible = false;
            enddate.Visible = false;
            sedate.Visible = false;

            subid.Visible = true;
            s_id.Visible = true;
            add.Visible = false;
            update.Visible = false;
            add2.Visible = false;
            sDel.Visible = true; ;
            sDel.Location = new Point(25, 355);
            AddSubtask.Text = "Delete Subtask";
            newOp.Visible = true;
            pid.Visible = true;
            sproid.Visible = true;
            DBConnect con = new DBConnect();

            //sql = "select ProjectID from Project";
            //DataSet set = new DataSet();
            //set = con.GetFromDB(sql);
            //for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            //{
            //    sproid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            //}
        }

        private void newOp_CheckedChanged(object sender, EventArgs e)
        {
          
            subname.Visible = true;
            title.Visible = true;
            label1.Visible = true;
            startdate.Visible = true;
            enddate.Visible = true;
            sedate.Visible = true;
            subid.Visible = false;
            s_id.Visible = false;
            update.Visible = false;
            sDel.Visible = false;
            pid.Visible = true;
            
            sproid.Visible = true;
            add2.Location = new Point(25, 355);
            add2.Visible = true;
            DBConnect con = new DBConnect();
            //sql = "select distinct ProjectID from Project";
            //DataSet set = new DataSet();
            //set = con.GetFromDB(sql);
            //for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            //{
            //    sproid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            //}

        }

        private void update_Click(object sender, EventArgs e)
        {

            if (sproid.SelectedItem == null)
            {


                MessageBox.Show("Please select a projectID","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            else
            {
              
                errorProvider1.SetError(pid, "");

                         
           

            }

            Sname = title.Text;
            sdate = startdate.Value.ToString("yyyy-MM-dd ");
            edate = enddate.Value.ToString("yyyy-MM-dd");
            TimeSpan timespan = startdate.Value - enddate.Value;
            duration = timespan.Days + 1;
            Subtask sub = new Subtask();
            if (s_id.SelectedItem.Equals(null)) {

                MessageBox.Show("Please select a SubtaskID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            else
            {

                sub.update(sproid.SelectedItem.ToString(), s_id.SelectedItem.ToString(), Sname, sdate, edate, duration);          
            }
           
        }

        private void sproid_SelectedIndexChanged(object sender, EventArgs e)
        {
            s_id.Items.Clear();
            sql = "select SubtaskID from Subtask where ProjectID='" +sproid.SelectedItem.ToString()+ "'";
            DBConnect con = new DBConnect();
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                s_id.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }

        }

        private void sDel_Click(object sender, EventArgs e)
        {
            dialogbox = MessageBox.Show("Deleting the subtask will result in removal of all related information to it \n Click Yes to continue", "Warning ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogbox == DialogResult.Yes)
            {
                if (sproid.Text == "")
                {
                    MessageBox.Show("Please select a ProjectID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        sub.delete(s_id.SelectedItem.ToString());
                        MessageBox.Show("Successfully Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataSet data = new DataSet();
                        data = sub.getdata();
                        panel.DataSource = data.Tables[0];
                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void add2_Click(object sender, EventArgs e)
        {
            if (startdate.Value > enddate.Value)
            {

                MessageBox.Show("Your start date is ahead of end date", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                DBConnect con = new DBConnect();
                sql = "select NumberOfSubtasks from Project where ProjectID='" + sproid.SelectedItem.ToString() + "'";
                DataSet set = con.GetFromDB(sql);

                subcnt = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());

                sql = "select count(SubtaskID) from Subtask where ProjectID='" + sproid.SelectedItem.ToString() + "'";
                set = con.GetFromDB(sql);

                int incount = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());
                
                if (incount == subcnt)
                {

                    MessageBox.Show("You have already added subtasks for this project");
                    
                }
                else
                {
                    i = incount - subcnt;
                    if (sproid.Text == "")
                    {
                        MessageBox.Show("Please select a ProjectID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        sql = "select EndDate from Project where ProjectID='" + sproid.SelectedItem.ToString() + "'";

                        date = con.GetFromDB(sql);
                        lstdate = date.Tables[0].Rows[0][0].ToString();
                        MessageBox.Show(lstdate);
                        //lastdate = Convert.ToDateTime(lastdate);
                        lastdate = DateTime.Parse(lstdate);
                        MessageBox.Show(lastdate.ToString());
                        
                        if (i > subcnt)
                        {

                            MessageBox.Show("");

                        }
                        else
                        {
                            string proid = sproid.SelectedItem.ToString();
                            Sname = title.Text;
                            //sdate = startdate.Value.ToString("yyyy-MM-dd ");
                            //edate = enddate.Value.ToString("yyyy-MM-dd");
                            TimeSpan timespan = enddate.Value - startdate.Value;
                            duration = timespan.Days + 1;
                            Subtask sub = new Subtask();

                            if (enddate.Value > lastdate)
                            {
                                MessageBox.Show("ERROR! \n End Date of the above subtask exceeds the Dead Line of the project:" + lastdate);
                            }
                            else if (startdate.Value > lastdate)
                            {

                                MessageBox.Show("ERROR! \n End Date of the above subtask exceeds the Dead Line of the project:" + lastdate.ToString());
                            }

                            else
                            {
                                Subtask.count = i;

                                sub.AddSubtask(proid, Sname, startdate.Value, enddate.Value, duration);
                                DataSet data = new DataSet();
                                data = sub.getdata();
                                panel.DataSource = data.Tables[0];
                                MessageBox.Show("Subtask added successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                i++;
                            }

                        }

                    }
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            sql = "select NumberOfSubtasks from Project where ProjectID='" + Subtask.Projectid + "'";
                DataSet set = con.GetFromDB(sql);
                if (set.Tables[0].Rows.Count != 0)
                {
                    subcnt = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());
                }
               
                sql ="select count(SubtaskID) from Subtask where ProjectID='" + Subtask.Projectid + "'";
                set = con.GetFromDB(sql);
                int incount = Convert.ToInt32(set.Tables[0].Rows[0][0].ToString());

                if (incount < subcnt)
                {
                    MessageBox.Show("You must enter" + " " + subcnt + " " + "subcnt");



                }
                else {

                    this.Dispose();
                    Form1 fr=new Form1();
                    fr.Show();
                
                
                }
           // if (i < subcnt)
            //{

              //  MessageBox.Show("You must enter"+ " " + subcnt + " " + "subcnt");
            //}
            //else
            //{
              //  this.Dispose();
                //Form1 fr = new Form1();
                //fr.Show();
           // }
        }

        private void sproid_Validating(object sender, CancelEventArgs e)
        {

            if (sproid.Text == "")
            {
                MessageBox.Show("Please select a ProjectID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sname_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void title_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                // e.Cancel = true;
                pid.Focus();
                errorProvider1.SetError(title, "Subtask Name cannot be left blank!");
                add2.Enabled = false;
                add.Enabled = false;
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(title, "");
                add2.Enabled = true;
                add.Enabled = true;
            }
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void enddate_Validating(object sender, CancelEventArgs e)
        {

            if (startdate.Value > enddate.Value)
            {

                errorProvider1.SetError(enddate, "Select a date greater than the Start Date");


            }
            else
            {

                errorProvider1.SetError(enddate, "");

            }
        }

        private void Add_Subtask_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "select * from Subtask SubtaskID='" + nam.Text + "'";
            
            DBConnect con = new DBConnect();
            DataSet set = new DataSet();
            panel.DataSource = set.Tables[0];
        }
     
    }
}
