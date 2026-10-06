using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public Employee Post(EmpId request)
    {
        if (request.Id == 101){
            return new Employee {Id=101,Name="Rahul",Department="IT"};
        }
        else
        {
            return new Employee {Id=0 ,Name="NotFound",Department="null"};
        }

    }
}

public sealed record EmpId(int Id);
public class Employee
{
    public int Id{get; set;}
    public string Name{get; set;}
    public string Department{get; set;}
}
