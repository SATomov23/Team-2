using SchoolLibrary.Services;
using System.Text;
using SchoolLibrary.Data.Repositories;

Console.OutputEncoding = Encoding.UTF8;

IBookRepository repository= new InMemoryBookRepository();
BookService service = new BookService(repository);

bool running = true;
while (running)
{
    Console.WriteLine("1 - Покажи всички книги");
    Console.WriteLine("2 - Заеми книга");
    Console.WriteLine("3 - Върни книга");
    Console.WriteLine("0 - Изход");
    Console.Write("Избор: ");

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
            string status = book.IsBorrowed ? "Заета" : "Налична";
            Console.WriteLine($"{book.Id} | {book.Title} | {book.Author} | {status}");
        }
    }
    else if (choice == "2" || choice == "3")
    {
        Console.Write("Номер на книга: ");
        string? input = Console.ReadLine();

        if (input == null)
        {
            break; 
        }
        else if (int.TryParse(input, out int id))
        {
            if (choice == "2")
            {
                string result = service.BorrowBook(id);
                Console.WriteLine(result);
            }
            else
            {
                string result = service.ReturnBook(id);
                Console.WriteLine(result);
            }
        }
        else
        {
            Console.WriteLine("Невалиден номер на книга.");
        }
    }
    else if (choice == "0")
    {
        running = false;
    }
    else
    {
        Console.WriteLine("Невалиден избор. Моля, опитайте отново.");
    }
    Console.WriteLine();
        
}