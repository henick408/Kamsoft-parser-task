using Kamsoft.Dto;
using Kamsoft.Util;
using Microsoft.AspNetCore.Mvc;

namespace Kamsoft.Controllers;

[ApiController]
[Route(("api/v1"))]
public class ParseController(
    StringBase64Decoder base64Decoder
    ) : ControllerBase {
    
    [HttpPost("parse-content")]
    [Consumes("application/json")]
    public IActionResult ParseContent([FromBody] ParseRequest request) {
        return  Ok(base64Decoder.Decode(request.Content));
    }
    
}