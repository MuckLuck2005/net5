using System;
using System.Collections.Generic;

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book FindBookByCode(string code)
    {
        return books.Find(book => string.Equals(book.Code, code, StringComparison.OrdinalIgnoreCase));
    }

    public override string ToString()
    {
        string result = "Books in the library:\n";
        foreach (var book in books)
        {
            result += book.ToString() + "\n";
        }
        return result;
    }
}
