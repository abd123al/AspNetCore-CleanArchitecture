using CleanArchitecture.Web.Middlewares;

namespace CleanArchitecture.Web.Extensions;

public static class ListServiceExtension
{
    public static IServiceCollection AddCustomizedListService(this IServiceCollection services)
    {
        services.Configure<ServiceConfig>(config =>
            {
                config.Services = new System.Collections.Generic.List<ServiceDescriptor>(services);
                config.Path = "/listservices";
            });

        return services;
    }

    public static IApplicationBuilder UseCustomizedListService(this IApplicationBuilder app)
    {
        app.UseMiddleware<ShowAllServicesMiddleware>();

        return app;
    }
}
