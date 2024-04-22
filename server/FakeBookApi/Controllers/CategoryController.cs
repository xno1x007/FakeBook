using FakeBookApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FakeBookApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ILogger<CategoryController> _logger;

    public CategoryController(ILogger<CategoryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Categories> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Categories
        {
        })
        .ToArray();
    }
}
