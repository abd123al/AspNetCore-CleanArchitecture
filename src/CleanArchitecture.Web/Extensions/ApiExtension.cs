using CleanArchitecture.Web.Features.Todos.CreateTodo;

namespace CleanArchitecture.Web.Extensions;

public static class ApiExtension
{
    public static IEndpointRouteBuilder UseCustomizedApi(this IEndpointRouteBuilder app)
    {
        app.MapHello();
        app.MapTodos();

        return app;
    }
}
