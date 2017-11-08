using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> allBooks = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLine = Console.ReadLine().Split();
                Book book = new Book
                {
                    Title = inputLine[0],
                    Author = inputLine[1],
                    Publisher = inputLine[2],
                    ReleaseDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = int.Parse(inputLine[4]),
                    Price = double.Parse(inputLine[5])
                };
               
                if(!allBooks.ContainsKey(book.Author))
                {
                    allBooks[book.Author] = 0.0;
                }
                allBooks[book.Author] += book.Price;
            }

            foreach (var book in allBooks.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", book.Key, book.Value);
            }

        }
    }
}
