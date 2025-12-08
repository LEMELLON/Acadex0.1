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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Grades = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BS_Grade = new System.Windows.Forms.Label();
            this.WS_Grade = new System.Windows.Forms.Label();
            this.SubjectFilter = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.Button();
            this.SectionFilter = new System.Windows.Forms.ComboBox();
            this.Chart_Panel = new System.Windows.Forms.Panel();
            this.W_Panel = new System.Windows.Forms.Panel();
            this.H_Panel = new System.Windows.Forms.Panel();
            this.Sort_Panel = new System.Windows.Forms.Panel();
            this.Banner_Pannel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.BestStudent = new Acadex0._1.StudentTab();
            this.WorstStudent = new Acadex0._1.StudentTab();
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).BeginInit();
            this.Chart_Panel.SuspendLayout();
            this.W_Panel.SuspendLayout();
            this.H_Panel.SuspendLayout();
            this.Sort_Panel.SuspendLayout();
            this.Banner_Pannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grades
            // 
            chartArea1.Name = "ChartArea1";
            this.Grades.ChartAreas.Add(chartArea1);
            this.Grades.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Grades.Legends.Add(legend1);
            this.Grades.Location = new System.Drawing.Point(0, 0);
            this.Grades.Name = "Grades";
            this.Grades.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grades.Series.Add(series1);
            this.Grades.Size = new System.Drawing.Size(600, 600);
            this.Grades.TabIndex = 2;
            this.Grades.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest Average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lowest Average";
            // 
            // BS_Grade
            // 
            this.BS_Grade.AutoSize = true;
            this.BS_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BS_Grade.Location = new System.Drawing.Point(324, 13);
            this.BS_Grade.Name = "BS_Grade";
            this.BS_Grade.Size = new System.Drawing.Size(41, 32);
            this.BS_Grade.TabIndex = 7;
            this.BS_Grade.Text = "---";
            // 
            // WS_Grade
            // 
            this.WS_Grade.AutoSize = true;
            this.WS_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WS_Grade.Location = new System.Drawing.Point(324, 15);
            this.WS_Grade.Name = "WS_Grade";
            this.WS_Grade.Size = new System.Drawing.Size(50, 32);
            this.WS_Grade.TabIndex = 8;
            this.WS_Grade.Text = "----";
            // 
            // SubjectFilter
            // 
            this.SubjectFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectFilter.FormattingEnabled = true;
            this.SubjectFilter.Location = new System.Drawing.Point(31, 133);
            this.SubjectFilter.Name = "SubjectFilter";
            this.SubjectFilter.Size = new System.Drawing.Size(307, 33);
            this.SubjectFilter.TabIndex = 9;
            // 
            // filter
            // 
            this.filter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filter.Location = new System.Drawing.Point(387, 120);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(95, 46);
            this.filter.TabIndex = 10;
            this.filter.Text = "Sort";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // SectionFilter
            // 
            this.SectionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionFilter.FormattingEnabled = true;
            this.SectionFilter.Location = new System.Drawing.Point(31, 49);
            this.SectionFilter.Name = "SectionFilter";
            this.SectionFilter.Size = new System.Drawing.Size(307, 33);
            this.SectionFilter.TabIndex = 11;
            // 
            // Chart_Panel
            // 
            this.Chart_Panel.Controls.Add(this.Grades);
            this.Chart_Panel.Location = new System.Drawing.Point(20, 223);
            this.Chart_Panel.Name = "Chart_Panel";
            this.Chart_Panel.Size = new System.Drawing.Size(600, 600);
            this.Chart_Panel.TabIndex = 12;
            // 
            // W_Panel
            // 
            this.W_Panel.BackColor = System.Drawing.Color.White;
            this.W_Panel.Controls.Add(this.WS_Grade);
            this.W_Panel.Controls.Add(this.WorstStudent);
            this.W_Panel.Controls.Add(this.label3);
            this.W_Panel.Location = new System.Drawing.Point(635, 664);
            this.W_Panel.Name = "W_Panel";
            this.W_Panel.Size = new System.Drawing.Size(525, 130);
            this.W_Panel.TabIndex = 13;
            // 
            // H_Panel
            // 
            this.H_Panel.BackColor = System.Drawing.Color.White;
            this.H_Panel.Controls.Add(this.BS_Grade);
            this.H_Panel.Controls.Add(this.BestStudent);
            this.H_Panel.Controls.Add(this.label2);
            this.H_Panel.Location = new System.Drawing.Point(635, 477);
            this.H_Panel.Name = "H_Panel";
            this.H_Panel.Size = new System.Drawing.Size(525, 130);
            this.H_Panel.TabIndex = 14;
            // 
            // Sort_Panel
            // 
            this.Sort_Panel.BackColor = System.Drawing.Color.White;
            this.Sort_Panel.Controls.Add(this.SubjectFilter);
            this.Sort_Panel.Controls.Add(this.filter);
            this.Sort_Panel.Controls.Add(this.SectionFilter);
            this.Sort_Panel.Location = new System.Drawing.Point(638, 242);
            this.Sort_Panel.Name = "Sort_Panel";
            this.Sort_Panel.Size = new System.Drawing.Size(522, 208);
            this.Sort_Panel.TabIndex = 15;
            // 
            // Banner_Pannel
            // 
            this.Banner_Pannel.BackColor = System.Drawing.Color.White;
            this.Banner_Pannel.Controls.Add(this.panel8);
            this.Banner_Pannel.Controls.Add(this.label4);
            this.Banner_Pannel.Controls.Add(this.label1);
            this.Banner_Pannel.Location = new System.Drawing.Point(20, 19);
            this.Banner_Pannel.Name = "Banner_Pannel";
            this.Banner_Pannel.Size = new System.Drawing.Size(1140, 188);
            this.Banner_Pannel.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(1056, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 81);
            this.panel8.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 108);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Students Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 76);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(440, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bringing order to your student life.\r\n";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(1116, -50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 242);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(1084, 131);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 143);
            this.panel6.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(1058, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 81);
            this.panel7.TabIndex = 23;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel9.Location = new System.Drawing.Point(1110, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 81);
            this.panel9.TabIndex = 25;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel10.Location = new System.Drawing.Point(1135, 145);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(17, 81);
            this.panel10.TabIndex = 26;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel11.Location = new System.Drawing.Point(-40, 32);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(151, 18);
            this.panel11.TabIndex = 22;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel12.Location = new System.Drawing.Point(56, 8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(180, 18);
            this.panel12.TabIndex = 23;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel13.Location = new System.Drawing.Point(3, 56);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(75, 12);
            this.panel13.TabIndex = 24;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel14.Location = new System.Drawing.Point(25, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(75, 12);
            this.panel14.TabIndex = 25;
            // 
            // BestStudent
            // 
            this.BestStudent.Location = new System.Drawing.Point(13, 68);
            this.BestStudent.Name = "BestStudent";
            this.BestStudent.Size = new System.Drawing.Size(500, 50);
            this.BestStudent.TabIndex = 3;
            // 
            // WorstStudent
            // 
            this.WorstStudent.Location = new System.Drawing.Point(13, 60);
            this.WorstStudent.Name = "WorstStudent";
            this.WorstStudent.Size = new System.Drawing.Size(500, 50);
            this.WorstStudent.TabIndex = 4;
            // 
            // GradeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Banner_Pannel);
            this.Controls.Add(this.Sort_Panel);
            this.Controls.Add(this.H_Panel);
            this.Controls.Add(this.W_Panel);
            this.Controls.Add(this.Chart_Panel);
            this.Name = "GradeStatistics";
            this.Size = new System.Drawing.Size(1173, 853);
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).EndInit();
            this.Chart_Panel.ResumeLayout(false);
            this.W_Panel.ResumeLayout(false);
            this.W_Panel.PerformLayout();
            this.H_Panel.ResumeLayout(false);
            this.H_Panel.PerformLayout();
            this.Sort_Panel.ResumeLayout(false);
            this.Banner_Pannel.ResumeLayout(false);
            this.Banner_Pannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart Grades;
        private StudentTab BestStudent;
        private StudentTab WorstStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BS_Grade;
        private System.Windows.Forms.Label WS_Grade;
        private System.Windows.Forms.ComboBox SubjectFilter;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.ComboBox SectionFilter;
        private System.Windows.Forms.Panel Chart_Panel;
        private System.Windows.Forms.Panel W_Panel;
        private System.Windows.Forms.Panel H_Panel;
        private System.Windows.Forms.Panel Sort_Panel;
        private System.Windows.Forms.Panel Banner_Pannel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
    }
}
