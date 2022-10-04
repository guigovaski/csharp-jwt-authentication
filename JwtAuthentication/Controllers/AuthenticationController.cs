using JwtAuthentication.Dtos;
using JwtAuthentication.Models;
using Microsoft.AspNetCore.Mvc;
using JwtAuthentication.Repositories;
using JwtAuthentication.Services;

namespace JwtAuthentication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthenticationController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    [HttpPost("register")]
    public ActionResult<UserRegisterDto> Register(User user)
    {
        UserRepository.Post(user);

        var token = _tokenService.GenerateToken(user);

        var metadata = new UserRegisterDto
        {
            IsAuthenticated = true,
            Role = user.Role,
            Token = token
        };

        return metadata;
    }


    [HttpPost("login")]
    public ActionResult<UserRegisterDto> Login([FromBody] UserLoginDto userLoginDto)
    {
        var user = UserRepository.Get(userLoginDto.Username, userLoginDto.Password);
        
        if (user is null) return NotFound();

        var token = _tokenService.GenerateToken(user);

        var metadata = new UserRegisterDto
        {
            IsAuthenticated = true,
            Role = user.Role,
            Token = token
        };

        return metadata;
    }
}
