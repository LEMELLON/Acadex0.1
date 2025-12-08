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
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Danny B. Cantillon\OneDrive\文档\Programing\VSCODE2022\C#\DSA_Proposals\Student Organizer\Acadex0.1\AcadexDatabase1.mdf;Integrated Security=True;Connect Timeout=30";

        public static List<(string abbreviation, string name)> Subjects = new List<(string abbreviation, string name)>()
        {
            ("DSA", "Data Structures And Algorithm"),
            ("ITC", "Introduction To Computing"),
            ("HCI", "Human - Computer Interaction"),
            ("OOP", "Object Oriented Programming"),
            ("NET", "Networking")
        };

        public static List<Student> Students = new List<Student>();
        public static List<Student> LoadedStudents = new List<Student>();

        static DataBase1()
        {
            LoadSubjects();
            LoadStudents();
            LoadGrades();
            LoadLoadedStudents();
        }
        public static void LoadLoadedStudents()
        {
            LoadedStudents.Clear(); // clear any previous data

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT Id, Name, Section, Subject FROM StudentLoaded", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoadedStudents.Add(new Student(
                                reader["Name"].ToString(),
                                reader["Id"].ToString(),
                                reader["Section"].ToString(),
                                reader["Subject"].ToString()
                            ));
                        }
                    }
                }
            }
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
                SqlCommand cmd = new SqlCommand("SELECT Id, Subject, Activity, Grade, Weight FROM StudentGrades", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string studentId = reader["Id"].ToString();
                        string subject = reader["Subject"].ToString();
                        string activity = reader["Activity"].ToString();
                        string grade = reader["Grade"].ToString();
                        string weight = reader["Weight"].ToString();

                        // Find the student
                        Student student = Students.Find(s => s.ID == studentId && s.subject == subject);
                        if (student != null)
                        {
                            student.StudentGrades.Add(Tuple.Create(activity, grade, weight));
                        }
                    }
                }
            }
        }

        public static void SaveLoadedStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // --- Delete all existing records in StudentLoaded ---
                using (SqlCommand clearCmd = new SqlCommand("DELETE FROM StudentLoaded", conn))
                {
                    clearCmd.ExecuteNonQuery();
                }

                // --- Insert all LoadedStudents ---
                foreach (var student in LoadedStudents)
                {
                    using (SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO StudentLoaded (Id, Name, Section, Subject) VALUES (@Id, @Name, @Section, @Subject)", conn))
                    {
                        insertCmd.Parameters.AddWithValue("@Id", student.ID);
                        insertCmd.Parameters.AddWithValue("@Name", student.name);
                        insertCmd.Parameters.AddWithValue("@Section", student.section);
                        insertCmd.Parameters.AddWithValue("@Subject", student.subject);

                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }
        public static List<Student> GetMatchingLoadedStudents()
        {
            List<Student> matchingStudents = new List<Student>();

            foreach (var loaded in LoadedStudents)
            {
                // Find actual student from main list
                var student = Students.Find(s =>
                    s.ID == loaded.ID &&
                    s.subject == loaded.subject &&
                    s.name == loaded.name &&
                    s.section == loaded.section
                );

                if (student != null)
                {
                    matchingStudents.Add(student);  // ✅ return the real Student object
                }
            }

            return matchingStudents;
        }



        public static void UpdateGrades()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (var student in Students)
                {
                    // Delete previous grades for this student
                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM StudentGrades WHERE Id = @Id and Subject = @Subject", conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@Id", student.ID);
                        deleteCmd.Parameters.AddWithValue("@Subject", student.subject);
                        deleteCmd.ExecuteNonQuery();
                    }

                    // Insert current grades
                    foreach (var grade in student.StudentGrades)
                    {
                        string[] parts = grade.Item1.Split(new string[] { " - " }, StringSplitOptions.None);
                        string activity = parts.Length > 0 ? parts[0] : "";

                        using (SqlCommand insertCmd = new SqlCommand(
                            "INSERT INTO StudentGrades (Id,Subject, Activity, Grade, Weight) VALUES (@Id,@Subject,@Activity, @Grade, @Weight)", conn))
                        {
                            insertCmd.Parameters.AddWithValue("@Id", student.ID);
                            insertCmd.Parameters.AddWithValue("@Activity", activity);
                            insertCmd.Parameters.AddWithValue("@Subject", student.subject);

                            if (float.TryParse(grade.Item2, out float g))
                                insertCmd.Parameters.AddWithValue("@Grade", g);
                            else
                                insertCmd.Parameters.AddWithValue("@Grade", DBNull.Value);

                            if (float.TryParse(grade.Item3, out float w))
                                insertCmd.Parameters.AddWithValue("@Weight", w);
                            else
                                insertCmd.Parameters.AddWithValue("@Weight", DBNull.Value);

                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
