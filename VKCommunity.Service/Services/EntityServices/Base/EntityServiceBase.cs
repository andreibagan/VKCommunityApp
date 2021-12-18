using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VKCommunity.Service.Services.EntityServices.Base
{
    public class EntityServiceBase<T>
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;

        public EntityServiceBase(string url)
        {
            _httpClient = new HttpClient();
            _url = url;
        }

        private async Task<List<T>> GetBaseAsync(string url, Func<HttpResponseMessage, Task<List<T>>> responseContent)
        {
            var entity = new List<T>();
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                entity = await responseContent(response);
            }
            return entity;
        }

        protected async Task<T> GetAsync(int id)
        {
            var entity = await GetBaseAsync($"{_url}/{id}", async response =>
            {
                return new List<T> { await response.Content.ReadAsAsync<T>() };
            });
            return entity.FirstOrDefault();
        }

        protected async Task<List<T>> GetAsync()
        {
            return await GetBaseAsync(_url, async response =>
            {
                return await response.Content.ReadAsAsync<List<T>>();
            });
        }

        protected async Task<bool> PostAsync(T entity)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_url, entity);
            response.EnsureSuccessStatusCode();
            return await Task.FromResult(true);
        }
    }
}
