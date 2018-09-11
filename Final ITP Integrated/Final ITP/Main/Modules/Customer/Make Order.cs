using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Modules.Customer
{
    public partial class Make_Order_Copy : Form
    {
        public Make_Order_Copy()
        {
            InitializeComponent();
        }

        //variables for bill number and total
        string type,count,BillNo;       
        decimal total ;

        private void btmakeorder_Click(object sender, EventArgs e)
        {
            //radio butten select
            if (RByes.Checked == true)
            {
                type = "yes";
            }
            else
            {
                type = "no";
            }

            //call get bill number methode(auto increment bill no)
            BillNo = GetBillNo();
  

            //check quantity 
            bool quantityEmpty = false;
            for(int i=0 ; i< LItems.Rows.Count ; i++)
            {            
                if (LItems.Rows[i].Cells[5].Value== null)                             
                {                            
                    MessageBox.Show("Please Enter The Quantity !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                 
                    quantityEmpty = true;                                 
                    break;                            
                }            
            }

            if(!quantityEmpty)
            {
                if ((txtConNo.Text == string.Empty) || (txtConNo.Text == "Contact Number"))
                {
                    MessageBox.Show("Enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (RByes.Checked != true && RBno.Checked != true)
                {
                    MessageBox.Show("Do you need transport facilities ?", "Check Transport Facilities", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else if (RByes.Checked == true && txtDadd.Text == string.Empty)
                {
                    MessageBox.Show("please Enter the Delivery Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;                
                }

                else if (RByes.Checked == true && txtDadd.Text == "Address")
                {
                    MessageBox.Show("please Enter the Delivery Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (date_validator(DateTime.Parse(dtpreturn.Text)))
                {
                    MessageBox.Show("Your return date should be a future date","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    return;
                }

                else
                {
                    //save customer order 
                    new DBConnect().SendToDB("INSERT INTO Customer_order (Bill_No,Contact_Number,Return_Date ,Transport_Facilities,Delivery_Address) VALUES ('" + BillNo + "'," + txtConNo.Text + " ,'" + dtpreturn.Value.ToString() + "','" + type + "','" + txtDadd.Text + "')");

                    for (int i = 0; i < LItems.Rows.Count; i++)
                    {
                        //save selected items
                        new DBConnect().SendToDB("INSERT INTO Selected_Items (Bill_No,Item_No,Contact_Number,Quantity ) VALUES ('" + BillNo + "','" + LItems.Rows[i].Cells[0].Value + "' ," + txtConNo.Text + ",' " + LItems.Rows[i].Cells[5].Value + "')");

                        //calculate total(quantity * unit price)
                        total = 0;
                        total = Convert.ToInt32(LItems.Rows[i].Cells[5].Value) * Convert.ToDecimal(LItems.Rows[i].Cells[4].Value);

                        //save data to advance bill
                        new DBConnect().SendToDB("INSERT INTO Advance_Bill (Bill_No,Item_No,Quantity,Unit_Price,Total_Amount) VALUES ('" + BillNo + "' ,'" + LItems.Rows[i].Cells[0].Value + "'," + LItems.Rows[i].Cells[5].Value + "," + LItems.Rows[i].Cells[4].Value + "," + total + ")");

                    }

                    //after adding values show success message and bill number
                    MessageBox.Show("Information Saved Successfully!!", "Order Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(BillNo + "  Is Your Bill Number");
                }
            }
               
        }


        // create auto increment bill number
        public String GetBillNo()
        {
            count = (Convert.ToInt32(new DBConnect().GetFromDB("SELECT COUNT(*) FROM Customer_order").Tables[0].Rows[0][0]) + 1).ToString();
            return ("No"+count);
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            //get items to datagrid view according to category
            DataSet data = new DBConnect().GetFromDB("SELECT Model,Category,Coustomer_Category,Brand,Unit_Price  FROM tbl_items WHERE Coustomer_Category = '" + cmbCategory.Text + "'");
            dataGridView1.DataSource = data.Tables[0]; 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get selected item from Litems datagrid
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int rowNumber = LItems.Rows.Count;
            bool duplicated = false;

                if (rowNumber != 0)
                {
                    for (int i = 0; i < rowNumber; i++)
                    {
                        if (LItems.Rows[i].Cells[0].Value == dataGridView1.Rows[selectedRow].Cells[0].Value) {
                            duplicated = true;
                            break;
                        }
                    }

                    if (!duplicated)
                    {
                        //call selectedItem method to copy data from Litems
                        addSelectedItem();
                    }
                    else {
                        MessageBox.Show("You Already Selected The Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addSelectedItem();
                }                
            }

        //copy data to selected item datagrid
        private void addSelectedItem() 
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = (DataGridViewRow)dataGridView1.Rows[selectedRow].Clone();
            int col = 0;
            foreach (DataGridViewCell cell in dataGridView1.Rows[selectedRow].Cells)
            {
                row.Cells[col].Value = cell.Value;
                col++;
            }
            LItems.Rows.Add(row);
        }

        //remove items from selected item datagrid
        private void btremove_Click(object sender, EventArgs e)
        {
            int rowIndex = LItems.CurrentCell.RowIndex;
            LItems.Rows.RemoveAt(rowIndex);

        }

        private void txtConNo_Leave(object sender, EventArgs e)
        {
            if (txtConNo.Text == string.Empty)
            {
                txtConNo.Text = "Contact Number";
                txtConNo.ForeColor = Color.DimGray;
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

        private void txtDadd_Leave(object sender, EventArgs e)
        {
            if (txtDadd.Text == "")
            {
                txtDadd.Text = "Address";
                txtDadd.ForeColor = Color.DimGray;
            }
        }

        private void txtDadd_Enter(object sender, EventArgs e)
        {
            if (txtDadd.Text == "Address")
            {
                txtDadd.Text = "";
                txtDadd.ForeColor = Color.Black;
            }
        }

        //validate return date
        public Boolean date_validator(DateTime date)
        { 
            DateTime currentDate = DateTime.Now.Date; 
            DateTime inputDate = date;
            if (currentDate >= inputDate)
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
