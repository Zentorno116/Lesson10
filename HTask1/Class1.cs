using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string author, string publisher)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
    }
}

public class BookContainer
{
    private List<Book> books;

    public BookContainer()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public delegate int BookComparison(Book x, Book y);

    public void SortBooks(BookComparison comparison)
    {
        books.Sort(new Comparison<Book>(comparison));
    }
}
