using Cats.API.MappingProfiles;

namespace Cats.API;

public static class DependencyRegistrar
{
    public static IServiceCollection ConfigureAutoMapper(
        this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CatProfile));

        return services;
    }
}