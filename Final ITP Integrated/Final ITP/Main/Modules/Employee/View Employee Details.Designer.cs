namespace Main.Module.Employee
{
    partial class View_Employee_Details
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
            this.ed_delete = new System.Windows.Forms.Button();
            this.detail_grid = new System.Windows.Forms.DataGridView();
            this.ed_empcode = new System.Windows.Forms.TextBox();
            this.ed_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ed_err_code = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ed_exit = new System.Windows.Forms.Button();
            this.code_search = new System.Windows.Forms.RadioButton();
            this.name_search = new System.Windows.Forms.RadioButton();
            this.err_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ed_delete
            // 
            this.ed_delete.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_delete.Location = new System.Drawing.Point(247, 275);
            this.ed_delete.Margin = new System.Windows.Forms.Padding(4);
            this.ed_delete.Name = "ed_delete";
            this.ed_delete.Size = new System.Drawing.Size(121, 36);
            this.ed_delete.TabIndex = 174;
            this.ed_delete.Text = "Delete";
            this.ed_delete.UseVisualStyleBackColor = true;
            this.ed_delete.Click += new System.EventHandler(this.ed_delete_Click);
            // 
            // detail_grid
            // 
            this.detail_grid.AllowUserToAddRows = false;
            this.detail_grid.AllowUserToDeleteRows = false;
            this.detail_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_grid.Location = new System.Drawing.Point(462, 63);
            this.detail_grid.Name = "detail_grid";
            this.detail_grid.ReadOnly = true;
            this.detail_grid.Size = new System.Drawing.Size(454, 465);
            this.detail_grid.TabIndex = 175;
            // 
            // ed_empcode
            // 
            this.ed_empcode.Enabled = false;
            this.ed_empcode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_empcode.Location = new System.Drawing.Point(165, 132);
            this.ed_empcode.Margin = new System.Windows.Forms.Padding(4);
            this.ed_empcode.MaxLength = 10;
            this.ed_empcode.Name = "ed_empcode";
            this.ed_empcode.Size = new System.Drawing.Size(276, 22);
            this.ed_empcode.TabIndex = 176;
            // 
            // ed_search
            // 
            this.ed_search.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_search.Location = new System.Drawing.Point(82, 275);
            this.ed_search.Margin = new System.Windows.Forms.Padding(4);
            this.ed_search.Name = "ed_search";
            this.ed_search.Size = new System.Drawing.Size(121, 36);
            this.ed_search.TabIndex = 177;
            this.ed_search.Text = "Search";
            this.ed_search.UseVisualStyleBackColor = true;
            this.ed_search.Click += new System.EventHandler(this.ed_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 178;
            this.label1.Text = "Employee Code";
            // 
            // ed_err_code
            // 
            this.ed_err_code.AutoSize = true;
            this.ed_err_code.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_err_code.ForeColor = System.Drawing.Color.Red;
            this.ed_err_code.Location = new System.Drawing.Point(162, 158);
            this.ed_err_code.Name = "ed_err_code";
            this.ed_err_code.Size = new System.Drawing.Size(56, 14);
            this.ed_err_code.TabIndex = 179;
            this.ed_err_code.Text = "err_label";
            this.ed_err_code.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 28);
            this.label13.TabIndex = 180;
            this.label13.Text = "View Employees";
            // 
            // ed_exit
            // 
            this.ed_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_exit.Location = new System.Drawing.Point(165, 396);
            this.ed_exit.Margin = new System.Windows.Forms.Padding(4);
            this.ed_exit.Name = "ed_exit";
            this.ed_exit.Size = new System.Drawing.Size(121, 36);
            this.ed_exit.TabIndex = 181;
            this.ed_exit.Text = "Exit";
            this.ed_exit.UseVisualStyleBackColor = true;
            this.ed_exit.Click += new System.EventHandler(this.ed_exit_Click);
            // 
            // code_search
            // 
            this.code_search.AutoSize = true;
            this.code_search.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_search.Location = new System.Drawing.Point(233, 83);
            this.code_search.Margin = new System.Windows.Forms.Padding(4);
            this.code_search.Name = "code_search";
            this.code_search.Size = new System.Drawing.Size(131, 19);
            this.code_search.TabIndex = 183;
            this.code_search.TabStop = true;
            this.code_search.Text = "Search Using Code";
            this.code_search.UseVisualStyleBackColor = true;
            this.code_search.Click += new System.EventHandler(this.code_search_Click);
            // 
            // name_search
            // 
            this.name_search.AutoSize = true;
            this.name_search.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search.Location = new System.Drawing.Point(65, 83);
            this.name_search.Margin = new System.Windows.Forms.Padding(4);
            this.name_search.Name = "name_search";
            this.name_search.Size = new System.Drawing.Size(139, 19);
            this.name_search.TabIndex = 182;
            this.name_search.TabStop = true;
            this.name_search.Text = "Search Using Name";
            this.name_search.UseVisualStyleBackColor = true;
            this.name_search.Click += new System.EventHandler(this.name_search_Click);
            // 
            // err_name
            // 
            this.err_name.AutoSize = true;
            this.err_name.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_name.ForeColor = System.Drawing.Color.Red;
            this.err_name.Location = new System.Drawing.Point(162, 230);
            this.err_name.Name = "err_name";
            this.err_name.Size = new System.Drawing.Size(56, 14);
            this.err_name.TabIndex = 186;
            this.err_name.Text = "err_label";
            this.err_name.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 185;
            this.label3.Text = "Employee Name";
            // 
            // emp_name
            // 
            this.emp_name.Enabled = false;
            this.emp_name.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.Location = new System.Drawing.Point(165, 204);
            this.emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.emp_name.MaxLength = 50;
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(276, 22);
            this.emp_name.TabIndex = 184;
            // 
            // View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.err_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emp_name);
            this.Controls.Add(this.code_search);
            this.Controls.Add(this.name_search);
            this.Controls.Add(this.ed_exit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ed_err_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_search);
            this.Controls.Add(this.ed_empcode);
            this.Controls.Add(this.detail_grid);
            this.Controls.Add(this.ed_delete);
            this.Name = "View_Employee_Details";
            this.Text = "View_Employee_Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_Employee_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ed_delete;
        private System.Windows.Forms.DataGridView detail_grid;
        private System.Windows.Forms.TextBox ed_empcode;
        private System.Windows.Forms.Button ed_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ed_err_code;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button ed_exit;
        private System.Windows.Forms.RadioButton code_search;
        private System.Windows.Forms.RadioButton name_search;
        private System.Windows.Forms.Label err_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emp_name;
    }
}