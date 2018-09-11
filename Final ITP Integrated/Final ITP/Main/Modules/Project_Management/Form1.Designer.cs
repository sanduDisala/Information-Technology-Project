namespace Main.Modules.Project_Management
{
    partial class Form1
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
            this.Add_project = new System.Windows.Forms.Button();
            this.Add_subtask = new System.Windows.Forms.Button();
            this.Allocate_resources = new System.Windows.Forms.Button();
            this.Calcualte_budget = new System.Windows.Forms.Button();
            this.Evaluate_progress = new System.Windows.Forms.Button();
            this.semail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_project
            // 
            this.Add_project.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Add_project.Location = new System.Drawing.Point(59, 44);
            this.Add_project.Name = "Add_project";
            this.Add_project.Size = new System.Drawing.Size(129, 44);
            this.Add_project.TabIndex = 0;
            this.Add_project.Text = "Project";
            this.Add_project.UseVisualStyleBackColor = true;
            this.Add_project.Click += new System.EventHandler(this.Add_project_Click);
            // 
            // Add_subtask
            // 
            this.Add_subtask.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Add_subtask.Location = new System.Drawing.Point(59, 119);
            this.Add_subtask.Name = "Add_subtask";
            this.Add_subtask.Size = new System.Drawing.Size(129, 44);
            this.Add_subtask.TabIndex = 1;
            this.Add_subtask.Text = "Subtask";
            this.Add_subtask.UseVisualStyleBackColor = true;
            this.Add_subtask.Click += new System.EventHandler(this.Add_subtask_Click);
            // 
            // Allocate_resources
            // 
            this.Allocate_resources.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Allocate_resources.Location = new System.Drawing.Point(59, 209);
            this.Allocate_resources.Name = "Allocate_resources";
            this.Allocate_resources.Size = new System.Drawing.Size(129, 44);
            this.Allocate_resources.TabIndex = 3;
            this.Allocate_resources.Text = "Resources";
            this.Allocate_resources.UseVisualStyleBackColor = true;
            this.Allocate_resources.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calcualte_budget
            // 
            this.Calcualte_budget.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Calcualte_budget.Location = new System.Drawing.Point(59, 298);
            this.Calcualte_budget.Name = "Calcualte_budget";
            this.Calcualte_budget.Size = new System.Drawing.Size(129, 44);
            this.Calcualte_budget.TabIndex = 4;
            this.Calcualte_budget.Text = "Calculate Budget";
            this.Calcualte_budget.UseVisualStyleBackColor = true;
            this.Calcualte_budget.Click += new System.EventHandler(this.Calcualte_budget_Click);
            // 
            // Evaluate_progress
            // 
            this.Evaluate_progress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Evaluate_progress.Location = new System.Drawing.Point(59, 386);
            this.Evaluate_progress.Name = "Evaluate_progress";
            this.Evaluate_progress.Size = new System.Drawing.Size(129, 44);
            this.Evaluate_progress.TabIndex = 5;
            this.Evaluate_progress.Text = "Evaluate Progress";
            this.Evaluate_progress.UseVisualStyleBackColor = true;
            this.Evaluate_progress.Click += new System.EventHandler(this.Evaluate_progress_Click);
            // 
            // semail
            // 
            this.semail.Location = new System.Drawing.Point(59, 469);
            this.semail.Name = "semail";
            this.semail.Size = new System.Drawing.Size(129, 44);
            this.semail.TabIndex = 6;
            this.semail.Text = "Send Email";
            this.semail.UseVisualStyleBackColor = true;
            this.semail.Click += new System.EventHandler(this.semail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources.Main_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.semail);
            this.Controls.Add(this.Evaluate_progress);
            this.Controls.Add(this.Calcualte_budget);
            this.Controls.Add(this.Allocate_resources);
            this.Controls.Add(this.Add_subtask);
            this.Controls.Add(this.Add_project);
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_project;
        private System.Windows.Forms.Button Add_subtask;
        private System.Windows.Forms.Button Allocate_resources;
        private System.Windows.Forms.Button Calcualte_budget;
        private System.Windows.Forms.Button Evaluate_progress;
        private System.Windows.Forms.Button semail;
       // private System.Windows.Forms.Button button1;
    }
}

