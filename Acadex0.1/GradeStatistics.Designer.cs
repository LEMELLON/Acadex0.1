namespace Acadex0._1
{
    partial class GradeStatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.Grades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BestStudent = new Acadex0._1.StudentTab();
            this.WorstStudent = new Acadex0._1.StudentTab();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BS_Grade = new System.Windows.Forms.Label();
            this.WS_Grade = new System.Windows.Forms.Label();
            this.SubjectFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(249, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stats";
            // 
            // Grades
            // 
            chartArea3.Name = "ChartArea1";
            this.Grades.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Grades.Legends.Add(legend3);
            this.Grades.Location = new System.Drawing.Point(12, 22);
            this.Grades.Name = "Grades";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Grades.Series.Add(series3);
            this.Grades.Size = new System.Drawing.Size(311, 232);
            this.Grades.TabIndex = 2;
            this.Grades.Text = "chart1";
            // 
            // BestStudent
            // 
            this.BestStudent.Location = new System.Drawing.Point(23, 311);
            this.BestStudent.Name = "BestStudent";
            this.BestStudent.Size = new System.Drawing.Size(500, 50);
            this.BestStudent.TabIndex = 3;
            // 
            // WorstStudent
            // 
            this.WorstStudent.Location = new System.Drawing.Point(23, 405);
            this.WorstStudent.Name = "WorstStudent";
            this.WorstStudent.Size = new System.Drawing.Size(500, 50);
            this.WorstStudent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lowest Average";
            // 
            // BS_Grade
            // 
            this.BS_Grade.AutoSize = true;
            this.BS_Grade.Location = new System.Drawing.Point(169, 276);
            this.BS_Grade.Name = "BS_Grade";
            this.BS_Grade.Size = new System.Drawing.Size(0, 16);
            this.BS_Grade.TabIndex = 7;
            // 
            // WS_Grade
            // 
            this.WS_Grade.AutoSize = true;
            this.WS_Grade.Location = new System.Drawing.Point(169, 376);
            this.WS_Grade.Name = "WS_Grade";
            this.WS_Grade.Size = new System.Drawing.Size(0, 16);
            this.WS_Grade.TabIndex = 8;
            // 
            // SubjectFilter
            // 
            this.SubjectFilter.FormattingEnabled = true;
            this.SubjectFilter.Location = new System.Drawing.Point(356, 235);
            this.SubjectFilter.Name = "SubjectFilter";
            this.SubjectFilter.Size = new System.Drawing.Size(139, 24);
            this.SubjectFilter.TabIndex = 9;
            // 
            // GradeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubjectFilter);
            this.Controls.Add(this.WS_Grade);
            this.Controls.Add(this.BS_Grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorstStudent);
            this.Controls.Add(this.BestStudent);
            this.Controls.Add(this.Grades);
            this.Controls.Add(this.label1);
            this.Name = "GradeStatistics";
            this.Size = new System.Drawing.Size(533, 493);
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grades;
        private StudentTab BestStudent;
        private StudentTab WorstStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BS_Grade;
        private System.Windows.Forms.Label WS_Grade;
        private System.Windows.Forms.ComboBox SubjectFilter;
    }
}
