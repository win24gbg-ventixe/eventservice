using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController(EventService eventService) : ControllerBase
{
    private readonly EventService _eventService = eventService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _eventService.GetAllAsync();
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetAll(int id)
    {
        var result = await _eventService.GetAsync(id);
        return result is not null ? Ok(result) : NotFound();
    }
}
