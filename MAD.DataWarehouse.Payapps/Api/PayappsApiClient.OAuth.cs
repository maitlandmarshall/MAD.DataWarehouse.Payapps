using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace Payapps.Api
{
    public partial class OauthControllerApiClient
    {
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            using var bodyJson = request.Content.ReadAsStream();
            using var sr = new StreamReader(bodyJson);
            var json = JsonConvert.DeserializeObject<Dictionary<string, string>>(sr.ReadToEnd());
            var formEncoded = new FormUrlEncodedContent(json);

            request.Content = formEncoded;
        }

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response)
        {
            // The API client expects a 201 when the API returns a 200
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                response.StatusCode = System.Net.HttpStatusCode.Created;
            }
        }
    }
}
