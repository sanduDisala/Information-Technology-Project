using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.Common;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Main.Modules.Event
{
    public partial class View_event_D : Form
    {
        DBConnect con = new DBConnect();
        string sql1 = "select * from Event_Details";
        string sql2 = "select * from Hired_Compo_Details";
        string sql3 = "select * from Booking_Details";
        string sql4 = "select * from Return_Compo";

        public View_event_D()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_event_D_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
        }


        private void ve_Click(object sender, EventArgs e)
        {
            se.Visible = true;
            button5.Visible = true;
            se.Text = "Event name";
            se.ForeColor = Color.Gray;

            Update.Visible = true;
            Delete.Visible = true;
            DataGridView data = new DataGridView();


            DBConnect con = new DBConnect();
            SqlConnection conn = con.getconnection();

            DataSet set = new DataSet();
            set = con.GetFromDB(sql1);
            View_event_D v = new View_event_D();
            view.DataSource = set.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            se.Visible = true;
            button5.Visible = true;
            se.Text = "Event name";
            se.ForeColor = Color.Gray;

            Update.Visible = true;
            Delete.Visible = true;
            DataGridView data = new DataGridView();

            string sql = "select * from Booking_Details";
            DBConnect con = new DBConnect();

            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            View_event_D v = new View_event_D();
            view.DataSource = set.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            se.Visible = true;
            button5.Visible = true;
            se.Text = "Event name";
            se.ForeColor = Color.Gray;

            Update.Visible = false;
            Delete.Visible = true;

            DataGridView data = new DataGridView();

            string sql = "select * from Hired_Compo_Details";
            DBConnect con = new DBConnect();

            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            View_event_D v = new View_event_D();
            view.DataSource = set.Tables[0];
        }

        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (this.view.Columns[2].HeaderText == "event_id")
            {
                // Delete Event details
                if (e.ColumnIndex == 1)
                {
                    DialogResult dia = MessageBox.Show("Do you really want to delete this row?", "Exit", MessageBoxButtons.YesNo);

                    if (dia == DialogResult.Yes)
                    {

                        try
                        {
                            int selectedrowindex = view.SelectedCells[0].RowIndex;

                            DataGridViewRow selectedRow = view.Rows[selectedrowindex];

                            string a = Convert.ToString(selectedRow.Cells[2].Value);

                            string sql = "delete from Event_Details where event_id='" + a + "'";
                            con.SendToDB(sql);

                            MessageBox.Show("Delete");

                            DataSet set = new DataSet();
                            set = con.GetFromDB(sql1);
                            View_event_D v = new View_event_D();
                            view.DataSource = set.Tables[0];

                        }
                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }

                    }

                }

                //Update Event Details
                if (e.ColumnIndex == 0)
                {
                    DialogResult dia = MessageBox.Show("Do you really want to update this row?", "Exit", MessageBoxButtons.YesNo);

                    if (dia == DialogResult.Yes)
                    {
                        this.Hide();
                        Add_events a1 = new Add_events();
                        a1.Show();

                        a1.event_id.Text = view.CurrentRow.Cells[2].Value.ToString();
                        MessageBox.Show(view.CurrentRow.Cells[2].Value.ToString());

                        a1.event_name.ReadOnly = true;
                        a1.event_name.Text = view.CurrentRow.Cells[3].Value.ToString();

                        a1.cat.Enabled = false;
                        a1.cat.Text = view.CurrentRow.Cells[4].Value.ToString();

                        int selectedrowindex = view.SelectedCells[0].RowIndex;

                        DataGridViewRow selectedRow = view.Rows[selectedrowindex];

                        string a = Convert.ToString(selectedRow.Cells[5].Value);

                        if (a == "Indoor")
                        {
                            a1.outdoor.Visible = false;
                        }
                        else
                            a1.indoor.Visible = false;

                        a1.venu.Text = view.CurrentRow.Cells[6].Value.ToString();
                        a1.venu.ForeColor = Color.Black;

                        a1.venu.Text = view.CurrentRow.Cells[6].Value.ToString();
                        a1.venu.ForeColor = Color.Black;

                        a1.datepick.Text = view.CurrentRow.Cells[7].Value.ToString();
                        a1.timepick.Text = view.CurrentRow.Cells[8].Value.ToString();


                        int scrowindex = view.SelectedCells[0].RowIndex;

                        DataGridViewRow scRow = view.Rows[scrowindex];

                        string b = Convert.ToString(scRow.Cells[9].Value);

                        if (b == "Full coverage")
                        {
                            a1.part.Visible = false;
                            a1.price.Visible = true;
                            a1.price.Text = view.CurrentRow.Cells[10].Value.ToString();
                            a1.price.ForeColor = Color.Black;

                        }
                        else
                            a1.full.Visible = false;


                        a1.bupdate.Visible = true;
                        a1.submit.Visible = false;
                    }
                }
            }


            if (this.view.Columns[2].HeaderText == "hire_id")
            {


                // Delete Hire component details
                if (e.ColumnIndex == 1)
                {
                    DialogResult dia = MessageBox.Show("Do you really want to delete this row?", "Exit", MessageBoxButtons.YesNo);

                    if (dia == DialogResult.Yes)
                    {

                        try
                        {

                            int selectedrowindex = view.SelectedCells[0].RowIndex;

                            DataGridViewRow selectedRow = view.Rows[selectedrowindex];

                            string a = Convert.ToString(selectedRow.Cells[2].Value);


                            int selectedrowindex1 = view.SelectedCells[0].RowIndex;

                            DataGridViewRow selectedRow1 = view.Rows[selectedrowindex];

                            string b = Convert.ToString(selectedRow.Cells[4].Value);

                            string sql = "delete from Hired_Compo_Details where hire_id='" + a + "' and hired_compo ='" + b + "'";
                            con.SendToDB(sql);

                            MessageBox.Show("Delete");

                            DataSet set = new DataSet();
                            set = con.GetFromDB(sql2);
                            View_event_D v = new View_event_D();
                            view.DataSource = set.Tables[0];

                        }
                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }

                    }

                }

            }



            if (this.view.Columns[2].HeaderText == "booking_id")
            {
                // Delete Booking details
                if (e.ColumnIndex == 1)
                {
                    DialogResult dia = MessageBox.Show("Do you really want to delete this row?", "Exit", MessageBoxButtons.YesNo);

                    if (dia == DialogResult.Yes)
                    {

                        try
                        {
                            int selectedrowindex = view.SelectedCells[0].RowIndex;

                            DataGridViewRow selectedRow = view.Rows[selectedrowindex];

                            string a = Convert.ToString(selectedRow.Cells[2].Value);

                            string sql = "delete from Booking_Details where booking_id= '" + a + "'";
                            con.SendToDB(sql);

                            MessageBox.Show("Delete");

                            DataSet set = new DataSet();
                            set = con.GetFromDB(sql3);
                            View_event_D v = new View_event_D();
                            view.DataSource = set.Tables[0];

                        }
                        catch (SqlException ex)
                        {

                            MessageBox.Show(ex.ToString());

                        }

                    }

                }
        //Update
                if (e.ColumnIndex == 0)
                {
                    DialogResult dia = MessageBox.Show("Do you really want to update this row?", "Exit", MessageBoxButtons.YesNo);

                    if (dia == DialogResult.Yes)
                    {
                        this.Hide();
                        Bookings b1 = new Bookings();
                        b1.Show();

                        b1.label7.Text = "Updated date";
                        b1.booking_id.Text = view.CurrentRow.Cells[2].Value.ToString();
                        b1.event_name.Enabled = false;
                        b1.event_name.Text = view.CurrentRow.Cells[3].Value.ToString();
                        b1.event_id.Text = view.CurrentRow.Cells[4].Value.ToString();
                        b1.cus_name.ReadOnly = true;
                        b1.cus_name.Text = view.CurrentRow.Cells[5].Value.ToString();
                        b1.cunt.Visible = true;
                        b1.cunt.Text = view.CurrentRow.Cells[6].Value.ToString();
                        b1.cunt.ForeColor = Color.Black;
                        b1.dateTimePicker1.Text = view.CurrentRow.Cells[7].Value.ToString();
                        b1.amt.Text = view.CurrentRow.Cells[8].Value.ToString();
                       

                        b1.update.Visible = true;
                        b1.button1.Visible = false;


                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            se.Visible = true;
            button5.Visible = true;
            se.Text = "Event name";
            se.ForeColor = Color.Gray;
            
            Update.Visible = false;
            Delete.Visible = false;
            DataGridView data = new DataGridView();

            string sql = "select * from Return_Compo";
            DBConnect con = new DBConnect();

            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            View_event_D v = new View_event_D();
            view.DataSource = set.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            se.Visible = true;
            button5.Visible = true;
            se.Text = "Event name";
            se.ForeColor = Color.Gray;

            Update.Visible = false;
            Delete.Visible = false;
            DataGridView data = new DataGridView();

            string sql = "select * from  Payment";
            DBConnect con = new DBConnect();

            DataSet set = new DataSet();
            set = con.GetFromDB(sql);
            View_event_D v = new View_event_D();
            view.DataSource = set.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.view.Columns[2].HeaderText == "event_id")
            {
                string sql = "select * from Event_Details where event_name='" + se.Text + "'";
                DBConnect con = new DBConnect();

                DataSet set = new DataSet();
                set = con.GetFromDB(sql);
                View_event_D v = new View_event_D();
                view.DataSource = set.Tables[0];

            }

            if (this.view.Columns[2].HeaderText == "booking_id")
            {
                string sql1 = "select * from Booking_Details where event_name='" + se.Text + "'";
                DBConnect con1 = new DBConnect();

                DataSet set1 = new DataSet();
                set1 = con1.GetFromDB(sql1);
                View_event_D v1 = new View_event_D();
                view.DataSource = set1.Tables[0];
            }

            if (this.view.Columns[1].HeaderText == "hire_id")
           {
                string sql2 = "select * from Hired_Compo_Details where event_name='" + se.Text + "'";
               // string s = "select * from Hired_Compo_Details where event_name='srtbrth'";
                DBConnect con2 = new DBConnect();

                DataSet set2 = new DataSet();
                set2 = con2.GetFromDB(sql2);
                View_event_D v2 = new View_event_D();
                view.DataSource = set2.Tables[0];
         }

            if (this.view.Columns[2].HeaderText == "hire_id")
            {
                string sql = "select * from Return_Compo where event_name='" + se.Text + "'";
                DBConnect con = new DBConnect();

                DataSet set = new DataSet();
                set = con.GetFromDB(sql);
                View_event_D v = new View_event_D();
                view.DataSource = set.Tables[0];
            }

            if (this.view.Columns[2].HeaderText == "hire_id")
            {
                string sql = "select * from Payment where event_name='" + se.Text + "'";
                DBConnect con = new DBConnect();

                DataSet set = new DataSet();
                set = con.GetFromDB(sql);
                View_event_D v = new View_event_D();
                view.DataSource = set.Tables[0];
            }
        }

        private void se_Enter(object sender, EventArgs e)
        {
            if (se.Text == "Event name")
            {
                se.Text = "";
                se.ForeColor = Color.Black;
            }
        }

    }
}






