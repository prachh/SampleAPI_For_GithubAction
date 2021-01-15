using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SampleAPI.Infrastructure.Provider
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetValues(string url, Dictionary<string, string> headervalues = null);
    }
}
