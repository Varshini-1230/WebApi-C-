using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
public class Student
{
    public int Id {get; set;}
    public string Name{get; set;}
    public string Course{get;set;}
    public int Age{get;set;}
}
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public Student Get()
    {
        return new Student{Id=1,Name="varsh",Course="B.Tech",Age=20};
    }
}