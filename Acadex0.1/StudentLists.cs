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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Collections.Specialized.BitVector32;

namespace Acadex0._1
{
    public partial class StudentLists : UserControl
    {

        public StudentLists()
        {
            InitializeComponent();
            // UI setup
            inputStudent.SubmitClicked += InputStudent_SubmitClicked;
            Toolset.MakeRounded(List_Panel, 10);
            Toolset.MakeRounded(StudentAddBar, 10);
            Toolset.MakeRounded(SortBox, 10);
            Toolset.MakeRounded(Picture_Panel, 10);
            Toolset.MakeRounded(Graph_Panel, 10);
            Toolset.MakeTransparent(Banner, Banner_Pic);
            Toolset.MakeTransparent(Banne_Quote, Banner_Pic);
            laodList();
            MyStudents = Students;
            

        }
        public static bool isLoaded = false;
        public void laodList() {
            if (!isLoaded)
            {
                Students = DataBase1.GetMatchingLoadedStudents();
                updateList();
                isLoaded = true;
            }
        }


        InputStudent inputStudent = new InputStudent();
        public static bool isInStudents(Student temp)
        {
            return Students.Any(s =>
                s.ID == temp.ID &&
                s.name == temp.name &&
                s.subject == temp.subject
            );
        }


        public List<(string abbreviation, string name)> MySubjects = new List<(string abbreviation, string name)>();
        public List<(string abbreviation, int amount)> MySubjectsAmount = new List<(string abbreviation, int amount)>();

        private void UpdateSubjects()
        {
            MySubjects.Clear();
            MySubjectsAmount.Clear();

            foreach (var stu in Students)
            {
                var subjectDef = DataBase1.Subjects
                    .FirstOrDefault(s => s.abbreviation == stu.subject);

                if (subjectDef != default && !MySubjects.Any(x => x.abbreviation == subjectDef.abbreviation))
                {
                    MySubjects.Add(subjectDef);
                }
            }

            // --- count how many students for each subject ---
            foreach (var sub in MySubjects)
            {
                int count = Students.Count(s => s.subject == sub.abbreviation);
                MySubjectsAmount.Add((sub.abbreviation, count));
            }

            UpdateSections();
            updateFilter();
        }



        public List<string> MySections = new List<string>();

        private void UpdateSections()
        {
            MySections.Clear();

            foreach (var stu in Students)
            {
                // Add section only if it's not already in the list
                if (!string.IsNullOrEmpty(stu.section) && !MySections.Contains(stu.section))
                {
                    MySections.Add(stu.section);
                }
            }

        }



        public static List<Student> Students = new List<Student>();
        public  List<Student> MyStudents ;
        public  List<Student> MyLaodedStudents ;
        public static void AddStudent(Student student)
        {
            Students.Add(student);
            
        }



        private void newStudent_Click(object sender, EventArgs e)
        {
            inputStudent.Show();
            inputStudent.BringToFront();
            removeMode = false;
            foreach (Control c in StudentListBar.Controls)
            {
                if (c is StudentTab tab)
                {
                    tab.removeModeOff();
                }
            }
        }
        public void updateList()
        {

            UpdateSubjects();
            updateSubChart();


            StudentListBar.Controls.Clear();
            int index = 0;
            foreach (Student student in Students)
            {
                StudentTab thisTab = new StudentTab();

                thisTab.name = student.name;
                thisTab.ID = student.ID;
                thisTab.section = student.section;
                thisTab.subject = student.subject;
                thisTab.Dock = DockStyle.Top;

                thisTab.StudentListLoc = index;

                thisTab.OpenStudentInfo += OnStudentTabClicked;
                thisTab.removeStudentInfo += OnStudentTabRemoved;


                index++;

                StudentListBar.Controls.Add(thisTab);
            }
            DataBase1.LoadedStudents = Students;
            DataBase1.SaveLoadedStudents();

            filterList();
        }



