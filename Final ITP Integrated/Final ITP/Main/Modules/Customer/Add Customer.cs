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
using System.Text.RegularExpressions;

namespace Main.Modules.Customer
{
    public partial class Add_Customer : Form
    {
       
        public Add_Customer()
        {
            InitializeComponent();
        }

      

        private void btadd_Click(object sender, EventArgs e)
        {
            // check text box values (validations)
            if (txtComName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Company Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(txtFName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtLName.Text == string.Empty)
            {
                MessageBox.Show("Please enter a  Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtAdd1.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Address1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtAdd2.Text == string.Empty)
            {
                MessageBox.Show("Please enter your Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtConNo.Text == string.Empty)
            {
                MessageBox.Show("Please enter a Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Regex.IsMatch(txtConNo.Text, @"^([0-9]{10})$"))
            {
                MessageBox.Show("Invalid Contact Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CBcategory.Text == string.Empty)
            {
                MessageBox.Show("Please Select a Category !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (date_validator(DateTime.Parse(dtpDOB.Text)))
            {
                MessageBox.Show("Please enter correct Birthday !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    // add data to customer database
                    new DBConnect().SendToDB("INSERT INTO customer(Company_Name,Fname ,Lname ,Address1 ,Address2 ,Email ,Contact_number ,DOB,Category ) VALUES('" + txtComName.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAdd1.Text + "','" + txtAdd2.Text + "','" + txtEmail.Text + "'," + txtConNo.Text + ",'" + dtpDOB.Value.ToString() + "','" + CBcategory.SelectedItem.ToString() + "')");

                    //after adding values show success message
                    MessageBox.Show("Information Saved Successfully!!", "Save Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error message");
                }
            }      
           
        }


      
       
        //validate email address

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DimGray;
            }

            string email = txtEmail.Text;
           
            if (emailIsValid(email))
            {
                responce.Text = "";
            }
            else
            {
                responce.Text = "Invalid email address !!"; 
            }


        }

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


               private void txtComName_Enter(object sender, EventArgs e)
               {
                   if (txtComName.Text == "Company Name")
                   {
                       txtComName.Text = "";
                       txtComName.ForeColor = Color.Black;
                   }
               }

               private void txtFName_Enter(object sender, EventArgs e)
               {
                   if (txtFName.Text == "First Name")
                   {
                       txtFName.Text = "";
                       txtFName.ForeColor = Color.Black;
                   }
               }

               private void txtLName_Enter(object sender, EventArgs e)
               {
                   if (txtLName.Text == "Last Name")
                   {
                       txtLName.Text = "";
                       txtLName.ForeColor = Color.Black;
                   }
               }

               private void txtAdd1_Enter(object sender, EventArgs e)
               {
                   if (txtAdd1.Text == "Address")
                   {
                       txtAdd1.Text = "";
                       txtAdd1.ForeColor = Color.Black;
                   }
               }

               private void txtAdd2_Enter(object sender, EventArgs e)
               {
                   if (txtAdd2.Text == "City")
                   {
                       txtAdd2.Text = "";
                       txtAdd2.ForeColor = Color.Black;
                   }
               }

               private void txtEmail_Enter(object sender, EventArgs e)
               {
                   if (txtEmail.Text == "Email")
                   {
                       txtEmail.Text = "";
                       txtEmail.ForeColor = Color.Black;
                   }
               }

               private void txtConNo_Enter(object sender, EventArgs e)
               {
                   if (txtConNo.Text == "Contact Number")
                   {
                       txtConNo.Text = "";
                       txtConNo.ForeColor = Color.Black;
                   }
               }

               private void txtComName_Leave(object sender, EventArgs e)
               {
                   if (txtComName.Text == "")
                   {
                       txtComName.Text = "Company Name";
                       txtComName.ForeColor = Color.DimGray;
                   }
               }

               private void txtFName_Leave(object sender, EventArgs e)
               {
                   if (txtFName.Text == "")
                   {
                       txtFName.Text = "First Name";
                       txtFName.ForeColor = Color.DimGray;
                   }
               }

               private void txtLName_Leave(object sender, EventArgs e)
               {
                   if (txtLName.Text == "")
                   {
                       txtLName.Text = "Last Name";
                       txtLName.ForeColor = Color.DimGray;
                   }
               }

               private void txtAdd1_Leave(object sender, EventArgs e)
               {
                   if (txtAdd1.Text == "")
                   {
                       txtAdd1.Text = "Address";
                       txtAdd1.ForeColor = Color.DimGray;
                   }
               }

               private void txtAdd2_Leave(object sender, EventArgs e)
               {
                   if (txtAdd2.Text == "")
                   {
                       txtAdd2.Text = "City";
                       txtAdd2.ForeColor = Color.DimGray;
                   }
               }

               private void txtConNo_Leave_1(object sender, EventArgs e)
               {
                   if (txtConNo.Text == "")
                   {
                       txtConNo.Text = "Contact Number";
                       txtConNo.ForeColor = Color.DimGray;
                   }
               }

               private void btndemo_Click(object sender, EventArgs e)
               {
                   txtComName.Text = "MAS";
                   txtFName.Text = "elena";
                   txtLName.Text = "macol";
                   txtAdd1.Text = "baconhill";
                   txtAdd2.Text = "south west";
                   txtConNo.Text = "0332295065";
                   txtEmail.Text = "elena@gmail.com";
                   CBcategory.Text = "Event";
                   dtpDOB.Text = "1985/10/30";
               }

               private void Add_Customer_Load(object sender, EventArgs e)
               {
                   
               }

               //validate birthday
               public Boolean date_validator(DateTime date)
               {
                   DateTime currentDate = DateTime.Now.Date;
                   DateTime inputDate = date;
                   if (currentDate <= inputDate)
                   {
                       return true;
                   }

                   else
                   {
                       return false;
                   }
               }

    }
}
