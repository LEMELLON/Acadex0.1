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
            InvalidInputText.Text = "";
            ActivityName.Text = "";
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
            string Temp = "";
            Temp+= student.GetAverage();
            student_Grade.Text = Temp;
            Grades.Columns.Add("Activity", "Activity");
            Grades.Columns.Add("Grade", "Grade");

            foreach (var grade in student.StudentGrades)
            {
                Grades.Rows.Add(grade.Key, grade.Value);
            }
        }


        private void AddGrade_Button(object sender, EventArgs e)
        {
            if (Activity_Name.Text == "") ActivityName.Text = "*Enter A Valid Name";
            else if (int.TryParse(Activity_Grade.Text, out int value))
            {
                if (Convert.ToDouble(Activity_Grade.Text) > 100 || Convert.ToDouble(Activity_Grade.Text) < 1)
                {
                    InvalidInputText.Text = "*Enter A Valid Average Grade";
                }
                else
                {
                    student.StudentGrades.Add(new KeyValuePair<string, string>(Activity_Name.Text, Activity_Grade.Text));
                    clearGradeAdding();
                    updateGrades();
                }

            }
            else
            {
                InvalidInputText.Text = "*Enter A Valid Grade";
            }
        }

        private void Activity_Grade_TextChanged(object sender, EventArgs e)
        {
            InvalidInputText.Text = "";
        }

        private void Activity_Name_TextChanged(object sender, EventArgs e)
        {
            ActivityName.Text = "";
        }
    }
}
