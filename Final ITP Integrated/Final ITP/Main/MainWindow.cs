using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public partial class MainWindow : Form
    {
        string function = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        //static Main.Modules.Inventory.InventoryMain InventoryMain;
        //static bool chartUpdated = false;

        private void UIDesignForm_Load(object sender, EventArgs e)
        {
            this.panel_login.Visible = false;
            this.btn_login.Visible = false;
            this.lbl_username.Visible = false;
            this.txt_username.Visible = false;
            this.lbl_password.Visible = false;
            this.txt_password.Visible = false;

            this.panel_left.BackColor = Color.FromArgb(128, 255, 255, 255);
            this.panel_right.BackColor = this.panel_left.BackColor;
            this.panel_login.BackColor = Color.FromArgb(65,209,209,224);          

            this.lbl_welcomeText.BackColor = Color.Transparent;
            this.lbl_username.BackColor = Color.Transparent;
            this.lbl_password.BackColor = Color.Transparent;

            this.lbl_inventory.BackColor = Color.Transparent;
            this.lbl_transport_management.BackColor = Color.Transparent;
            this.lbl_supplier.BackColor = Color.Transparent;
            this.lbl_customer_management.BackColor = Color.Transparent;
            this.lbl_Employee.BackColor = Color.Transparent;
            this.lbl_financial.BackColor = Color.Transparent;
            this.lbl_project.BackColor = Color.Transparent;
            this.lbl_Event.BackColor = Color.Transparent;

            this.btn_login.BackColor = Color.FromArgb(255,51,153,51);
            this.btn_inventory.BackColor = Color.Transparent;
            this.btn_supplier.BackColor =  Color.Transparent;
            this.btn_transport.BackColor = Color.Transparent;
            this.btn_customer_management.BackColor = Color.Transparent;
            this.btn_Employee.BackColor = Color.Transparent;
            this.btn_Event.BackColor = Color.Transparent;
            this.btn_project.BackColor = Color.Transparent;
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.DimGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.PasswordChar = '*';
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.DimGray;                
                txt_password.PasswordChar = '\0';
            }
        }

        private void showLogin(string functionalParameter) {
            this.function = functionalParameter;
            this.panel_login.Visible = true;
            this.lbl_username.Visible = true;
            this.lbl_password.Visible = true;
            this.txt_username.Visible = true;
            this.txt_password.Visible = true;
            this.btn_login.Visible = true;
        }

        private string loadModule(DataSet userID,string userType,string functionParameter,Form moduleObject) {
            string errorMessage = null;

            if (userID.Tables[0].Rows[0][1].ToString() == userType)
            {
                if (function == functionParameter)
                {
                    errorMessage = null;
                    moduleObject.Show();
                    //new Main.modules.inventory.InventoryMain().Show();
                }
                else
                {
                    errorMessage = "You Don't Have Permission To Use This Function.Please Use " + function + " Management Function";
                    moduleObject.Dispose();
                }
            }
            return errorMessage;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string errorMessage = null;

            if (username == "Username")
            {
                if (password == "Password")
                {
                    errorMessage = "Please Enter The Username And Password";
                }
                else
                {
                    errorMessage = "Please Enter The Username";
                }
            }
            else
            {
                if (password == "Password")
                {
                    errorMessage = "Please Enter The Password";
                }
                else
                {
                    DataSet userID = new UserDBQueries().getUserDetails(username, password);
                    if (userID.Tables[0].Rows.Count != 0)
                    {
                        txt_password.Text = "Password";
                        txt_username.Text = "Username";
                        txt_password.PasswordChar = '\0';

                        txt_password.ForeColor = Color.DimGray;
                        txt_username.ForeColor = Color.DimGray;

                        loadModule(userID, "Inventory Manager", "Inventory", new Main.Modules.Inventory.InventoryMain());
                        //loadModule(userID, "Project Manager", "Project", new frmProjectMain());
                        //loadModule(userID, "Supply Manager", "Supply", new frmSupplyMain());
                        //loadModule(userID, "Transport Manager", "Transport", new frmTransportMain());
                        //loadModule(userID, "Customer Manager", "Customer", new frmCustomerMain());
                        //loadModule(userID, "Event Manager", "Event", new frmEvent_Main());
                        //loadModule(userID, "Financial Manager", "Financial", new frmFinanceMain());
                        //loadModule(userID, "Employee Manager", "Employee", new frmEmployeeMain());
                    }
                    else
                    {
                        errorMessage = "Invalid Username Or Password";
                    }                                     
                }                               
            }

            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            showLogin("Inventory");
        }

        private void lbl_inventory_Click(object sender, EventArgs e)
        {
            showLogin("Inventory");
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            showLogin("Supply");
        }

        private void lbl_supplier_Click(object sender, EventArgs e)
        {
            showLogin("Supply");
        }

        private void btn_transport_Click(object sender, EventArgs e)
        {
            showLogin("Transport");
        }

        private void lbl_transport_management_Click(object sender, EventArgs e)
        {
            showLogin("Transport");
        }

        private void btn_customer_management_Click(object sender, EventArgs e)
        {
            showLogin("Customer");
        }

        private void lbl_customer_management_Click(object sender, EventArgs e)
        {
            showLogin("Customer");
        }

        private void btn_Event_Click(object sender, EventArgs e)
        {
            showLogin("Event");
        }

        private void btn_Financial_Click(object sender, EventArgs e)
        {
            showLogin("Financial");
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            showLogin("Employee");
        }

        private void btn_project_Click(object sender, EventArgs e)
        {
            showLogin("Project");
        }

        private void lbl_project_Click(object sender, EventArgs e)
        {
            showLogin("Project");
        }

        private void btn_financial_Click_1(object sender, EventArgs e)
        {
            showLogin("Financial");
        }

        private void lbl_financial_Click(object sender, EventArgs e)
        {
            showLogin("Financial");
        }

        private void lbl_Employee_Click(object sender, EventArgs e)
        {
            showLogin("Employee");
        }
    }
}
