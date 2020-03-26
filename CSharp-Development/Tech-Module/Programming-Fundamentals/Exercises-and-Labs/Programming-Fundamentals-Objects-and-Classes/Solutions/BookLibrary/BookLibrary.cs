using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, double> authors = new Dictionary<string, double>();

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

                if (!authors.ContainsKey(currentBook.Author))
                {
                    authors.Add(currentBook.Author, currentBook.Price);
                }
                else
                {
                    authors[currentBook.Author] += currentBook.Price;
                }
            }

            var result = authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Key} -> {person.Value:F2}");
            }
        }
    }
}
