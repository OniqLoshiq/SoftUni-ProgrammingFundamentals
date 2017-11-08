using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BookLibrModed
{
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


            List<Book> allBooks = new List<Book>();

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

                allBooks.Add(book);
            }

            DateTime checkDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> booksToPrint = allBooks.Where(x => x.ReleaseDate > checkDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title).ToList();

            foreach (var book in booksToPrint)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", book.Title, book.ReleaseDate);
            }
        }
    }
}
