using System.Text.Json;
using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class InternalJsonParser : IContentParser {
    public ParseContentType Type => ParseContentType.INTERNAL_JSON;
    
    public IList<IDictionary<string, object?>> Parse(string content) {
        return JsonSerializer.Deserialize<IList<IDictionary<string, object?>>>(content)
               ?? throw new JsonException("JSON content cannot be empty.");
    }
}