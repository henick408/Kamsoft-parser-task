using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class CsvParser : IContentParser {
    public ParseContentType Type => ParseContentType.CSV;
    
    public IList<object?> Parse(string content) {
        throw new NotImplementedException();
    }
}