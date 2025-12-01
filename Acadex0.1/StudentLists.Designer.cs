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
            this.studentTab1 = new Acadex0._1.StudentTab();
            this.newStudent = new System.Windows.Forms.Button();
            this.StudentListBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentListBar
            // 
            this.StudentListBar.AutoScroll = true;
            this.StudentListBar.Controls.Add(this.studentTab1);
            this.StudentListBar.Location = new System.Drawing.Point(0, 51);
            this.StudentListBar.Name = "StudentListBar";
            this.StudentListBar.Size = new System.Drawing.Size(499, 448);
            this.StudentListBar.TabIndex = 2;
            // 
            // studentTab1
            // 
            this.studentTab1.Location = new System.Drawing.Point(0, 25);
            this.studentTab1.Name = "studentTab1";
            this.studentTab1.Size = new System.Drawing.Size(500, 50);
            this.studentTab1.TabIndex = 1;
            // 
            // newStudent
            // 
            this.newStudent.Location = new System.Drawing.Point(367, 10);
            this.newStudent.Name = "newStudent";
            this.newStudent.Size = new System.Drawing.Size(116, 35);
            this.newStudent.TabIndex = 3;
            this.newStudent.Text = "Add Student";
            this.newStudent.UseVisualStyleBackColor = true;
            this.newStudent.Click += new System.EventHandler(this.newStudent_Click);
            // 
            // StudentLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
