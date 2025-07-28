public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

public class Library
{
    public List<Book> Books { get; } = new();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> ListBooksByAuthor(string author)
    {
        return Books
            .Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}

class Program
{
    private static void Main()
    {
        var library = new Library();

        library.AddBook(new Book("1984", "Джордж Оруэлл", 1948));
        library.AddBook(new Book("Тревожные люди", "Фредрик Бакман", 2019));
        library.AddBook(new Book("Человек, который принял жену за шляпу", "Оливер Сакс", 1971));
        library.AddBook(new Book("Скотный двор", "Джордж Оруэлл", 1945));
        library.AddBook(new Book("Война и мир", "Лев Толстой", 1869));
        library.AddBook(new Book("Анна Каренина", "Лев Толстой", 1877));
        library.AddBook(new Book("Детство", "Лев Толстой", 1852));
        library.AddBook(new Book("Евгений Онегин", "Александр Пушкин", 1833));

        Console.WriteLine("Введите автора для поиска книг: ");
        var author = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(author))
        {
            Console.WriteLine("\n Не введено имя автора");
            return;
        }
        var authorBooks = library.ListBooksByAuthor(author);

        if (authorBooks.Count > 0)
        {
            Console.WriteLine($"\nКниги автора {author}:");
            foreach (var book in authorBooks)
            {
                Console.WriteLine($"- \"{book.Title}\" {book.Author}, ({book.Year} год)");
            }
        }
        else
        {
            Console.WriteLine($"\nКниг автора {author} не найдено в библиотеке.");
        }
    }
}
