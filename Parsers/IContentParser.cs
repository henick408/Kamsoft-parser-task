using Kamsoft.Models;

namespace Kamsoft.Parsers;

public interface IContentParser {
    
    ParseContentType Type { get; }

    IList<object> Parse(string content);
}