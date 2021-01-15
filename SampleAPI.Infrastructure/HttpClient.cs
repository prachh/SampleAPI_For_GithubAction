using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SampleAPI.Infrastructure.Provider;

namespace SampleAPI.Infrastructure
{
    public class HttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public HttpClient(System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetValues(string url, Dictionary<string, string> headervalues = null)
        {
            using (var request = CreateRequest(HttpMethod.Get, url, headervalues))
            {
                return await _httpClient.SendAsync(request);
            }
        }

        private HttpRequestMessage CreateRequest(HttpMethod method, string url, Dictionary<string, string> headervalues = null)
        {
            var request = new HttpRequestMessage(method, url);

            if (headervalues != null)
            {
                foreach (var headers in headervalues)
                {
                    request.Headers.Add(headers.Key, headers.Value);
                }
            }
            return request;
        }
     }
 }
