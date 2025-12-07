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
        public static bool isInStudents(Student temp) {
            return Students.Any(s =>
            s.ID == temp.ID 
            );
        }

        public List<(string abbreviation, string name)> MySubjects = new List<(string abbreviation, string name)>();

        private void UpdateSubjects()
        {
            // Clear list so unused subjects disappear automatically
            MySubjects.Clear();

            // Loop through all students
            foreach (var stu in Students)
            {
                // Find the subject definition in the master list
                var subjectDef = DataBase1.Subjects
                    .FirstOrDefault(s => s.abbreviation == stu.subject);

                // Add to MySubjects only if it exists and is not already added
                if (subjectDef != default && !MySubjects.Any(x => x.abbreviation == subjectDef.abbreviation))
                {
                    MySubjects.Add(subjectDef);
                }
            }
            UpdateSections();
        }


        public List<string> MySections = new List<string>();

        private void UpdateSections()
        {
            // Clear the list so old/unused sections disappear
            MySections.Clear();

            // Loop through all students
            foreach (var stu in Students)
            {
                // Add section only if it's not already in the list
                if (!string.IsNullOrEmpty(stu.section) && !MySections.Contains(stu.section))
                {
                    MySections.Add(stu.section);
                }
            }

            // Optional: debug output
            DebugShowSections();
        }

        private void DebugShowSections()
        {
            string result = string.Join("\n", MySections);
            MessageBox.Show(result == "" ? "No sections found" : result);
        }

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
            removeMode = false;
            foreach (Control c in StudentListBar.Controls)
            {
                if (c is StudentTab tab)
                {
                    tab.removeModeOff();
                }
            }
        }
        public void updateList() {
            UpdateSubjects();
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

                thisTab.StudentListLoc = index;

                thisTab.OpenStudentInfo += OnStudentTabClicked;
                thisTab.removeStudentInfo += OnStudentTabRemoved;

                  
                index++;

                StudentListBar.Controls.Add(thisTab);
            }
        }

        public void OnStudentTabClicked(int index) {
            OpenStudentInfo?.Invoke(index);
        }
        public void OnStudentTabRemoved(int index)
        {
            if (index >= 0 && index < Students.Count)
            {
                Students.RemoveAt(index);     // remove student
                updateList();                 // refresh UI
                foreach (Control c in StudentListBar.Controls)
                {
                    if (c is StudentTab tab)
                    {
                        if (removeMode) tab.removeModeOn();
                        else tab.removeModeOff();
                    }
                }
            }
        }


        public event Action <int>OpenStudentInfo;
        private void InputStudent_SubmitClicked()
        {
            updateList();
        }
        private bool removeMode = false; 
        private void removeStudent_Click(object sender, EventArgs e)
        {
            if (!removeMode)
            {
                foreach (Control c in StudentListBar.Controls)
                {
                    if (c is StudentTab tab)
                    {
                        tab.removeModeOn();
                    }
                }
                removeMode = true;
            }
            else
            {
                foreach (Control c in StudentListBar.Controls)
                {
                    if (c is StudentTab tab)
                    {
                        tab.removeModeOff();
                    }
                }
                removeMode = false;
            }
        }

    }

}



