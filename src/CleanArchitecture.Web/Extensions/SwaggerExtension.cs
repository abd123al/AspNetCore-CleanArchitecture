namespace CleanArchitecture.Web.Extensions;

public static class SwaggerExtension
{
    public static IServiceCollection AddCustomizedSwagger(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    public static IApplicationBuilder UseCustomizedSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();

        return app;
    }
}
