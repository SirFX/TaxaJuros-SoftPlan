using System;
using System.Collections.Generic;
using System.Text;

namespace API2.Domain.Interface
{
    public interface ICalculaTaxaJurosService
    {
        decimal CalculaJuros(decimal taxaJuros, decimal valorInicial, int meses);
    }
}
