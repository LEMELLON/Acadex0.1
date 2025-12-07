using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Acadex0._1
{
    public partial class StudentLists : UserControl
    {
        InputStudent inputStudent = new InputStudent();

        
         
        public static List<Student> Students = new List<Student>();
        public  List<Student> MyStudents ;
        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public StudentLists()
        {   
            InitializeComponent();
            inputStudent.SubmitClicked += InputStudent_SubmitClicked;
            MyStudents = Students;

        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            inputStudent.Show();
        }
        public void updateList() {
            MyStudents = Students;
            StudentListBar.Controls.Clear();
            int index = 0;
            foreach (Student student in Students)
            {
                StudentTab thisTab = new StudentTab();
                
                thisTab.name=student.name;
                thisTab.ID=student.ID;
                thisTab.section = student.section;
                thisTab.subject = student.subject;
                thisTab.Dock = DockStyle.Top;

                thisTab.OpenStudentInfo += OnStudentTabClicked;

                thisTab.StudentListLoc = index;  
                index++;

                StudentListBar.Controls.Add(thisTab);
            }
        }

        public void OnStudentTabClicked(int index) {
            OpenStudentInfo?.Invoke(index);
        }
        public event Action <int>OpenStudentInfo;
        private void InputStudent_SubmitClicked()
        {
            updateList();
        }
    }

}



