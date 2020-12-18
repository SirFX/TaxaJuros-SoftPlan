using API2.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace API2.Domain.Service
{
    public class CalculaTaxaJurosService : ICalculaTaxaJurosService
    {
        public decimal CalculaJuros(decimal taxaJuros, decimal valorInicial, int meses)
        {
            var valorFinal = (decimal)Math.Pow((double)(1 + taxaJuros), meses);
            valorFinal = valorInicial * valorFinal;

            return Truncate(valorFinal, 2);
        }
        private static decimal Truncate(decimal value, int decimalPlaces)
        {
            var power = (decimal)Math.Pow(10, decimalPlaces);

            return Math.Truncate(value * power) / power;
        }
    }
}
