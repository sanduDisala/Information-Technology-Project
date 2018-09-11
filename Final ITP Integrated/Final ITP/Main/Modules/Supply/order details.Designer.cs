namespace Main.Modules.Supply
{
    partial class order_details
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.QuanityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelTextBox.Location = new System.Drawing.Point(145, 109);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(199, 26);
            this.ModelTextBox.TabIndex = 4;
            this.ModelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModelTextBox_KeyPress);
            // 
            // QuanityTextBox
            // 
            this.QuanityTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuanityTextBox.Location = new System.Drawing.Point(145, 156);
            this.QuanityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuanityTextBox.Name = "QuanityTextBox";
            this.QuanityTextBox.ReadOnly = true;
            this.QuanityTextBox.Size = new System.Drawing.Size(199, 26);
            this.QuanityTextBox.TabIndex = 5;
            this.QuanityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuanityTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 291);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDTextBox.Location = new System.Drawing.Point(145, 63);
            this.OrderIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(199, 26);
            this.OrderIDTextBox.TabIndex = 8;
            this.OrderIDTextBox.TextChanged += new System.EventHandler(this.OrderIDTextBox_TextChanged);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(145, 210);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(199, 26);
            this.email.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(42, 214);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(89, 16);
            this.label.TabIndex = 9;
            this.label.Text = "Supplier Email";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Check Model";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuanityTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "order_details";
            this.Text = "order_details";
            this.Load += new System.EventHandler(this.order_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox QuanityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button3;
    }
}