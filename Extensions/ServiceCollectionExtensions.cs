using FinalException.AzureKeyVault.HowToUse.Dtos;
using FinalException.AzureKeyVault.HowToUse.Services;

namespace FinalException.AzureKeyVault.HowToUse.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddExternalServiceApi(this IServiceCollection services)
        {
            services
               .AddOptions<ExternalServiceApi>()
               .Configure<IConfiguration>(
                  (settings, configuration) => configuration.GetSection(nameof(ExternalServiceApi)).Bind(settings));

            services.AddSingleton<IExternalServiceApiClient, ExternalServiceApiClient>();

            return services;
        }
    }
}
