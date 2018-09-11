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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using System.Collections;


namespace Main.Modules.Event
{
    public partial class payment : Form
    {
        public static string id;
        public static string enme;
        public static string nme;
        public static string dt;

        public payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 102, 153);
        
        }

        private void en_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Return r1 = new Return();
            //MessageBox.Show(r1.label28.Text);
            int lc, dc, tot1 = 0, tot2 = 0, tot;
            string a = "";
            string b = "";

            string name = en.Text;
            string sql = "select hire_id from Hired_Compo_Details where event_name='" + name + "'";

            DBConnect b1 = new DBConnect();
            b1.ConnectToDatabase();
            DataSet valu = b1.GetFromDB(sql);
            hir_id.Text = valu.Tables[0].Rows[0][0].ToString();

            string eid = hir_id.Text;
            string sql1 = "select deposit from Hired_Compo_Details where event_name='" + name + "' and hire_id='" + eid + "'";

            DBConnect b2 = new DBConnect();
            b2.ConnectToDatabase();
            DataSet valu1 = b2.GetFromDB(sql1);
            string dep = valu1.Tables[0].Rows[0][0].ToString();

            if (dep != "")
            {
                textBox2.Text = dep;
            }

            string sql2 = "select lcharge from Return_Compo where event_name='" + name + "' and hire_id='" + eid + "'";

            DBConnect b3 = new DBConnect();
            b3.ConnectToDatabase();
            DataSet valu2 = b3.GetFromDB(sql2);


            for (int i = 0; i < valu2.Tables[0].Rows.Count; i++)
            {

                lc = Convert.ToInt32(valu2.Tables[0].Rows[i][0].ToString());
            //    MessageBox.Show(valu2.Tables[0].Rows[i][0].ToString());
                tot1 += lc;
            }

            string sql3 = "select dcharge from Return_Compo where event_name='" + name + "' and hire_id='" + eid + "'";

            DBConnect b4 = new DBConnect();
            b4.ConnectToDatabase();
            DataSet valu3 = b4.GetFromDB(sql3);

            for (int i = 0; i < valu3.Tables[0].Rows.Count; i++)
            {

                dc = Convert.ToInt32(valu3.Tables[0].Rows[i][0].ToString());
             //   MessageBox.Show(valu3.Tables[0].Rows[i][0].ToString());
                tot2 += dc;

            }

            tot = tot1 + tot2;
            //MessageBox.Show(tot.ToString());
            textBox3.Text = tot.ToString();


            string sql4 = "select price from Hired_Compo_Details where event_name='" + name + "' and hire_id='" + eid + "'";
            string sql5 = "select count from Hired_Compo_Details where event_name='" + name + "' and hire_id='" + eid + "'";
            string sql6 = "select no_of_date from Hired_Compo_Details where event_name='" + name + "' and hire_id='" + eid + "'";

            DBConnect b5 = new DBConnect();
            b5.ConnectToDatabase();
            DataSet valu4 = b5.GetFromDB(sql4);

            DBConnect b6 = new DBConnect();
            b6.ConnectToDatabase();
            DataSet valu5 = b6.GetFromDB(sql5);

            DBConnect b7 = new DBConnect();
            b7.ConnectToDatabase();
            DataSet valu6= b7.GetFromDB(sql6);

              int total = 0, c, d, f;


            for (int i = 0; i < valu4.Tables[0].Rows.Count; i++)
            {
               a = valu4.Tables[0].Rows[i][0].ToString();

            //   MessageBox.Show("hi:" + a);
             //  MessageBox.Show("i:" + i.ToString());

               for (int j = i; j < i+1; j++)
                {
                    b = valu5.Tables[0].Rows[j][0].ToString();
                  // MessageBox.Show("count :" + b);
                  // MessageBox.Show("j:" + j.ToString());

                    for (int k = i; k < i + 1; k++)
                    {

                        c = (Convert.ToInt32(valu4.Tables[0].Rows[i][0].ToString())) * (Convert.ToInt32(valu5.Tables[0].Rows[j][0].ToString())) * (Convert.ToInt32(valu6.Tables[0].Rows[k][0].ToString()));
                        total += c;
                    }
                   
               }
            }

          //  MessageBox.Show(total.ToString());
            textBox1.Text = total.ToString();
        }
                
           
        private void trans_Leave(object sender, EventArgs e)
        {
            if (trans.Text == "Transpotation")
            {
                errorProvider1.SetError(trans, "Please enter the event name");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }

            int tot_amt = 0;
            int amt = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text) + Convert.ToInt32(trans.Text);
          

            if (textBox2.Text !="")
            {
                int j = Convert.ToInt32(textBox2.Text);
                tot_amt = amt - j;
            }

            if (textBox2.Text == "")
            {
                tot_amt = amt;
            }

            textBox4.Text = tot_amt.ToString();
           // MessageBox.Show(tot_amt.ToString());
        }

        private void submit_Click(object sender, EventArgs e)
        {
            submit.Visible = false;
            button1.Visible = true;
            Validation v1 = new Validation();
            Boolean c1 = v1.validateInput(en.Text, "Event name");
            Boolean c2 = v1.validateInput(trans.Text, "Transpotation");
            Boolean c3 = v1.validateInput(textBox5.Text, "Customer name");
            //  Boolean c4;

            if (c1 == true || c2 == true || c3 == true)
            {
                MessageBox.Show("Should have to fill all the textboxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult dia = MessageBox.Show("Do you really want to save details?", "Exit", MessageBoxButtons.YesNo);

                if (dia == DialogResult.Yes)
                {
                    DBConnect b1 = new DBConnect();
                    b1.ConnectToDatabase();

                    b1.SendToDB("update Hired_Compo_Details set status='Returned' where hire_id='" + hir_id.Text + "'");
                    b1.SendToDB("insert into Payment (hired_id,event_name,deposit,hired_compo_charges,extra_charge,Transpotation,Customer_name,date,Total_amount) values('" + this.hir_id.Text + "','" + this.en.Text + "','" + this.textBox2.Text + "','" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.trans.Text + "','" + this.textBox5.Text + "','" + this.dateTimePicker1.Text + "','" + this.textBox4.Text + "')");
                    MessageBox.Show("Saved");



                }

                else if (dia == DialogResult.No)
                {

                }
            }
        }
        private void en_Enter(object sender, EventArgs e)
        {
            if (en.Text == "Event name")
            {
                en.Text = "";
                en.ForeColor = Color.Black;

            }
        }

        private void en_Leave(object sender, EventArgs e)
        {

            if (en.Text == "")
            {
                en.Text = "Event name";
                en.ForeColor = Color.Silver;
            }


            if (en.Text == "Event name")
            {
                errorProvider1.SetError(en, "Please enter the event name");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void trans_Enter(object sender, EventArgs e)
        {
            if (trans.Text == "Transpotation")
            {
                trans.Text = "";
                trans.ForeColor = Color.Black;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Customer name")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Customer name";
               textBox5.ForeColor = Color.Silver;
            }


            if (textBox5.Text == "Customer name")
            {
                errorProvider1.SetError(textBox5, "Please enter the event name");
                errorProvider1.Icon = Properties.Resources.wrong;
            }
            else
            {
                errorProvider1.Dispose();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = hir_id.Text;
            enme = en.Text;
            nme = textBox5.Text;
            dt = dateTimePicker1.Text;

            this.Hide();
            Report a1 = new Report();
            a1.Show();
            
        }

        private void trans_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
