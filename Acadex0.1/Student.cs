using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadex0._1
{
    public class Student
    {
            public List<KeyValuePair<string, string>> StudentGrades { get; set; }
            public string ID;
            private float average=0;
            public string name;
            public string section;
            public string subject;
            public Student(String name, string ID, String section, String subject)
            {
                this.name = name;
                this.ID = ID;
                this.section = section;
                this.subject = subject;

                StudentGrades = new List<KeyValuePair<string, string>>();
                
            }

            public float GetAverage()
            {
                if (StudentGrades.Count == 0)
                    return 0f;

                float sum = 0;

                foreach (var grade in StudentGrades)
                {
                    if (int.TryParse(grade.Value, out int value))
                        sum += value;
                    else
                        return 0f; // non-numeric grade found
                }

                return (float)Math.Round(sum / StudentGrades.Count, 2);
        }
    }
}
