using System.Text.Json.Serialization;
using Kamsoft.Config;

namespace Kamsoft;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers()
            .AddJsonOptions(options => {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
        builder.Services.AddOpenApi();
        builder.Services.AddBase64Encoder();
        builder.Services.AddParsers();
        builder.Services.AddMappers();

        var app = builder.Build();
        
        if (app.Environment.IsDevelopment()) {
            app.MapOpenApi();
        }

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}