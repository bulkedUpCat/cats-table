using Cats.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cats.API.Controllers;

[ApiController]
[Route("api/cats")]
public class CatsController: ControllerBase
{
    private readonly ICatService _catService;

    public CatsController(ICatService catService)
    {
        _catService = catService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var cats = await _catService.GetAllCatsAsync();
        return Ok(cats);
    }
}