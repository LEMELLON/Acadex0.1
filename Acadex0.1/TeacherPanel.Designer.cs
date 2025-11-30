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
            this.gradeStatistics1 = new Acadex0._1.GradeStatistics();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.StudentListButton = new System.Windows.Forms.Button();
            this.Stat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.students_Panel1 = new Acadex0._1.Students_Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.students_Panel1);
            this.panel1.Controls.Add(this.gradeStatistics1);
            this.panel1.Location = new System.Drawing.Point(145, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 500);
            this.panel1.TabIndex = 0;
            // 
            // gradeStatistics1
            // 
            this.gradeStatistics1.Location = new System.Drawing.Point(0, 0);
            this.gradeStatistics1.Name = "gradeStatistics1";
            this.gradeStatistics1.Size = new System.Drawing.Size(541, 500);
            this.gradeStatistics1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "AcaDex";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Logo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(21, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 131);
            this.panel2.TabIndex = 3;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(15, 14);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(80, 80);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // StudentListButton
            // 
            this.StudentListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StudentListButton.FlatAppearance.BorderSize = 0;
            this.StudentListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentListButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentListButton.Location = new System.Drawing.Point(21, 185);
            this.StudentListButton.Name = "StudentListButton";
            this.StudentListButton.Size = new System.Drawing.Size(118, 35);
            this.StudentListButton.TabIndex = 4;
            this.StudentListButton.Text = "Students";
            this.StudentListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StudentListButton.UseVisualStyleBackColor = true;
            this.StudentListButton.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // Stat
            // 
            this.Stat.BackColor = System.Drawing.Color.Transparent;
            this.Stat.FlatAppearance.BorderSize = 0;
            this.Stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stat.Location = new System.Drawing.Point(21, 235);
            this.Stat.Name = "Stat";
            this.Stat.Size = new System.Drawing.Size(118, 35);
            this.Stat.TabIndex = 5;
            this.Stat.Text = "Statistics";
            this.Stat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Stat.UseVisualStyleBackColor = false;
            this.Stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(33, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.StudentListButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(25, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.Stat_Click);
            // 
            // students_Panel1
            // 
            this.students_Panel1.Location = new System.Drawing.Point(5, 0);
            this.students_Panel1.Name = "students_Panel1";
            this.students_Panel1.Size = new System.Drawing.Size(500, 500);
            this.students_Panel1.TabIndex = 2;
            // 
            // TeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Stat);
            this.Controls.Add(this.StudentListButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherPanel";
            this.Size = new System.Drawing.Size(650, 500);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button StudentListButton;
        private System.Windows.Forms.Button Stat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private GradeStatistics gradeStatistics1;
        private Students_Panel students_Panel1;
    }
}
