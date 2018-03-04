using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P05BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = new DateTime();
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
        //LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00
    }

    class Library
    {
        public string Name { get; set; } // ne znam zashto e nujno da se pravi takuv klas...
        public List<Book> Books = new List<Book>();
    }


    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine().Trim());

            Library library = new Library();
            library.Name = "Dead Trees";

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] input = Console.ReadLine().Trim().Split();
                string bookTitle = input[0];
                string author = input[1];
                string publisher = input[2];
                string dateFormat = "dd.MM.yyyy";
                DateTime releaseDate = DateTime.ParseExact(input[3], dateFormat, CultureInfo.InvariantCulture);
                string isbn = input[4];
                decimal price = decimal.Parse(input[5]);

                Book currentBook = new Book(bookTitle, author, publisher, releaseDate, isbn, price);
                library.Books.Add(currentBook);
            }

            Dictionary<string, decimal> authorTotalIncome = new Dictionary<string, decimal>();

            foreach (Book book in library.Books)
            {
                if (authorTotalIncome.ContainsKey(book.Author) == false)
                {
                    authorTotalIncome.Add(book.Author, book.Price);
                }
                else
                {
                    authorTotalIncome[book.Author] += book.Price;
                }
            }

            //authorTotalIncome = authorTotalIncome.OrderBy(price => price.Value).ThenBy(author => author.Key).ToDictionary();
            //foreach (var kvp in authorTotalIncome)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            //}

            foreach (var kvp in authorTotalIncome.OrderByDescending(price => price.Value).ThenBy(author => author.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

            //main ends here
        }
    }
}
