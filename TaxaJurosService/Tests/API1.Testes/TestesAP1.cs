using API1.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace TaxaJuros.Testes
{
    public class TestesAP1
    {        
        [Fact]
        public void ObterTaxaJuros()
        {
            var taxajuros = new TaxaJurosService();
            decimal resultado = taxajuros.GetTaxaJuros();
            Assert.Equal(0.01M, resultado);
        }

        [Fact]
        public void ObterTaxaJurosNotEqual()
        {
            var taxajuros = new TaxaJurosService();
            decimal resultado = taxajuros.GetTaxaJuros();
            Assert.NotEqual(1M, resultado);
        }
    }
}
