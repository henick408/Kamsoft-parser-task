using Kamsoft.Models;

namespace Kamsoft.Parsers;

public interface IContentParser {
    
    ParseContentType Type { get; }
    
    IList<Dictionary<string, object?>> Parse(string content);
}