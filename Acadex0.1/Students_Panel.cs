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
    public partial class Students_Panel : UserControl
    {
        public List<Student> MyStudents;
        public List<(string abbreviation, string name)> MySubjects;
        public List<string> MySections = new List<string>();
        public Students_Panel()
        {
            InitializeComponent();
            studentLists1.OpenStudentInfo += openInfo;
            student_InfoPanel1.SwitchToStudentList += openList;
            MyStudents = studentLists1.MyStudents;
            MySubjects = studentLists1.MySubjects;
            MySections = studentLists1.MySections;
        }
        private void openInfo(int index)
        {

            studentLists1.Hide();
            student_InfoPanel1.Show();
            student_InfoPanel1.student = studentLists1.MyStudents[index];
            student_InfoPanel1.updateInfo();
        }

        private void openList() {
            studentLists1.Show();
            student_InfoPanel1.Hide();
        }
    }
}
