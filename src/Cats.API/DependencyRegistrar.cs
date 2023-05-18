using Cats.API.DataProviders;
using Cats.API.DataProviders.Interfaces;
using Cats.API.MappingProfiles;
using Cats.API.Services;
using Cats.API.Services.Interfaces;

namespace Cats.API;

public static class DependencyRegistrar
{
    public static IServiceCollection ConfigureAutoMapper(
        this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CatProfile));

        return services;
    }

    public static IServiceCollection ConfigureDataProviders(
        this IServiceCollection services)
    {
        services.AddScoped<IDataProvider, DataProvider>();

        return services;
    }

    public static IServiceCollection ConfigureServices(
        this IServiceCollection services)
    {
        services.AddScoped<ICatService, CatService>();

        return services;
    }

    public static IServiceCollection ConfigureCors(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy("AllowAll", config =>
            {
                config.AllowAnyOrigin();
                config.AllowAnyMethod();
                config.AllowAnyHeader();
            });
        });

        return services;
    }
}