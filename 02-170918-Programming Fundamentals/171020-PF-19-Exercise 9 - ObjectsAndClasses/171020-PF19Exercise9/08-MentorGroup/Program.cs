using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MentorGroup
{
    class Stundet
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var allStudents = new SortedDictionary<string, Stundet>();

            string firstInput = Console.ReadLine();

            while (firstInput != "end of dates")
            {
                string[] datesInput = firstInput.Split(new char[] { ' ', ',' });

                string studentName = datesInput[0];

                if (!allStudents.ContainsKey(studentName))
                {
                    allStudents[studentName] = new Stundet();
                    allStudents[studentName].Dates = new List<DateTime>();
                    allStudents[studentName].Comments = new List<string>();
                }

                for (int i = 1; i < datesInput.Length; i++)
                {
                    allStudents[studentName].Dates.Add(DateTime.ParseExact(datesInput[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of comments")
            {
                string[] commentsInput = secondInput.Split('-');

                string studentName = commentsInput[0];

                if (allStudents.ContainsKey(studentName))
                {
                    allStudents[studentName].Comments.Add(commentsInput[1]);
                }

                secondInput = Console.ReadLine();
            }


            foreach (var student in allStudents)
            {
                Console.WriteLine(student.Key);

                Console.WriteLine("Comments:");
                foreach (var comment in student.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
