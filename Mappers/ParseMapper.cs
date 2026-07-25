using Kamsoft.Dto;

namespace Kamsoft.Mappers;

public class ParseMapper : IParseMapper {
    public ParseResponse ToResponse(IList<Dictionary<string, object?>> content) {
        return new ParseResponse {
            Success = true,
            Count = content.SelectMany(dictionary => dictionary).Count(),
            Data = content
        };
    }
}