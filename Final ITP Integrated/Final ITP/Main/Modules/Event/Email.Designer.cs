namespace Main.Modules.Event
{
    partial class Email
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
            this.textmsg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textto = new System.Windows.Forms.TextBox();
            this.textsub = new System.Windows.Forms.TextBox();
            this.textcc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textmsg
            // 
            this.textmsg.Location = new System.Drawing.Point(57, 43);
            this.textmsg.Name = "textmsg";
            this.textmsg.Size = new System.Drawing.Size(355, 336);
            this.textmsg.TabIndex = 0;
            this.textmsg.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "To :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "CC :";
            // 
            // textto
            // 
            this.textto.Location = new System.Drawing.Point(557, 71);
            this.textto.Name = "textto";
            this.textto.Size = new System.Drawing.Size(169, 20);
            this.textto.TabIndex = 8;
            // 
            // textsub
            // 
            this.textsub.Location = new System.Drawing.Point(557, 123);
            this.textsub.Name = "textsub";
            this.textsub.Size = new System.Drawing.Size(169, 20);
            this.textsub.TabIndex = 9;
            // 
            // textcc
            // 
            this.textcc.Location = new System.Drawing.Point(557, 97);
            this.textcc.Name = "textcc";
            this.textcc.Size = new System.Drawing.Size(169, 20);
            this.textcc.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textcc);
            this.Controls.Add(this.textsub);
            this.Controls.Add(this.textto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textmsg);
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textmsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textto;
        private System.Windows.Forms.TextBox textsub;
        private System.Windows.Forms.TextBox textcc;
        private System.Windows.Forms.Button button1;
    }
}