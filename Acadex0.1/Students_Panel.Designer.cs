namespace Acadex0._1
{
    partial class Students_Panel
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
            this.studentLists1 = new Acadex0._1.StudentLists();
            this.student_InfoPanel1 = new Acadex0._1.Student_InfoPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentLists1);
            this.panel1.Controls.Add(this.student_InfoPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 853);
            this.panel1.TabIndex = 0;
            // 
            // studentLists1
            // 
            this.studentLists1.BackColor = System.Drawing.SystemColors.Control;
            this.studentLists1.Location = new System.Drawing.Point(0, 0);
            this.studentLists1.Name = "studentLists1";
            this.studentLists1.Size = new System.Drawing.Size(1173, 853);
            this.studentLists1.TabIndex = 0;
            // 
            // student_InfoPanel1
            // 
            this.student_InfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_InfoPanel1.Location = new System.Drawing.Point(0, 0);
            this.student_InfoPanel1.Name = "student_InfoPanel1";
            this.student_InfoPanel1.Size = new System.Drawing.Size(1173, 853);
            this.student_InfoPanel1.TabIndex = 1;
            // 
            // Students_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Students_Panel";
            this.Size = new System.Drawing.Size(1173, 853);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private StudentLists studentLists1;
        private Student_InfoPanel student_InfoPanel1;
    }
}
