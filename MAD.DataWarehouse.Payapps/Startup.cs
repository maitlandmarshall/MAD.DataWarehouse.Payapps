using MAD.DataWarehouse.Payapps.Api;
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

            serviceDescriptors.AddHttpClient<OauthControllerApiClient>(this.ConfigurePaysappApiClient);
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

        private void ConfigurePaysappApiClient(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://api.payapps.com/");
        }
    }
}