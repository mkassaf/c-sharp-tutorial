using System;

namespace Generic
{

    
    /**
     * In this exmaple we craeted a class that conatins a list. 
     * This a real exmaple how the list is used
     */
    class Program
    {

        static void Main(string[] args)
        {
            Book book = new Book(1, "C#");
            book.Category = BookCategory.PROGRAMING;
            book.AddAuthor("Mustafa");
            
            book.AddAuthor("Rami");

            book.AddAuthor("Elias");

            Console.WriteLine(book.ToString());

            book.RemoveAuthor("Rami");

            Console.WriteLine(book.ToString());

        }
    }
}
