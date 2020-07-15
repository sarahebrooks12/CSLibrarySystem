using System;

// as long as we're in same namespace we can access it - no imports/exports
namespace library_system
{
    // public - accessible anywhere
    public class Book{

// constructor 
        public Book(string titleParam, string authorParam){
            Title = titleParam;
            Author = authorParam;
        }
// property - can be used other places get(read it) set (write it)
        public string Title {get; set;}

        public string Author {get; set;}

        public int ISBN {get; set;}


    }
}