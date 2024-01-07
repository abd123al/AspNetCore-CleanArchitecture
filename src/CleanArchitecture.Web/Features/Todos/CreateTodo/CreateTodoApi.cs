using CleanArchitecture.Web.Extensions;

using FluentValidation;

// using Microsoft.AspNetCore.Http.HttpResults;

namespace CleanArchitecture.Web.Features.Todos.CreateTodo;

public static class CreateTodoApi
{
    public static RouteGroupBuilder MapTodos(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/todos");

        group.WithTags("Todos");
        group.WithOpenApi();

        // Add security requirements, all incoming requests to this API *must*
        // be authenticated with a valid user.
        // group.RequireAuthorization()
        //      .AddOpenApiSecurityRequirement();

        // Rate limit all of the APIs
        group.RequireFixedRateLimit();

        group.MapPost("/", async (CreateTodoRequest newTodo, IValidator<CreateTodoRequest> validator) =>
        {
            var validationResult = await validator.ValidateAsync(newTodo);

            if (!validationResult.IsValid)
            {
                return Results.ValidationProblem(validationResult.ToDictionary());
            }

            return Results.Ok();
        });

        return group;
    }
}
