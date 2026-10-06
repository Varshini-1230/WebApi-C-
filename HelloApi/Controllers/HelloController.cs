using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
[ApiController]
[Route("[controller]")]
public class HelloController:ControllerBase{
[HttpGet]
public string Get()

{
 return "Hello, welcome to ASP.NET Core Web API!";   
}
}