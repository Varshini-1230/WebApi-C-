using System.Globalization;
using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
[ApiController]
[Route("[controller]")]
public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(SquareReq request)
    {
        return request.num * request.num;
    }
}
public sealed record SquareReq(int num);