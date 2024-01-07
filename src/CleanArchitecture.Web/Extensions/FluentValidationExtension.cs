using CleanArchitecture.Web.Features.Todos.CreateTodo;

using FluentValidation;

namespace CleanArchitecture.Web.Extensions;

public static class FluentValidationExtension
{
    public static IServiceCollection AddCustomizedFluentValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateTodoValidator>();

        return services;
    }
}
