using Kamsoft.Models;
using Kamsoft.Parsers;

namespace Kamsoft.Util;

public class ParserProvider {

    private readonly Dictionary<ParseContentType, IContentParser> parsers;

    public ParserProvider(IEnumerable<IContentParser> parsers) {
        this.parsers = parsers.ToDictionary(p => p.Type);
    }

    public IContentParser Get(ParseContentType type) {
        if (!parsers.TryGetValue(type, out var parser)) {
            throw new InvalidOperationException($"Parser '{type}' is not registered.");
        }

        return parser;
    }

}