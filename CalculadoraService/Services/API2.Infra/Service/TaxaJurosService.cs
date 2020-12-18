using API2.Infra.Interface;
using API2.Domain.Models;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace API2.Infra.Service
{
    public class TaxaJurosService : ITaxaJurosService
    {
       
        private readonly HttpClient _httpClient;
        private string Endpoint => "https://localhost:44359/api";
        public TaxaJurosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<TaxaJurosModel> GetTaxaJuros()
        {
            var TaxaJuros = new TaxaJurosModel();
            var resposta = await _httpClient.GetStringAsync($"{Endpoint}/taxajuros");
            TaxaJuros.Valor = decimal.Parse(resposta,NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture); ;
            return TaxaJuros;
        }        
    }
}
