using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API1.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;
        public TaxaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }
        /// <summary>
        /// Obter a taxa de juros.
        /// </summary>
        /// <response code="200">A taxa de juros foi obtida com sucesso.</response>

        [HttpGet]
        [ProducesResponseType(typeof(decimal), 200)]
        public ActionResult<decimal> Get()
        {
            try
            {
                return Ok(_taxaJurosService.GetTaxaJuros());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
