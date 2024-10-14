using Azure.Identity;
using FinalException.AzureKeyVault.HowToUse.Extensions;

namespace FinalException.AzureKeyVault.HowToUse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var vaultUri = builder.Configuration.GetValue<Uri>("VaultUrli");
            builder.Configuration.AddAzureKeyVault(vaultUri, new DefaultAzureCredential());

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddExternalServiceApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
