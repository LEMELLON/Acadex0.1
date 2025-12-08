namespace Acadex0._1
{
    partial class StudentLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLists));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StudentListBar = new System.Windows.Forms.Panel();
            this.newStudent = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            this.subjectFillter = new System.Windows.Forms.ComboBox();
            this.filtter = new System.Windows.Forms.Button();
            this.sectionFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.List_Panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentAddBar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SortBox = new System.Windows.Forms.Panel();
            this.Picture_Panel = new System.Windows.Forms.Panel();
            this.Banne_Quote = new System.Windows.Forms.Label();
            this.Banner = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Banner_Pic = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Graph_Panel = new System.Windows.Forms.Panel();
            this.SubjectChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ID_Filter = new System.Windows.Forms.ComboBox();
            this.List_Panel.SuspendLayout();
            this.StudentAddBar.SuspendLayout();
            this.SortBox.SuspendLayout();
            this.Picture_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner_Pic)).BeginInit();
            this.Graph_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListBar
            // 
            this.StudentListBar.AutoScroll = true;
            this.StudentListBar.Location = new System.Drawing.Point(11, 66);
            this.StudentListBar.Name = "StudentListBar";
            this.StudentListBar.Size = new System.Drawing.Size(654, 387);
            this.StudentListBar.TabIndex = 2;
            // 
            // newStudent
            // 
            this.newStudent.BackColor = System.Drawing.Color.White;
            this.newStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newStudent.Location = new System.Drawing.Point(601, 15);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(61, 35);
            this.newStudent.TabIndex = 3;
            this.newStudent.Text = "add";
            this.newStudent.UseVisualStyleBackColor = false;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.removeStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.removeStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.removeStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.removeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStudent.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeStudent.Location = new System.Drawing.Point(490, 15);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(95, 35);
            this.removeStudent.TabIndex = 4;
            this.removeStudent.Text = "remove";
            this.removeStudent.UseVisualStyleBackColor = false;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // subjectFillter
            // 
            this.subjectFillter.FormattingEnabled = true;
            this.subjectFillter.Location = new System.Drawing.Point(120, 20);
            this.subjectFillter.Name = "subjectFillter";
            this.subjectFillter.Size = new System.Drawing.Size(226, 24);
            this.subjectFillter.TabIndex = 5;
            // 
            // filtter
            // 
            this.filtter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.filtter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filtter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtter.Location = new System.Drawing.Point(19, 76);
            this.filtter.Name = "filtter";
            this.filtter.Size = new System.Drawing.Size(85, 46);
            this.filtter.TabIndex = 6;
            this.filtter.Text = "sort";
            this.filtter.UseVisualStyleBackColor = true;
            this.filtter.Click += new System.EventHandler(this.filtter_Click);
            // 
            // sectionFilter
            // 
            this.sectionFilter.FormattingEnabled = true;
            this.sectionFilter.Location = new System.Drawing.Point(120, 61);
            this.sectionFilter.Name = "sectionFilter";
            this.sectionFilter.Size = new System.Drawing.Size(226, 24);
            this.sectionFilter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "#  Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(212, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(328, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(492, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 1);
            this.panel1.TabIndex = 12;
            // 
            // List_Panel
            // 
            this.List_Panel.BackColor = System.Drawing.Color.White;
            this.List_Panel.Controls.Add(this.label6);
            this.List_Panel.Controls.Add(this.panel1);
            this.List_Panel.Controls.Add(this.label4);
            this.List_Panel.Controls.Add(this.label3);
            this.List_Panel.Controls.Add(this.label2);
            this.List_Panel.Controls.Add(this.label1);
            this.List_Panel.Controls.Add(this.StudentListBar);
            this.List_Panel.Location = new System.Drawing.Point(38, 361);
            this.List_Panel.Name = "List_Panel";
            this.List_Panel.Size = new System.Drawing.Size(675, 470);
            this.List_Panel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(606, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "##";
            // 
            // StudentAddBar
            // 
            this.StudentAddBar.BackColor = System.Drawing.Color.White;
            this.StudentAddBar.Controls.Add(this.label5);
            this.StudentAddBar.Controls.Add(this.removeStudent);
            this.StudentAddBar.Controls.Add(this.newStudent);
            this.StudentAddBar.Location = new System.Drawing.Point(38, 285);
            this.StudentAddBar.Name = "StudentAddBar";
            this.StudentAddBar.Size = new System.Drawing.Size(674, 65);
            this.StudentAddBar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Linked Students";
            // 
            // SortBox
            // 
            this.SortBox.BackColor = System.Drawing.Color.White;
            this.SortBox.Controls.Add(this.ID_Filter);
            this.SortBox.Controls.Add(this.sectionFilter);
            this.SortBox.Controls.Add(this.filtter);
            this.SortBox.Controls.Add(this.subjectFillter);
            this.SortBox.Location = new System.Drawing.Point(740, 285);
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(372, 144);
            this.SortBox.TabIndex = 15;
            // 
            // Picture_Panel
            // 
            this.Picture_Panel.BackColor = System.Drawing.Color.White;
            this.Picture_Panel.Controls.Add(this.Banne_Quote);
            this.Picture_Panel.Controls.Add(this.Banner);
            this.Picture_Panel.Controls.Add(this.pictureBox2);
            this.Picture_Panel.Controls.Add(this.Banner_Pic);
            this.Picture_Panel.Location = new System.Drawing.Point(38, 18);
            this.Picture_Panel.Name = "Picture_Panel";
            this.Picture_Panel.Size = new System.Drawing.Size(674, 245);
            this.Picture_Panel.TabIndex = 18;
            // 
            // Banne_Quote
            // 
            this.Banne_Quote.AutoSize = true;
            this.Banne_Quote.BackColor = System.Drawing.Color.Black;
            this.Banne_Quote.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banne_Quote.ForeColor = System.Drawing.Color.White;
            this.Banne_Quote.Location = new System.Drawing.Point(16, 159);
            this.Banne_Quote.Name = "Banne_Quote";
            this.Banne_Quote.Size = new System.Drawing.Size(409, 22);
            this.Banne_Quote.TabIndex = 3;
            this.Banne_Quote.Text = "“Focus on growth. Acadex handles the rest.”\r\n";
            // 
            // Banner
            // 
            this.Banner.AutoSize = true;
            this.Banner.BackColor = System.Drawing.Color.Black;
            this.Banner.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banner.ForeColor = System.Drawing.Color.White;
            this.Banner.Location = new System.Drawing.Point(14, 43);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(384, 104);
            this.Banner.TabIndex = 2;
            this.Banner.Text = "Your PROGRESS \r\nORGANIZED.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(547, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Banner_Pic
            // 
            this.Banner_Pic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Banner_Pic.BackgroundImage")));
            this.Banner_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Banner_Pic.Location = new System.Drawing.Point(-35, 1);
            this.Banner_Pic.Name = "Banner_Pic";
            this.Banner_Pic.Size = new System.Drawing.Size(750, 244);
            this.Banner_Pic.TabIndex = 0;
            this.Banner_Pic.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(740, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1129, -18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 242);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(1101, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 207);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(1076, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 133);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(1055, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 66);
            this.panel6.TabIndex = 23;
            // 
            // Graph_Panel
            // 
            this.Graph_Panel.BackColor = System.Drawing.Color.White;
            this.Graph_Panel.Controls.Add(this.SubjectChart);
            this.Graph_Panel.Location = new System.Drawing.Point(740, 457);
            this.Graph_Panel.Name = "Graph_Panel";
            this.Graph_Panel.Size = new System.Drawing.Size(372, 374);
            this.Graph_Panel.TabIndex = 19;
            // 
            // SubjectChart
            // 
            this.SubjectChart.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.SubjectChart.BackColor = System.Drawing.Color.Transparent;
            this.SubjectChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubjectChart.ChartAreas.Add(chartArea1);
            this.SubjectChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.SubjectChart.Legends.Add(legend1);
            this.SubjectChart.Location = new System.Drawing.Point(0, 0);
            this.SubjectChart.Name = "SubjectChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            this.SubjectChart.Series.Add(series1);
            this.SubjectChart.Size = new System.Drawing.Size(372, 374);
            this.SubjectChart.TabIndex = 0;
            this.SubjectChart.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(-11, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 219);
            this.panel2.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel8.Location = new System.Drawing.Point(26, 588);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(21, 133);
            this.panel8.TabIndex = 23;
            // 
            // ID_Filter
            // 
            this.ID_Filter.FormattingEnabled = true;
            this.ID_Filter.Location = new System.Drawing.Point(120, 105);
            this.ID_Filter.Name = "ID_Filter";
            this.ID_Filter.Size = new System.Drawing.Size(226, 24);
            this.ID_Filter.TabIndex = 8;
            // 
            // StudentLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Graph_Panel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Picture_Panel);
            this.Controls.Add(this.SortBox);
            this.Controls.Add(this.StudentAddBar);
            this.Controls.Add(this.List_Panel);
            this.Controls.Add(this.panel8);
            this.Name = "StudentLists";
            this.Size = new System.Drawing.Size(1173, 853);
            this.List_Panel.ResumeLayout(false);
            this.List_Panel.PerformLayout();
            this.StudentAddBar.ResumeLayout(false);
            this.StudentAddBar.PerformLayout();
            this.SortBox.ResumeLayout(false);
            this.Picture_Panel.ResumeLayout(false);
            this.Picture_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banner_Pic)).EndInit();
            this.Graph_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel StudentListBar;
        private System.Windows.Forms.Button newStudent;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.ComboBox subjectFillter;
        private System.Windows.Forms.Button filtter;
        private System.Windows.Forms.ComboBox sectionFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel List_Panel;
        private System.Windows.Forms.Panel StudentAddBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SortBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Picture_Panel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Graph_Panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Banner_Pic;
        private System.Windows.Forms.Label Banner;
        private System.Windows.Forms.Label Banne_Quote;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart SubjectChart;
        private System.Windows.Forms.ComboBox ID_Filter;
    }
}
