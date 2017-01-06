using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pokemon = new List<string>();
            pokemon.Add("gotta");
            pokemon.Add("catch");
            pokemon.Add("em");
            pokemon.Add("all");
            pokemon.Add("catch");
            pokemon.Add("all");
            foreach (string word in pokemon)
            {
                Console.WriteLine("Original list: {0}", word);
            }
            Console.WriteLine("");
            List<string> distinct = pokemon.Distinct().ToList();
            foreach (string word in distinct)
            {
                Console.WriteLine("Without duplicate list: {0}", word);
            }
            Console.WriteLine("");
            List<double> student1Grades = new List<double> { 90, 80, 75, 85, 95 };
            List<double> student2Grades = new List<double> { 75, 60, 75, 72, 85 };
            student1Grades.Remove(student1Grades.Min());
            student2Grades.Remove(student2Grades.Min());
            double averageStudent1 = student1Grades.Average();
            double averageStudent2 = student2Grades.Average();
            List<double> allStudentGrades = new List<double> { averageStudent1, averageStudent2 };
            double allStudentAverage = allStudentGrades.Average();
            {
                Console.WriteLine("Student 1 average: {0}", averageStudent1);
                Console.WriteLine("Student 2 average: {0}", averageStudent2);
                Console.WriteLine("Overall average: {0}", allStudentAverage);
            }
            Console.WriteLine("");
            List<char> letters = new List<char> { 'j', 'e', 'l', 'l', 'y', 'f', 'i', 's', 'h' };
            foreach (char letter in letters)
            {
                Console.WriteLine("Original list: {0}", letter);
            }
            Console.WriteLine("");
            var ordered = (from l in letters orderby char.ToLower(l) select l).ToList();
            foreach (char letter in ordered)
            {
                Console.WriteLine("Alphabetical list: {0}", letter);
            }
            Console.ReadKey();
        }
    }
}
