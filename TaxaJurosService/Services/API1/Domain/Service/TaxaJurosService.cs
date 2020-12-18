using API1.Domain.Interface;

namespace API1.Domain.Service
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public decimal GetTaxaJuros()
        {
            return 0.01M;
        }
    }
}
