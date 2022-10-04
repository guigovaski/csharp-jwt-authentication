using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthentication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public string Get() => "Hello, world!";

    [HttpGet("authenticated")]
    [Authorize]
    public string Authenticated() => "You are Authenticated!";

    [HttpGet("admin")]
    [Authorize(Roles = "Admin")]
    public string Admin() => "You are Admin!";
}
