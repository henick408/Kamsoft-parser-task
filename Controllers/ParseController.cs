using Kamsoft.Dto;
using Kamsoft.Models;
using Kamsoft.Parsers;
using Kamsoft.Util;
using Microsoft.AspNetCore.Mvc;

namespace Kamsoft.Controllers;

[ApiController]
[Route("api/v1")]
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

        if (!base64Decoder.TryDecode(request.Content, out string decodedContent)) {
            return BadRequest(new {
                message = "Content is not valid Base64."
            });
        }

        IContentParser parser = parserProvider.Get(type);

        IList<Dictionary<string, object?>> objects = parser.Parse(decodedContent);

        Console.WriteLine(objects.SelectMany(dictionary => dictionary).Count());

        return Ok(objects);

    }
    
}