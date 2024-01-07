using CleanArchitecture.Web.Features.Todos.CreateTodo;

namespace CleanArchitecture.Web.Extensions;

public static class MediatRExtension
{
    public static IServiceCollection AddCustomizedMediatRExtension(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateTodoRequest).Assembly));
        // services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

        return services;
    }
}
