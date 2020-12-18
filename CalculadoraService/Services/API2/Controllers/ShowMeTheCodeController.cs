using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API2.Infra.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {

        private readonly IShowMeTheCodeService _service;

        public ShowMeTheCodeController(IShowMeTheCodeService service)
        {
            _service = service;
        }
        /// <summary>
        /// Obter URL do respositorio do github.
        /// </summary>
        /// <response code="200">Url obtida com sucesso.</response>
        [HttpGet]
        [Route("/api/showmethecode")]
        public async Task<IActionResult> ShowMeTheCode()
        {
            return Ok(await _service.GetUrlProjeto());
        }

    }
}
