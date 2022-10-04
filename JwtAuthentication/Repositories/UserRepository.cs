using JwtAuthentication.Models;
using JwtAuthentication.Models.Enums;

namespace JwtAuthentication.Repositories;

public static class UserRepository
{
    private static readonly List<User> _users = new List<User>();

    public static void Post(User user)
    {
        _users.Add(user);
    }

    public static User Get(string username, string password) => 
        _users.FirstOrDefault(u => u.Username == username && u.Password == password)!;
    
}
