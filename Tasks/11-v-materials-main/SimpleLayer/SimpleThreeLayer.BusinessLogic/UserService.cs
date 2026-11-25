using SimpleThreeLayer.DataAccess;
using SimpleThreeLayer.Models;
namespace SimpleThreeLayer.BusinessLogic;

public class UserService
{
    private readonly UserRepository _repository;
    
    public UserService(UserRepository repository)
    {
        _repository = repository;
    }

    public void CreateUser(int id, string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Invalid name!");
        }

        var user = new User
        {
            Id = id,
            Name = name
        };

        _repository.AddUser(user);
    }

    public List<User> GetAllUsers()
    {
        return _repository.GetUsers();
    }
}

// Този слой проверява дали въведеното име е валидно.
/* Част 2 - задача 5
 1. Проверката се намира в слоя с бизнес логика.
 2. Проверката string.IsNullOrWhiteSpace(name) улавя случаите, 
 в които името е празно, null или съдържа само интервали. Не
 се допуска, защото трябва задължително да има име.
 3. Това означава, че кодът прекъсва изпълнението си и 
 генерира грешка от тип ArgumentException, 
 тъй като е получен невалиден аргумент.*/