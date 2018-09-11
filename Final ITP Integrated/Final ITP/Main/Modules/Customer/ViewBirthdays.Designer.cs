namespace Main.Modules.Customer
{
    partial class ViewBirthdays
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbttoday = new System.Windows.Forms.RadioButton();
            this.rbtweek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send birthday message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbttoday);
            this.groupBox1.Controls.Add(this.rbtweek);
            this.groupBox1.Location = new System.Drawing.Point(95, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Birthdays In";
            // 
            // rbttoday
            // 
            this.rbttoday.AutoSize = true;
            this.rbttoday.Location = new System.Drawing.Point(205, 36);
            this.rbttoday.Name = "rbttoday";
            this.rbttoday.Size = new System.Drawing.Size(55, 17);
            this.rbttoday.TabIndex = 1;
            this.rbttoday.TabStop = true;
            this.rbttoday.Text = "Today";
            this.rbttoday.UseVisualStyleBackColor = true;
            this.rbttoday.CheckedChanged += new System.EventHandler(this.rbttoday_CheckedChanged);
            // 
            // rbtweek
            // 
            this.rbtweek.AutoSize = true;
            this.rbtweek.Location = new System.Drawing.Point(33, 36);
            this.rbtweek.Name = "rbtweek";
            this.rbtweek.Size = new System.Drawing.Size(74, 17);
            this.rbtweek.TabIndex = 0;
            this.rbtweek.TabStop = true;
            this.rbtweek.Text = "This week";
            this.rbtweek.UseVisualStyleBackColor = true;
            this.rbtweek.CheckedChanged += new System.EventHandler(this.rbtweek_CheckedChanged);
            // 
            // ViewBirthdays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBirthdays";
            this.Text = "ViewBirthdays";
            //this.Load += new System.EventHandler(this.ViewBirthdays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbttoday;
        private System.Windows.Forms.RadioButton rbtweek;
    }
}