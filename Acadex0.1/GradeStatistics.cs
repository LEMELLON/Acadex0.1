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
            MessageBox.Show("UPDIT!");

            foreach (var s in MySubjects)
            {
                SubjectFilter.Items.Add($"{s.abbreviation} - {s.name}");
            }

            SubjectFilter.SelectedIndex = 0;
        }
        public void updateStats() {
            updateFilter();

            if (Students == null) return;

            failing = Students.Count(s => s.GetAverage() < 75);
            passing = Students.Count(s => s.GetAverage() >= 75 && s.GetAverage() < 85);
            excelling = Students.Count(s => s.GetAverage() >= 85);
            

            
            Student BS = Students.OrderByDescending(s => s.GetAverage()).FirstOrDefault();
            Student WS = Students.OrderBy(s => s.GetAverage()).FirstOrDefault();

            BestStudent.name = BS.name;
            BestStudent.ID = BS.ID;
            BestStudent.section = BS.section;
            BestStudent.subject = BS.subject;

            WorstStudent.name = WS.name;
            WorstStudent.ID = WS.ID;
            WorstStudent.section = WS.section;
            WorstStudent.subject= WS.subject;
            string Temp = "";
            Temp+= BS.GetAverage();
            BS_Grade.Text = Temp;
            Temp = "";
            Temp += WS.GetAverage();
            WS_Grade.Text=Temp;
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


    }
}
