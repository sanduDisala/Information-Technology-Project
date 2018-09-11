namespace Main.Modules.Project_Management
{
    partial class ProjectEvaluator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percent = new System.Windows.Forms.TextBox();
            this.up_date = new System.Windows.Forms.DateTimePicker();
            this.subid = new System.Windows.Forms.ComboBox();
            this.pid = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SubtaskID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panels = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Evaluation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.percent);
            this.panel1.Controls.Add(this.up_date);
            this.panel1.Controls.Add(this.subid);
            this.panel1.Controls.Add(this.pid);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SubtaskID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 433);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(112, 205);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(27, 20);
            this.percent.TabIndex = 11;
            this.percent.TextChanged += new System.EventHandler(this.percent_TextChanged);
            this.percent.Validating += new System.ComponentModel.CancelEventHandler(this.percent_Validating);
            // 
            // up_date
            // 
            this.up_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.up_date.Location = new System.Drawing.Point(112, 162);
            this.up_date.Name = "up_date";
            this.up_date.Size = new System.Drawing.Size(121, 20);
            this.up_date.TabIndex = 10;
            // 
            // subid
            // 
            this.subid.FormattingEnabled = true;
            this.subid.Location = new System.Drawing.Point(112, 117);
            this.subid.Name = "subid";
            this.subid.Size = new System.Drawing.Size(121, 21);
            this.subid.TabIndex = 9;
            this.subid.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pid
            // 
            this.pid.FormattingEnabled = true;
            this.pid.Location = new System.Drawing.Point(112, 81);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(121, 21);
            this.pid.TabIndex = 8;
            this.pid.SelectedIndexChanged += new System.EventHandler(this.pid_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(168, 329);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(87, 329);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 329);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pecentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SubtaskID
            // 
            this.SubtaskID.AutoSize = true;
            this.SubtaskID.Location = new System.Drawing.Point(40, 125);
            this.SubtaskID.Name = "SubtaskID";
            this.SubtaskID.Size = new System.Drawing.Size(57, 13);
            this.SubtaskID.TabIndex = 2;
            this.SubtaskID.Text = "SubtaskID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProjectID";
            // 
            // panels
            // 
            this.panels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panels.Location = new System.Drawing.Point(276, 4);
            this.panels.Name = "panels";
            this.panels.Size = new System.Drawing.Size(593, 189);
            this.panels.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Graphical View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 449);
            this.Controls.Add(this.panels);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectEvaluator";
            this.Text = "ProjectEvaluator";
            this.Load += new System.EventHandler(this.ProjectEvaluator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox percent;
        private System.Windows.Forms.DateTimePicker up_date;
        private System.Windows.Forms.ComboBox subid;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SubtaskID;
        private System.Windows.Forms.DataGridView panels;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox pid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}