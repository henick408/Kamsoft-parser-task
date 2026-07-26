using System.Text.Json;
using CsvHelper;
using Kamsoft.Dto;
using Microsoft.AspNetCore.Diagnostics;

namespace Kamsoft.Exceptions;

public class GlobalExceptionHandler : IExceptionHandler {
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken) {
        switch (exception) {
            case JsonException ex :
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

                await httpContext.Response.WriteAsJsonAsync(
                    new ErrorResponse {
                        Success = false,
                        Message = ex.Message
                    },
                    cancellationToken);

                return true;
            
            case CsvHelperException ex:
                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;

                await httpContext.Response.WriteAsJsonAsync(
                    new ErrorResponse {
                        Success = false,
                        Message = ex.Message
                    },
                    cancellationToken);
                
                return true;
            
            default:
                return false;
        }
    }
}