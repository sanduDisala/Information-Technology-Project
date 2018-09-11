namespace Main.Modules.Project_Management
{
    partial class Add_Subtask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.TextBox();
            this.add2 = new System.Windows.Forms.Button();
            this.s_id = new System.Windows.Forms.ComboBox();
            this.subid = new System.Windows.Forms.Label();
            this.label_pid = new System.Windows.Forms.Label();
            this.pid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sDel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.pid = new System.Windows.Forms.Label();
            this.sproid = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.sedate = new System.Windows.Forms.Label();
            this.subname = new System.Windows.Forms.Label();
            this.AddSubtask = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.DataGridView();
            this.UpdateOp = new System.Windows.Forms.RadioButton();
            this.DelOp = new System.Windows.Forms.RadioButton();
            this.view = new System.Windows.Forms.Button();
            this.newOp = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nam = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.add2);
            this.panel1.Controls.Add(this.s_id);
            this.panel1.Controls.Add(this.subid);
            this.panel1.Controls.Add(this.label_pid);
            this.panel1.Controls.Add(this.pid_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sDel);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.pid);
            this.panel1.Controls.Add(this.sproid);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Controls.Add(this.sedate);
            this.panel1.Controls.Add(this.subname);
            this.panel1.Controls.Add(this.AddSubtask);
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(119, 182);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 20;
            this.title.Validating += new System.ComponentModel.CancelEventHandler(this.title_Validating);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(25, 444);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(75, 23);
            this.add2.TabIndex = 19;
            this.add2.Text = "Add";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Visible = false;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // s_id
            // 
            this.s_id.FormattingEnabled = true;
            this.s_id.Location = new System.Drawing.Point(118, 139);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(117, 21);
            this.s_id.TabIndex = 18;
            this.s_id.Visible = false;
            // 
            // subid
            // 
            this.subid.AutoSize = true;
            this.subid.Location = new System.Drawing.Point(23, 147);
            this.subid.Name = "subid";
            this.subid.Size = new System.Drawing.Size(57, 13);
            this.subid.TabIndex = 17;
            this.subid.Text = "SubtaskID";
            this.subid.Visible = false;
            // 
            // label_pid
            // 
            this.label_pid.AutoSize = true;
            this.label_pid.Location = new System.Drawing.Point(23, 65);
            this.label_pid.Name = "label_pid";
            this.label_pid.Size = new System.Drawing.Size(35, 13);
            this.label_pid.TabIndex = 16;
            this.label_pid.Text = "label2";
            // 
            // pid_label
            // 
            this.pid_label.AutoSize = true;
            this.pid_label.Location = new System.Drawing.Point(23, 65);
            this.pid_label.Name = "pid_label";
            this.pid_label.Size = new System.Drawing.Size(0, 13);
            this.pid_label.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start Date";
            // 
            // sDel
            // 
            this.sDel.Location = new System.Drawing.Point(112, 400);
            this.sDel.Name = "sDel";
            this.sDel.Size = new System.Drawing.Size(75, 23);
            this.sDel.TabIndex = 14;
            this.sDel.Text = "Delete";
            this.sDel.UseVisualStyleBackColor = true;
            this.sDel.Visible = false;
            this.sDel.Click += new System.EventHandler(this.sDel_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(25, 400);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(210, 355);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(119, 355);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Location = new System.Drawing.Point(27, 110);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(51, 13);
            this.pid.TabIndex = 9;
            this.pid.Text = "ProjectID";
            this.pid.Visible = false;
            // 
            // sproid
            // 
            this.sproid.FormattingEnabled = true;
            this.sproid.Location = new System.Drawing.Point(119, 102);
            this.sproid.Name = "sproid";
            this.sproid.Size = new System.Drawing.Size(116, 21);
            this.sproid.TabIndex = 10;
            this.sproid.Visible = false;
            this.sproid.SelectedIndexChanged += new System.EventHandler(this.sproid_SelectedIndexChanged);
            this.sproid.Validating += new System.ComponentModel.CancelEventHandler(this.sproid_Validating);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(25, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // enddate
            // 
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.Location = new System.Drawing.Point(118, 294);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(117, 20);
            this.enddate.TabIndex = 8;
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            this.enddate.Validating += new System.ComponentModel.CancelEventHandler(this.enddate_Validating);
            // 
            // startdate
            // 
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(118, 237);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(117, 20);
            this.startdate.TabIndex = 7;
            // 
            // sedate
            // 
            this.sedate.AutoSize = true;
            this.sedate.Location = new System.Drawing.Point(23, 300);
            this.sedate.Name = "sedate";
            this.sedate.Size = new System.Drawing.Size(52, 13);
            this.sedate.TabIndex = 5;
            this.sedate.Text = "End Date";
            // 
            // subname
            // 
            this.subname.AutoSize = true;
            this.subname.Location = new System.Drawing.Point(23, 189);
            this.subname.Name = "subname";
            this.subname.Size = new System.Drawing.Size(77, 13);
            this.subname.TabIndex = 3;
            this.subname.Text = "Subtask Name";
            // 
            // AddSubtask
            // 
            this.AddSubtask.AutoSize = true;
            this.AddSubtask.Location = new System.Drawing.Point(116, 24);
            this.AddSubtask.Name = "AddSubtask";
            this.AddSubtask.Size = new System.Drawing.Size(71, 13);
            this.AddSubtask.TabIndex = 2;
            this.AddSubtask.Text = "Add Subtask ";
            // 
            // panel
            // 
            this.panel.AllowUserToAddRows = false;
            this.panel.AllowUserToDeleteRows = false;
            this.panel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panel.Location = new System.Drawing.Point(336, 54);
            this.panel.Name = "panel";
            this.panel.ReadOnly = true;
            this.panel.Size = new System.Drawing.Size(651, 202);
            this.panel.TabIndex = 1;
            // 
            // UpdateOp
            // 
            this.UpdateOp.AutoSize = true;
            this.UpdateOp.Location = new System.Drawing.Point(912, 297);
            this.UpdateOp.Name = "UpdateOp";
            this.UpdateOp.Size = new System.Drawing.Size(60, 17);
            this.UpdateOp.TabIndex = 2;
            this.UpdateOp.TabStop = true;
            this.UpdateOp.Text = "Update";
            this.UpdateOp.UseVisualStyleBackColor = true;
            this.UpdateOp.CheckedChanged += new System.EventHandler(this.UpdateOp_CheckedChanged);
            // 
            // DelOp
            // 
            this.DelOp.AutoSize = true;
            this.DelOp.Location = new System.Drawing.Point(912, 320);
            this.DelOp.Name = "DelOp";
            this.DelOp.Size = new System.Drawing.Size(56, 17);
            this.DelOp.TabIndex = 3;
            this.DelOp.TabStop = true;
            this.DelOp.Text = "Delete";
            this.DelOp.UseVisualStyleBackColor = true;
            this.DelOp.CheckedChanged += new System.EventHandler(this.DelOp_CheckedChanged);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(912, 262);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // newOp
            // 
            this.newOp.AutoSize = true;
            this.newOp.Location = new System.Drawing.Point(912, 343);
            this.newOp.Name = "newOp";
            this.newOp.Size = new System.Drawing.Size(89, 17);
            this.newOp.TabIndex = 5;
            this.newOp.TabStop = true;
            this.newOp.Text = "New Subtask";
            this.newOp.UseVisualStyleBackColor = true;
            this.newOp.Visible = false;
            this.newOp.CheckedChanged += new System.EventHandler(this.newOp_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nam
            // 
            this.nam.Location = new System.Drawing.Point(689, 326);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(75, 23);
            this.nam.TabIndex = 11;
            this.nam.Text = "Search";
            this.nam.UseVisualStyleBackColor = true;
            this.nam.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(559, 326);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(124, 20);
            this.name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subtask Name";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1258, 60);
            this.logo.TabIndex = 12;
            // 
            // Add_Subtask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1242, 599);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newOp);
            this.Controls.Add(this.view);
            this.Controls.Add(this.DelOp);
            this.Controls.Add(this.UpdateOp);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Subtask";
            this.Text = "Add_Subtask";
            this.Load += new System.EventHandler(this.Add_Subtask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView panel;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label sedate;
        private System.Windows.Forms.Label subname;
        private System.Windows.Forms.Label AddSubtask;
        private System.Windows.Forms.Button sDel;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button clear;
        public System.Windows.Forms.ComboBox sproid;
        public System.Windows.Forms.Label pid;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.RadioButton UpdateOp;
        private System.Windows.Forms.RadioButton DelOp;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.RadioButton newOp;
        private System.Windows.Forms.Label pid_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox s_id;
        private System.Windows.Forms.Label subid;
        public System.Windows.Forms.Button add2;
        public System.Windows.Forms.Button add;
        public System.Windows.Forms.Label label_pid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button nam;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Panel logo;

    }
}