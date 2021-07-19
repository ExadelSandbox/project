using ExaLearn.Shared.Middleware;
using Microsoft.AspNetCore.Builder;

namespace ExaLearn.Shared.Extensions
{
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static void UseGlobalExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
