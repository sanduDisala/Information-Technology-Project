namespace Main.Modules.Customer
{
    partial class birthdayEmail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtmsg);
            this.groupBox1.Controls.Add(this.txtcc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsub);
            this.groupBox1.Controls.Add(this.txtto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(43, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 279);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create mail";
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(164, 164);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmsg.Size = new System.Drawing.Size(525, 91);
            this.txtmsg.TabIndex = 8;
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(164, 81);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(525, 20);
            this.txtcc.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(164, 120);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(525, 20);
            this.txtsub.TabIndex = 9;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(164, 42);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(525, 20);
            this.txtto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send Mail";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthdayEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "birthdayEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "birthdayEmail";
            this.Load += new System.EventHandler(this.birthdayEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtcc;
    }
}