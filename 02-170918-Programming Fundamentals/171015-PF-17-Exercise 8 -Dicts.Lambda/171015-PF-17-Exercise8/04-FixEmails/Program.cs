using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Dictionary<string, string> emailsOfPeople = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                string domain = email.Substring(email.Length - 2);

                if(domain != "us" && domain != "uk")
                {
                    emailsOfPeople[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var person in emailsOfPeople)
            {
                Console.WriteLine("{0} -> {1}", person.Key, person.Value);
            }
        }
    }
}
