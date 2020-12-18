using API2.Domain.Service;
using System;
using Xunit;

namespace API2.UnitTests
{
    public class TestesAPI2
    {
        [Theory]
        [InlineData(0.01, 100, 5, 105.1)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(0, 1, 0, 1)]
        [InlineData(0, 10, 10, 10)]
        public void CalculaTaxaJuros(decimal juros, decimal valorInicial, int Meses, decimal result)
        {
            var CalculaTaxaJuros = new CalculaTaxaJurosService();
            decimal ValorFinal = CalculaTaxaJuros.CalculaJuros(juros, valorInicial, Meses);
            Assert.Equal(result, ValorFinal);
        }

        [Theory]
        [InlineData(0.01, 100, 5, 1)]
        [InlineData(0.01, 100, 5, 0)]
        [InlineData(0.01, 100, 5, 100)]
        public void CalculaTaxaJurosNotEqual(decimal juros, decimal valorInicial, int Meses, decimal result)
        {
            var CalculaTaxaJuros = new CalculaTaxaJurosService();
            decimal ValorFinal = CalculaTaxaJuros.CalculaJuros(juros, valorInicial, Meses);
            Assert.NotEqual(result, ValorFinal);
        }
    }
}
