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
            this.StudentListBar = new System.Windows.Forms.Panel();
            this.newStudent = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            this.subjectFillter = new System.Windows.Forms.ComboBox();
            this.filtter = new System.Windows.Forms.Button();
            this.sectionFilter = new System.Windows.Forms.ComboBox();
            this.studentTab1 = new Acadex0._1.StudentTab();
            this.StudentListBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentListBar
            // 
            this.StudentListBar.AutoScroll = true;
            this.StudentListBar.Controls.Add(this.studentTab1);
            this.StudentListBar.Location = new System.Drawing.Point(0, 87);
            this.StudentListBar.Name = "StudentListBar";
            this.StudentListBar.Size = new System.Drawing.Size(499, 412);
            this.StudentListBar.TabIndex = 2;
            // 
            // newStudent
            // 
            this.newStudent.Location = new System.Drawing.Point(367, 30);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(116, 35);
            this.newStudent.TabIndex = 3;
            this.newStudent.Text = "Add Student";
            this.newStudent.UseVisualStyleBackColor = true;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.Location = new System.Drawing.Point(213, 30);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(148, 35);
            this.removeStudent.TabIndex = 4;
            this.removeStudent.Text = "Remove Student";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // subjectFillter
            // 
            this.subjectFillter.FormattingEnabled = true;
            this.subjectFillter.Location = new System.Drawing.Point(15, 47);
            this.subjectFillter.Name = "subjectFillter";
            this.subjectFillter.Size = new System.Drawing.Size(135, 24);
            this.subjectFillter.TabIndex = 5;
            // 
            // filtter
            // 
            this.filtter.Location = new System.Drawing.Point(156, 33);
            this.filtter.Name = "filtter";
            this.filtter.Size = new System.Drawing.Size(45, 29);
            this.filtter.TabIndex = 6;
            this.filtter.Text = "Sort";
            this.filtter.UseVisualStyleBackColor = true;
            this.filtter.Click += new System.EventHandler(this.filtter_Click);
            // 
            // sectionFilter
            // 
            this.sectionFilter.FormattingEnabled = true;
            this.sectionFilter.Location = new System.Drawing.Point(15, 17);
            this.sectionFilter.Name = "sectionFilter";
            this.sectionFilter.Size = new System.Drawing.Size(135, 24);
            this.sectionFilter.TabIndex = 7;
            // 
            // studentTab1
            // 
            this.studentTab1.Location = new System.Drawing.Point(-3, 338);
            this.studentTab1.Name = "studentTab1";
            this.studentTab1.Size = new System.Drawing.Size(500, 50);
            this.studentTab1.TabIndex = 1;
            // 
            // StudentLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sectionFilter);
            this.Controls.Add(this.filtter);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.subjectFillter);
            this.Controls.Add(this.newStudent);
            this.Controls.Add(this.StudentListBar);
            this.Name = "StudentLists";
            this.Size = new System.Drawing.Size(500, 500);
            this.StudentListBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private StudentTab studentTab1;
        private System.Windows.Forms.Panel StudentListBar;
        private System.Windows.Forms.Button newStudent;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.ComboBox subjectFillter;
        private System.Windows.Forms.Button filtter;
        private System.Windows.Forms.ComboBox sectionFilter;
    }
}
