using System.Text.Json.Serialization;
using Kamsoft.Config;

namespace Kamsoft;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers()
            .AddJsonOptions(options => {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddBase64Encoder();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment()) {
            app.MapOpenApi();
        }

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}