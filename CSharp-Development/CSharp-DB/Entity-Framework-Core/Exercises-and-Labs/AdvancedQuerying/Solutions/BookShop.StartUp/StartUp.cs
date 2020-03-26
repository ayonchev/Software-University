namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                int result = RemoveBooks(db);

                Console.WriteLine($"{result} books were deleted");
            }
        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var bookTitles = context.Books
                .Where(b => Enum.GetName(typeof(AgeRestriction), b.AgeRestriction).ToLower() == command.ToLower())
                .Select(b => b.Title)
                .OrderBy(title => title)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            var bookTitles = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            var bookTitlesAndPrices = context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => new
                {
                    TitleAndPrice = $"{b.Title} - ${b.Price:F2}"
                })
                .Select(b => b.TitleAndPrice)
                .ToList();

            return string.Join(Environment.NewLine, bookTitlesAndPrices);
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLower())
                .ToArray();

            var bookTitles = context.Books
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Where(b => b.BookCategories
                            .Select(bc => bc.Category.Name)
                            .Any(c => categories.Contains(c.ToLower())))
                .Select(b => b.Title)
                .OrderBy(title => title)
                .ToList();
            return string.Join(Environment.NewLine, bookTitles);
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authorsNames = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => a.FirstName + " " + a.LastName)
                .OrderBy(name => name)
                .ToList();

            return string.Join(Environment.NewLine, authorsNames);
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var booksCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return booksCount;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var authorsAndCopies = context.Authors
                .Include(a => a.Books)
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    BookCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.BookCopies)
                .Select(a => a.FullName + " - " + a.BookCopies)
                .ToList();

            return string.Join(Environment.NewLine, authorsAndCopies);
        }

        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var categoriesAndProfit = context.Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .Select(c => new
                {
                    c.Name,
                    BooksProfit = c.CategoryBooks.Select(cb => cb.Book).Sum(b => b.Copies * b.Price)
                })
                .OrderByDescending(cp => cp.BooksProfit)
                .Select(cp => cp.Name + " $" + cp.BooksProfit.ToString("F2"))
                .ToList();

            return string.Join(Environment.NewLine, categoriesAndProfit);
        }

        public static string GetMostRecentBooks(BookShopContext context)
        {
            var categories = context.Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .OrderBy(c => c.Name)
                .ToList();

            var result = new StringBuilder();

            foreach (var category in categories)
            {
                result.AppendLine($"--{category.Name}");

                foreach (var book in category.CategoryBooks
                                    .OrderByDescending(cb => cb.Book.ReleaseDate)
                                    .Select(bc => bc.Book)
                                    .Take(3))
                {
                    result.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return result.ToString().Trim();
        }

        public static void IncreasePrices(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            books.ForEach(b => b.Price += 5);
        }

        public static int RemoveBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(b => b.Copies < 4200)
                .ToList();

            var bookCount = books.Count;

            context.Books.RemoveRange(books);
            context.SaveChanges();

            return books.Count;
        }
    }
}
