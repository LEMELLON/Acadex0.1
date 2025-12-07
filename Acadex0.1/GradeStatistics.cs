using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Acadex0._1
{
    public partial class GradeStatistics : UserControl
    {
        private  List<Student> Students;
        private  List<(string abbreviation, string name)> MySubjects;
        public List<string> MySections = new List<string>();
        public GradeStatistics()
        {
            InitializeComponent();

        }
        private int failing;
        private int passing;
        private int excelling;
        public void loadStats(List<Student> temp, List<(string abbreviation, string name)> temp2, List<string> temp3) {
            Students = temp;
            MySections = temp3;
            MySubjects = temp2;
        }
        public void updateFilter()
        {
            // --- Subject Filter ---
            if (MySubjects != null)
            {
                SubjectFilter.Items.Clear();
                SubjectFilter.Items.Add("All Subjects");

                foreach (var s in MySubjects)
                {
                    SubjectFilter.Items.Add($"{s.abbreviation} - {s.name}");
                }

                SubjectFilter.SelectedIndex = 0;
            }

            // --- Section Filter ---
            if (MySections != null)
            {
                SectionFilter.Items.Clear();
                SectionFilter.Items.Add("All Sections");

                foreach (var sec in MySections)
                {
                    SectionFilter.Items.Add(sec);
                }

                SectionFilter.SelectedIndex = 0;
            }
        }

        public void updateStats()
        {
            if (Students == null || Students.Count == 0)
            {
                // No students at all, reset everything
                BS_Grade.Text = WS_Grade.Text = "-";
                Grades.Series.Clear();
                return;
            }

            // Start with all students
            List<Student> filteredStudents = Students;

            // --- Filter by Subject ---
            if (SubjectFilter.SelectedIndex > 0 && SubjectFilter.SelectedItem.ToString() != "All Subjects")
            {
                string abbrev = SubjectFilter.SelectedItem.ToString().Split('-')[0].Trim();
                filteredStudents = filteredStudents.Where(s => s.subject.Trim() == abbrev).ToList();
            }

            // --- Filter by Section ---
            if (SectionFilter.SelectedIndex > 0 && SectionFilter.SelectedItem.ToString() != "All Sections")
            {
                string section = SectionFilter.SelectedItem.ToString();
                filteredStudents = filteredStudents.Where(s => s.section.Trim() == section).ToList();
            }

            // --- Handle empty filtered list ---
            if (filteredStudents.Count == 0)
            {
                BS_Grade.Text = WS_Grade.Text = "-";

                // Show placeholders in the controls
                BestStudent.name = "No Student";
                BestStudent.ID = "";
                BestStudent.section = "";
                BestStudent.subject = "";

                WorstStudent.name = "No Student";
                WorstStudent.ID = "";
                WorstStudent.section = "";
                WorstStudent.subject = "";

                BestStudent.updateTab();
                WorstStudent.updateTab();

                Grades.Series.Clear();
                return;
            }

            // --- Calculate stats ---
            failing = filteredStudents.Count(s => s.GetAverage() < 75);
            passing = filteredStudents.Count(s => s.GetAverage() >= 75 && s.GetAverage() < 85);
            excelling = filteredStudents.Count(s => s.GetAverage() >= 85);

            Student BS = filteredStudents.OrderByDescending(s => s.GetAverage()).First();
            Student WS = filteredStudents.OrderBy(s => s.GetAverage()).First();

            BestStudent.name = BS.name;
            BestStudent.ID = BS.ID;
            BestStudent.section = BS.section;
            BestStudent.subject = BS.subject;

            WorstStudent.name = WS.name;
            WorstStudent.ID = WS.ID;
            WorstStudent.section = WS.section;
            WorstStudent.subject = WS.subject;

            BS_Grade.Text = BS.GetAverage().ToString("F2");
            WS_Grade.Text = WS.GetAverage().ToString("F2");

            BestStudent.updateTab();
            WorstStudent.updateTab();
            updateChart();
        }



        private void updateChart()
        {
            Grades.Series.Clear();  // reset the chart

            var series = new Series("Grades");
            series.ChartType = SeriesChartType.Doughnut; // changed from Pie to Doughnut

            // Add data points
            var failingPoint = series.Points.AddXY("Failing", failing);
            series.Points[failingPoint].Color = Color.Red;

            var passingPoint = series.Points.AddXY("Passing", passing);
            series.Points[passingPoint].Color = Color.Blue;

            var excellingPoint = series.Points.AddXY("Excelling", excelling);
            series.Points[excellingPoint].Color = Color.Green;

            Grades.Series.Add(series);

            // Optional: show percentage labels
            series.IsValueShownAsLabel = true;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            updateStats();
        }
    }
}
