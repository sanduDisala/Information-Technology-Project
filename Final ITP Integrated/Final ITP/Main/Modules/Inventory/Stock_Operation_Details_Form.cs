using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;

namespace Main.Modules.Inventory
{
    public partial class Stock_Operation_Details_Form : Form
    {
        public Stock_Operation_Details_Form()
        {
            InitializeComponent();
        }

        public int operation;
        private string chkCode = null, errorMessage = null;

        private bool validateNumbers(string number)
        {
            if (Regex.IsMatch(number, @"^\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void Prepare_Form_Elements(string availableItemsText,string selectedItemsText,string btnOKText, DataSet data, DataSet combolist1, DataSet combolist2, DataSet combolist3, DataSet combolist4, string combolist1ValueMember, string combolist2ValueMember, string combolist3ValueMember, string combolist4ValueMember)
        {
            this.grp_Available_Items.Text = availableItemsText;
            this.grp_Selected_Items.Text = selectedItemsText;
            this.btnOK.Text = btnOKText;
            this.grdView_Available_Items.DataSource = data.Tables[0];

            DataSet Lists = combolist1; //new DBQueries().getBrandList();
            cmbBrand.DataSource = Lists.Tables[0];
            cmbBrand.ValueMember = combolist1ValueMember;// "Brand";
            cmbBrand.DisplayMember = "brand";

            Lists = combolist2; //new DBQueries().getDealerList();
            cmbDealer.DataSource = Lists.Tables[0];
            cmbDealer.ValueMember = combolist2ValueMember;//"Supplier_Name";
            cmbDealer.DisplayMember = "dealers";

            Lists = combolist3; //new DBQueries().getItemTypeList();
            cmbType.DataSource = Lists.Tables[0];
            cmbType.ValueMember = combolist3ValueMember;//"Type";
            cmbType.DisplayMember = "type";

            Lists = combolist4; //new DBQueries().getItemCategoryList();
            cmbCategory.DataSource = Lists.Tables[0];
            cmbCategory.ValueMember = combolist4ValueMember;//"Category";
            cmbCategory.DisplayMember = "category";

            Lists.Dispose();

            cmbBrand.Text = "Tick And Select";
            cmbCategory.Text = cmbBrand.Text;
            cmbDealer.Text = cmbBrand.Text;
            cmbType.Text = cmbBrand.Text;

            cmbBrand.Enabled = false;
            cmbCategory.Enabled = false;
            cmbDealer.Enabled = false;
            cmbType.Enabled = false;
        }

        //DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();

        private void Stock_form_Load(object sender, EventArgs e)
        {
            if (operation < 4)
            {
                if (operation == 1)
                {
                    this.Text = "Add Stock Form";
                    this.btnOK.Text = "Add";

                    grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");
                    //grdView_Selected_Items.Columns.Add("Item_ID", "Item ID");
                    grdView_Selected_Items.Columns.Add("Model", "Model");
                    grdView_Selected_Items.Columns.Add("Brand", "Brand");
                    grdView_Selected_Items.Columns.Add("Category", "Category");
                    grdView_Selected_Items.Columns.Add("Quantity", "Quantity");

                    grdView_Selected_Items.Columns[0].ReadOnly = true;
                    grdView_Selected_Items.Columns[1].ReadOnly = true;
                    grdView_Selected_Items.Columns[2].ReadOnly = true;
                    grdView_Selected_Items.Columns[3].ReadOnly = true;
                    grdView_Selected_Items.Columns[4].ReadOnly = false;

                    Prepare_Form_Elements("Ordered Item Details","Selected Item Details","Add Stock",new DBQueries().getArrivedStockDetails(null, null, null, null, null, null, 0, "0"), new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
                }
                else if (operation == 2)
                {
                    this.Text = "Remove Stock Form";
                    this.btnOK.Text = "Delete";

                    grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");
                    grdView_Selected_Items.Columns.Add("Model", "Model");
                    grdView_Selected_Items.Columns.Add("Brand", "Brand");
                    grdView_Selected_Items.Columns.Add("Quantity", "Quantity");

                    grdView_Selected_Items.Columns[0].ReadOnly = true;
                    grdView_Selected_Items.Columns[1].ReadOnly = true;
                    grdView_Selected_Items.Columns[2].ReadOnly = true;
                    grdView_Selected_Items.Columns[3].ReadOnly = true;
                    this.grp_formBox.Text = "Remove Stock Form Details";

                    Prepare_Form_Elements("Ordered Stock Details","Selected Stock Details","Remove Stock",new DBQueries().getStockDetails(null, null, null, null), new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
                }
                else
                {
                    this.Text = "Change Stock Form";

                    grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");
                    grdView_Selected_Items.Columns.Add("Model", "Model");
                    grdView_Selected_Items.Columns.Add("Brand", "Brand");
                    grdView_Selected_Items.Columns.Add("Quantity", "Quantity");

                    grdView_Selected_Items.Columns[0].ReadOnly = true;
                    grdView_Selected_Items.Columns[1].ReadOnly = true;
                    grdView_Selected_Items.Columns[2].ReadOnly = true;
                    grdView_Selected_Items.Columns[3].ReadOnly = false;
                    this.grp_formBox.Text = "Change Stock Form Details";

                    Prepare_Form_Elements("Ordered Stock Details","Selected Stock Details","Change Stock",new DBQueries().getStockDetails(null, null, null, null), new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
                }
            }
            else if (operation == 4)
            {
                this.Text = "Add Order Form";
                //this.grp_Available_Items.Text = "Available Items";                
                //this.grp_Selected_Items.Text = "Selected Items";
                this.grp_formBox.Text = "Add Order Form Details";
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();

                grdView_Selected_Items.Columns.Add("Order ID", "Order ID");
                grdView_Selected_Items.Columns.Add("Model Name", "Model Name");
                grdView_Selected_Items.Columns.Add("Brand", "Brand");
                grdView_Selected_Items.Columns.Add("Category", "Category");
                grdView_Selected_Items.Columns.Add("Type", "Type");
                grdView_Selected_Items.Columns.Add("Quantity", "Quantity");
                grdView_Selected_Items.Columns.Add("Price", "Price");

                column.HeaderText = "Automatic Reordering";
                column.Name = "Automatic Reordering";
                column.MaxDropDownItems = 2;
                column.ReadOnly = true;
                column.DataSource = new string[] { "Set", "Don't Set" };

                grdView_Selected_Items.Columns.Add(column);
                grdView_Selected_Items.Columns.Add("Threshold Value", "Threshold Value");
                grdView_Selected_Items.Columns.Add("Reordering Amount", "Reordering Amount");

                grdView_Selected_Items.Columns[0].ReadOnly = true;
                grdView_Selected_Items.Columns[1].ReadOnly = true;
                grdView_Selected_Items.Columns[2].ReadOnly = true;
                grdView_Selected_Items.Columns[3].ReadOnly = true;
                grdView_Selected_Items.Columns[4].ReadOnly = true;
                grdView_Selected_Items.Columns[5].ReadOnly = false;
                grdView_Selected_Items.Columns[6].ReadOnly = true;

                grdView_Selected_Items.Columns[7].ReadOnly = false;
                grdView_Selected_Items.Columns[8].ReadOnly = false;
                grdView_Selected_Items.Columns[9].ReadOnly = false;

                grdView_Selected_Items.Columns[8].Visible = false;
                grdView_Selected_Items.Columns[9].Visible = false;

                DataSet data = new DBQueries().getAvailableOrderItemDetails(null, null, null, null);
                Prepare_Form_Elements("Available Item Details","Selected Item Details","Place Order",data, new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
            }

            else if (operation == 5)
            {
                this.Text = "Remove Order Form";
                this.grp_Available_Items.Text = "Available Orders";
                this.grp_Selected_Items.Text = "Orders To Be Removed";

                grdView_Selected_Items.Columns.Add("Order ID", "Order ID");
                grdView_Selected_Items.Columns.Add("Brand", "Brand");
                grdView_Selected_Items.Columns.Add("Ordered Date", "Ordered Date");

                grdView_Selected_Items.Columns[0].ReadOnly = true;
                grdView_Selected_Items.Columns[1].ReadOnly = true;
                grdView_Selected_Items.Columns[2].ReadOnly = true;

                DataSet data = new DBQueries().getOrderDetails(null, null, null, null);
                Prepare_Form_Elements("Available Order Details","Selected Order Details","Cancel Order",data, new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
            }
            else if (operation == 6)
            {
                this.Text = "Change Order Form";
                this.grp_Available_Items.Text = "Available Orders";
                this.grp_Selected_Items.Text = "Details About Orders That Need To Be Updated";

                grdView_Selected_Items.Columns.Add("Model", "Model");
                grdView_Selected_Items.Columns.Add("Count", "Count");

                grdView_Selected_Items.Columns[0].ReadOnly = true;
                grdView_Selected_Items.Columns[1].ReadOnly = false;

                DataSet data = new DBQueries().getOrderDetails(null, null, null, null);
                Prepare_Form_Elements("Available Order Details","Selected Order Details","Change Order",data, new DBQueries().getBrandList(), new DBQueries().getDealerList(), new DBQueries().getItemTypeList(), new DBQueries().getItemCategoryList(), "Brand", "Supplier_Name", "Type", "Category");
            }
            else
            {
                if (operation == 7)
                {
                    this.grp_formBox.Text = "Add Warehouse Operation Information";
                    this.Text = "Add Warehouse Operation Details Form";

                    this.chkBrand.Text = "Vehicle Type";
                    this.chkDealer.Text = "Arrival";
                    this.chkType.Text = "Departure";
                    this.chkCategory.Text = "Request Date";

                    this.cmbBrand.Size = new System.Drawing.Size(140, 26);
                    this.cmbDealer.Size = new System.Drawing.Size(140, 26);
                    this.cmbType.Size = new System.Drawing.Size(140, 26);
                    this.cmbCategory.Size = new System.Drawing.Size(140, 26);

                    this.cmbBrand.Location = new Point((this.cmbBrand.Location.X + 20), this.cmbBrand.Location.Y);
                    this.cmbDealer.Location = new Point((this.cmbDealer.Location.X + 20), this.cmbDealer.Location.Y);
                    this.cmbType.Location = new Point((this.cmbType.Location.X + 20), this.cmbType.Location.Y);
                    this.cmbCategory.Location = new Point((this.cmbCategory.Location.X + 20), this.cmbCategory.Location.Y);

                    grdView_Selected_Items.Columns.Add("Activity_ID", "Activity ID");
                    //grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");

                    DataGridViewComboBoxColumn stockID = new DataGridViewComboBoxColumn();
                    stockID.HeaderText = "Stock ID";
                    stockID.Name = "Stock_ID";
                    stockID.ReadOnly = true;

                    DataSet data = new DBQueries().getStockIDList();
                    ArrayList stockIDList = new ArrayList();
                    MessageBox.Show(data.Tables[0].Rows.Count.ToString());

                    for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                    {
                        stockIDList.Add(data.Tables[0].Rows[i][0].ToString());
                    }

                    MessageBox.Show(stockIDList.Count.ToString());
                    stockID.Items.AddRange(stockIDList.ToArray());
                    grdView_Selected_Items.Columns.Add(stockID);

                    grdView_Selected_Items.Columns.Add("Vehicle_Type", "Vehicle Type");
                    grdView_Selected_Items.Columns.Add("Registration_No", "Registration Number");
                    grdView_Selected_Items.Columns.Add("Arrival", "Arrival");
                    grdView_Selected_Items.Columns.Add("Departure", "Departure");
                    //grdView_Selected_Items.Columns.Add("Operation", "Operation");

                    DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                    column.HeaderText = "Operation";
                    column.Name = "Operation";
                    column.MaxDropDownItems = 2;
                    column.ReadOnly = true;
                    //column.DataSource = new string[] { "In", "Out" };
                    column.Items.Add("In");
                    column.Items.Add("Out");

                    grdView_Selected_Items.Columns.Add(column);

                    grdView_Selected_Items.Columns.Add("Operation_Date", "Operation Date");
                    grdView_Selected_Items.Columns.Add("Operation_Time", "Operation Time");


                    grdView_Selected_Items.Columns[0].ReadOnly = true;
                    grdView_Selected_Items.Columns[1].ReadOnly = false;//true;
                    grdView_Selected_Items.Columns[2].ReadOnly = true;
                    grdView_Selected_Items.Columns[3].ReadOnly = true;
                    grdView_Selected_Items.Columns[4].ReadOnly = true;
                    grdView_Selected_Items.Columns[5].ReadOnly = true;
                    grdView_Selected_Items.Columns[6].ReadOnly = false;
                    grdView_Selected_Items.Columns[7].ReadOnly = true;// false;
                    grdView_Selected_Items.Columns[8].ReadOnly = true;//false;
                    //               grdView_Selected_Items.Columns.Add("Request Date And Time", "Request Date And Time");

                    Prepare_Form_Elements("Available Vehicle Request Details","Selected Vehicle Request Details","Add Activity",new DBQueries().getWarehouseRequestDetails(null, null, null, null), new DBQueries().getVehicleTypeList(), new DBQueries().getVehicleArrivalList(), new DBQueries().getVehicleDepartureList(), new DBQueries().getVehicleRequestDateList(), "VehicleType", "PlaceOfArrival", "PlaceOfDepature", "RequestDate");// (new DBQueries().getVehicleDetails());
                }
                else if (operation == 8)
                {
                    this.grp_formBox.Text = "Remove Warehouse Operation Information";
                    this.Text = "Remove Warehouse Operation Details Form";
                    // this.btnNext.Text = "Remove Next";

                    grdView_Selected_Items.Columns.Add("Activity_ID", "Activity ID");
                    grdView_Selected_Items.Columns.Add("Requset_ID", "Requset ID");
                    grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");
                    grdView_Selected_Items.Columns.Add("Operation", "Operation");
                    grdView_Selected_Items.Columns.Add("Operation_Date", "Operation Date");

                    grdView_Selected_Items.Columns[0].ReadOnly = true;
                    grdView_Selected_Items.Columns[1].ReadOnly = true;
                    grdView_Selected_Items.Columns[2].ReadOnly = true;
                    grdView_Selected_Items.Columns[3].ReadOnly = true;
                    grdView_Selected_Items.Columns[4].ReadOnly = true;

                    Prepare_Form_Elements("Available Vehicle Request Details","Selected Vehicle Request Details","Remove Activity",new DBQueries().getWarehouseActivities(), new DBQueries().getVehicleTypeList(), new DBQueries().getVehicleArrivalList(), new DBQueries().getVehicleDepartureList(), new DBQueries().getVehicleRequestDateList(), "VehicleType", "PlaceOfArrival", "PlaceOfDepature", "RequestDate");
                }
//                else
//                {
//                    this.Text = "Change Warehouse Activity Form";
//                    this.grp_formBox.Text = "Change Warehouse Activity Information";
//                    //this.btnNext.Text = "Change Next";

//                    grdView_Selected_Items.Columns.Add("Activity_ID", "Activity ID");
//                    grdView_Selected_Items.Columns.Add("Vehicle", "Vehicle");
//                    grdView_Selected_Items.Columns.Add("Registration No", "Registration No");
//                    grdView_Selected_Items.Columns.Add("Stock_ID", "Stock ID");
//                    grdView_Selected_Items.Columns.Add("Operation", "Operation");
//                    grdView_Selected_Items.Columns.Add("Date", "Date");
//                    // grdView_Selected_Items.Columns.Add("Time", "Time");
//                    grdView_Selected_Items.Columns.Add("Arrival", "Arrival");
//                    grdView_Selected_Items.Columns.Add("Departure", "Departure");

//                    grdView_Selected_Items.Columns[0].ReadOnly = true;
//                    grdView_Selected_Items.Columns[1].ReadOnly = true;
//                    grdView_Selected_Items.Columns[2].ReadOnly = true;
//                    grdView_Selected_Items.Columns[3].ReadOnly = true;
//                    grdView_Selected_Items.Columns[4].ReadOnly = true;
//                    grdView_Selected_Items.Columns[5].ReadOnly = true;
//                    grdView_Selected_Items.Columns[6].ReadOnly = true;
//                    grdView_Selected_Items.Columns[7].ReadOnly = true;
//                    //grdView_Selected_Items.Columns[8].ReadOnly = true;

//                    MessageBox.Show("Please remove this");

////                    Prepare_Form_Elements(new DBQueries().getWarehouseActivities(), new DBQueries().getVehicleTypeList(), new DBQueries().getVehicleArrivalList(), new DBQueries().getVehicleDepartureList(), new DBQueries().getVehicleRequestDateList(), "VehicleType", "PlaceOfArrival", "PlaceOfDepature", "RequestDate");
//                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int selectRowCount = grdView_Selected_Items.Rows.Count;
            if (operation < 4)
            {
                if (operation == 1)
                {
                    if (validateInput(4,selectRowCount - 1,"Stock"))
                    {
                        new DBQueries().addStockInformation(grdView_Selected_Items);
                        MessageBox.Show("Stock(s) Is/Are Successfully Added To Stock", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InventoryMain.stockForm = null;
                        this.Dispose();
                    }
                }
                else if (operation == 2)
                {
                    new DBQueries().removeStockInformation(grdView_Selected_Items);
                    MessageBox.Show("Stock(s) Is/Are Successfully Removed From Stock", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventoryMain.stockForm = null;
                    this.Dispose();
                }
                else
                {
                    if (validateInput(3,selectRowCount - 1,"Stock"))
                    {
                        new DBQueries().changeStockInformation(grdView_Selected_Items);
                        MessageBox.Show("Stock Information(s) Is/Are Successfully Changed In Stock", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InventoryMain.stockForm = null;
                        this.Dispose();
                    }
                }
            }
            else if (operation == 4)
            {
                if (validateInput(5,selectRowCount - 1,"Order")){
                    string messageBody = "<img src = " + "https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL" + "></img><p>Company has been ordered following items from suppliers on " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + ".</p><table border = 1><tr><th>Order ID</th><th>Model</th><th>Brand</th><th>Amount</th></tr>";
                    new DBQueries().addOrderInformation(grdView_Selected_Items);

                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        messageBody = messageBody + "<tr><td>" + grdView_Selected_Items.Rows[i].Cells[0].Value.ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[1].Value.ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[2].Value.ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[5].Value.ToString() + "</td></tr>";
                    }

                    messageBody = messageBody + "</table>";

                    new DBConnect().sendMail("inventorymanager47@gmail.com", "supplymanager6@gmail.com", "Order Information", messageBody, "ermodmnunzxcfrnn");// "inventoryManager1234");

                    MessageBox.Show("Orders Added Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventoryMain.orderForm = null;
                    this.Dispose();
                }                
            }
            else if (operation == 5)
            {
                string messageBody = "<img src = " + "https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL" + "></img><p>Company has cancelled following orders on " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + ".</p><table border = 1><tr><th>Order ID</th><th>Company</th></tr>";
                new DBQueries().removeOrderInformation(grdView_Selected_Items);

                for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                {
                    messageBody = messageBody + "<tr><td>" + grdView_Selected_Items.Rows[i].Cells[0].Value.ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[1].Value.ToString() + "</td></tr>";
                }

                messageBody = messageBody + "</table>";

                new DBConnect().sendMail("inventorymanager47@gmail.com", "supplymanager6@gmail.com", "Order Information", messageBody, "ermodmnunzxcfrnn");//"inventoryManager1234");

                MessageBox.Show("Selected Orders Removed Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InventoryMain.orderForm = null;
                this.Dispose();
            }
            else if (operation == 6)
            {
                //                ArrayList initialOrderAmounts = null;

                int availableSelected = grdView_Available_Items.CurrentCell.RowIndex;

                if (validateInput(1, selectRowCount - 1, "Order"))
                {
                    new DBQueries().changeOrderInformation(grdView_Selected_Items, grdView_Available_Items.Rows[availableSelected].Cells[0].Value.ToString());

                    string messageBody = "<img src = " + "https://drive.google.com/uc?id=17ENlP0D997E-KsbBBDYrcaqQFiUrOUlL" + "></img><p>Company has changed the order amount for the orders given below on " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + ".</p><table border = 1><tr><th>Order ID</th><th>Model ID</th><th>Previous Amount</th><th>New Amount</th></tr>";

                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(grdView_Selected_Items.Rows[i].Cells[1].Value) != Convert.ToInt32(initialOrderAmounts[i].ToString()))
                        {
                            messageBody = messageBody + "<tr><td>" + grdView_Available_Items.Rows[availableSelected].Cells[0].Value.ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[0].Value.ToString() + "</td><td>" + initialOrderAmounts[i].ToString() + "</td><td>" + grdView_Selected_Items.Rows[i].Cells[1].Value.ToString() + "</td></tr>";
                        }
                    }

                    messageBody = messageBody + "</table>";
                    new DBConnect().sendMail("inventorymanager47@gmail.com", "supplymanager6@gmail.com", "Order Information", messageBody, "ermodmnunzxcfrnn");//"inventoryManager1234");

                    MessageBox.Show("Selected Orders Changed Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult confirmExit = MessageBox.Show("Do You Have Any Orders To Change ?", "Any Orders To Change ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmExit == DialogResult.No)
                    {
                        InventoryMain.orderForm = null;
                        this.Dispose();
                    }
                }
            }
            else if (operation == 7)
            {
                new DBQueries().addWarehhouseActivities(grdView_Selected_Items);
                MessageBox.Show("Selected Warehouse Activities Added Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InventoryMain.warehouseActivityForm = null;
                this.Dispose();
            }
            else if (operation == 8)
            {
                new DBQueries().removeWarehosuActivities(grdView_Selected_Items);
                MessageBox.Show("Selected Warehouse Activities Removed Successfully", "Operation Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InventoryMain.warehouseActivityForm = null;
                this.Dispose();
            }
            else if (operation == 9)
            {
                //new DBQueries().removeWarehosuActivities(grdView_Selected_Items);
                InventoryMain.warehouseActivityForm = null;
            }


            //InventoryMain.updateChart();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int selected = grdView_Selected_Items.CurrentCell.RowIndex;
            grdView_Selected_Items.Rows.RemoveAt(selected);
        }

        //int number = new DBQueries().generateActivityNo();
        private void addRecord()
        {

            int Selected = grdView_Available_Items.CurrentCell.RowIndex;
            int rowID = grdView_Selected_Items.Rows.Add(); // what is happening here ?
            DataGridViewRow row = grdView_Selected_Items.Rows[rowID]; // and here ?

            if (operation == 1)
            {
                row.Cells[0].Value = new DBQueries().generateStockID(grdView_Available_Items.Rows[Selected].Cells[2/*1*/].Value.ToString(), grdView_Available_Items.Rows[Selected].Cells[0].Value.ToString());
                for (int i = 1; i < grdView_Selected_Items.Columns.Count - 1; i++)
                {
                    row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i - 1].Value;
                }
            }
            if (operation == 2 || operation == 3)
            {
                for (int i = 0; i < grdView_Available_Items.Rows[Selected].Cells.Count; i++)
                {
                    row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                }
            }
            if (operation == 4)
            {
                string orderID = new DBQueries().generateOrderID(grdView_Available_Items.Rows[Selected].Cells[1].Value.ToString(), grdView_Available_Items.Rows[Selected].Cells[0].Value.ToString());
                row.Cells[0].Value = orderID;
                for (int i = 0; i < grdView_Available_Items.Rows[Selected].Cells.Count - 1; i++)
                {
                    row.Cells[i + 1].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                }
            }
            if (operation == 5 || operation == 6)
            {
                for (int i = 0; i < grdView_Available_Items.Rows[Selected].Cells.Count; i++)
                {
                    if (i < 7)
                    {
                        if (i == 4)
                        {
                            row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i + 2].Value;
                        }
                        else if (i == 6)
                        {
                            row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i + 1].Value;
                        }
                        else if (i == 5)
                        {
                            row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i - 1].Value;
                        }
                        else
                        {
                            row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                        }
                    }
                }
            }
            if (operation == 7)
            {
                int number = new DBQueries().generateActivityNo();
                for (int i = 0; i < grdView_Available_Items.Rows[Selected].Cells.Count; i++)
                {
                    row.Cells[0].Value = "ACC" + number.ToString();//.generateActivityID();
                    row.Cells[2].Value = grdView_Available_Items.Rows[Selected].Cells[1].Value;
                    row.Cells[3].Value = grdView_Available_Items.Rows[Selected].Cells[2].Value;
                    row.Cells[4].Value = grdView_Available_Items.Rows[Selected].Cells[5].Value;
                    row.Cells[5].Value = grdView_Available_Items.Rows[Selected].Cells[6].Value;
                    row.Cells[7].Value = DateTime.Now.ToString("yyyy-MM-dd");
                    row.Cells[8].Value = DateTime.Now.ToString("hh:mm:ss tt");

                    number++;
                }
            }
            if (operation == 8)
            {
                for (int i = 0; i < grdView_Available_Items.Rows[Selected].Cells.Count; i++)
                {
                    if (i < 3)
                    {
                        row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                    }
                    else if ((i > 3) && (i < 6))
                    {
                        row.Cells[i - 1].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                    }
                }
            }
            if (operation == 9)
            {
                for (int i = 0; i < grdView_Selected_Items.Rows[rowID].Cells.Count; i++)
                {
                    DataSet vehicleDetails = new DBQueries().getVehicleArrivalDepartureAndType(grdView_Available_Items.Rows[Selected].Cells[2].Value.ToString());
                    if (i != 1 && i != 6 && i != 7)
                    {
                        row.Cells[i].Value = grdView_Available_Items.Rows[Selected].Cells[i].Value;
                    }
                    else
                    {
                        if (i == 1)
                        {
                            row.Cells[i].Value = vehicleDetails.Tables[0].Rows[rowID][0].ToString();
                        }
                        else
                        {
                            row.Cells[i].Value = vehicleDetails.Tables[0].Rows[rowID][i - 5].ToString();
                        }
                    }
                }
            }
        }

        ArrayList ModelList = new ArrayList();
        ArrayList initialOrderAmounts = new ArrayList();
        bool checkValidatedOnce = false;

        private void grdView_Available_Items_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //bool Valide = false;
            int Selected = grdView_Available_Items.CurrentCell.RowIndex, rowCount = grdView_Selected_Items.Rows.Count, lastSelected = 0;

            if (operation == 1)
            {
                if (rowCount != 0)
                {
                    bool isDuplicated = false;
                    //        MessageBox.Show(ItemIDList.Count.ToString(),"ItemCount");
                    for (int i = 0; i < ModelList.Count; i++)
                    {
                        if (grdView_Available_Items.Rows[Selected].Cells[0].Value.ToString() == ModelList[i].ToString())
                        {
                            //              MessageBox.Show(grdView_Selected_Items.Rows[rowCount - 1].Cells[1].Value.ToString() + "==" + ItemIDList[i].ToString());
                            isDuplicated = true;
                            break;
                        }
                    }

                    if (isDuplicated)
                    {
                        MessageBox.Show("You Already Selected The Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (validateInput(4, (rowCount - 1), "Stock"))
                        {
                            if (!checkValidatedOnce)
                            {
                                lastSelected = Selected;
                                checkValidatedOnce = true;
                            }

                            if (Convert.ToInt32(grdView_Selected_Items.Rows[rowCount - 1].Cells[4].Value.ToString()) > Convert.ToInt32(grdView_Available_Items.Rows[lastSelected].Cells[4].Value.ToString()))
                            {
                                MessageBox.Show("Arrived Amount Is Smaller Than The Amount You Entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                addRecord();
                                ModelList.Add(grdView_Available_Items.Rows[Selected].Cells[0].Value);
                            }
                        }
                        //      MessageBox.Show(quantity.ToString() + getQuantity().ToString(),"GetQuantity");
                    }
                }
                else
                {
                    addRecord();
                    ModelList.Add(grdView_Available_Items.Rows[Selected].Cells[0].Value);
                    //        MessageBox.Show(ItemIDList.Count.ToString(), "FirstItemCount");
                }
            }
            if (operation == 2 || operation == 3)
            {
                if (rowCount != 0)
                {
                    bool isDuplicated = false;

                    for (int i = 0; i < rowCount; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[0].Value == grdView_Available_Items.Rows[Selected].Cells[0].Value)
                        {
                            isDuplicated = true;
                            break;
                        }
                    }

                    if (!isDuplicated)
                    {
                        if (grdView_Selected_Items.Rows[rowCount - 1].Cells[3].Value != null)
                        {
                            if (operation == 3 && validateInput(3, (rowCount - 1), "Selected Stock"))
                            {
                                addRecord();
                            }
                            else
                            {
                                if (operation == 2)
                                {
                                    addRecord();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter A Quantity For Selected Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Have Selected That Stock Already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addRecord();
                }
            }
            if (operation == 4)
            {
                if (rowCount != 0)
                {
                    bool isDuplicated = false;
                    for (int i = 0; i < rowCount; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[1].Value == grdView_Available_Items.Rows[Selected].Cells[0].Value)
                        {
                            isDuplicated = true;
                            break;
                        }
                    }

                    if (!isDuplicated)
                    {
                        //Valide = validateInput(5, rowCount - 1, "Selected Order");

                        if (validateInput(5, rowCount - 1, "Selected Order"))
                        {
                            addRecord();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You Already Entered The Product To The Selected Items", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addRecord();
                }
            }

            if (operation == 5 /*|| operation == 6*/)
            {
                if (rowCount != 0)
                {
                    bool isDuplicated = false;
                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[0].Value == grdView_Available_Items.Rows[Selected].Cells[0].Value)
                        {
                            if (grdView_Selected_Items.Rows[i].Cells[1].Value == grdView_Available_Items.Rows[Selected].Cells[1].Value)
                            {
                                if (grdView_Selected_Items.Rows[i].Cells[6].Value != grdView_Available_Items.Rows[Selected].Cells[7].Value) // why it is not working for ==
                                {
                                    isDuplicated = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (!isDuplicated)
                    {
                        addRecord();
                    }
                    else
                    {
                        MessageBox.Show("You Already Selected That Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addRecord();
                }
            }
            if (operation == 6)
            {
                string OrderID = grdView_Available_Items.Rows[Selected].Cells[0].Value.ToString();

                DataSet selectedOrderDetails = new DBQueries().getModelCountDetails(OrderID);
                grdView_Selected_Items.Columns.Clear();
                grdView_Selected_Items.DataSource = selectedOrderDetails.Tables[0];

                int selectedRowCount = grdView_Selected_Items.Rows.Count;

                for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                {
                    initialOrderAmounts.Add(grdView_Selected_Items.Rows[i].Cells[1].Value.ToString());
                }
            }
            if (operation == 7)
            {
                bool isDuplicated = false;
                string errorMessage = null;
                int count = 0;
                if (rowCount != 0)
                {
                    //      MessageBox.Show(grdView_Selected_Items.Rows.Count.ToString(), "rowCount");
                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[3].Value != grdView_Available_Items.Rows[Selected].Cells[2].Value)
                        { // why this is not working for ==

                            //             MessageBox.Show(grdView_Selected_Items.Rows[i].Cells[3].Value.ToString() + "==" + grdView_Available_Items.Rows[Selected].Cells[2].Value.ToString(),"",MessageBoxButtons.OK);
                            isDuplicated = true;
                            count++;
                            break;
                        }
                    }

                    // MessageBox.Show(isDuplicated.ToString(), "Duplicated");
                    if (!isDuplicated)
                    {
                        if (grdView_Selected_Items.Rows[rowCount - 1].Cells[1].Value == null)
                        {
                            errorMessage = errorMessage + "Stock ID,";
                            count++;

                        }

                        if (grdView_Selected_Items.Rows[rowCount - 1].Cells[6].Value == null)
                        {
                            errorMessage = errorMessage + "Operation,";
                            count++;
                        }
                        else
                        {
                            errorMessage = null;
                        }

                        /*if (grdView_Selected_Items.Rows[rowCount - 1].Cells[7].Value == null)
                        {
                            if (grdView_Selected_Items.Rows[rowCount - 1].Cells[8].Value == null)
                            {
                                errorMessage = errorMessage + "Arrival And Departure Locations,";
                                count++;
                            }
                            else
                            {
                                errorMessage = errorMessage + "Departure Location,";
                                count++;
                            }
                            MessageBox.Show(errorMessage);
                        }
                        else
                        {
                            if (grdView_Selected_Items.Rows[rowCount - 1].Cells[8].Value == null)
                            {
                                errorMessage = errorMessage + "Arrival Location,";
                                count++;
                            }
                            else
                            {
                                errorMessage = null;
                            }
                            MessageBox.Show(errorMessage);
                        }*/
                    }
                    else
                    {
                        errorMessage = "You Have Already Selected The Vehicle.";
                    }

                    if (errorMessage == null)
                    {
                        addRecord();
                    }
                    else
                    {
                        if (isDuplicated)
                        {
                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show(errorMessage.Substring(0, errorMessage.Count() - 1) + " Are Empty For Last Selected Vehicle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(errorMessage.Substring(0, errorMessage.Count() - 1) + " Is Empty For Last Selected Vehicle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    addRecord();
                }
            }
            if (operation == 8)
            {
                bool isDuplicated = false;
                if (rowCount != 0)
                {
                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[0].Value == grdView_Available_Items.Rows[Selected].Cells[0].Value)
                        {
                            isDuplicated = true;
                        }
                    }

                    if (!isDuplicated)
                    {
                        addRecord();
                    }
                    else
                    {
                        MessageBox.Show("You Have Already Selected That Warehouse Activity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addRecord();
                }
            }
            if (operation == 9)
            {
                if (rowCount != 0)
                {

                }
                else
                {
                    addRecord();
                }
            }
        }

        private void datagridOneCellClickView()
        {
            grdView_Selected_Items.BeginEdit(true);
            ComboBox combo = (ComboBox)grdView_Selected_Items.EditingControl;
            combo.DroppedDown = true;
        }

        private void grdView_Selected_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = grdView_Selected_Items.CurrentCell.RowIndex;

            if (operation == 4)
            {
                if (e.RowIndex >= 0 & e.ColumnIndex == 7)
                {
                    datagridOneCellClickView();
                }
            }
            else if (operation == 7)
            {
                if (e.RowIndex >= 0 & (e.ColumnIndex == 1 || e.ColumnIndex == 6))
                {
                    datagridOneCellClickView();
                }
            }
        }

        private void grdView_Selected_Items_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (operation == 4)
            {
                int selected = grdView_Available_Items.CurrentCell.RowIndex;

                if (e.ColumnIndex == 7)
                {
                    if (e.Value != null)
                    {
                        if (e.Value.ToString() == "Set")
                        {
                            e.Value = "Set";
                        }
                        else
                        {
                            e.Value = "Don't Set";
                        }
                    }
                    else
                    {
                        e.Value = "Don't Set";
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (e.Value == null)
                    {
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[6].Value = 0;
                    }
                }
            }
        }

        private void grdView_Selected_Items_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (operation == 4)
            {
                int selected = grdView_Selected_Items.CurrentCell.RowIndex;

                if (grdView_Selected_Items.Rows[selected].Cells[7].Value == null)
                {
                    grdView_Selected_Items.Rows[selected].Cells[7].Value = "Don't Set";
                    grdView_Selected_Items.CommitEdit(DataGridViewDataErrorContexts.Commit); //meaning of this ?
                }
                else
                {
                    grdView_Selected_Items.CommitEdit(DataGridViewDataErrorContexts.Commit); //meaning of this ?
                }

                if (grdView_Selected_Items.Rows[selected].Cells[7].Value.ToString() == "Set")
                {
                    grdView_Selected_Items.Columns[8].Visible = true;
                    grdView_Selected_Items.Columns[9].Visible = true;
                    grdView_Selected_Items.Rows[selected].Cells[8].ReadOnly = false;
                    grdView_Selected_Items.Rows[selected].Cells[9].ReadOnly = false;


                    if (grdView_Selected_Items.Rows[selected].Cells[8].Value == null)
                    {
                        grdView_Selected_Items.Rows[selected].Cells[8].Value = "Not Set";
                    }


                    if (grdView_Selected_Items.Rows[selected].Cells[9].Value == null)
                    {
                        grdView_Selected_Items.Rows[selected].Cells[9].Value = "Not Set";
                    }
                }
                else
                {
                    bool settedAutomaticReorder = false;
                    for (int i = 0; i < grdView_Selected_Items.Rows.Count; i++)
                    {
                        if (grdView_Selected_Items.Rows[i].Cells[7].Value != null)
                        {
                            if (grdView_Selected_Items.Rows[i].Cells[7].Value.ToString() == "Set")
                            {
                                settedAutomaticReorder = true;
                                break;
                            }
                            else
                            {
                                settedAutomaticReorder = false;
                            }
                        }
                    }
                    if (!settedAutomaticReorder)
                    {
                        grdView_Selected_Items.Columns[8].Visible = false;
                        grdView_Selected_Items.Columns[9].Visible = false;
                        grdView_Selected_Items.Rows[selected].Cells[8].Value = "Not Set";
                        grdView_Selected_Items.Rows[selected].Cells[9].Value = "Not Set";
                    }
                }
            }
        }

        private void grdView_Selected_Items_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (operation == 4)
            {
                if (e.ColumnIndex == 7)
                {
                    if (grdView_Selected_Items.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Don't Set")
                    {
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[8].ReadOnly = true;
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[9].ReadOnly = true;
                    }
                    else
                    {
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[8].ReadOnly = false;
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[9].ReadOnly = false;
                    }
                }
            }
        }

        private bool validateInput(int columnIndex, int rowIndex, string errorMessageParameter)
        {
            string errorMessage = null;

            if (grdView_Selected_Items.Rows[rowIndex].Cells[columnIndex].Value == null)
            {
                errorMessage = "Please Enter A Quantity For Lastly Selected " + errorMessageParameter;
            }
            else
            {
                if (!validateNumbers(grdView_Selected_Items.Rows[rowIndex].Cells[columnIndex].Value.ToString()))
                {
                    if (Regex.IsMatch(grdView_Selected_Items.Rows[rowIndex].Cells[columnIndex].Value.ToString(), @"^\-\d+$"))
                    {
                        errorMessage = "Please Enter A Positive Number For Lastly Selected " + errorMessageParameter;
                    }
                    else
                    {
                        errorMessage = "Please Enter A Number For Lastly Selected " + errorMessageParameter;
                    }
                }
            }

            if (errorMessage != null)
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void grdView_Selected_Items_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bool isValid = false;
            int Available_Table_Selected = grdView_Available_Items.CurrentCell.RowIndex;
            if (operation == 4)
            {
                if ((grdView_Selected_Items.Rows[e.RowIndex].Cells[5].Value != null))
                {
                    isValid = validateNumbers((grdView_Selected_Items.Rows[e.RowIndex].Cells[5].Value.ToString()));
                    if (isValid)
                    {
                        int quantity = Convert.ToInt32(grdView_Selected_Items.Rows[e.RowIndex].Cells[5].Value);
                        double price = 0;

                        for (int i = 0; i < grdView_Available_Items.Rows.Count; i++)
                        {
                            if (grdView_Available_Items.Rows[i].Cells[0].Value == grdView_Selected_Items.Rows[grdView_Selected_Items.Rows.Count - 1].Cells[1].Value)
                            {
                                price = Convert.ToDouble(grdView_Available_Items.Rows[i].Cells[4].Value);
                            }
                        }
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[6].Value = price * quantity;
                    }
                    else
                    {
                        grdView_Selected_Items.Rows[e.RowIndex].Cells[6].Value = "Error";
                    }
                }
            }

            if (operation == 6)
            {
                if (grdView_Selected_Items.Rows[grdView_Selected_Items.CurrentCell.RowIndex].Cells[/*5*/1].Value == null)
                {
                    MessageBox.Show("Please Enter A Quantity For Selected Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Stock_Operation_Details_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (operation < 4) {
            InventoryMain.stockForm = null;
            //}
            //else if (operation < 7) {
            InventoryMain.orderForm = null;
            //}
            //else if (operation < 10) {
            InventoryMain.warehouseActivityForm = null;
            //}
        }

        private void chkBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBrand.Checked)
            {
                if (operation == 5)
                {
                    chkCategory.Enabled = false;
                    chkDealer.Enabled = false;
                    chkType.Enabled = false;
                }
                cmbBrand.Enabled = true;

            }
            else
            {
                if (operation == 5)
                {
                    chkCategory.Enabled = true;
                    chkDealer.Enabled = true;
                    chkType.Enabled = true;
                }
                cmbBrand.Text = "Tick And Select";
                cmbBrand.Enabled = false;
            }
        }

        private void chkDealer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDealer.Checked)
            {
                if (operation == 5)
                {
                    //cmbBrand.Enabled = false;
                    chkBrand.Enabled = false;
                    chkCategory.Enabled = false;
                    chkType.Enabled = false;
                    chkBrand.Checked = false;
                    chkCategory.Checked = false;
                    chkType.Checked = false;
                }
                cmbDealer.Enabled = true;
            }
            else
            {
                if (operation == 5)
                {
                    //         cmbBrand.Enabled = true;
                    chkBrand.Enabled = true;
                    chkCategory.Enabled = true;
                    chkType.Enabled = true;
                }
                cmbDealer.Text = "Tick And Select";
                cmbDealer.Enabled = false;
            }
        }

        private void checkTypeOrCategory(CheckBox checkbox1, CheckBox checkbox2, ComboBox cmbCheckBox1)
        {
            if (checkbox1.Checked)
            {
                if (operation == 5)
                {
                    //      cmbBrand.Enabled = false;
                    chkBrand.Enabled = false;
                    chkDealer.Enabled = false;
                    chkBrand.Checked = false;
                    chkDealer.Checked = false;
                }
                cmbCheckBox1.Enabled = true;
            }
            else
            {
                if (operation == 5)
                {
                    if (!checkbox2.Checked)
                    {
                        chkBrand.Enabled = true;
                        chkDealer.Enabled = true;
                    }
                    else
                    {
                        chkBrand.Enabled = false;
                        chkDealer.Enabled = false;
                    }
                }
                cmbCheckBox1.Text = "Tick And Select";
                cmbCheckBox1.Enabled = false;
            }
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            checkTypeOrCategory(chkType, chkCategory, cmbType);
        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            checkTypeOrCategory(chkCategory, chkType, cmbCategory);
        }

        private void checkFilterParameters(CheckBox checkbox1, ComboBox combobox1, string pchkCode, string perrorMessage)
        {
            if (checkbox1.Checked && combobox1.Text == "Tick And Select")
            {
                chkCode = chkCode + pchkCode;
                errorMessage = errorMessage + perrorMessage + ",";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataSet itemResults = null;
            chkCode = null;
            errorMessage = null;
            if (operation < 7)
            {
                checkFilterParameters(chkBrand, cmbBrand, "B", "Brand");
                checkFilterParameters(chkDealer, cmbDealer, "D", "Dealer");
                checkFilterParameters(chkType, cmbType, "T", "Type");
                checkFilterParameters(chkCategory, cmbCategory, "C", "Category");
            }
            else
            {
                checkFilterParameters(chkBrand, cmbBrand, "V", "Vehicle Type");
                checkFilterParameters(chkDealer, cmbDealer, "A", "Arrival");
                checkFilterParameters(chkType, cmbType, "D", "Departure");
                checkFilterParameters(chkCategory, cmbCategory, "R", "Request Date");
            }

            if (chkCode != null)
            {
                if (chkCode.Length == 1)
                {
                    MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (chkCode.Length > 1)
                {
                    MessageBox.Show(errorMessage.Substring(0, errorMessage.Length - 1) + " Are Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                string brand = null, dealer = null, category = null, type = null;

                if (cmbBrand.Text != "Tick And Select")
                {
                    brand = cmbBrand.Text;
                }
                else
                {
                    brand = null;
                }

                if (cmbDealer.Text != "Tick And Select")
                {
                    dealer = cmbDealer.Text;
                }
                else
                {
                    dealer = null;
                }

                if (cmbCategory.Text != "Tick And Select")
                {
                    category = cmbCategory.Text;
                }
                else
                {
                    category = null;
                }

                if (cmbType.Text != "Tick And Select")
                {
                    type = cmbType.Text;
                }
                else
                {
                    type = null;
                }

                if (operation == 1)
                {
                    itemResults = new DBQueries().getArrivedStockDetails(brand, dealer, type, category, null, null, 0, "0");//(brand, dealer, category, type);
                }
                if (operation == 2 || operation == 3)
                {
                    itemResults = new DBQueries().getStockDetails(brand, dealer, type, category);//(brand, dealer, type, category);
                }
                if (operation == 4)
                {
                    itemResults = new DBQueries().getAvailableOrderItemDetails(brand, dealer, type, category);//(brand, dealer, category, type);
                }
                if (operation == 5 || operation == 6)
                {
                    itemResults = new DBQueries().getOrderDetails(brand, dealer, type, category);//(brand,dealer,category,type);
                }
                if (operation == 7)
                {
                    itemResults = new DBQueries().getWarehouseRequestDetails(brand, dealer, type, category);//(brand, dealer, category, type);
                }

                if (itemResults != null)
                {
                    grdView_Available_Items.DataSource = itemResults.Tables[0];
                }
            }


            //itemResults.Dispose();
        }        

        private void validateNumbersTest(string input) {
            if (Regex.IsMatch(input, @"[a-z]"))
            {
                MessageBox.Show("Please Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (Convert.ToInt32(input) < 1) {
                    MessageBox.Show("Please Enter A Valid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
