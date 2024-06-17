using Microsoft.AspNetCore.Mvc;

namespace Simple_API.Controllers;

[ApiController]
[Route("[controller]")]
public class SimpleAPI : ControllerBase
{
    [HttpGet]
    [Route("sum")]
    public IActionResult GetSum([FromQuery] int num1, [FromQuery] int num2)
    {
        int sum = num1 + num2;
        return Ok(sum);
    }
}