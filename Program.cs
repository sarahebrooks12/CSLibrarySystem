using System;
using System.Collections.Generic;

// as long as we're in same namespace we can access it - no imports/exports
namespace library_system
{
    // when create class - template for class - structure for class 
    class Program
    {
        static void Main(string[] args)
        {
//             Console.WriteLine("Hello World!");
// // a defined type that C# knows - string, int, double, List, Dictionary
//             string name = "Mandy";

//             int scale1to10 = 10;

//             double someDemical = 2.2;

//             List<double> temperatures = new List<double>(){70.4, 96.9, 101.2};

            Dictionary<string, string> warAndPeace = new Dictionary<string, string>(){
                {"Title", "War and Peace"},
                {"Length", "SO Long"}
            };

            Book WarAndPeace = new Book("War and Peace", "Leo Tolstoycd li"){
                ISBN = 123456789
            };

            Book AnnaKarenina = new Book(){
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                ISBN = 012345678
            };

            Console.WriteLine($"{WarAndPeace.Title} by {WarAndPeace.Author}");

            List<Book> LibraryInventory = new List<Book>(){
                WarAndPeace,
                AnnaKarenina
            };

            LibraryInventory.ForEach(book => Console.WriteLine(book.Title));

            Patron steve = new Patron(){
                FirstName = "Steve",
                LastName = "Brownlee"
            };

            // steve.FirstName = "Stephen";

            steve.CheckedOutBook(WarAndPeace);

            Console.WriteLine();

            
        }
    }
}
