using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_AdvertisementMSG
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrase = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            Random phraseIndex = new Random();
            string[] evenT = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            Random eventIndex = new Random();
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            Random authorIndex = new Random();
            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            Random townIndex = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}", phrase[phraseIndex.Next(0, phrase.Length)], evenT[eventIndex.Next(0, evenT.Length)],
                                                       author[authorIndex.Next(0, author.Length)], city[townIndex.Next(0, city.Length)]);
            }
        }
    }
}
