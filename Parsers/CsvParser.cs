using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class CsvParser : IContentParser {
    public ParseContentType Type => ParseContentType.CSV;
    
    public object Parse(string content) {
        throw new NotImplementedException();
    }
}