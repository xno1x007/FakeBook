using FakeBookApi.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FakeBookApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly CategoriesService _categoriesService;

    public CategoryController(CategoriesService categoriesService)
    {
        _categoriesService = categoriesService;
    }

    [HttpGet]
    public async Task<IActionResult> Get() {
        var data = await _categoriesService.GetAsync();
        var result = new { data = data };
        return Ok(result);
    }
}
