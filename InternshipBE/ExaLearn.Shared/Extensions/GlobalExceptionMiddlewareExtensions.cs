using ExaLearn.Shared.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace ExaLearn.Shared.Extensions
{
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static void UseGlobalExceptionMiddleware(this IApplicationBuilder app, ILogger logger)
        {
            app.UseMiddleware<ExceptionMiddleware>(logger);
        }
    }
}
