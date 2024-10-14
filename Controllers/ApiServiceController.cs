using FinalException.AzureKeyVault.HowToUse.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinalException.AzureKeyVault.HowToUse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiServiceController : ControllerBase
    {
        private readonly IExternalServiceApiClient _externalServiceApiClient;

        public ApiServiceController(IExternalServiceApiClient externalServiceApiClient)
        {
            _externalServiceApiClient = externalServiceApiClient;
        }

        [HttpGet]
        public IActionResult Get() 
        {

            var message = _externalServiceApiClient.GetMessage();
            return Ok(message);
        }
    }
}
