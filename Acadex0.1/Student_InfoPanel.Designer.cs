namespace Acadex0._1
{
    partial class Student_InfoPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentSection = new System.Windows.Forms.Label();
            this.StudentSubject = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Add_StudentGrade = new System.Windows.Forms.Button();
            this.Activity_Name = new System.Windows.Forms.TextBox();
            this.Activity_Grade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(24, 50);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(203, 123);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(24, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 220);
            this.panel1.TabIndex = 1;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(254, 50);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(44, 16);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "Name";
            // 
            // StudentSection
            // 
            this.StudentSection.AutoSize = true;
            this.StudentSection.Location = new System.Drawing.Point(254, 84);
            this.StudentSection.Name = "StudentSection";
            this.StudentSection.Size = new System.Drawing.Size(52, 16);
            this.StudentSection.TabIndex = 2;
            this.StudentSection.Text = "Section";
            // 
            // StudentSubject
            // 
            this.StudentSubject.AutoSize = true;
            this.StudentSubject.Location = new System.Drawing.Point(254, 119);
            this.StudentSubject.Name = "StudentSubject";
            this.StudentSubject.Size = new System.Drawing.Size(52, 16);
            this.StudentSubject.TabIndex = 3;
            this.StudentSubject.Text = "Subject";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(254, 157);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(20, 16);
            this.StudentID.TabIndex = 4;
            this.StudentID.Text = "ID";
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(10, 13);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(80, 28);
            this.Return_Button.TabIndex = 5;
            this.Return_Button.Text = "Back";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // Add_StudentGrade
            // 
            this.Add_StudentGrade.Location = new System.Drawing.Point(204, 270);
            this.Add_StudentGrade.Name = "Add_StudentGrade";
            this.Add_StudentGrade.Size = new System.Drawing.Size(49, 30);
            this.Add_StudentGrade.TabIndex = 6;
            this.Add_StudentGrade.Text = "Add";
            this.Add_StudentGrade.UseVisualStyleBackColor = true;
            this.Add_StudentGrade.Click += new System.EventHandler(this.button1_Click);
            // 
            // Activity_Name
            // 
            this.Activity_Name.Location = new System.Drawing.Point(24, 242);
            this.Activity_Name.Name = "Activity_Name";
            this.Activity_Name.Size = new System.Drawing.Size(158, 22);
            this.Activity_Name.TabIndex = 7;
            // 
            // Activity_Grade
            // 
            this.Activity_Grade.Location = new System.Drawing.Point(24, 280);
            this.Activity_Grade.Name = "Activity_Grade";
            this.Activity_Grade.Size = new System.Drawing.Size(157, 22);
            this.Activity_Grade.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // Student_InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.Activity_Grade);
            this.Controls.Add(this.Activity_Name);
            this.Controls.Add(this.Add_StudentGrade);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentSubject);
            this.Controls.Add(this.StudentSection);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Student_InfoPanel";
            this.Size = new System.Drawing.Size(479, 500);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentSection;
        private System.Windows.Forms.Label StudentSubject;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button Add_StudentGrade;
        private System.Windows.Forms.TextBox Activity_Name;
        private System.Windows.Forms.TextBox Activity_Grade;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
