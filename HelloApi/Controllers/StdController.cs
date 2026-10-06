using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
[ApiController]
[Route("[controller]")]
public class StdController : ControllerBase
{
    [HttpPost]
    public Message Post(Stud request)
    {

        return new Message {msg="Student created successfully",Name=request.Name,Age=request.Age,Course=request.Course};
    }
}

public sealed record Stud(string Name, int Age, string Course);

public class Message
{
    public string msg{get; set;}
    public string Name{get; set;}
    public int Age{get; set;}
    public string Course{get; set;}
};