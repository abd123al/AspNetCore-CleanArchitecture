// using System.Reflection;

namespace CleanArchitecture.Web.Extensions;

public static class RepositoryExtension
{
    public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
    {
        // var repositoryTypes = Assembly.GetExecutingAssembly().GetTypes()
        //     .Where(type => !type.IsAbstract && !type.IsInterface && type.GetInterfaces().Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IRepositoryBase<>)));

        // // filter out RepositoryBase<>
        // var nonBaseRepos = repositoryTypes.Where(t => t != typeof(RepositoryBase<>));

        // foreach (var repositoryType in nonBaseRepos)
        // {
        //     var interfaces = repositoryType.GetInterfaces()
        //         .Where(@interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IRepositoryBase<>))
        //         .ToList();

        //     if (interfaces.Count != 1)
        //     {
        //         throw new InvalidOperationException($"Repository '{repositoryType.Name}' must implement only one interface that implements IRepositoryBase<T>.");
        //     }

        //     services.AddScoped(interfaces[0], repositoryType);
        // }

        return services;
    }
}
