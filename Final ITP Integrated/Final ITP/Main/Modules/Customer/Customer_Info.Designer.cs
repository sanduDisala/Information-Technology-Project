﻿namespace Main.Modules.Customer
{
    partial class Customer_Info
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(100, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 182);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD  CUSTOMER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.Location = new System.Drawing.Point(433, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 182);
            this.button2.TabIndex = 1;
            this.button2.Text = "UPDATE  CUSTOMER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(772, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 184);
            this.button3.TabIndex = 2;
            this.button3.Text = "DELETE  CUSTOMER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Customer_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 581);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Info";
            this.Text = "Customer_Info";
            this.Load += new System.EventHandler(this.Customer_Info_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;


    }
}