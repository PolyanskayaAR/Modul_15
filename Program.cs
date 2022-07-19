using System;
using System.Collections.Generic;
using System.Linq;

namespace modul_15
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string[] GetAllStudents(Classroom[] classes)
        {
            
            IEnumerable<string> studentsAll = new List<string>();
            foreach (var eachClass in classes)
            {
                studentsAll = studentsAll.Concat(eachClass.Students);
            }
            
            var studentsAllFinal = studentsAll.ToArray();
            return studentsAllFinal;
        }
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
