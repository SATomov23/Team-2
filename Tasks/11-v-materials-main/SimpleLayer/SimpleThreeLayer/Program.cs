using SimpleThreeLayer.DataAccess;
using SimpleThreeLayer.BusinessLogic;

public class Program
{
    public static void Main()
    {
        var repository = new UserRepository();
        var service = new UserService(repository);

        service.CreateUser(1, "Alexander");
        service.CreateUser(2, "Maria");
        service.CreateUser(3, "Georgi");
        service.CreateUser(4, "Petar");

        Console.WriteLine("Users:");

        foreach (var user in service.GetAllUsers())
        {
            Console.WriteLine($"{user.Id}: {user.Name}");
        }
    }
}

/* Част 1
 1. Приложението е разделено на слоеве, защото прави кода по-лесен за поддръжка, по-лесен за тестване
 и по-разбираем.
 2. Кодът ще стане дълъг и труден за четене, при всяка промяна може да се чупи приложението, тестването
 и разширяването на кода ще е по-трудно.*/