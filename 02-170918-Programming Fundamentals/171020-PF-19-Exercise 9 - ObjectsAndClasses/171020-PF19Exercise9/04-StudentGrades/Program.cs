using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double AvgGrade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                Student st = new Student { Name = inputLine[0], AvgGrade = inputLine.Skip(1).Select(double.Parse).Average() };

                students.Add(st);
            }

            List<Student> excelletStudents = students.Where(x => x.AvgGrade >= 5.0).OrderBy(x => x.Name).ThenByDescending(x => x.AvgGrade).ToList();

            foreach (var student in excelletStudents)
            {
                Console.WriteLine("{0} -> {1:f2}", student.Name, student.AvgGrade);
            }
        }
    }
}
