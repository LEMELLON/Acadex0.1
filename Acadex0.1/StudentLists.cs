using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Acadex0._1
{
    public partial class StudentLists : UserControl
    {
        InputStudent inputStudent = new InputStudent();

        public static List<string> SectionList = new List<string>();

        public static List<Student> Students = new List<Student>();
        public static void AddStudent(Student student)
        {
            Students.Add(student);

        }
        public StudentLists()
        {   
            InitializeComponent();
            inputStudent.SubmitClicked += inputStudent_SubmitClicked;
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            inputStudent.Show();
        }
        public void updateList() {
            StudentListBar.Controls.Clear();
            foreach (Student student in Students)
            {
                StudentTab thisTab = new StudentTab();
                thisTab.name=student.name;
                thisTab.ID=student.ID;
                thisTab.section = student.section;
                thisTab.subject = student.subject;
                thisTab.Dock = DockStyle.Top;
                StudentListBar.Controls.Add(thisTab);
            }
        }

       

        private void inputStudent_SubmitClicked()
        {
            updateList();
        }
    }
    public class Student
    {
        public string ID;
        public string name;
        public string section;
        public string subject;
        public Student(String name, string ID, String section, String subject)
        {
            this.name = name;
            this.ID = ID;
            this.section = section;
            this.subject = subject;
        }
    }
}
