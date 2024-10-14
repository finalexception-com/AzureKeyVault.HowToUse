using FinalException.AzureKeyVault.HowToUse.Dtos;
using Microsoft.Extensions.Options;

namespace FinalException.AzureKeyVault.HowToUse.Services
{
    public interface IExternalServiceApiClient
    {
        string GetMessage();
    }

    public class ExternalServiceApiClient : IExternalServiceApiClient
    {
        private readonly IOptions<ExternalServiceApi> _options;

        public ExternalServiceApiClient(IOptions<ExternalServiceApi> options)
        {
            _options = options;
        }

        public string GetMessage() 
            => $"ApiUrl is: {_options.Value.ApiUrl}, ApiKey is: {_options.Value.ApiKey}";
    }
}
