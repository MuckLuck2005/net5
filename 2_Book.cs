using System;

class Book
{
    public string Author { get; private set; }
    public string Title { get; private set; }
    public string Code { get; private set; }
    public int Year { get; private set; }
    public int Pages { get; private set; }
    public string Genre { get; private set; }

    public Book()
    {
    }

    public Book(string author, string title, string code, int year, int pages, string genre)
    {
        Author = author;
        Title = title;
        Code = code;
        Year = year;
        Pages = pages;
        Genre = genre;
    }

    public bool CompareBy(string parameter, Book otherBook)
    {
        switch (parameter.ToLower())
        {
            case "author":
                return string.Equals(this.Author, otherBook.Author, StringComparison.OrdinalIgnoreCase);
            case "title":
                return string.Equals(this.Title, otherBook.Title, StringComparison.OrdinalIgnoreCase);
            case "code":
                return string.Equals(this.Code, otherBook.Code, StringComparison.OrdinalIgnoreCase);
            case "year":
                return this.Year == otherBook.Year;
            case "pages":
                return this.Pages == otherBook.Pages;
            case "genre":
                return string.Equals(this.Genre, otherBook.Genre, StringComparison.OrdinalIgnoreCase);
            default:
                throw new ArgumentException("Invalid parameter for comparison.");
        }
    }

    public override string ToString()
    {
        return $"Author: {Author}, Title: {Title}, Code: {Code}, Year: {Year}, Pages: {Pages}, Genre: {Genre}";
    }
}
