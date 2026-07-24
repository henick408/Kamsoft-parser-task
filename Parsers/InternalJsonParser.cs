using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class InternalJsonParser : IContentParser {
    public ParseContentType Type => ParseContentType.INTERNAL_JSON;
    
    public object Parse(string content) {
        throw new NotImplementedException();
    }
}