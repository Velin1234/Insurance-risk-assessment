using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(InsuranceRiskAssessment.Web.Areas.Identity.IdentityHostingStartup))]
namespace InsuranceRiskAssessment.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}