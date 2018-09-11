namespace Main.Modules.Event
{
    partial class View_event_D
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
            this.view = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.se = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.AllowUserToAddRows = false;
            this.view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Delete});
            this.view.Location = new System.Drawing.Point(87, 34);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(1080, 356);
            this.view.TabIndex = 0;
            this.view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_CellClick);
            this.view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // ve
            // 
            this.ve.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ve.Location = new System.Drawing.Point(211, 500);
            this.ve.Name = "ve";
            this.ve.Size = new System.Drawing.Size(126, 40);
            this.ve.TabIndex = 1;
            this.ve.Text = "Event Details";
            this.ve.UseVisualStyleBackColor = true;
            this.ve.Click += new System.EventHandler(this.ve_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(354, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Booking Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(501, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hire Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1007, 508);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(645, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Return Details";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(794, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Payment Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // se
            // 
            this.se.Location = new System.Drawing.Point(545, 423);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(136, 20);
            this.se.TabIndex = 7;
            this.se.Visible = false;
            this.se.Enter += new System.EventHandler(this.se_Enter);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(710, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // View_event_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 552);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.se);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ve);
            this.Controls.Add(this.view);
            this.Name = "View_event_D";
            this.Text = "View_event_D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.View_event_D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        public System.Windows.Forms.Button ve;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox se;
        private System.Windows.Forms.Button button5;

    }
}