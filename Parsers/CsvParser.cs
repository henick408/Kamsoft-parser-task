using System.Globalization;
using CsvHelper;
using Kamsoft.Models;

namespace Kamsoft.Parsers;

public class CsvParser : IContentParser {
    public ParseContentType Type => ParseContentType.CSV;
    
    public IList<object> Parse(string content) {
        using StringReader reader = new StringReader(content);
        using CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);

        return csvReader.GetRecords<dynamic>()
            .Cast<object>()
            .ToList();

    }
}