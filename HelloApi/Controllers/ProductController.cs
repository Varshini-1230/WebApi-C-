using Microsoft.AspNetCore.Mvc;
namespace HelloApi.Controllers;
public class Product
{
    public int Id{get; set;}
    public string Name{get; set;}
    public int Price{get; set;}
    public string Brand{get; set;}
}
[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Get()
    {
        return new Product{Id=1,Name="Laptop",Price=45000,Brand="hp"};
    }
}