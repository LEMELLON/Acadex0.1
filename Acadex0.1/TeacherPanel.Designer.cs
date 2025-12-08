namespace Acadex0._1
{
    partial class TeacherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.students_Panel1 = new Acadex0._1.Students_Panel();
            this.gradeStatistics1 = new Acadex0._1.GradeStatistics();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.students_Panel1);
            this.panel1.Controls.Add(this.gradeStatistics1);
            this.panel1.Location = new System.Drawing.Point(309, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 859);
            this.panel1.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(8, 35);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(288, 115);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // StudentListButton
            // 
            this.StudentListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentListButton.FlatAppearance.BorderSize = 0;
            this.StudentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentListButton.Location = new System.Drawing.Point(25, 197);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(250, 60);
            this.StudentListButton.TabIndex = 4;
            this.StudentListButton.Text = "              Students";
            this.StudentListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StudentListButton.UseVisualStyleBackColor = true;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // Stat
            // 
            this.Stat.BackColor = System.Drawing.Color.Transparent;
            this.Stat.FlatAppearance.BorderSize = 0;
            this.Stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stat.Location = new System.Drawing.Point(25, 283);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(250, 60);
            this.Stat.TabIndex = 5;
            this.Stat.Text = "              Statistics";
            this.Stat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Stat.UseVisualStyleBackColor = false;
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(42, 297);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Stat_Click);
            // 
            // students_Panel1
            // 
            this.students_Panel1.AutoSize = true;
            this.students_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.students_Panel1.Location = new System.Drawing.Point(3, 0);
            this.students_Panel1.Name = "students_Panel1";
            this.students_Panel1.Size = new System.Drawing.Size(1176, 856);
            this.students_Panel1.TabIndex = 2;
            // 
            // gradeStatistics1
            // 
            this.gradeStatistics1.AutoSize = true;
            this.gradeStatistics1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gradeStatistics1.Location = new System.Drawing.Point(3, 0);
            this.gradeStatistics1.Name = "gradeStatistics1";
            this.gradeStatistics1.Size = new System.Drawing.Size(1163, 826);
            this.gradeStatistics1.TabIndex = 1;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.StudentListButton);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherPanel";
            this.Size = new System.Drawing.Size(1494, 862);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GradeStatistics gradeStatistics1;
        private Students_Panel students_Panel1;
    }
}
