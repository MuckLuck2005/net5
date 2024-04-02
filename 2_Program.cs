using System;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("John Doe", "C# Programming", "12345", 2020, 300, "Programming");
        Book book2 = new Book("Jane Smith", "Introduction to Algorithms", "67890", 2018, 500, "Computer Science");

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine(library.ToString());

        string searchCode = "12345";
        Book foundBook = library.FindBookByCode(searchCode);
        if (foundBook != null)
        {
            Console.WriteLine($"Book with code {searchCode} found: {foundBook}");
        }
        else
        {
            Console.WriteLine($"Book with code {searchCode} not found.");
        }
    }
}
