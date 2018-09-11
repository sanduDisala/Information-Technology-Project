using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Main.Modules.Inventory
{
    public partial class InventoryMain : Form
    {
        public InventoryMain()
        {
            InitializeComponent();
        }

        public static string type = null;
        public static Stock_Operation_Details_Form stockForm = null, orderForm = null, warehouseActivityForm = null;
        private DataSet tableData = null, chartData = null;

        private void generateChart(Chart chartName, string seriesName, DataSet dataSource, string xValueMember, ChartValueType xValueType, string yValueMember, ChartValueType yValueType)
        {
            chartName.DataSource = dataSource.Tables[0];
            chartName.Series[seriesName].XValueMember = xValueMember;
            chartName.Series[seriesName].XValueType = xValueType;
            chartName.Series[seriesName].YValueMembers = yValueMember;
            chartName.Series[seriesName].YValueType = yValueType;
        }

        private void generateSubMain(Image image1, Image image2, Image image3, Image image4, string labelParameter)
        {
            this.grpOperation.Visible = true;
            this.chartViewer.Visible = true;
            this.grpMain.Visible = false;

            this.grpOperation.BackColor = pnlDashBoard.BackColor;
            this.picbtnAdd.BackColor = Color.Transparent;
            this.picbtnRemove.BackColor = Color.Transparent;
            this.picbtnView.BackColor = Color.Transparent;

            this.lblAdd.BackColor = Color.Transparent;
            this.lblRemove.BackColor = Color.Transparent;
            this.lblView.BackColor = Color.Transparent;

            this.lblAdd.Text = "Add " + labelParameter + " Details";
            this.lblRemove.Text = "Remove " + labelParameter + " Details";
            this.lblView.Text = "View " + labelParameter + " Details In Table View";

            if (type != "warehouse")
            {
                this.picbtnChange.Visible = true;
                this.lblChange.Visible = true;
                this.picbtnChange.BackColor = Color.Transparent;
                this.lblChange.BackColor = Color.Transparent;
                this.lblChange.Text = "Change " + labelParameter + " Details";
                this.picbtnRemove.Location = new Point(320, 25);
                this.lblRemove.Location = new Point(308, 158);
            }
            else {
                this.picbtnChange.Visible = false;
                this.lblChange.Visible = false;
                this.picbtnRemove.Location = new Point(450, 25);
                this.lblRemove.Location = new Point(438, 158);
            }
            addButtons(image1, image2, image3, image4);
        }

        private void addButtons(Image image1, Image image2, Image image3, Image image4)
        {
            this.picbtnAdd.BackgroundImage = image1;
            this.picbtnChange.BackgroundImage = image2;
            this.picbtnRemove.BackgroundImage = image3;
            this.picbtnView.BackgroundImage = image4;
        }

        private void changeButtonImage(PictureBox buttton, Image stockImage, Image orderImage, Image warehouseActivityImage)
        {
            buttton.Image = null;
            if (type == "stock")
            {
                buttton.BackgroundImage = stockImage;
            }
            else if (type == "order")
            {
                buttton.BackgroundImage = orderImage;
            }
            else if (type == "warehouse")
            {
                buttton.BackgroundImage = warehouseActivityImage;
            }
        }

        GroupBox grpAlert = null;
        private void generateOverviewSubMain()
        {

            this.grpMain.Visible = true;
            this.grpOperation.Visible = false;
            this.grdTableViewer.Visible = false;
            this.chartViewer.Visible = false;
            this.grpMain.BackColor = Color.Transparent;
            this.grpMain.Text = "Overview";

            DataSet reorderDetails = new DBQueries().getOrderAlertStockDetails();

            
            //////////////////////////////////////////////////////////
            //reorderDetails = new DBQueries().getOrderAlertOrderDetails(reorderDetails);
            /////////////////////////////////////////////////////////

            
            // = new GroupBox();

            if (grpAlert == null)
            {
                grpAlert = new GroupBox();
            }
            else {
                grpAlert.Dispose();
                grpAlert = new GroupBox();
            }

            Label[] alerLabelArray = new Label[reorderDetails.Tables[0].Rows.Count];
            Button[] buttonArray = new Button[reorderDetails.Tables[0].Rows.Count];

            const int X = 10;
            int y = 30;

            grpMain.Controls.Add(grpAlert);
            grpAlert.Text = "Alerts";
           // grpNoAlert.Text = "Alerts";
            grpAlert.Location = new Point(20, 20);
            grpAlert.Width = 1050;
            grpAlert.Anchor = AnchorStyles.Top & AnchorStyles.Left & AnchorStyles.Right;

            Label alertLabel = new Label();
            
            if (reorderDetails.Tables[0].Rows.Count != 0)// && reorderDetails != null)
            {
                grpAlert.Controls.Clear();
                grpAlert.Height = 200;
                alertLabel.Visible = false;

                for (int i = 0; i < reorderDetails.Tables[0].Rows.Count; i++)
                {
                    alerLabelArray[i] = new Label();
                    buttonArray[i] = new Button();

                    alerLabelArray[i].Width = 600;
                    buttonArray[i].Width = 100;
                    buttonArray[i].Height = 50;

                    //alerLabelArray[i].BackColor = Color.Red;
                    buttonArray[i].FlatStyle = FlatStyle.Flat;
                    buttonArray[i].BackColor = Color.FromArgb(255, 0, 0);
                    buttonArray[i].ForeColor = Color.White;
                    buttonArray[i].FlatAppearance.BorderSize = 0;

                    alerLabelArray[i].Text = " Amount Of Item Model " + reorderDetails.Tables[0].Rows[i][0].ToString() + " Is Below The Threshold Value.Do You Want To Reorder ?";
                    buttonArray[i].Text = "Order Now";
                    buttonArray[i].Name = reorderDetails.Tables[0].Rows[i][0].ToString();

                    alerLabelArray[i].Location = new Point(X, y + 15);
                    buttonArray[i].Location = new Point(X + alerLabelArray[i].Width + 20, y);
                    buttonArray[i].Click += new EventHandler(OrderButton_Click);

                    alerLabelArray[i].Visible = true;
                    grpAlert.Controls.Add(alerLabelArray[i]);
                    grpAlert.Controls.Add(buttonArray[i]);
                    y += 70;
                }
            }
            else
            {
                alertLabel.Visible = true;
                alertLabel.Width = 150;
                alertLabel.Text = "No Alerts To Show";
                alertLabel.Location = new Point(20, 20);
                grpAlert.Controls.Add(alertLabel);
                grpAlert.Height = 50;
            }            
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Button receiver = (Button)sender;
            MessageBox.Show(receiver.Name, "OrderButtonName");
            Stock_Operation_Details_Form form = new Stock_Operation_Details_Form();
            form.operation = 4;
            form.Show();
        }

        private void checkActiveForms()
        {
            if (type == "stock")
            {
                if (stockForm == null)
                {
                    stockForm = new Stock_Operation_Details_Form();
                }
                else
                {
                    MessageBox.Show("You Have Already Opened A Stock Form");
                }
            }

            if (type == "order")
            {
                if (orderForm == null)
                {
                    orderForm = new Stock_Operation_Details_Form();
                }
                else
                {
                    MessageBox.Show("You Have Already Opened A Order Form");
                }
            }

            if (type == "warehouse")
            {
                if (warehouseActivityForm == null)
                {
                    warehouseActivityForm = new Stock_Operation_Details_Form();
                }
                else
                {
                    MessageBox.Show("You Have Already Opened A Stock Form");
                }
            }
        }

        private void showForms(PictureBox pictureBox, Image stockImage, Image orderImage, Image warehouseImage, int stockOperation, int orderOperation, int warehouseOperation)
        {
            changeButtonImage(pictureBox, stockImage, orderImage, warehouseImage);//(picbtnAdd, Main.Properties.Resources.StockPlusIcon_click, Main.Properties.Resources.order_add_click, Main.Properties.Resources.Add_Warehouse_Activity_click);
            checkActiveForms();

            if (type == "stock")
            {
                stockForm.operation = stockOperation;//1;
                stockForm.Show();
            }
            else if (type == "order")
            {
                orderForm.operation = orderOperation;//4;
                orderForm.Show();
            }
            else if (type == "warehouse")
            {
                if (warehouseOperation != 9)
                {
                    warehouseActivityForm.operation = warehouseOperation;//7;
                    warehouseActivityForm.Show();
                }
                else {
                    warehouseActivityForm.Dispose();
                    warehouseActivityForm = null;
                }

            }
        }

        private void InventoryMainTest_Load(object sender, EventArgs e)
        {
            generateOverviewSubMain();
            pnlDashBoard.BackColor = Color.FromArgb(128, 255, 255, 255);
            pnlBody.BackColor = Color.FromArgb(128, 255, 255, 255);
        }

        private void btnWareHouseActivites_Click(object sender, EventArgs e)
        {
            type = "warehouse";
            chartData = new DBQueries().getWarehouseChartData();
            chartViewer.Series["Series1"].ChartType = SeriesChartType.Column;
            generateChart(chartViewer, "Series1", chartData, "Operation_Date", ChartValueType.Date, "Amount", ChartValueType.Int32);
            generateSubMain(Main.Properties.Resources.Add_Warehouse_Activity_Button, Main.Properties.Resources.Change_Warehouse_Activity, Main.Properties.Resources.Remove_Warehouse_Activity, Main.Properties.Resources.View_Warehouse_Activity, "Warehouse");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            type = "stock";
            chartData = new DBQueries().getStockChartData();
            chartViewer.Series["Series1"].ChartType = SeriesChartType.Column;
            generateChart(chartViewer, "Series1", chartData, "Type", ChartValueType.String, "Amount", ChartValueType.Int32);
            generateSubMain(Main.Properties.Resources.StockPlusIcon, Main.Properties.Resources.StockChangeIcon, Main.Properties.Resources.StockMinusIcon, Main.Properties.Resources.viewstock, "Stock");
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            generateOverviewSubMain();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            type = "order";
            chartData = new DBQueries().getOrderChartData();
            chartViewer.Series["Series1"].ChartType = SeriesChartType.Line;
            generateChart(chartViewer, "Series1", chartData, "Ordered Date", ChartValueType.Date, "Amount", ChartValueType.Int32);
            generateSubMain(Main.Properties.Resources.order_add, Main.Properties.Resources.order_change, Main.Properties.Resources.order_remove, Main.Properties.Resources.order_view, "Order");
        }

        private void picbtnAdd_MouseEnter(object sender, EventArgs e)
        {
            changeButtonImage(picbtnAdd, Main.Properties.Resources.StockPlusIcon_active, Main.Properties.Resources.order_add_active, Main.Properties.Resources.Add_Warehouse_Activity_active);
        }

        private void picbtnAdd_MouseLeave(object sender, EventArgs e)
        {
            changeButtonImage(picbtnAdd, Main.Properties.Resources.StockPlusIcon, Main.Properties.Resources.order_add, Main.Properties.Resources.Add_Warehouse_Activity_Button);
        }

        private void picbtnAdd_Click(object sender, EventArgs e)
        {
            showForms(picbtnAdd, Main.Properties.Resources.StockPlusIcon_click, Main.Properties.Resources.order_add_click, Main.Properties.Resources.Add_Warehouse_Activity_click, 1, 4, 7);
        }

        private void picbtnRemove_MouseEnter(object sender, EventArgs e)
        {
            changeButtonImage(picbtnRemove, Main.Properties.Resources.StockMinusIcon_active, Main.Properties.Resources.order_remove_active, Main.Properties.Resources.Remove_Warehouse_Activity_active);
        }

        private void picbtnRemove_MouseLeave(object sender, EventArgs e)
        {
            changeButtonImage(picbtnRemove, Main.Properties.Resources.StockMinusIcon, Main.Properties.Resources.order_remove, Main.Properties.Resources.Remove_Warehouse_Activity);
        }

        private void picbtnRemove_Click(object sender, EventArgs e)
        {
            showForms(picbtnRemove, Main.Properties.Resources.StockMinusIcon_click, Main.Properties.Resources.order_remove_click, Main.Properties.Resources.Remove_Warehouse_Activity_click, 2, 5, 8);
        }

        private void picbtnChange_MouseEnter(object sender, EventArgs e)
        {
            changeButtonImage(picbtnChange, Main.Properties.Resources.StockChangeIcon_active, Main.Properties.Resources.order_change_active, Main.Properties.Resources.Change_Warehouse_Activity_active);
        }

        private void picbtnChange_MouseLeave(object sender, EventArgs e)
        {
            changeButtonImage(picbtnChange, Main.Properties.Resources.StockChangeIcon, Main.Properties.Resources.order_change, Main.Properties.Resources.Change_Warehouse_Activity);
        }

        private void picbtnChange_Click(object sender, EventArgs e)
        {
            showForms(picbtnChange, Main.Properties.Resources.StockChangeIcon_click, Main.Properties.Resources.order_change_click, Main.Properties.Resources.Change_Warehouse_Activity_click, 3, 6, 9);
        }

        private void picbtnView_MouseEnter(object sender, EventArgs e)
        {
            changeButtonImage(picbtnView, Main.Properties.Resources.viewstock_active, Main.Properties.Resources.order_view_active, Main.Properties.Resources.View_Warehouse_Activity_active);
        }

        private void picbtnView_MouseLeave(object sender, EventArgs e)
        {
            changeButtonImage(picbtnView, Main.Properties.Resources.viewstock, Main.Properties.Resources.order_view, Main.Properties.Resources.View_Warehouse_Activity);
        }

        private void picbtnView_Click(object sender, EventArgs e)
        {
            changeButtonImage(picbtnView, Main.Properties.Resources.viewstock_click, Main.Properties.Resources.order_view_click, Main.Properties.Resources.View_Warehouse_Activity_click);


            if (type == "stock")
            {
                tableData = new DBQueries().getStockDetails(null, null, null, null);
            }
            else if (type == "order")
            {
                tableData = new DBQueries().getOrderDetails(null, null, null, null);
            }
            else
            {
                tableData = new DBQueries().getWarehouseActivities();
                //tableData = new DBQueries().getWarehouseRequestDetails(null, null, null, null);
            }


            grdTableViewer.DataSource = tableData.Tables[0];
            if (chartViewer.Visible)
            {
                grdTableViewer.Visible = true;
                chartViewer.Visible = false;
            }
            else
            {
                grdTableViewer.Visible = false;
                chartViewer.Visible = true;
            }
        }

        private void InventoryMain_Activated(object sender, EventArgs e)
        {
            if (type == "stock") {
                chartData = new DBQueries().getStockChartData();
                generateChart(chartViewer, "Series1", chartData, "Type", ChartValueType.String, "Amount", ChartValueType.Int32);
            }
            else if (type == "order") {
                chartData = new DBQueries().getOrderChartData();
                generateChart(chartViewer, "Series1", chartData, "Ordered Date", ChartValueType.Date, "Amount", ChartValueType.Int32);
            }
            else if (type == "warehouse")
            {
                chartData = new DBQueries().getWarehouseChartData();
                generateChart(chartViewer, "Series1", chartData, "Operation_Date", ChartValueType.Date, "Amount", ChartValueType.Int32);
            }
                /////////////////////////////////
            //else {
            //    generateOverviewSubMain();
            //}
            ////////////////////////////////////////////
        }
    }
}
