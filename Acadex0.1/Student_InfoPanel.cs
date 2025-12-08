using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Acadex0._1
{
    public partial class Student_InfoPanel : UserControl
    {
        public Student student;

        public Student_InfoPanel()
        {
            InitializeComponent();
            Grades.CellValidating += Grades_CellValidating;
        }

        public void updateInfo()
        {
            this.StudentName.Text = student.name;
            this.StudentSection.Text = student.section;
            this.StudentID.Text = student.ID;
            this.StudentSubject.Text = student.subject;
            InvalidInputText.Text = "";
            ActivityName.Text = "";
            invalidInput_Weight.Text = "";
            Weight.Text = ""; // if you have a TextBox for weight input
            updateGrades();
        }

        public event Action SwitchToStudentList;

        private void clearGradeAdding()
        {
            Activity_Name.Text = "";
            Activity_Grade.Text = "";
            Weight.Text = "";
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            SwitchToStudentList?.Invoke();
            clearGradeAdding();
        }

        private void updateGrades()
        {
            Grades.Columns.Clear();
            Grades.Rows.Clear();

            student_Grade.Text = student.GetAverage().ToString("F2");

            Grades.Columns.Add("Activity", "Activity");
            Grades.Columns.Add("Grade", "Grade");
            Grades.Columns.Add("Weight", "Weight");

            foreach (var grade in student.StudentGrades)
            {
                string formattedWeight = grade.Item3;

                // Try to format it properly
                if (float.TryParse(grade.Item3, out float w))
                {
                    // Force 2 decimals (change "F2" to "F3" if you want 3 decimals)
                    formattedWeight = w.ToString("F2");
                }

                Grades.Rows.Add(grade.Item1, grade.Item2, formattedWeight);
            }
        }

        private void AddGrade_Button(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Activity_Name.Text))
            {
                ActivityName.Text = "*Enter A Valid Name";
                return;
            }

            if (!float.TryParse(Activity_Grade.Text, out float value) || value < 0 || value > 100)
            {
                InvalidInputText.Text = "*Enter A Valid Grade (0-100)";
                return;
            }

            if (!float.TryParse(Weight.Text, out float weight) || weight <= 0 || weight > 1)
            {
                invalidInput_Weight.Text = "*Enter a valid weight (0-1)";
                return;
            }

            if (!student.IsValidWeight(Convert.ToSingle(Weight.Text)))
            {
                invalidInput_Weight.Text = "*Total weights cannot exceed 1";
                return;
            }

            // Add grade
            student.StudentGrades.Add(Tuple.Create(Activity_Name.Text, Activity_Grade.Text, Weight.Text));
            clearGradeAdding();
            updateGrades();
        }

        private void Activity_Grade_TextChanged(object sender, EventArgs e)
        {
            InvalidInputText.Text = "";
        }

        private void Activity_Name_TextChanged(object sender, EventArgs e)
        {
            ActivityName.Text = "";
        }

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            invalidInput_Weight.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Keep a backup of existing weights so we can restore them
            List<Tuple<string, string, string>> oldGrades = new List<Tuple<string, string, string>>(student.StudentGrades);

            // Clear and rebuild
            student.StudentGrades.Clear();

            int index = 0; // for tracking original weights

            foreach (DataGridViewRow row in Grades.Rows)
            {
                if (row.IsNewRow) continue;

                string activity = row.Cells["Activity"].Value?.ToString() ?? "";
                string grade = row.Cells["Grade"].Value?.ToString() ?? "";
                string weightStr = row.Cells["Weight"].Value?.ToString() ?? "";

                // Validate name + grade
                if (string.IsNullOrWhiteSpace(activity) ||
                    !float.TryParse(grade, out float g) || g < 0 || g > 100)
                {
                    MessageBox.Show($"Invalid entry: Activity='{activity}', Grade='{grade}'");
                    continue;
                }

                // Validate weight input format
                float w;
                bool parsed = float.TryParse(weightStr, out w);

                if (!parsed || w <= 0 || w > 1)
                {
                    // Restore original weight
                    string oldWeight = oldGrades[index].Item3;
                    MessageBox.Show($"Invalid weight '{weightStr}'. Restoring previous weight: {oldWeight}");

                    student.StudentGrades.Add(Tuple.Create(activity, grade, oldWeight));
                    index++;
                    continue;
                }

                // Validate weight using IsValidWeight
                if (!student.IsValidWeight(w))
                {
                    // Restore old weight
                    string oldWeight = oldGrades[index].Item3;
                    MessageBox.Show($"Weight {w} would exceed total 1. Restoring previous weight {oldWeight}");

                    student.StudentGrades.Add(Tuple.Create(activity, grade, oldWeight));
                    index++;
                    continue;
                }

                // Valid input — save normally
                student.StudentGrades.Add(Tuple.Create(activity, grade, w.ToString("F2")));
                index++;
            }

            updateGrades();
            DataBase1.UpdateGrades();
        }


        private void Grades_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = Grades.Columns[e.ColumnIndex].Name;
            string value = e.FormattedValue?.ToString() ?? "";

            if (columnName == "Activity")
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    e.Cancel = true;
                    MessageBox.Show("Activity name cannot be empty.");
                }
            }
            else if (columnName == "Grade")
            {
                if (!float.TryParse(value, out float g) || g < 0 || g > 100)
                {
                    e.Cancel = true;
                    MessageBox.Show("Grade must be a valid number between 0 and 100.");
                }
            }
            else if (columnName == "Weight")
            {
                if (!float.TryParse(value, out float w) || w <= 0 || w > 1)
                {
                    e.Cancel = true;
                    MessageBox.Show("Weight must be a valid decimal between 0 and 1.");
                }
            }
        }
    }
}
