namespace Main
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel_left = new System.Windows.Forms.Panel();
            this.lbl_customer_management = new System.Windows.Forms.Label();
            this.btn_customer_management = new System.Windows.Forms.Panel();
            this.lbl_transport_management = new System.Windows.Forms.Label();
            this.btn_transport = new System.Windows.Forms.Panel();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.btn_supplier = new System.Windows.Forms.Panel();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.btn_inventory = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.lbl_Event = new System.Windows.Forms.Label();
            this.btn_Event = new System.Windows.Forms.Panel();
            this.lbl_Employee = new System.Windows.Forms.Label();
            this.btn_financial = new System.Windows.Forms.Panel();
            this.btn_project = new System.Windows.Forms.Panel();
            this.btn_Employee = new System.Windows.Forms.Panel();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_financial = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_welcomeText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_left.Controls.Add(this.lbl_customer_management);
            this.panel_left.Controls.Add(this.btn_customer_management);
            this.panel_left.Controls.Add(this.lbl_transport_management);
            this.panel_left.Controls.Add(this.btn_transport);
            this.panel_left.Controls.Add(this.lbl_supplier);
            this.panel_left.Controls.Add(this.btn_supplier);
            this.panel_left.Controls.Add(this.lbl_inventory);
            this.panel_left.Controls.Add(this.btn_inventory);
            this.panel_left.Location = new System.Drawing.Point(0, 50);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 678);
            this.panel_left.TabIndex = 6;
            // 
            // lbl_customer_management
            // 
            this.lbl_customer_management.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_customer_management.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer_management.Location = new System.Drawing.Point(18, 605);
            this.lbl_customer_management.Name = "lbl_customer_management";
            this.lbl_customer_management.Size = new System.Drawing.Size(155, 48);
            this.lbl_customer_management.TabIndex = 7;
            this.lbl_customer_management.Text = "Customer Management";
            this.lbl_customer_management.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_customer_management.Click += new System.EventHandler(this.lbl_customer_management_Click);
            // 
            // btn_customer_management
            // 
            this.btn_customer_management.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_customer_management.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_customer_management.BackgroundImage")));
            this.btn_customer_management.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_customer_management.Location = new System.Drawing.Point(40, 499);
            this.btn_customer_management.Name = "btn_customer_management";
            this.btn_customer_management.Size = new System.Drawing.Size(113, 105);
            this.btn_customer_management.TabIndex = 6;
            this.btn_customer_management.Click += new System.EventHandler(this.btn_customer_management_Click);
            // 
            // lbl_transport_management
            // 
            this.lbl_transport_management.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_transport_management.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transport_management.Location = new System.Drawing.Point(18, 443);
            this.lbl_transport_management.Name = "lbl_transport_management";
            this.lbl_transport_management.Size = new System.Drawing.Size(155, 48);
            this.lbl_transport_management.TabIndex = 5;
            this.lbl_transport_management.Text = "Transport Management";
            this.lbl_transport_management.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_transport_management.Click += new System.EventHandler(this.lbl_transport_management_Click);
            // 
            // btn_transport
            // 
            this.btn_transport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_transport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transport.BackgroundImage")));
            this.btn_transport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transport.Location = new System.Drawing.Point(40, 337);
            this.btn_transport.Name = "btn_transport";
            this.btn_transport.Size = new System.Drawing.Size(113, 105);
            this.btn_transport.TabIndex = 4;
            this.btn_transport.Click += new System.EventHandler(this.btn_transport_Click);
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_supplier.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.Location = new System.Drawing.Point(16, 281);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(155, 48);
            this.lbl_supplier.TabIndex = 3;
            this.lbl_supplier.Text = "Supplier Management";
            this.lbl_supplier.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_supplier.Click += new System.EventHandler(this.lbl_supplier_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_supplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_supplier.BackgroundImage")));
            this.btn_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supplier.Location = new System.Drawing.Point(40, 174);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(113, 105);
            this.btn_supplier.TabIndex = 2;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_inventory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventory.Location = new System.Drawing.Point(28, 119);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(135, 48);
            this.lbl_inventory.TabIndex = 1;
            this.lbl_inventory.Text = "Inventory Management";
            this.lbl_inventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_inventory.Click += new System.EventHandler(this.lbl_inventory_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inventory.BackgroundImage")));
            this.btn_inventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inventory.Location = new System.Drawing.Point(40, 13);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(113, 105);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.Control;
            this.panel_right.Controls.Add(this.lbl_Event);
            this.panel_right.Controls.Add(this.btn_Event);
            this.panel_right.Controls.Add(this.lbl_Employee);
            this.panel_right.Controls.Add(this.btn_financial);
            this.panel_right.Controls.Add(this.btn_project);
            this.panel_right.Controls.Add(this.btn_Employee);
            this.panel_right.Controls.Add(this.lbl_project);
            this.panel_right.Controls.Add(this.lbl_financial);
            this.panel_right.Location = new System.Drawing.Point(1167, 50);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(200, 678);
            this.panel_right.TabIndex = 7;
            // 
            // lbl_Event
            // 
            this.lbl_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Event.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Event.Location = new System.Drawing.Point(22, 605);
            this.lbl_Event.Name = "lbl_Event";
            this.lbl_Event.Size = new System.Drawing.Size(155, 48);
            this.lbl_Event.TabIndex = 15;
            this.lbl_Event.Text = "Event Management";
            this.lbl_Event.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Event
            // 
            this.btn_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Event.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Event.BackgroundImage")));
            this.btn_Event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Event.Location = new System.Drawing.Point(44, 499);
            this.btn_Event.Name = "btn_Event";
            this.btn_Event.Size = new System.Drawing.Size(113, 105);
            this.btn_Event.TabIndex = 14;
            this.btn_Event.Click += new System.EventHandler(this.btn_Event_Click);
            // 
            // lbl_Employee
            // 
            this.lbl_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Employee.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee.Location = new System.Drawing.Point(22, 443);
            this.lbl_Employee.Name = "lbl_Employee";
            this.lbl_Employee.Size = new System.Drawing.Size(155, 48);
            this.lbl_Employee.TabIndex = 13;
            this.lbl_Employee.Text = "Employee Management";
            this.lbl_Employee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Employee.Click += new System.EventHandler(this.lbl_Employee_Click);
            // 
            // btn_financial
            // 
            this.btn_financial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_financial.BackgroundImage = global::Main.Properties.Resources.Financial;
            this.btn_financial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_financial.Location = new System.Drawing.Point(44, 174);
            this.btn_financial.Name = "btn_financial";
            this.btn_financial.Size = new System.Drawing.Size(113, 105);
            this.btn_financial.TabIndex = 10;
            this.btn_financial.Click += new System.EventHandler(this.btn_financial_Click_1);
            // 
            // btn_project
            // 
            this.btn_project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_project.BackgroundImage = global::Main.Properties.Resources._559121;
            this.btn_project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_project.Location = new System.Drawing.Point(44, 13);
            this.btn_project.Name = "btn_project";
            this.btn_project.Size = new System.Drawing.Size(113, 105);
            this.btn_project.TabIndex = 8;
            this.btn_project.Click += new System.EventHandler(this.btn_project_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Employee.BackgroundImage = global::Main.Properties.Resources.SAMPLED_6629472_900__nocrop__;
            this.btn_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Employee.Location = new System.Drawing.Point(44, 337);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Size = new System.Drawing.Size(113, 105);
            this.btn_Employee.TabIndex = 12;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // lbl_project
            // 
            this.lbl_project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_project.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(32, 119);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(135, 48);
            this.lbl_project.TabIndex = 9;
            this.lbl_project.Text = "Project Management";
            this.lbl_project.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_project.Click += new System.EventHandler(this.lbl_project_Click);
            // 
            // lbl_financial
            // 
            this.lbl_financial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_financial.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_financial.Location = new System.Drawing.Point(20, 281);
            this.lbl_financial.Name = "lbl_financial";
            this.lbl_financial.Size = new System.Drawing.Size(155, 48);
            this.lbl_financial.TabIndex = 11;
            this.lbl_financial.Text = "Financial Management";
            this.lbl_financial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_financial.Click += new System.EventHandler(this.lbl_financial_Click);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.Controls.Add(this.lbl_password);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.lbl_welcomeText);
            this.panel_login.Location = new System.Drawing.Point(280, 142);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(848, 349);
            this.panel_login.TabIndex = 9;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_login.Location = new System.Drawing.Point(349, 239);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(151, 66);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.DimGray;
            this.txt_password.Location = new System.Drawing.Point(170, 171);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(654, 40);
            this.txt_password.TabIndex = 19;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DimGray;
            this.txt_username.Location = new System.Drawing.Point(170, 120);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(654, 40);
            this.txt_username.TabIndex = 18;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(24, 178);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(119, 33);
            this.lbl_password.TabIndex = 17;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(24, 121);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(127, 33);
            this.lbl_username.TabIndex = 16;
            this.lbl_username.Text = "Username";
            // 
            // lbl_welcomeText
            // 
            this.lbl_welcomeText.AutoSize = true;
            this.lbl_welcomeText.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeText.Location = new System.Drawing.Point(290, 43);
            this.lbl_welcomeText.Name = "lbl_welcomeText";
            this.lbl_welcomeText.Size = new System.Drawing.Size(293, 33);
            this.lbl_welcomeText.TabIndex = 15;
            this.lbl_welcomeText.Text = "Please Login To Continue";
            this.lbl_welcomeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Main.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(560, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 73);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UIDesignForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UIDesignForm_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel btn_inventory;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Label lbl_transport_management;
        private System.Windows.Forms.Panel btn_transport;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Panel btn_supplier;
        private System.Windows.Forms.Label lbl_customer_management;
        private System.Windows.Forms.Panel btn_customer_management;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_welcomeText;
        private System.Windows.Forms.Label lbl_Event;
        private System.Windows.Forms.Panel btn_Event;
        private System.Windows.Forms.Label lbl_Employee;
        private System.Windows.Forms.Panel btn_financial;
        private System.Windows.Forms.Panel btn_project;
        private System.Windows.Forms.Panel btn_Employee;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_financial;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}