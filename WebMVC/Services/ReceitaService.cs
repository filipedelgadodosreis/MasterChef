using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WebMVC.Infrastructure;
using WebMVC.Models;


namespace WebMVC.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public IOptions<AppSettings> Settings { get; }

        public ReceitaService(HttpClient httpClient, IOptions<AppSettings> settings)
        {
            Settings = settings;
            _httpClient = httpClient;

            _remoteServiceBaseUrl = $"{Settings.Value.ReceitaUrl}/api/receita/";
        }

        public async Task<IEnumerable<ReceitaViewModel>> GetLatestCookies()
        {
            var uri = Api.Receita.GetLatestCookies(_remoteServiceBaseUrl);
            var responseString = await _httpClient.GetStringAsync(uri);

            var posts = JsonConvert.DeserializeObject<IEnumerable<ReceitaViewModel>>(responseString);

            return posts;
        }
    }
}
