namespace Main.Module.Employee
{
    partial class SearchEmployeeDetails
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
            this.label13 = new System.Windows.Forms.Label();
            this.view_emp = new System.Windows.Forms.RadioButton();
            this.view_all = new System.Windows.Forms.RadioButton();
            this.ed_err_code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ed_empcode = new System.Windows.Forms.TextBox();
            this.field_err = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detail_grid = new System.Windows.Forms.DataGridView();
            this.ed_exit = new System.Windows.Forms.Button();
            this.ed_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(302, 28);
            this.label13.TabIndex = 181;
            this.label13.Text = "Search Employee Details";
            // 
            // view_emp
            // 
            this.view_emp.AutoSize = true;
            this.view_emp.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_emp.Location = new System.Drawing.Point(212, 84);
            this.view_emp.Margin = new System.Windows.Forms.Padding(4);
            this.view_emp.Name = "view_emp";
            this.view_emp.Size = new System.Drawing.Size(156, 19);
            this.view_emp.TabIndex = 185;
            this.view_emp.TabStop = true;
            this.view_emp.Text = "Details of an Employee";
            this.view_emp.UseVisualStyleBackColor = true;
            this.view_emp.Click += new System.EventHandler(this.view_emp_Click);
            // 
            // view_all
            // 
            this.view_all.AutoSize = true;
            this.view_all.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.Location = new System.Drawing.Point(44, 84);
            this.view_all.Margin = new System.Windows.Forms.Padding(4);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(117, 19);
            this.view_all.TabIndex = 184;
            this.view_all.Text = "View All Details";
            this.view_all.UseVisualStyleBackColor = true;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // ed_err_code
            // 
            this.ed_err_code.AutoSize = true;
            this.ed_err_code.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_err_code.ForeColor = System.Drawing.Color.Red;
            this.ed_err_code.Location = new System.Drawing.Point(162, 166);
            this.ed_err_code.Name = "ed_err_code";
            this.ed_err_code.Size = new System.Drawing.Size(56, 14);
            this.ed_err_code.TabIndex = 188;
            this.ed_err_code.Text = "err_label";
            this.ed_err_code.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 187;
            this.label1.Text = "Employee Code";
            // 
            // ed_empcode
            // 
            this.ed_empcode.Enabled = false;
            this.ed_empcode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_empcode.Location = new System.Drawing.Point(165, 140);
            this.ed_empcode.Margin = new System.Windows.Forms.Padding(4);
            this.ed_empcode.MaxLength = 10;
            this.ed_empcode.Name = "ed_empcode";
            this.ed_empcode.Size = new System.Drawing.Size(221, 22);
            this.ed_empcode.TabIndex = 186;
            // 
            // field_err
            // 
            this.field_err.AutoSize = true;
            this.field_err.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field_err.ForeColor = System.Drawing.Color.Red;
            this.field_err.Location = new System.Drawing.Point(163, 232);
            this.field_err.Name = "field_err";
            this.field_err.Size = new System.Drawing.Size(56, 14);
            this.field_err.TabIndex = 191;
            this.field_err.Text = "err_label";
            this.field_err.Visible = false;
            // 
            // field
            // 
            this.field.Enabled = false;
            this.field.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.field.FormattingEnabled = true;
            this.field.ImeMode = System.Windows.Forms.ImeMode.On;
            this.field.Items.AddRange(new object[] {
            "Personal Details",
            "Office Details",
            "Contact Details",
            "Experiances",
            "Qualifications",
            "Salary and Tax Details",
            "Leaves Taken"});
            this.field.Location = new System.Drawing.Point(165, 208);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(221, 23);
            this.field.TabIndex = 190;
            this.field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.field_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 189;
            this.label2.Text = "Detail Category";
            // 
            // detail_grid
            // 
            this.detail_grid.AllowUserToAddRows = false;
            this.detail_grid.AllowUserToDeleteRows = false;
            this.detail_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detail_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detail_grid.Location = new System.Drawing.Point(403, 84);
            this.detail_grid.Name = "detail_grid";
            this.detail_grid.ReadOnly = true;
            this.detail_grid.Size = new System.Drawing.Size(840, 465);
            this.detail_grid.TabIndex = 192;
            // 
            // ed_exit
            // 
            this.ed_exit.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_exit.Location = new System.Drawing.Point(212, 315);
            this.ed_exit.Margin = new System.Windows.Forms.Padding(4);
            this.ed_exit.Name = "ed_exit";
            this.ed_exit.Size = new System.Drawing.Size(121, 36);
            this.ed_exit.TabIndex = 194;
            this.ed_exit.Text = "Exit";
            this.ed_exit.UseVisualStyleBackColor = true;
            this.ed_exit.Click += new System.EventHandler(this.ed_exit_Click);
            // 
            // ed_search
            // 
            this.ed_search.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed_search.Location = new System.Drawing.Point(46, 315);
            this.ed_search.Margin = new System.Windows.Forms.Padding(4);
            this.ed_search.Name = "ed_search";
            this.ed_search.Size = new System.Drawing.Size(121, 36);
            this.ed_search.TabIndex = 193;
            this.ed_search.Text = "Search";
            this.ed_search.UseVisualStyleBackColor = true;
            this.ed_search.Click += new System.EventHandler(this.ed_search_Click);
            // 
            // SearchEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.ed_exit);
            this.Controls.Add(this.ed_search);
            this.Controls.Add(this.detail_grid);
            this.Controls.Add(this.field_err);
            this.Controls.Add(this.field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ed_err_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ed_empcode);
            this.Controls.Add(this.view_emp);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.label13);
            this.Name = "SearchEmployeeDetails";
            this.Text = "SearchEmployeeDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.detail_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton view_emp;
        private System.Windows.Forms.RadioButton view_all;
        private System.Windows.Forms.Label ed_err_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ed_empcode;
        private System.Windows.Forms.Label field_err;
        private System.Windows.Forms.ComboBox field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView detail_grid;
        private System.Windows.Forms.Button ed_exit;
        private System.Windows.Forms.Button ed_search;
    }
}