using CsvHelper;
using MidtermPractical.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    class OutputHelper
    {

        public static void writeToConsole(List<Book> books)
        {
            //Writing into the consule
            foreach (var oneBook in books)
            {
                Console.WriteLine($"Book: {oneBook.BookId}    Title:{oneBook.BookTitle} Release Year:{oneBook.YearOfRelease}");
            }
        }

        public static void writeToCSV(List<Book> books)
        {
            //@ reads the next text as a literal // is a scape
            using (var writer = new StreamWriter(@"..\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }
    }
}
