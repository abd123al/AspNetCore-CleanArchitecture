namespace CleanArchitecture.Web.Extensions;

public static class AutoMapperExtension
{
    public static IServiceCollection AddCustomizedAutoMapper(this IServiceCollection services)
    {
        // TODO:
        // services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}
