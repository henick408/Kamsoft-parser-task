using Kamsoft.Mappers;
using Kamsoft.Parsers;
using Kamsoft.Util;

namespace Kamsoft.Config;

public static class ServiceExtensions {
    public static void AddBase64Encoder(this IServiceCollection services) {
        services.AddTransient<StringBase64Decoder>();
    }

    public static void AddParsers(this IServiceCollection services) {
        services.AddTransient<IContentParser, CsvParser>();
        services.AddTransient<IContentParser, InternalJsonParser>();
        services.AddTransient<ParserProvider>();
    }

    public static void AddMappers(this IServiceCollection services) {
        services.AddTransient<IParseMapper, ParseMapper>();
    }
}