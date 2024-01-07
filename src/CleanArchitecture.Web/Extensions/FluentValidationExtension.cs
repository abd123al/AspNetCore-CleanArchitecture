using System.Reflection;

using FluentValidation;

namespace CleanArchitecture.Web.Extensions;

public static class FluentValidationExtension
{
    public static IServiceCollection AddCustomizedFluentValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        // services.AddValidatorsFromAssemblyContaining<CreateTodoValidator>();

        return services;
    }
}
