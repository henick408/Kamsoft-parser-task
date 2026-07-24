using Kamsoft.Models;

namespace Kamsoft.Parsers;

public interface IContentParser {
    
    ParseContentType Type { get; }

    object Parse(string content);

}