using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadex0._1
{
    public partial class TeacherPanel : UserControl
    {
        public TeacherPanel()
        {
            InitializeComponent();
            MakeRounded(panel1,30);
            MakeRounded(Logo, 50);
            this.Dock = DockStyle.Fill;
            gradeStatistics1.loadStats(students_Panel1.MyStudents, students_Panel1.MySubjects);
        }
        public static void MakeRounded(Control control, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int w = control.Width, h = control.Height;
            int d = radius * 2;

            path.StartFigure();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(w - d, 0, d, d, 270, 90);
            path.AddArc(w - d, h - d, d, d, 0, 90);
            path.AddArc(0, h - d, d, d, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
        private void switchPanel(UserControl thisPanel)
        {

            students_Panel1.Hide();
            gradeStatistics1.Hide();
            
            thisPanel.Show();
            thisPanel.BringToFront();
        }
        private void StudentListButton_Click(object sender, EventArgs e)
        {
            switchPanel(students_Panel1);
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            switchPanel(gradeStatistics1);
            gradeStatistics1.updateStats();
        }
    }
}
