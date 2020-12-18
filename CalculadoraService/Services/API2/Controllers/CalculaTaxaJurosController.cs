using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using API2.Domain.Service;
using API2.Infra.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaTaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _service;
        public CalculaTaxaJurosController(ITaxaJurosService service)
        {
           _service = service;
        }
        /// <summary>
        /// Obtem valor final do calculo de juros.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="Meses"></param>
        /// <response code ="200">Valor final obtido com sucesso.</response>
        [HttpGet]
        [Route("/api/calculajuros")]
        [ProducesResponseType(typeof(decimal), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CalculaJuro(decimal valorInicial, int Meses)

        {
            try { 
            var taxaJuros = await _service.GetTaxaJuros();

            var CalculaTaxaJuros = new CalculaTaxaJurosService();
            var result = CalculaTaxaJuros.CalculaJuros(taxaJuros.Valor, valorInicial, Meses);
            return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
