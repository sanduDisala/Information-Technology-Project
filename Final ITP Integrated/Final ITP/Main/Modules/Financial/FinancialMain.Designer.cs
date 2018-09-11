namespace Main.Modules.Financial
{
    partial class FinancialMain
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
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.btnIncomeStatement = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDashBoard.Controls.Add(this.btnIncomeStatement);
            this.pnlDashBoard.Controls.Add(this.btnExpense);
            this.pnlDashBoard.Controls.Add(this.btnIncome);
            this.pnlDashBoard.Controls.Add(this.btnPurchase);
            this.pnlDashBoard.Controls.Add(this.btnSales);
            this.pnlDashBoard.Location = new System.Drawing.Point(11, 13);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(200, 655);
            this.pnlDashBoard.TabIndex = 0;
            // 
            // btnIncomeStatement
            // 
            this.btnIncomeStatement.Location = new System.Drawing.Point(46, 298);
            this.btnIncomeStatement.Name = "btnIncomeStatement";
            this.btnIncomeStatement.Size = new System.Drawing.Size(110, 40);
            this.btnIncomeStatement.TabIndex = 4;
            this.btnIncomeStatement.Text = "Reports";
            this.btnIncomeStatement.UseVisualStyleBackColor = true;
            this.btnIncomeStatement.Click += new System.EventHandler(this.btnIncomeStatement_Click);
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(46, 229);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(110, 40);
            this.btnExpense.TabIndex = 3;
            this.btnExpense.Text = "Expenses";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(46, 161);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(110, 40);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Income";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(46, 92);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(110, 40);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(46, 28);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(110, 40);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Location = new System.Drawing.Point(228, 13);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1091, 655);
            this.pnlBody.TabIndex = 1;
            // 
            // FinancialMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources.Main_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 681);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlDashBoard);
            this.Name = "FinancialMain";
            this.Text = "FinancialMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinancialMain_Load);
            this.pnlDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnIncomeStatement;

    }
}