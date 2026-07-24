using System.Text.Json;
using Kamsoft.Dto;
using Kamsoft.Models;
using Kamsoft.Util;
using Microsoft.AspNetCore.Mvc;

namespace Kamsoft.Controllers;

[ApiController]
[Route(("api/v1"))]
public class ParseController(
    StringBase64Decoder base64Decoder,
    ParserProvider parserProvider
    ) : ControllerBase {
    
    [HttpPost("parse-content")]
    [Consumes("application/json")]
    public IActionResult ParseContent([FromBody] ParseRequest request) {
        if (!Enum.TryParse(request.Type, true, out ParseContentType type)) {
            return BadRequest(new {
                message = $"Unsupported type '{request.Type}'."
            });
        }
        
        string decodedContent = base64Decoder.Decode(request.Content);

        IList<object?> objects = parserProvider.Get(type).Parse(decodedContent);

        return Ok(objects);

    }
    
}