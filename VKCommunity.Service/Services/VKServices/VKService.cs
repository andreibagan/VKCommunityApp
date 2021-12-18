using System.Net.Http;
using System.Threading.Tasks;

namespace VKCommunity.Service.Services.VKServices
{
    public class VKService : IVKService
    {
        private readonly HttpClient _httpClient;

        public VKService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetHtmlSource(string url)
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync(url))
            {
                using (HttpContent content = response.Content)
                {
                    return await content.ReadAsStringAsync();
                }
            }
        }
    }
}
