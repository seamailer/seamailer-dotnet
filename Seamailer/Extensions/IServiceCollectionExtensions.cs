using Microsoft.Extensions.DependencyInjection;
using Seamailer.Contracts;
using Seamailer.Services;
using Seamailer.Settings;
using Seamailer.Shared;

namespace Seamailer.Extensions;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddSeaMailer(this IServiceCollection services)
    {
        // Register the SeaMailerSetting class with the DI container
        services.AddOptions<SeaMailerSetting>()
              .BindConfiguration(nameof(SeaMailerSetting));

        // Register the HttpClient class with the DI container
        services.AddHttpClient();

        // Register the IResult interface with the DI container
        services.AddScoped(typeof(IResult<>), typeof(Result<>));

        // Register the ISeaMailerClient interface with the DI container
        services.AddScoped<ISeaMailerClient, SeaMailerClient>();

        return services;
    }
}
