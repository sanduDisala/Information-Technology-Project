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


    public partial class AddProject : Form
    {

        public static String quantity;
        String sql;
        Project project = new Project();
        string clid1, title1, type1;
        string startdate1;
        string endate1;
        string clcompany;
        DialogResult dialogbox = new DialogResult();
        int i;
        int argb;
        public static string objpid;
       
       // public event EventHandler Leave;
        
        public AddProject()
        {

            InitializeComponent();
            getclcpnames();
            no_sub.KeyPress += new KeyPressEventHandler(no_sub_KeyPress);
          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Subtask add = new Add_Subtask();
            AddProject add1 = new AddProject();
            
            quantity = no_sub.Text;
            if (quantity == "")
            {
                MessageBox.Show("Please enter number of subtasks","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else if (Ptype.SelectedItem == null || cl_company.SelectedItem == null || clid.SelectedItem == null) {

                MessageBox.Show("You are not allowed to leave option fields blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            
            }
            else
            {
                i = Int32.Parse(quantity);
                Add_Subtask.subcnt = i;
                startdate1 = sdate.Value.ToString("yyyy-MM-dd ");
                endate1 = edate.Value.ToString("yyyy-MM-dd");
                TimeSpan timespan = edate.Value - sdate.Value;
                int num = timespan.Days + 1;
                clid1 = clid.SelectedItem.ToString();
                title1 = title.Text;
                type1 = Ptype.SelectedItem.ToString();
                clcompany = cl_company.SelectedItem.ToString();
                //Subtask.op = 2;
                //object call for class Project
                try
                {
                    project.setdata(clcompany, clid1, title1, type1, sdate.Value, edate.Value, i, num, argb);
                    MessageBox.Show("Project added successfully!", " Insertion Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSet data = new DataSet();
                    data = project.getData();

                    Subtask.Projectid = Project.ProjectID;

                    Add_Subtask.lastdate = edate.Value;
                    Add_Subtask sub = new Add_Subtask();
                    sub.label_pid.Text = Project.ProjectID;
                    panel.DataSource = data.Tables[0];
                    //dialogbox = MessageBox.Show("Do you want to add subtask Now", " ", MessageBoxButtons.YesNo);
                    //if (dialogbox == DialogResult.Yes)
                    //{

                    //    add1 = this;
                    //    this.Hide();
                    //    add.Show();

                    //}

                }
                catch (SqlException E)
                {
                    MessageBox.Show(E.ToString());

                }




            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            sdate.Text = "";
            title.Text = " ";
            Ptype.Text = " ";
            cl_company.Text = " ";
            clid.Text = " ";
            no_sub.Text = " ";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form = new Form1();
            form.Show();
        }

        private void title_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
               
                title.Focus();
                errorProvider1.SetError(title, "Name should not be left blank!");
            }
            else
            {
               
                errorProvider1.SetError(title, "");
            }
        }

        private void Ptype_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Ptype.Text))
            {
                e.Cancel = true;
                Ptype.Focus();
                errorProvider2.SetError(Ptype, "Project title should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(Ptype, "");
            }
        }

        private void sdate_Validating(object sender, CancelEventArgs e)
        {
        }

        private void clid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clid.Text))
            {
                // e.Cancel = true;
                clid.Focus();
                errorProvider2.SetError(clid, "client id should not be left blank!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider2.SetError(clid, "");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AddProject_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
          
        }

        public void CreateTable()
        {


        }

        private void title_Enter(object sender, EventArgs e)
        {
            if (title.Text == "Title")
            {
                title.Text = "";
                title.ForeColor = Color.Black;
            }
        }

        private void title_Leave(object sender, EventArgs e)
        {
            if (title.Text == "")
            {
                title.Text = "Title";
                title.ForeColor = Color.Silver;
            }
        }

        //private void View_Click(object sender, EventArgs e)
        //{
        //    DataSet data = new DataSet();
        //    data = project.getData();

        //    panel.DataSource = data.Tables[0];
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            title.Visible = false;
            protitle.Visible = true;
            protitle.Location = new Point(146, 39);
            sql = "select Title from Project";
            DBConnect con = new DBConnect();
            DataSet data = new DataSet();
            data = con.GetFromDB(sql);
            for (int i = 0; i < data.Tables[0].Rows.Count; i++)
            {
                protitle.Items.Add(data.Tables[0].Rows[1][0].ToString());

            }


        }

        private void UpdateOp_CheckedChanged(object sender, EventArgs e)
        {
            no_sub.Visible = false;
            nosub.Visible = false;
            
            plabel.Text = "Update Projects";
            Add.Visible = false;
            Update.Visible = true;
            Delete.Visible = false;
            Update.Location = new Point(53, 480);
            proid.Visible = true;
            pid.Visible = true;
            addOp.Visible = true;
            pid.Items.Clear();
            DBConnect con = new DBConnect();
            sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                pid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }

        }
        private void fill() {

            Project pro = new Project();
            DataSet fill= pro.getData();

        
        }

        private void DeleteOp_CheckedChanged(object sender, EventArgs e)
        {
           
            plabel.Text = "Delete Projects";
            Add.Visible = false;
            Update.Visible = false;
            Delete.Location = new Point(53, 480);
            Delete.Visible = true;
            proid.Visible = true;
            pid.Visible = true;
            addOp.Visible = true;
            pid.Items.Clear();

            DeleteOptions();



        }
        private void DeleteOptions() {


            DBConnect con = new DBConnect();
            sql = "select ProjectID from Project";
            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            if (set.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No Projects available");

            }
            for (int i = 0; i < set.Tables[0].Rows.Count; i++)
            {
                pid.Items.Add(set.Tables[0].Rows[i][0].ToString());
            }
        }

        private void addOp_CheckedChanged(object sender, EventArgs e)
        {
            no_sub.Visible = true;
            nosub.Visible = true;
            proid.Visible = false; ;
            pid.Visible = false; ;
            Delete.Visible = false;
            Update.Visible = false;
            Add.Visible = true;

        }

        private void View_Click_1(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data = project.getData();
            
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No recent projects added to the database");


            }
            else
            {
                panel.DataSource = data.Tables[0];
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                
                 argb = colorDialog1.Color.ToArgb();
                 string s = Color.FromArgb(argb).Name;
                 
                string proid = pid.SelectedItem.ToString();
                quantity = no_sub.Text;
                //i = Int32.Parse(quantity);

                startdate1 = sdate.Value.ToString("yyyy-MM-dd ");
                endate1 = edate.Value.ToString("yyyy-MM-dd");
                TimeSpan timespan = edate.Value - sdate.Value;
                int num = timespan.Days + 1;
                clid1 = clid.Text;
                title1 = title.Text;
                type1 = Ptype.Text;
                // string proid,string clid, string title, string type, string sdate, string edate, int nosub, int duration
                project.Update(proid, clid1, title1, type1, startdate1, endate1, num,argb);

                MessageBox.Show("Updated Successfully"," ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                DataSet data = new DataSet();
                data = project.getData();
                panel.DataSource = data.Tables[0];

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void pid_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(pid.SelectedItem.ToString()))
            {
                // e.Cancel = true;
                pid.Focus();
                errorProvider2.SetError(pid, "Please select the Project you want to edit");
            }
            else
            {
                //e.Cancel = false;
                errorProvider2.SetError(pid, "");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            dialogbox = MessageBox.Show("Deleting the project" + " " + pid.SelectedItem.ToString() + " will result in removal of all the details related to it \n Do you want to Proceed?", " Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            {
                try
                {
                    string proid = pid.SelectedItem.ToString();
                    project.Delete(proid);
                    MessageBox.Show("Deleted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataSet data = new DataSet();
                    data = project.getData();
                    panel.DataSource = data.Tables[0];
                   
                   
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            getclcpnames();
        }

        private void no_sub_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && !char.IsWhiteSpace(ch))
            {
                e.Handled = true;
            }
        }

        private void clid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void edate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void edate_Validating(object sender, CancelEventArgs e)
        {


            if (sdate.Value > edate.Value)
            {

                errorProvider3.SetError(edate, "Select a date greater than the Start Date");


            }
            else
            {

                errorProvider3.SetError(edate, "");

            }



        }
        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ' ') 
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }
        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void cl_company_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "select Fname from customer where Company_Name='" + cl_company.SelectedItem.ToString() + "'";
                DBConnect con = new DBConnect();
                DataSet clnames = new DataSet();
                clnames = con.GetFromDB(sql);
                for (int i = 0; i < clnames.Tables[0].Rows.Count; i++)
                {
                    clid.Items.Add(clnames.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }
        private void cl_company_Leave(object sender, EventArgs e)
        {
            try
            {
                sql = "select Fname from customer where Company_Name='"+cl_company.SelectedItem.ToString()+"'";
                DBConnect con = new DBConnect();
                DataSet clnames = new DataSet();
                clnames = con.GetFromDB(sql);
                for (int i = 0; i < clnames.Tables[0].Rows.Count; i++)
                {
                    clid.Items.Add(clnames.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        }
        public void getclcpnames() {
            try
            {
                sql = "select distinct Company_Name  from customer";
                DBConnect con = new DBConnect();
                DataSet cpnames = new DataSet();
                cpnames = con.GetFromDB(sql);
                for (int i = 0; i < cpnames.Tables[0].Rows.Count; i++)
                {
                    cl_company.Items.Add(cpnames.Tables[0].Rows[i][0].ToString());
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());


            }
        
        
        }

        private void Add_Validating(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void colour_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                 argb = colorDialog1.Color.ToArgb();
                 string s = Color.FromArgb(argb).Name;
                 
                 


            }
        }

        private void pid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            sql = "select * from Project where Title='" + name.Text + "'";
            DBConnect con = new DBConnect();
            DataSet set=new DataSet();
            set = con.GetFromDB(sql);
            panel.DataSource = set.Tables[0];
        }

        private void objbutton_Click(object sender, EventArgs e)
        {

            panelobj.Location = new Point(0, 2);
            panelobj.Size = new Size(333, 585);

            panelobj.Show();

        }

        private void addobj_Click(object sender, EventArgs e)
        {  
            Project pro = new Project();
            DataSet data= new DataSet();
            DBConnect con=new DBConnect();
            if (label8.Text =="")
            {

                MessageBox.Show("Create a Project first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else 
            {


               
                pro.setobjectives(label8.Text, obj.Text, stra.Text);
                MessageBox.Show("objectives added successfully!", " Insertion Successful ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                sql="select * from ProjectObjectives where ProjectID='"+label8.Text+"'";
               
                data=con.GetFromDB(sql);
               panel.DataSource = data.Tables[0];
               dialogbox = MessageBox.Show("Do you want to add subtask Now", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
               if (dialogbox == DialogResult.Yes)
               {
                   Add_Subtask add1 = new Add_Subtask();

                   this.Hide();
                   add1.Show();

               }
               
            }
            
        
            

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelobj.Visible = false;
        }

        private void panelobj_Paint(object sender, PaintEventArgs e)
        {
            label8.Text = objpid;
        }

        private void panel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pid_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


    }
}
 