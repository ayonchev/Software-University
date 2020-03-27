using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisingMessage
{
    class AdvertisingMessage
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] author = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] city = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            for (int i = 0; i < count; i++)
            {
                int phraseIndex = rnd.Next(phrases.Length);
                int eventsIndex = rnd.Next(events.Length);
                int authorIndex = rnd.Next(author.Length);
                int cityIndex = rnd.Next(city.Length);

                Console.WriteLine($"{phrases[phraseIndex]} {events[eventsIndex]} {author[authorIndex]} -  {city[cityIndex]}");
            }
        }
    }
}
