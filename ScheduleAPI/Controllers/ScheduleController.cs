using Microsoft.AspNetCore.Mvc;
using ScheduleAPI.Models;

namespace ScheduleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ScheduleController : ControllerBase
{
    private readonly ILogger<ScheduleController> _logger;

    public ScheduleController(ILogger<ScheduleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSchedule")]
    public IEnumerable<ScheduleDto>? Get()
    {
        return null;
    }
}