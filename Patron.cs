using System;
using System.Collections.Generic;

namespace library_system
{
    public class Patron : Person
    {
        public List<Book> CheckedOutBooks { get; set; } = new List<Book>();

        private List<Book> _CheckedOutBooks { get; set; } = new List<Book>();

        public void CheckedOutBook(Book bookToCheckOut)
        {
            if (_CheckedOutBooks.Count < 10)
            {
                _CheckedOutBooks.Add(bookToCheckOut);
            }
            else
            {
                Console.WriteLine("You have too many books checked out!")
            };
        }
    }
}