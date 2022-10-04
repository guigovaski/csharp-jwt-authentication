using JwtAuthentication.Models.Enums;

namespace JwtAuthentication.Dtos;

public class UserRegisterDto
{
    public bool IsAuthenticated { get; set; }
    public string? Token { get; set; }
    public Role Role { get; set; }
}
