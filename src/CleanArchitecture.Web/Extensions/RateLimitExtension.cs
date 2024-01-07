using Microsoft.AspNetCore.RateLimiting;

using System.Threading.RateLimiting;

namespace CleanArchitecture.Web.Extensions;

public static class RateLimitExtension
{
    private static readonly string Policy = "fixed";

    public static IServiceCollection AddCustomizedRateLimit(this IServiceCollection services)
    {
        // Fixed window limiter
        services.AddRateLimiter(_ => _
            .AddFixedWindowLimiter(policyName: Policy, options =>
            {
                options.PermitLimit = 4;
                options.Window = TimeSpan.FromSeconds(12);
                options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                options.QueueLimit = 2;
            }));

        return services;
    }

    public static IApplicationBuilder UseCustomizedRateLimit(this IApplicationBuilder app)
    {
        app.UseRateLimiter();

        return app;
    }

    public static IEndpointConventionBuilder RequireFixedRateLimit(this IEndpointConventionBuilder builder)
    {
        return builder.RequireRateLimiting(Policy);
    }
}
