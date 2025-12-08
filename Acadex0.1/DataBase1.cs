using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadex0._1
{
    public class DataBase1
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AcadexDatabase1.mdf;Integrated Security=True;Connect Timeout=30";

        public static List<(string abbreviation, string name)> Subjects = new List<(string abbreviation, string name)>()
        {
            ("DSA", "Data Structures And Algorithm"),
            ("ITC", "Introduction To Computing"),
            ("HCI", "Human - Computer Interaction"),
            ("OOP", "Object Oriented Programming"),
            ("NET", "Networking")
        };

        public static List<Student> Students = new List<Student>();
        static DataBase1()
        {
            LoadSubjects();
            LoadStudents();
            LoadGrades();
        }


        private static void LoadSubjects()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Abbreviation, Name FROM Subjects", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subjects.Add((reader["Abbreviation"].ToString(), reader["Name"].ToString()));
                    }
                }
            }
        }

        private static void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Name, Section, Subject FROM Student", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Students.Add(new Student(
                            reader["Name"].ToString(),
                            reader["Id"].ToString(),
                            reader["Section"].ToString(),
                            reader["Subject"].ToString()
                        ));
                    }
                }
            }
        }

        private static void LoadGrades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, Subject, Activity, Grade FROM StudentGrades", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string studentId = reader["Id"].ToString();
                        string subject = reader["Subject"].ToString();
                        string activity = reader["Activity"].ToString();
                        string grade = reader["Grade"].ToString();

                        // Find the student
                        Student student = Students.Find(s => s.ID == studentId);
                        if (student != null)
                        {
                            // Store "Subject - Activity" as key
                            string key = $"{subject} - {activity}";
                            student.StudentGrades.Add(new KeyValuePair<string, string>(key, grade));
                        }
                    }
                }
            }
        }

    }
}
