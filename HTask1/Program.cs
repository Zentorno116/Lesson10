using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var container = new BookContainer();
        container.AddBook(new Book("Title1", "Author1", "Publisher1"));
        container.AddBook(new Book("Title2", "Author2", "Publisher2"));
        container.AddBook(new Book("Title3", "Author3", "Publisher3"));

        container.SortBooks((x, y) => x.Title.CompareTo(y.Title)); 
        container.SortBooks((x, y) => x.Author.CompareTo(y.Author)); 
        container.SortBooks((x, y) => x.Publisher.CompareTo(y.Publisher)); 
    }
}