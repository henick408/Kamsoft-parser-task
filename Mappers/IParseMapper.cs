using Kamsoft.Dto;

namespace Kamsoft.Mappers;

public interface IParseMapper {
    ParseResponse ToResponse(IList<IDictionary<string, object?>> content);
}