namespace Main.Modules.Inventory
{
    partial class InventoryMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWareHouseActivites = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.chartViewer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.grdTableViewer = new System.Windows.Forms.DataGridView();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.picbtnReport = new System.Windows.Forms.PictureBox();
            this.picbtnView = new System.Windows.Forms.PictureBox();
            this.lblView = new System.Windows.Forms.Label();
            this.picbtnChange = new System.Windows.Forms.PictureBox();
            this.picbtnRemove = new System.Windows.Forms.PictureBox();
            this.picbtnAdd = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.pnlDashBoard.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableViewer)).BeginInit();
            this.grpOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDashBoard.Controls.Add(this.button1);
            this.pnlDashBoard.Controls.Add(this.label1);
            this.pnlDashBoard.Controls.Add(this.btnWareHouseActivites);
            this.pnlDashBoard.Controls.Add(this.btnOrders);
            this.pnlDashBoard.Controls.Add(this.btnStock);
            this.pnlDashBoard.Controls.Add(this.btnOverview);
            this.pnlDashBoard.Location = new System.Drawing.Point(11, 13);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(200, 655);
            this.pnlDashBoard.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-443, -55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Warehouse Details";
            // 
            // btnWareHouseActivites
            // 
            this.btnWareHouseActivites.Location = new System.Drawing.Point(37, 160);
            this.btnWareHouseActivites.Name = "btnWareHouseActivites";
            this.btnWareHouseActivites.Size = new System.Drawing.Size(109, 39);
            this.btnWareHouseActivites.TabIndex = 6;
            this.btnWareHouseActivites.Text = "Warehouse Activities";
            this.btnWareHouseActivites.UseVisualStyleBackColor = true;
            this.btnWareHouseActivites.Click += new System.EventHandler(this.btnWareHouseActivites_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(37, 114);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(110, 40);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(37, 68);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(110, 40);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(37, 22);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(110, 40);
            this.btnOverview.TabIndex = 4;
            this.btnOverview.Text = "Overview";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Controls.Add(this.chartViewer);
            this.pnlBody.Controls.Add(this.grpMain);
            this.pnlBody.Controls.Add(this.grdTableViewer);
            this.pnlBody.Location = new System.Drawing.Point(228, 13);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1091, 655);
            this.pnlBody.TabIndex = 12;
            // 
            // chartViewer
            // 
            this.chartViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartViewer.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartViewer.Legends.Add(legend1);
            this.chartViewer.Location = new System.Drawing.Point(12, 8);
            this.chartViewer.Name = "chartViewer";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartViewer.Series.Add(series1);
            this.chartViewer.Size = new System.Drawing.Size(1069, 417);
            this.chartViewer.TabIndex = 0;
            this.chartViewer.Text = "chart1";
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(17, 18);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(1060, 620);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "groupBox1";
            // 
            // grdTableViewer
            // 
            this.grdTableViewer.AllowUserToAddRows = false;
            this.grdTableViewer.AllowUserToDeleteRows = false;
            this.grdTableViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTableViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTableViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTableViewer.Location = new System.Drawing.Point(12, 8);
            this.grdTableViewer.Name = "grdTableViewer";
            this.grdTableViewer.ReadOnly = true;
            this.grdTableViewer.Size = new System.Drawing.Size(1069, 417);
            this.grdTableViewer.TabIndex = 2;
            // 
            // grpOperation
            // 
            this.grpOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOperation.Controls.Add(this.lblReport);
            this.grpOperation.Controls.Add(this.picbtnReport);
            this.grpOperation.Controls.Add(this.picbtnView);
            this.grpOperation.Controls.Add(this.lblView);
            this.grpOperation.Controls.Add(this.picbtnChange);
            this.grpOperation.Controls.Add(this.picbtnRemove);
            this.grpOperation.Controls.Add(this.picbtnAdd);
            this.grpOperation.Controls.Add(this.lblAdd);
            this.grpOperation.Controls.Add(this.lblRemove);
            this.grpOperation.Controls.Add(this.lblChange);
            this.grpOperation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperation.Location = new System.Drawing.Point(238, 444);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(1071, 215);
            this.grpOperation.TabIndex = 8;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operations";
            // 
            // picbtnReport
            // 
            this.picbtnReport.Location = new System.Drawing.Point(912, 25);
            this.picbtnReport.Name = "picbtnReport";
            this.picbtnReport.Size = new System.Drawing.Size(150, 130);
            this.picbtnReport.TabIndex = 8;
            this.picbtnReport.TabStop = false;
            // 
            // picbtnView
            // 
            this.picbtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picbtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbtnView.Location = new System.Drawing.Point(703, 25);
            this.picbtnView.Name = "picbtnView";
            this.picbtnView.Size = new System.Drawing.Size(150, 130);
            this.picbtnView.TabIndex = 3;
            this.picbtnView.TabStop = false;
            this.picbtnView.Click += new System.EventHandler(this.picbtnView_Click);
            this.picbtnView.MouseEnter += new System.EventHandler(this.picbtnView_MouseEnter);
            this.picbtnView.MouseLeave += new System.EventHandler(this.picbtnView_MouseLeave);
            // 
            // lblView
            // 
            this.lblView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblView.Location = new System.Drawing.Point(689, 154);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(178, 46);
            this.lblView.TabIndex = 7;
            this.lblView.Text = "View Warehouse Activities In Tabular View";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // picbtnChange
            // 
            this.picbtnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picbtnChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbtnChange.Location = new System.Drawing.Point(475, 25);
            this.picbtnChange.Name = "picbtnChange";
            this.picbtnChange.Size = new System.Drawing.Size(150, 130);
            this.picbtnChange.TabIndex = 2;
            this.picbtnChange.TabStop = false;
            this.picbtnChange.Click += new System.EventHandler(this.picbtnChange_Click);
            this.picbtnChange.MouseEnter += new System.EventHandler(this.picbtnChange_MouseEnter);
            this.picbtnChange.MouseLeave += new System.EventHandler(this.picbtnChange_MouseLeave);
            // 
            // picbtnRemove
            // 
            this.picbtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbtnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbtnRemove.Location = new System.Drawing.Point(241, 25);
            this.picbtnRemove.Name = "picbtnRemove";
            this.picbtnRemove.Size = new System.Drawing.Size(150, 130);
            this.picbtnRemove.TabIndex = 1;
            this.picbtnRemove.TabStop = false;
            this.picbtnRemove.Click += new System.EventHandler(this.picbtnRemove_Click);
            this.picbtnRemove.MouseEnter += new System.EventHandler(this.picbtnRemove_MouseEnter);
            this.picbtnRemove.MouseLeave += new System.EventHandler(this.picbtnRemove_MouseLeave);
            // 
            // picbtnAdd
            // 
            this.picbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbtnAdd.Location = new System.Drawing.Point(17, 25);
            this.picbtnAdd.Name = "picbtnAdd";
            this.picbtnAdd.Size = new System.Drawing.Size(150, 130);
            this.picbtnAdd.TabIndex = 0;
            this.picbtnAdd.TabStop = false;
            this.picbtnAdd.Click += new System.EventHandler(this.picbtnAdd_Click);
            this.picbtnAdd.MouseEnter += new System.EventHandler(this.picbtnAdd_MouseEnter);
            this.picbtnAdd.MouseLeave += new System.EventHandler(this.picbtnAdd_MouseLeave);
            // 
            // lblAdd
            // 
            this.lblAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAdd.Location = new System.Drawing.Point(18, 158);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(157, 18);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Add Warehouse Activity";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblRemove
            // 
            this.lblRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemove.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblRemove.Location = new System.Drawing.Point(229, 158);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(183, 18);
            this.lblRemove.TabIndex = 5;
            this.lblRemove.Text = "Remove Warehouse Activity";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChange.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblChange.Location = new System.Drawing.Point(466, 158);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(178, 18);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Change Warehouse Activity";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(930, 158);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(121, 18);
            this.lblReport.TabIndex = 9;
            this.lblReport.Text = "View Stock Report";
            // 
            // InventoryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources.Main_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 681);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.pnlBody);
            this.Name = "InventoryMain";
            this.Text = "Inventory Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.InventoryMain_Activated);
            this.Load += new System.EventHandler(this.InventoryMainTest_Load);
            this.pnlDashBoard.ResumeLayout(false);
            this.pnlDashBoard.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTableViewer)).EndInit();
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbtnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Button btnWareHouseActivites;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.PictureBox picbtnView;
        private System.Windows.Forms.PictureBox picbtnChange;
        private System.Windows.Forms.PictureBox picbtnRemove;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.PictureBox picbtnAdd;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.DataGridView grdTableViewer;
        //public System.Windows.Forms.DataVisualization.Charting.Chart chartViewer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picbtnReport;
        private System.Windows.Forms.Label lblReport;
    }
}