        public void updateFilter()
        {
            // --- Subject Filter ---
            if (MySubjects != null)
            {
                subjectFillter.Items.Clear();
                subjectFillter.Items.Add("All Subjects");

                foreach (var s in MySubjects)
                {
                    subjectFillter.Items.Add($"{s.abbreviation} - {s.name}");
                }

                subjectFillter.SelectedIndex = 0;
            }

            // --- Section Filter ---
            if (MySections != null)
            {
                sectionFilter.Items.Clear();
                sectionFilter.Items.Add("All Sections");

                foreach (var sec in MySections)
                {
                    sectionFilter.Items.Add(sec);
                }

                sectionFilter.SelectedIndex = 0;
            }

            // --- ID Filter (ComboBox) ---
            if (ID_Filter != null) // ComboBox exists
            {
                ID_Filter.Items.Clear();
                ID_Filter.Items.Add("All IDs");

                // Get distinct student IDs
                var ids = Students
                    .Where(s => !string.IsNullOrWhiteSpace(s.ID))
                    .Select(s => s.ID.Trim())
                    .Distinct()
                    .OrderBy(id => id)
                    .ToList();


                foreach (string id in ids)
                {
                    ID_Filter.Items.Add(id);
                }

                ID_Filter.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// BUTTONS
        /// </summary>


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
        private void filtter_Click(object sender, EventArgs e)
        {
            filterList();
        }

        private void filterList()
        {
            if (Students == null || Students.Count == 0) return;

            // Start with all students
            List<Student> filteredStudents = Students;

            // --- Filter by Subject ---
            if (subjectFillter.SelectedIndex > 0 && subjectFillter.SelectedItem.ToString() != "All Subjects")
            {
                string abbrev = subjectFillter.SelectedItem.ToString().Split('-')[0].Trim();
                filteredStudents = filteredStudents.Where(s => s.subject.Trim() == abbrev).ToList();
            }

            // --- Filter by Section ---
            if (sectionFilter.SelectedIndex > 0 && sectionFilter.SelectedItem.ToString() != "All Sections")
            {
                string section = sectionFilter.SelectedItem.ToString();
                filteredStudents = filteredStudents.Where(s => s.section.Trim() == section).ToList();

            }
            // --- Filter by ID ---
            if (ID_Filter.SelectedIndex > 0) // 0 = "All IDs"
            {
                string selectedID = ID_Filter.SelectedItem.ToString();
                filteredStudents = filteredStudents.Where(s => s.ID == selectedID).ToList();
            }

            // --- Filter by Score/Grade ---
            if (!string.IsNullOrWhiteSpace(SortByGrade.Text))
            {
                if (float.TryParse(SortByGrade.Text.Trim(), out float minGrade))
                {
                    filteredStudents = filteredStudents
                        .Where(s => s.GetAverage() >= minGrade)
                        .ToList();
                }
            }

            // --- Update MyStudents ---
            MyStudents = filteredStudents;

            // --- Clear existing UI ---
            StudentListBar.Controls.Clear();

            if (filteredStudents.Count == 0)
            {
                // Show placeholder tab if no students match
                StudentTab placeholder = new StudentTab
                {
                    name = "No Student Found",
                    ID = "",
                    section = "",
                    subject = "",
                    Dock = DockStyle.Top,
                    StudentListLoc = -1 // invalid index
                };
                StudentListBar.Controls.Add(placeholder);
                return;
            }

            // --- Populate filtered students ---
            int index = 0;
            foreach (Student student in filteredStudents)
            {
                StudentTab thisTab = new StudentTab
                {
                    name = student.name,
                    ID = student.ID,
                    section = student.section,
                    subject = student.subject,
                    Dock = DockStyle.Top,
                    StudentListLoc = index
                };

                thisTab.OpenStudentInfo += OnStudentTabClicked;
                thisTab.removeStudentInfo += OnStudentTabRemoved;

                index++;
                StudentListBar.Controls.Add(thisTab);
            }
        }
        private void updateSubChart()
        {
            Series series;

            // Create or get the series
            if (SubjectChart.Series.Count == 0)
            {
                series = SubjectChart.Series.Add("subject");
            }
            else
            {
                if (SubjectChart.Series.IndexOf("subject") >= 0)
                    series = SubjectChart.Series["subject"];
                else
                {
                    series = SubjectChart.Series[0];
                    series.Name = "subject";
                }
            }

            // Clear old points
            series.Points.Clear();

            // Show values on the bars
            series.IsValueShownAsLabel = true;


            // Add data points
            foreach (var item in MySubjectsAmount)
            {
                series.Points.AddXY(item.abbreviation, item.amount);
            }
        }



    }

}



