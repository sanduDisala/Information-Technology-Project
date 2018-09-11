namespace Main.Modules.Financial
{
    partial class Mainfrm
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
            this.sales = new System.Windows.Forms.Button();
            this.purchase = new System.Windows.Forms.Button();
            this.expenses = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.ist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.PeachPuff;
            this.sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales.Location = new System.Drawing.Point(99, 102);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(181, 35);
            this.sales.TabIndex = 0;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            this.sales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sales_MouseClick);
            this.sales.MouseEnter += new System.EventHandler(this.sales_MouseEnter);
            // 
            // purchase
            // 
            this.purchase.BackColor = System.Drawing.Color.PeachPuff;
            this.purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase.Location = new System.Drawing.Point(99, 170);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(181, 35);
            this.purchase.TabIndex = 1;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = false;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // expenses
            // 
            this.expenses.BackColor = System.Drawing.Color.PeachPuff;
            this.expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses.Location = new System.Drawing.Point(338, 170);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(181, 35);
            this.expenses.TabIndex = 3;
            this.expenses.Text = "Expenses";
            this.expenses.UseVisualStyleBackColor = false;
            this.expenses.Click += new System.EventHandler(this.expenses_Click);
            // 
            // income
            // 
            this.income.BackColor = System.Drawing.Color.PeachPuff;
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.Location = new System.Drawing.Point(338, 102);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(181, 35);
            this.income.TabIndex = 4;
            this.income.Text = "Income";
            this.income.UseVisualStyleBackColor = false;
            this.income.Click += new System.EventHandler(this.button5_Click);
            // 
            // ist
            // 
            this.ist.BackColor = System.Drawing.Color.PeachPuff;
            this.ist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ist.Location = new System.Drawing.Point(219, 264);
            this.ist.Name = "ist";
            this.ist.Size = new System.Drawing.Size(181, 35);
            this.ist.TabIndex = 5;
            this.ist.Text = "Income Statment";
            this.ist.UseVisualStyleBackColor = false;
            this.ist.Click += new System.EventHandler(this.ist_Click);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(679, 456);
            this.Controls.Add(this.ist);
            this.Controls.Add(this.income);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.sales);
            this.Name = "Mainfrm";
            this.Text = "Financial System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Button expenses;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button ist;
    }
}