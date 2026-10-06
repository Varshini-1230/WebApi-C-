using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(GreetReq request)
    {
        return $"Hello {request.name}";
    }
}
public sealed record GreetReq(string name);