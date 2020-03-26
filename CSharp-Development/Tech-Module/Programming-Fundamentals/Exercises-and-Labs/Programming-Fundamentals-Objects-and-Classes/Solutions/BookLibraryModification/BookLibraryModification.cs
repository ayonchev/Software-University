using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, DateTime> books = new Dictionary<string, DateTime>();

            for (int i = 0; i < count; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ');
                Book currentBook = new Book()
                {
                    Title = inputArray[0],
                    Author = inputArray[1],
                    Publisher = inputArray[2],
                    ReleaseDate = DateTime.ParseExact(inputArray[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = inputArray[4],
                    Price = double.Parse(inputArray[5])
                };

                if (!books.ContainsKey(currentBook.Title))
                {
                    books.Add(currentBook.Title, currentBook.ReleaseDate);
                }
                else
                {
                    books[currentBook.Title] = currentBook.ReleaseDate;
                }
            }

            string date = Console.ReadLine();
            DateTime givenDate = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var result = books.Where(x => x.Value > givenDate).OrderBy(x => x.Value).ThenBy(x => x.Key);

            foreach (var book in result)
            {
                string currDate = book.Value.ToString("dd.MM.yyyy");
                Console.WriteLine($"{book.Key} -> {currDate}");
            }
        }
    }
}
