using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace InterviewPreparation.LanguageConcepts.Middlewares;

public class LoggingMiddleware(RequestDelegate next, ILogger logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger _logger = logger;

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation("Request received!");

        await _next(context);

        _logger.LogInformation("Response sent!");
    }
}