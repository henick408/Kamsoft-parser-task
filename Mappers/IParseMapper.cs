using Kamsoft.Dto;

namespace Kamsoft.Mappers;

public interface IParseMapper {
    ParseResponse ToResponse(IList<Dictionary<string, object?>> content);
}