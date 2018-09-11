using System;
using System.Windows.Forms;
using System.Data;

namespace Main.Module.Employee
{
    
    public partial class Calendar : Form
    {
        DBConnect setter = new DBConnect();
        DataSet ds = new DataSet();
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string id = "";
            int month = DateTime.Parse(date).Month;
            if (sun.Checked == true)
            {
                //MessageBox.Show("date = " + date);
                id = date + "S";
                //MessageBox.Show("id="+id+"month="+month+"date"+date);
                add_grid.Rows.Add(id, month,date);
            }
            else if(sat.Checked == true) 
            {
                //MessageBox.Show("date = " + date);
                id = date + "SA";
                //MessageBox.Show("id=" + id + "month=" + month + "date" + date);
                add_grid.Rows.Add(id, month,null,date);
            }
            else if (pub_hol.Checked == true)
            {
               // MessageBox.Show("date = " + date);
                id = date + "P";
                //MessageBox.Show("id=" + id + "month=" + month + "date" + date);
                add_grid.Rows.Add(id, month, null, null, date);
            }
            else
            {
                MessageBox.Show("Please select the type of Day", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void sun_CheckedChanged(object sender, EventArgs e)
        {
            sat.Checked = false;
            pub_hol.Checked = false;
        }

        private void sat_CheckedChanged(object sender, EventArgs e)
        {
            sun.Checked = false;
            pub_hol.Checked = false;
        }

        private void pub_hol_CheckedChanged(object sender, EventArgs e)
        {
            sun.Checked = false;
            sat.Checked = false;
        }

        private void cal_save_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to save the dates?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {
                string id = "";
                int month = 0;
                string sday = "";
                string satday = "";
                string pholi = "";
                for (int i = 0; i < add_grid.Rows.Count; i++)
                {
                    id = add_grid.Rows[i].Cells[0].Value.ToString();
                    month = Convert.ToInt32(add_grid.Rows[i].Cells[1].Value.ToString());
                    if (add_grid.Rows[i].Cells[2].Value == null)
                    {
                        if (add_grid.Rows[i].Cells[3].Value == null)
                        {
                            sday = null;
                            satday = null;
                            pholi = add_grid.Rows[i].Cells[4].Value.ToString();
                        }
                        else
                        {
                            sday = null;
                            satday = add_grid.Rows[i].Cells[3].Value.ToString();
                            pholi = null;

                        }
                    }
                    else
                    {
                        sday = add_grid.Rows[i].Cells[2].Value.ToString();
                        satday = null;
                        pholi = null;
                    }


                    setter.SendToDB("INSERT INTO Calendar(id, month, sunday, saturday, public_holiday) VALUES ('" + id + "', " + month + ", '" + sday + "', '" + satday + "', '" + pholi + "')");
                    
                    
                }
                MessageBox.Show("Saved the dates successfully", "Information");
                add_grid.Rows.Clear();
            }


        }

        private void cal_clear_Click(object sender, EventArgs e)
        {
            add_grid.Rows.Clear();
        }

        private void cal_view_Click(object sender, EventArgs e)
        {
            cal_save.Visible = false;
            cal_clear.Visible = false;
            cal_hisClear.Visible = true;
            add_new.Visible = true;

            ds = setter.GetFromDB("SELECT COUNT(id) FROM Calendar");

            //MessageBox.Show("ds = " + ds.Tables[0].Rows[0][0]);

            int i = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            //MessageBox.Show("i = " + i);
            if (i > 0)
            {
                ds = setter.GetFromDB("SELECT * FROM Calendar");
                view_grid.DataSource = ds.Tables[0];
                view_grid.Visible = true;
                add_grid.Visible = false;

            }
        }

        private void cal_hisClear_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you want to Clear the History?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == System.Windows.Forms.DialogResult.Yes)
            {             
                setter.SendToDB("DELETE FROM Calendar");
                view_grid.DataSource = null;
                MessageBox.Show("History cleared Successfully.");
            }

        }

        private void add_new_Click(object sender, EventArgs e)
        {
            cal_save.Visible = true;
            cal_clear.Visible = true;
            add_new.Visible = false;
            cal_hisClear.Visible = false;
            view_grid.Visible = false;
            view_grid.DataSource = null;
            add_grid.Rows.Clear();
            add_grid.Visible = true;
        }

        
        
    }
}
