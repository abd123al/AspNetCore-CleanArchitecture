using CleanArchitecture.Web.Extensions;

namespace CleanArchitecture.Web.Features.Todos.CreateTodo;

public static class GetHelloApi
{
    public static RouteGroupBuilder MapHello(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/");

        group.WithTags("Hello");
        group.WithOpenApi();

        // Rate limit all of the APIs
        group.RequireFixedRateLimit();

        static string GetTicks() => (DateTime.Now.Ticks & 0x11111).ToString("00000");

        group.MapGet("/", () => Results.Ok($"Hello {GetTicks()}"));

        return group;
    }
}
