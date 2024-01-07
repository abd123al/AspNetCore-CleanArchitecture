using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace CleanArchitecture.UseCases;

public static class MediatRExtension
{
    public static IServiceCollection AddCustomizedMediatR(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            // cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        });

        return services;
    }
}
