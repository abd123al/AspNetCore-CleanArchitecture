using CleanArchitecture.Core.Abstractions.Messaging;

using MediatR;

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
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        return services;
    }
}
