using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadex0._1
{
    public class Student
    {
        public List<Tuple<string, string, string>> StudentGrades { get; set; }

        public string ID;
        private float average=0;
        public string name;
        public string section;
        public string subject;
            public Student(String name, String ID, String section, String subject)
            {
                this.name = name;
                this.ID = ID;
                this.section = section;
                this.subject = subject;

                StudentGrades = new List<Tuple<string, string, string>>();
                
            }

            public float GetAverage()
            {
                if (StudentGrades.Count == 0)
                    return 0f;

                float weightedSum = 0f;
                float totalWeight = 0f;

                foreach (var grade in StudentGrades)
                {
                    // Parse grade and weight
                    if (float.TryParse(grade.Item2, out float g) && float.TryParse(grade.Item3, out float w))
                    {
                        weightedSum += g * w;
                        totalWeight += w;
                    }
                }

                // Avoid division by zero
                if (totalWeight == 0f)
                    return 0f;

                // Weighted average
                return (float)Math.Round(weightedSum / totalWeight, 2);
            }

            public bool IsValidWeight(float newWeight)
                {
                    // Get all unique weights from current grades
                    var uniqueWeights = StudentGrades
                        .Select(g => float.TryParse(g.Item3, out float w) ? w : 0f)
                        .Where(w => w > 0f)
                        .Distinct()
                        .ToList();

                    // Sum of current unique weights
                    float total = uniqueWeights.Sum();

                    // If the new weight already exists, it's fine
                    if (uniqueWeights.Contains(newWeight))
                        return true;

                    // Otherwise, check if adding it exceeds 1
                    return (total + newWeight) <= 1f;
                }

    }
}
