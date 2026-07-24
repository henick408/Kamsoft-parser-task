using System.Text.Json;
using Kamsoft.Dto;
using Kamsoft.Models;
using Kamsoft.Util;
using Microsoft.AspNetCore.Mvc;

namespace Kamsoft.Controllers;

[ApiController]
[Route(("api/v1"))]
public class ParseController(StringBase64Decoder base64Decoder) : ControllerBase {
    
    [HttpPost("parse-content")]
    [Consumes("application/json")]
    public IActionResult ParseContent([FromBody] ParseRequest request) {
        if (!Enum.TryParse(request.Type, true, out ParseContentType _)) {
            return BadRequest(new {
                message = $"Unsupported type '{request.Type}'."
            });
        }
        
        string decodedContent = base64Decoder.Decode(request.Content);
        
        IList<object>? objects = JsonSerializer.Deserialize<IList<object>>(decodedContent);

        return Ok(objects);

    }
    
}