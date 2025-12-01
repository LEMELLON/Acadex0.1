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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grades = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentSection = new System.Windows.Forms.Label();
            this.StudentSubject = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Add_StudentGrade = new System.Windows.Forms.Button();
            this.Activity_Name = new System.Windows.Forms.TextBox();
            this.Activity_Grade = new System.Windows.Forms.TextBox();
            this.student_Grade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InvalidInputText = new System.Windows.Forms.Label();
            this.ActivityName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Grades);
            this.panel1.Location = new System.Drawing.Point(14, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 220);
            this.panel1.TabIndex = 1;
            // 
            // Grades
            // 
            this.Grades.AllowUserToAddRows = false;
            this.Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grades.Location = new System.Drawing.Point(0, 0);
            this.Grades.Name = "Grades";
            this.Grades.ReadOnly = true;
            this.Grades.RowHeadersWidth = 51;
            this.Grades.RowTemplate.Height = 24;
            this.Grades.Size = new System.Drawing.Size(449, 220);
            this.Grades.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(32, 66);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(44, 16);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "Name";
            // 
            // StudentSection
            // 
            this.StudentSection.AutoSize = true;
            this.StudentSection.Location = new System.Drawing.Point(32, 106);
            this.StudentSection.Name = "StudentSection";
            this.StudentSection.Size = new System.Drawing.Size(52, 16);
            this.StudentSection.TabIndex = 2;
            this.StudentSection.Text = "Section";
            // 
            // StudentSubject
            // 
            this.StudentSubject.AutoSize = true;
            this.StudentSubject.Location = new System.Drawing.Point(32, 143);
            this.StudentSubject.Name = "StudentSubject";
            this.StudentSubject.Size = new System.Drawing.Size(52, 16);
            this.StudentSubject.TabIndex = 3;
            this.StudentSubject.Text = "Subject";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(32, 173);
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
            this.Add_StudentGrade.Location = new System.Drawing.Point(400, 173);
            this.Add_StudentGrade.Name = "Add_StudentGrade";
            this.Add_StudentGrade.Size = new System.Drawing.Size(49, 30);
            this.Add_StudentGrade.TabIndex = 6;
            this.Add_StudentGrade.Text = "Add";
            this.Add_StudentGrade.UseVisualStyleBackColor = true;
            this.Add_StudentGrade.Click += new System.EventHandler(this.AddGrade_Button);
            // 
            // Activity_Name
            // 
            this.Activity_Name.Location = new System.Drawing.Point(223, 155);
            this.Activity_Name.Name = "Activity_Name";
            this.Activity_Name.Size = new System.Drawing.Size(158, 22);
            this.Activity_Name.TabIndex = 7;
            this.Activity_Name.TextChanged += new System.EventHandler(this.Activity_Name_TextChanged);
            // 
            // Activity_Grade
            // 
            this.Activity_Grade.Location = new System.Drawing.Point(223, 196);
            this.Activity_Grade.Name = "Activity_Grade";
            this.Activity_Grade.Size = new System.Drawing.Size(157, 22);
            this.Activity_Grade.TabIndex = 8;
            this.Activity_Grade.TextChanged += new System.EventHandler(this.Activity_Grade_TextChanged);
            // 
            // student_Grade
            // 
            this.student_Grade.AutoSize = true;
            this.student_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Grade.Location = new System.Drawing.Point(311, 66);
            this.student_Grade.Name = "student_Grade";
            this.student_Grade.Size = new System.Drawing.Size(55, 39);
            this.student_Grade.TabIndex = 9;
            this.student_Grade.Text = "90";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "AVG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Activity";
            // 
            // InvalidInputText
            // 
            this.InvalidInputText.AutoSize = true;
            this.InvalidInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidInputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InvalidInputText.Location = new System.Drawing.Point(184, 183);
            this.InvalidInputText.Name = "InvalidInputText";
            this.InvalidInputText.Size = new System.Drawing.Size(94, 16);
            this.InvalidInputText.TabIndex = 13;
            this.InvalidInputText.Text = "Activity_Grade";
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSize = true;
            this.ActivityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ActivityName.Location = new System.Drawing.Point(184, 136);
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Size = new System.Drawing.Size(94, 16);
            this.ActivityName.TabIndex = 14;
            this.ActivityName.Text = "Activity_Grade";
            // 
            // Student_InfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ActivityName);
            this.Controls.Add(this.InvalidInputText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student_Grade);
            this.Controls.Add(this.Activity_Grade);
            this.Controls.Add(this.Activity_Name);
            this.Controls.Add(this.Add_StudentGrade);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentSubject);
            this.Controls.Add(this.StudentSection);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.panel1);
            this.Name = "Student_InfoPanel";
            this.Size = new System.Drawing.Size(479, 500);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentSection;
        private System.Windows.Forms.Label StudentSubject;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.Button Add_StudentGrade;
        private System.Windows.Forms.TextBox Activity_Name;
        private System.Windows.Forms.TextBox Activity_Grade;
        private System.Windows.Forms.DataGridView Grades;
        private System.Windows.Forms.Label student_Grade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label InvalidInputText;
        private System.Windows.Forms.Label ActivityName;
    }
}
