using FMT_MONv2v2.Services;
using Microsoft.AspNetCore.Mvc;

namespace FMT_MONv2v2.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ReviewsController : ControllerBase
{
    private readonly IReviewsService _service;

    ReviewsController(IReviewsService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult?> GetByIdAsync(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
    

}