using SimpleThreeLayer.Models;
namespace SimpleThreeLayer.DataAccess;

public class UserRepository
{
    private readonly List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public List<User> GetUsers()
    {
        return _users.ToList();
    } 
}

// Този слой отговаря за съхраняването на потребителите.