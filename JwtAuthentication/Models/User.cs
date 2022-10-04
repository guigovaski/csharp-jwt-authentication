using JwtAuthentication.Models.Enums;

namespace JwtAuthentication.Models;

public class User
{
    public int Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public Role Role { get; set; }
}
