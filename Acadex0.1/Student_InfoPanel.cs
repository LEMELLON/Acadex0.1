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
    public partial class Student_InfoPanel : UserControl
    {
        public Student student;

        public Student_InfoPanel()
        {
            InitializeComponent();
        }



        public void updateInfo() {
            this.StudentName.Text = student.name;
            this.StudentSection.Text = student.section;
            this.StudentID.Text = student.ID;
            this.StudentSubject.Text = student.subject;

            updateGrades();
        }


        public event Action SwitchToStudentList;

        private void clearGradeAdding() {
            Activity_Name.Text = "";
            Activity_Grade.Text = "";
        }
        private void Return_Button_Click(object sender, EventArgs e)
        {
            SwitchToStudentList?.Invoke();
            clearGradeAdding();
        }

        private void updateGrades() {
            Grades.Columns.Clear();
            Grades.Rows.Clear();

            Grades.Columns.Add("colActivity", "Activity");
            Grades.Columns.Add("colGrade", "Grade");

            foreach (var grade in student.StudentGrades)
            {
                Grades.Rows.Add(grade.Key, grade.Value);
            }
        }

        private void AddGrade_Button(object sender, EventArgs e)
        {
            student.StudentGrades.Add(new KeyValuePair<string, string>(Activity_Name.Text, Activity_Grade.Text));
            clearGradeAdding();
            updateGrades();
        }
    }
}
