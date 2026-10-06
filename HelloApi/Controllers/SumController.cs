
using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    [HttpPost]
    public int Post(SumRequest request)
    {
        return request.FirstNumber+request.SecondNumber;
    }
}
public sealed record SumRequest (int FirstNumber,int SecondNumber);