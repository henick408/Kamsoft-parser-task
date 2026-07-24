using System.Text.Json;
using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class InternalJsonParser : IContentParser {
    public ParseContentType Type => ParseContentType.INTERNAL_JSON;
    
    public IList<object?> Parse(string content) {
        return JsonSerializer.Deserialize<IList<object?>>(content);
    }
}