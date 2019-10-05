using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_3
{
    public class Book {
        public string Name;
        public string Author;
        public int Year;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<object>() {
                        new Book() { Name = "Guards! Guards!", Year = 2005, Author = "Petrov"},
                        new Book() { Name = "Billie1", Year = 2015, Author = "Kizaaf" },
                        new Book() { Name = "Guards! Guards!", Year = 2005, Author = "Petrov"},
                        new Book() { Name="Finders KeepersLINQ", Year = 2012, Author = "Zakhff" },
                        new Book() { Name = "Billie3", Year = 2015, Author = "Kizaaf" },
                        new Book() { Name = "Aaaaa", Year = 2001, Author = "Brighton"},
                        new Book() { Name="War and Piece", Year = 1970, Author = "Tolstoy"},
                        new Book() { Name="Good LINQBook", Year = 1960, Author = "Ivanov"},
                        new Book() { Name="War and Piece", Year = 1970, Author = "Tolstoy"},
                        new Book() { Name = "Billie", Year = 2015, Author = "Kizaaf" },
                        new Book() { Name="War and Piece", Year = 1970, Author = "Tolstoy"},
                        new Book() { Name = "AppleLINQ", Year = 2001, Author = "Brighton"},
                        new Book() { Name = "Apple", Year = 2001, Author = "Brighton"},
                    };

         
            Console.WriteLine(string.Join("\n", data.OfType<Book>()
                .Where(b => b.Name.Contains("LINQ") && (DateTime.IsLeapYear(b.Year)))
                .Select(b => b.Name)));

            Console.WriteLine("____________________");
            string line = "London is a capitalof Great Britain";
            Console.WriteLine(string.Join(", ", line
                .Where(c => c != ' ')
                .Distinct()
                .Count()
                ));

            Console.WriteLine("____________________");
            var arr = new int[] { 25, 12, 21, 20, 33, 52 };
            Console.WriteLine(string.Join(", ", arr
                .OrderBy(i => i / 10).ThenByDescending(j => j % 10)
                ));

            Console.WriteLine("____________________");
            Console.WriteLine(string.Join("\n", data.OfType<Book>()
                .GroupBy(a => a.Author)
                .Select(str => $"{str.Key}: \t{str.Count()}")));


        }
    }
}
