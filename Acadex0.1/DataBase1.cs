using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acadex0._1
{
    public class DataBase1
    {
        public static List<(string abbreviation, string name)> Subjects = new List<(string abbreviation, string name)>()
        {
            ("DSA ", "Data Structures And Algorithm"),
            ("ITC", "Introduction To Computing"),
            ("HCI", "Human - Computer Interaction"),
            ("OOP", "Object Oriented Programming"),
            ("NET", "Networking")
        };

        public static List<Student> Students = new List<Student>()
        {
            new Student("Danny B. Cantillon", "0000-0000", "BSIT 2-8", "DSA"),
            new Student("Juan Dela Cruz", "1025-0001", "BSIT 1-1", "ITC"),
            new Student("Maria Santos", "2025-0002", "BSIT 1-2", "OOP"),
            new Student("Jose Rizal", "2025-0003", "BSIT 1-3", "HCI"),
            new Student("Ana Lopez", "2025-0004", "BSIT 1-4", "NET"),
            new Student("Pedro Cruz", "2025-0005", "BSIT 2-1", "DSA"),
            new Student("Lucia Reyes", "2025-0006", "BSIT 2-2", "ITC"),
            new Student("Carlos Mendoza", "2025-0007", "BSIT 2-3", "OOP"),
            new Student("Isabel Garcia", "2025-0008", "BSIT 2-4", "HCI"),
            new Student("Miguel Ramos", "2025-0009", "BSIT 2-5", "NET"),
            new Student("Sofia Diaz", "2025-0010", "BSIT 2-6", "DSA"),
            new Student("Ricardo Tan", "2025-0011", "BSIT 2-7", "ITC"),
            new Student("Elena Flores", "2025-0012", "BSIT 2-8", "OOP"),
            new Student("Andres Bonifacio", "2025-0013", "BSIT 1-1", "HCI"),
            new Student("Carmen Villanueva", "2025-0014", "BSIT 1-2", "NET"),
            new Student("Fernando Torres", "2025-0015", "BSIT 1-3", "DSA"),
            new Student("Patricia Cruz", "2025-0016", "BSIT 1-4", "ITC"),
            new Student("Luis Garcia", "2025-0017", "BSIT 2-1", "OOP"),
            new Student("Gloria Mendoza", "2025-0018", "BSIT 2-2", "HCI"),
            new Student("Victor Ramos", "2025-0019", "BSIT 2-3", "NET"),
            new Student("Lucia Santos", "2025-0020", "BSIT 2-4", "DSA"),
            new Student("Diego Rivera", "2025-0021", "BSIT 2-5", "ITC"),
            new Student("Maria Lopez", "2025-0022", "BSIT 2-6", "OOP"),
            new Student("Juanita Reyes", "2025-0023", "BSIT 2-7", "HCI"),
            new Student("Pedro Mendoza", "2025-0024", "BSIT 2-8", "NET"),
            new Student("Clara Diaz", "2025-0025", "BSIT 1-1", "DSA"),
            new Student("Rafael Santos", "2025-0026", "BSIT 1-2", "ITC"),
            new Student("Angela Cruz", "2025-0027", "BSIT 1-3", "OOP"),
            new Student("Hector Garcia", "2025-0028", "BSIT 1-4", "HCI"),
            new Student("Isabel Torres", "2025-0029", "BSIT 2-1", "NET"),
            new Student("Mario Lopez", "2025-0030", "BSIT 2-2", "DSA")
        };
    }
}
