class Program
{
    static void Main()
    {
        var container = new BookContainer();
        container.AddBook(new Book("Название1", "Автор1", "Издатель1"));
        container.AddBook(new Book("Название2", "Автор2", "Издатель2"));
        container.AddBook(new Book("Название3", "Автор3", "Издатель3"));

        Console.WriteLine("Sorting by Title:");
        container.SortBooks((x, y) => x.Title.CompareTo(y.Title));
        container.PrintBooks();

        Console.WriteLine("\nSorting by Author:");
        container.SortBooks((x, y) => x.Author.CompareTo(y.Author)); 
        container.PrintBooks();

        Console.WriteLine("\nSorting by Publisher:");
        container.SortBooks((x, y) => x.Publisher.CompareTo(y.Publisher)); 
        container.PrintBooks();
    }
}