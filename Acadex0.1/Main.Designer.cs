namespace Acadex0._1
{
    partial class Acadex
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.teacherPanel1 = new Acadex0._1.TeacherPanel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.teacherPanel1);
            this.MainPanel.Location = new System.Drawing.Point(2, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(650, 500);
            this.MainPanel.TabIndex = 1;
            // 
            // teacherPanel1
            // 
            this.teacherPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.teacherPanel1.Location = new System.Drawing.Point(-3, 0);
            this.teacherPanel1.Name = "teacherPanel1";
            this.teacherPanel1.Size = new System.Drawing.Size(650, 500);
            this.teacherPanel1.TabIndex = 1;
            // 
            // Acadex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 498);
            this.Controls.Add(this.MainPanel);
            this.Name = "Acadex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Acadex_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private TeacherPanel teacherPanel1;
    }
}

