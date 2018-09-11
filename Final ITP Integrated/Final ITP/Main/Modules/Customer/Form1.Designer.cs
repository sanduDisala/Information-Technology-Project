namespace Main.Modules.Customer
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.payment = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.customer_reg = new System.Windows.Forms.Button();
            this.get_order = new System.Windows.Forms.Button();
            this.view_bd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(221, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 620);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // payment
            // 
            this.payment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment.Location = new System.Drawing.Point(16, 322);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(130, 50);
            this.payment.TabIndex = 1;
            this.payment.Text = "Payments";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // feedback
            // 
            this.feedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedback.Location = new System.Drawing.Point(16, 422);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(130, 50);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "Send Email";
            this.feedback.UseVisualStyleBackColor = true;
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // customer_reg
            // 
            this.customer_reg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_reg.Location = new System.Drawing.Point(16, 125);
            this.customer_reg.Name = "customer_reg";
            this.customer_reg.Size = new System.Drawing.Size(130, 50);
            this.customer_reg.TabIndex = 3;
            this.customer_reg.Text = "Customer Information";
            this.customer_reg.UseVisualStyleBackColor = true;
            this.customer_reg.Click += new System.EventHandler(this.customer_reg_Click);
            // 
            // get_order
            // 
            this.get_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.get_order.Location = new System.Drawing.Point(16, 223);
            this.get_order.Name = "get_order";
            this.get_order.Size = new System.Drawing.Size(130, 50);
            this.get_order.TabIndex = 0;
            this.get_order.Text = "Make Order";
            this.get_order.UseVisualStyleBackColor = true;
            this.get_order.Click += new System.EventHandler(this.get_order_Click);
            // 
            // view_bd
            // 
            this.view_bd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_bd.Location = new System.Drawing.Point(16, 526);
            this.view_bd.Name = "view_bd";
            this.view_bd.Size = new System.Drawing.Size(130, 48);
            this.view_bd.TabIndex = 0;
            this.view_bd.Text = "View Birthdays";
            this.view_bd.UseVisualStyleBackColor = true;
            this.view_bd.Click += new System.EventHandler(this.view_bd_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(16, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.view_bd);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.feedback);
            this.groupBox1.Controls.Add(this.get_order);
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.customer_reg);
            this.groupBox1.Location = new System.Drawing.Point(19, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 619);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button customer_reg;
        private System.Windows.Forms.Button get_order;
        private System.Windows.Forms.Button view_bd;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

