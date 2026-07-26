using Kamsoft.Models;

namespace Kamsoft.Parsers;

public interface IContentParser {
    
    ParseContentType Type { get; }
    
    IList<IDictionary<string, object?>> Parse(string content);
}