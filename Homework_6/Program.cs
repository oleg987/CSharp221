using System;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Name = "John";
            author.Surname = "Bowie";
            author.Birthday = 1967;
            author.Nationality = "englishman";
            Book book = new Book();
            book.Id = 503843;
            book.Title = "Murder";
            book.Genre = "Criminal";
            book.Quantity_Of_Pages = 234;
            Publisher publisher = new Publisher("RELX", 1999,"England");
        
        }
    }
}
