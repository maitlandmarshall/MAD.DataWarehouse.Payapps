using MAD.DataWarehouse.Payapps.Api;
using MAD.DataWarehouse.Payapps.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MIFCore.Settings;
using Payapps.Api;
using System;
using System.Net.Http;

namespace MAD.DataWarehouse.Payapps
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddIntegrationSettings<AppConfig>();
            serviceDescriptors.AddTransient<PayappsAuthDelegatingHandler>();

            serviceDescriptors.AddDbContext<PayappsDbContext>((svc, opt) => opt.UseSqlServer(svc.GetRequiredService<AppConfig>().ConnectionString));

            serviceDescriptors
                .AddHttpClient<OauthControllerApiClient>(this.ConfigurePaysappApiClient);

            serviceDescriptors
                .AddHttpClient<ProjectsControllerApiClient>(this.ConfigurePaysappApiClient)
                .AddHttpMessageHandler<PayappsAuthDelegatingHandler>();

            serviceDescriptors
                .AddHttpClient<PayappsControllerApiClient>(this.ConfigurePaysappApiClient)
                .AddHttpMessageHandler<PayappsAuthDelegatingHandler>();
        }

        public void Configure()
        {

        }

        public void PostConfigure(PayappsDbContext dbContext)
        {
            dbContext.Database.Migrate();
        }

        private void ConfigurePaysappApiClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.payapps.com/");
        }
    }
}