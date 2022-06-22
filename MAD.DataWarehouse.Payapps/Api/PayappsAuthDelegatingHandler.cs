using Payapps.Api;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MAD.DataWarehouse.Payapps.Api
{
    internal class PayappsAuthDelegatingHandler : DelegatingHandler
    {
        private readonly AppConfig appConfig;
        private readonly OauthControllerApiClient oauthControllerApiClient;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);

        private TokenResponseDto authToken;

        public PayappsAuthDelegatingHandler(AppConfig appConfig, OauthControllerApiClient oauthControllerApiClient)
        {
            this.appConfig = appConfig;
            this.oauthControllerApiClient = oauthControllerApiClient;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await this.GetAuthenticated();

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.authToken.AccessToken);

            return await base.SendAsync(request, cancellationToken);
        }

        private async Task GetAuthenticated()
        {
            try
            {
                await this.semaphoreSlim.WaitAsync();

                // If the auth token doesn't need a refresh, do nothing.
                if (this.authToken?.AccessTokenExpiresAt >= DateTime.Now)
                    return;

                var clientIdSecret = $"{this.appConfig.ClientId}:{this.appConfig.ClientSecret}";
                var clientIdSecretBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientIdSecret));

                var authorization = $"Basic {clientIdSecretBase64}";
                var token = await this.oauthControllerApiClient.GetTokenAsync(authorization, "application/x-www-form-urlencoded", new TokenRequestDto
                {
                    Grant_type = TokenRequestDtoGrant_type.Password,
                    Username = this.appConfig.Username,
                    Password = this.appConfig.Password
                });

                this.authToken = token;
            }
            finally
            {
                this.semaphoreSlim.Release();
            }
        }
    }
}
