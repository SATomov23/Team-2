using SchoolLibrary.Services;
using System.Text;
using SchoolLibrary.Data.Repositories;
Console.OutputEncoding = Encoding.UTF8;
IBookRepositories repositories = new InMemoryBookRepositories();
BookService service = new BookService();

bool running = true;
while (running)
{
    Console.WriteLine("1-Покави всички книги");
    Console.WriteLine("0-Изход");
    Console.Write("Избор:");

    string? choice = Console.ReadLine();

    if (choice == null)
    {
        break;
    }

    if (choice == "1")
    {
        var books = service.GetAllBooks();
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Id}. {book.Title}. {book.Author}");
        }
    }
    else if (choice == "0")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
    Console.WriteLine();
}