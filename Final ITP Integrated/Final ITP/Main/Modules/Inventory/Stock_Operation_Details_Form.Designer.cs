namespace Main.Modules.Inventory
{
    partial class Stock_Operation_Details_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btngrdRemove = new System.Windows.Forms.Button();
            this.grp_Available_Items = new System.Windows.Forms.GroupBox();
            this.grdView_Available_Items = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.grp_Selected_Items = new System.Windows.Forms.GroupBox();
            this.grdView_Selected_Items = new System.Windows.Forms.DataGridView();
            this.grp_formBox = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbDealer = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.chkType = new System.Windows.Forms.CheckBox();
            this.chkDealer = new System.Windows.Forms.CheckBox();
            this.chkBrand = new System.Windows.Forms.CheckBox();
            this.grp_Available_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Available_Items)).BeginInit();
            this.grp_Selected_Items.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Selected_Items)).BeginInit();
            this.grp_formBox.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btngrdRemove
            // 
            this.btngrdRemove.Location = new System.Drawing.Point(254, 501);
            this.btngrdRemove.Name = "btngrdRemove";
            this.btngrdRemove.Size = new System.Drawing.Size(98, 35);
            this.btngrdRemove.TabIndex = 2;
            this.btngrdRemove.Text = "Remove";
            this.btngrdRemove.UseVisualStyleBackColor = true;
            this.btngrdRemove.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // grp_Available_Items
            // 
            this.grp_Available_Items.Controls.Add(this.grdView_Available_Items);
            this.grp_Available_Items.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Available_Items.Location = new System.Drawing.Point(21, 19);
            this.grp_Available_Items.Name = "grp_Available_Items";
            this.grp_Available_Items.Size = new System.Drawing.Size(1022, 223);
            this.grp_Available_Items.TabIndex = 0;
            this.grp_Available_Items.TabStop = false;
            this.grp_Available_Items.Text = "Available Items";
            // 
            // grdView_Available_Items
            // 
            this.grdView_Available_Items.AllowUserToAddRows = false;
            this.grdView_Available_Items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdView_Available_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdView_Available_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdView_Available_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView_Available_Items.Location = new System.Drawing.Point(9, 18);
            this.grdView_Available_Items.Name = "grdView_Available_Items";
            this.grdView_Available_Items.ReadOnly = true;
            this.grdView_Available_Items.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdView_Available_Items.Size = new System.Drawing.Size(1005, 195);
            this.grdView_Available_Items.TabIndex = 0;
            this.grdView_Available_Items.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdView_Available_Items_CellMouseClick);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 501);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 35);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grp_Selected_Items
            // 
            this.grp_Selected_Items.Controls.Add(this.grdView_Selected_Items);
            this.grp_Selected_Items.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Selected_Items.Location = new System.Drawing.Point(21, 249);
            this.grp_Selected_Items.Name = "grp_Selected_Items";
            this.grp_Selected_Items.Size = new System.Drawing.Size(1297, 230);
            this.grp_Selected_Items.TabIndex = 1;
            this.grp_Selected_Items.TabStop = false;
            this.grp_Selected_Items.Text = "Selected Items";
            // 
            // grdView_Selected_Items
            // 
            this.grdView_Selected_Items.AllowUserToAddRows = false;
            this.grdView_Selected_Items.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdView_Selected_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdView_Selected_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdView_Selected_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView_Selected_Items.Location = new System.Drawing.Point(10, 21);
            this.grdView_Selected_Items.Name = "grdView_Selected_Items";
            this.grdView_Selected_Items.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdView_Selected_Items.Size = new System.Drawing.Size(1004, 195);
            this.grdView_Selected_Items.TabIndex = 0;
            this.grdView_Selected_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_Selected_Items_CellClick);
            this.grdView_Selected_Items.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_Selected_Items_CellEndEdit);
            this.grdView_Selected_Items.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdView_Selected_Items_CellFormatting);
            this.grdView_Selected_Items.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdView_Selected_Items_CellValueChanged);
            this.grdView_Selected_Items.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdView_Selected_Items_CurrentCellDirtyStateChanged);
            // 
            // grp_formBox
            // 
            this.grp_formBox.Controls.Add(this.grpFilter);
            this.grp_formBox.Controls.Add(this.grp_Selected_Items);
            this.grp_formBox.Controls.Add(this.btnOK);
            this.grp_formBox.Controls.Add(this.grp_Available_Items);
            this.grp_formBox.Controls.Add(this.btngrdRemove);
            this.grp_formBox.Controls.Add(this.btnCancel);
            this.grp_formBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_formBox.Location = new System.Drawing.Point(12, 8);
            this.grp_formBox.Name = "grp_formBox";
            this.grp_formBox.Size = new System.Drawing.Size(1330, 559);
            this.grp_formBox.TabIndex = 24;
            this.grp_formBox.TabStop = false;
            this.grp_formBox.Text = "Add Stock Details Form";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cmbCategory);
            this.grpFilter.Controls.Add(this.cmbType);
            this.grpFilter.Controls.Add(this.cmbDealer);
            this.grpFilter.Controls.Add(this.cmbBrand);
            this.grpFilter.Controls.Add(this.chkCategory);
            this.grpFilter.Controls.Add(this.chkType);
            this.grpFilter.Controls.Add(this.chkDealer);
            this.grpFilter.Controls.Add(this.chkBrand);
            this.grpFilter.Location = new System.Drawing.Point(1054, 19);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(270, 213);
            this.grpFilter.TabIndex = 25;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Available Items Using";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(92, 157);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 39);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(102, 116);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(162, 26);
            this.cmbCategory.TabIndex = 11;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(102, 86);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(162, 26);
            this.cmbType.TabIndex = 10;
            // 
            // cmbDealer
            // 
            this.cmbDealer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDealer.FormattingEnabled = true;
            this.cmbDealer.Location = new System.Drawing.Point(102, 56);
            this.cmbDealer.Name = "cmbDealer";
            this.cmbDealer.Size = new System.Drawing.Size(162, 26);
            this.cmbDealer.TabIndex = 9;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(102, 25);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(162, 26);
            this.cmbBrand.TabIndex = 8;
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCategory.Location = new System.Drawing.Point(18, 118);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(82, 22);
            this.chkCategory.TabIndex = 6;
            this.chkCategory.Text = "Category";
            this.chkCategory.UseVisualStyleBackColor = true;
            this.chkCategory.CheckedChanged += new System.EventHandler(this.chkCategory_CheckedChanged);
            // 
            // chkType
            // 
            this.chkType.AutoSize = true;
            this.chkType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkType.Location = new System.Drawing.Point(18, 88);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(56, 22);
            this.chkType.TabIndex = 2;
            this.chkType.Text = "Type";
            this.chkType.UseVisualStyleBackColor = true;
            this.chkType.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkDealer
            // 
            this.chkDealer.AutoSize = true;
            this.chkDealer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDealer.Location = new System.Drawing.Point(18, 58);
            this.chkDealer.Name = "chkDealer";
            this.chkDealer.Size = new System.Drawing.Size(68, 22);
            this.chkDealer.TabIndex = 1;
            this.chkDealer.Text = "Dealer";
            this.chkDealer.UseVisualStyleBackColor = true;
            this.chkDealer.CheckedChanged += new System.EventHandler(this.chkDealer_CheckedChanged);
            // 
            // chkBrand
            // 
            this.chkBrand.AutoSize = true;
            this.chkBrand.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBrand.Location = new System.Drawing.Point(18, 27);
            this.chkBrand.Name = "chkBrand";
            this.chkBrand.Size = new System.Drawing.Size(63, 22);
            this.chkBrand.TabIndex = 0;
            this.chkBrand.Text = "Brand";
            this.chkBrand.UseVisualStyleBackColor = true;
            this.chkBrand.CheckedChanged += new System.EventHandler(this.chkBrand_CheckedChanged);
            // 
            // Stock_Operation_Details_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 575);
            this.Controls.Add(this.grp_formBox);
            this.Name = "Stock_Operation_Details_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Stock Details";
//            this.Activated += new System.EventHandler(this.Stock_Operation_Details_Form_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stock_Operation_Details_Form_FormClosed);
            this.Load += new System.EventHandler(this.Stock_form_Load);
            this.grp_Available_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Available_Items)).EndInit();
            this.grp_Selected_Items.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView_Selected_Items)).EndInit();
            this.grp_formBox.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btngrdRemove;
        private System.Windows.Forms.GroupBox grp_Available_Items;
        private System.Windows.Forms.DataGridView grdView_Available_Items;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grp_Selected_Items;
        private System.Windows.Forms.DataGridView grdView_Selected_Items;
        private System.Windows.Forms.GroupBox grp_formBox;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbDealer;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.CheckBox chkType;
        private System.Windows.Forms.CheckBox chkDealer;
        private System.Windows.Forms.CheckBox chkBrand;

    }
}