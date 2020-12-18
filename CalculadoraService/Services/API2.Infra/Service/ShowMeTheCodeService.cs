using API2.Domain.Models;
using API2.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace API2.Infra.Service
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        private readonly HttpClient _httpClient;
        private HttpClient httpClient;

        private string Endpoint => "https://api.github.com/";

        public ShowMeTheCodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Sofplan-Desafio-App");
            
        }
        public async Task<string> GetUrlProjeto()
        {
            return await _httpClient.GetStringAsync($"{Endpoint}");
        }
    }
}
