namespace Main.Modules.Project_Management
{
    partial class ProjectEvaluation_GraphicalRepresentation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.projectchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.project = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.projectschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.projects = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectchart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectschart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.projectchart);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.project);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 585);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // projectchart
            // 
            chartArea1.Name = "ChartArea1";
            this.projectchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.projectchart.Legends.Add(legend1);
            this.projectchart.Location = new System.Drawing.Point(11, 47);
            this.projectchart.Name = "projectchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "project";
            this.projectchart.Series.Add(series1);
            this.projectchart.Size = new System.Drawing.Size(594, 480);
            this.projectchart.TabIndex = 4;
            this.projectchart.Text = "chart1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 551);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProjectID";
            // 
            // project
            // 
            this.project.Location = new System.Drawing.Point(317, 549);
            this.project.Name = "project";
            this.project.Size = new System.Drawing.Size(101, 23);
            this.project.TabIndex = 1;
            this.project.Text = "Create Graph";
            this.project.UseVisualStyleBackColor = true;
            this.project.Click += new System.EventHandler(this.project_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Graphical Representation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.projectschart);
            this.panel2.Controls.Add(this.projects);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(631, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 585);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(9, 554);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // projectschart
            // 
            chartArea2.Name = "ChartArea1";
            this.projectschart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.projectschart.Legends.Add(legend2);
            this.projectschart.Location = new System.Drawing.Point(9, 47);
            this.projectschart.Name = "projectschart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "projects";
            this.projectschart.Series.Add(series2);
            this.projectschart.Size = new System.Drawing.Size(609, 480);
            this.projectschart.TabIndex = 5;
            this.projectschart.Text = "chart2";
            // 
            // projects
            // 
            this.projects.Location = new System.Drawing.Point(462, 554);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(101, 23);
            this.projects.TabIndex = 4;
            this.projects.Text = "Create Graph";
            this.projects.UseVisualStyleBackColor = true;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Projects Graphical Representation";
            // 
            // ProjectEvaluation_GraphicalRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProjectEvaluation_GraphicalRepresentation";
            this.Text = "ProjectEvaluation_GraphicalRepresentation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectEvaluation_GraphicalRepresentation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectchart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectschart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button project;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart projectchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart projectschart;
        private System.Windows.Forms.Button cancel;
    }
}