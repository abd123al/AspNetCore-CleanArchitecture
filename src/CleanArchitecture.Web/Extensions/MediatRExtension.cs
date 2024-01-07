using System.Reflection;

namespace CleanArchitecture.Web.Extensions;

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
