using Kamsoft.Dto;

namespace Kamsoft.Mappers;

public class ParseMapper : IParseMapper {
    public ParseResponse ToResponse(IList<IDictionary<string, object?>> content) {
        return new ParseResponse {
            Success = true,
            Count = content.Count,
            Data = content
        };
    }
}