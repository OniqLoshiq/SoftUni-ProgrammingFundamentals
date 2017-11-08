using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10_StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int Seats { get; set; }
        public List<Student> StudentsList { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> StudentsGrouped { get; set; }
    }

    class Program
    {
        public static void Main()
        {
            List<Town> allTowns = GetInputData();
            List<Group> allGroups = GroupingStudentsIntoGroups(allTowns);

            Console.WriteLine($"Created {allGroups.Count} groups in {allTowns.Count} towns:");

            foreach (var group in allGroups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.StudentsGrouped.Select(x => x.Email).ToList()));
            }
        }

        private static List<Group> GroupingStudentsIntoGroups(List<Town> allTowns)
        {
            List<Group> allGroups = new List<Group>();

            foreach (var town in allTowns)
            {
                IEnumerable<Student> students = town.StudentsList.OrderBy(x => x.RegDate).ThenBy(x => x.Name).ThenBy(x => x.Email);

                while(students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.StudentsGrouped = students.Take(group.Town.Seats).ToList();
                    students = students.Skip(group.Town.Seats);

                    allGroups.Add(group);
                }
            }
           
            return allGroups;
        }

        static List<Town> GetInputData()
        {
            List<Town> allTowns = new List<Town>();

            string inputLine = Console.ReadLine();

            int townCounter = -1;

            while (inputLine != "End")
            {
                
                if (inputLine.Contains("=>"))
                {
                    string[] townInputData = inputLine.Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                    Town town = new Town();
                    town.Name = townInputData[0];
                    town.Seats = townInputData[1].Split().Take(1).Select(int.Parse).First();
                    town.StudentsList = new List<Student>();

                    allTowns.Add(town);
                    townCounter++;
                }
                else
                {
                    string[] studentInputData = inputLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student();
                    student.Name = studentInputData[0].Trim();
                    student.Email = studentInputData[1].Trim();
                    student.RegDate = DateTime.ParseExact(studentInputData[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    allTowns[townCounter].StudentsList.Add(student);
                }
                
                inputLine = Console.ReadLine();
            }
            
            return allTowns;
        }

    }
}
