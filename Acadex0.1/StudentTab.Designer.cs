namespace Acadex0._1
{
    partial class StudentTab
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
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentSection = new System.Windows.Forms.Label();
            this.StudentSubject = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(3, 18);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(44, 16);
            this.StudentName.TabIndex = 0;
            this.StudentName.Text = "Name";
            // 
            // StudentSection
            // 
            this.StudentSection.AutoSize = true;
            this.StudentSection.Location = new System.Drawing.Point(158, 17);
            this.StudentSection.Name = "StudentSection";
            this.StudentSection.Size = new System.Drawing.Size(52, 16);
            this.StudentSection.TabIndex = 1;
            this.StudentSection.Text = "Section";
            // 
            // StudentSubject
            // 
            this.StudentSubject.AutoSize = true;
            this.StudentSubject.Location = new System.Drawing.Point(272, 16);
            this.StudentSubject.Name = "StudentSubject";
            this.StudentSubject.Size = new System.Drawing.Size(52, 16);
            this.StudentSubject.TabIndex = 2;
            this.StudentSubject.Text = "Subject";
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(375, 17);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(20, 16);
            this.StudentID.TabIndex = 3;
            this.StudentID.Text = "ID";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(452, 8);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(35, 33);
            this.remove.TabIndex = 4;
            this.remove.Text = "x";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // StudentTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remove);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.StudentSubject);
            this.Controls.Add(this.StudentSection);
            this.Controls.Add(this.StudentName);
            this.Name = "StudentTab";
            this.Size = new System.Drawing.Size(500, 50);
            this.Load += new System.EventHandler(this.StudentTab_Load);
            this.Click += new System.EventHandler(this.Tab_Clicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentSection;
        private System.Windows.Forms.Label StudentSubject;
        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Button remove;
    }
}
