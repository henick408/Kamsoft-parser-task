using Kamsoft.Util;

namespace Kamsoft.Config;

public static class ServiceExtensions {
    public static void AddBase64Encoder(this IServiceCollection services) {
        services.AddScoped<StringBase64Decoder>();
    }
}