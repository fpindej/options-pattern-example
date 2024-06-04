using Microsoft.Extensions.DependencyInjection;

namespace OptionsPattern.HostApp;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddEuropeanBankApiClientConfiguration(this IServiceCollection services)
    {
        services.AddOptions<EuropeanBankApiClientConfiguration>()
            .BindConfiguration(EuropeanBankApiClientConfiguration.SectionName)
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }
}