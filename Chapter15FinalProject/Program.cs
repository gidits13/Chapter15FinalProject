using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter15FinalProject
{
    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
    internal class Program
    {
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(x => x.Students.Select(s => s)).ToArray();
        }
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
    }
}