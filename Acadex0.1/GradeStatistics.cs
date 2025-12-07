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
        public GradeStatistics()
        {
            InitializeComponent();

        }
        private int failing;
        private int passing;
        private int excelling;
        public void loadStats(List<Student> temp, List<(string abbreviation, string name)> temp2) {
            Students = temp;
            MySubjects = temp2;
        }
        public void updateFilter()
        {
            if (MySubjects == null) return;

            SubjectFilter.Items.Clear();
            SubjectFilter.Items.Add("All Subjects");

            foreach (var s in MySubjects)
            {
                SubjectFilter.Items.Add($"{s.abbreviation} - {s.name}");
            }

            SubjectFilter.SelectedIndex = 0;
        }
        public void updateStats()
        {
             // refresh subjects list

            if (Students == null || Students.Count == 0) return;

            // Filter students by selected subject
            List<Student> filteredStudents;
            if (SubjectFilter.SelectedIndex <= 0 || SubjectFilter.SelectedItem.ToString() == "All Subjects")
            {
                filteredStudents = Students;
            }
            else
            {
                string abbrev = SubjectFilter.SelectedItem.ToString().Split('-')[0].Trim();
                filteredStudents = Students.Where(s => s.subject.Trim() == abbrev).ToList();
            }

            // Handle empty filtered list
            if (filteredStudents.Count == 0)
            {
                BS_Grade.Text = WS_Grade.Text = "-";
                Grades.Series.Clear();
                return;
            }

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
