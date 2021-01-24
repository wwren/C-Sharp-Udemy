using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /*foreach (var b in books)
            {
                Console.WriteLine(b.Title);
            }*/
            // Linq extension methods
            var cheapBooks = books
                                                    .Where(b => b.Price < 10)
                                                    .OrderBy(b => b.Title)
                                                    .Select(b => b.Title);

        /*    foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook);
            }*/

            // Linq query operations
            var cheapB = 
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            /*foreach (var cheapBook in cheapB)
            {
                Console.WriteLine(cheapBook.Title);
            }*/

            var asp = books.SingleOrDefault(b => b.Title == "ADO.Net Step by Step++");

            /*Console.WriteLine(asp == null);*/

            var first = books.FirstOrDefault(b => b.Price == 5);

            var last = books.LastOrDefault(b => b.Price == 5);

            var selectiveBooks = books.Skip(2).Take(3);
            foreach (var b in selectiveBooks)
            {
                Console.WriteLine(b.Title);
            }

            var max = books.Max(b => b.Price);
            var sum = books.Sum(b => b.Price);
        }

    }
}
