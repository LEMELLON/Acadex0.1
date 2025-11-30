using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadex0._1
{
    public class Student
    {
            public List<KeyValuePair<string, int>> StudentGrades { get; set; }
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

                StudentGrades = new List<KeyValuePair<string, int>>();
            }
        
    }
}
