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

        private string Url => "https://github.com/SirFX/TaxaJuros-SoftPlan";

        public string GetUrlProjeto()
        {
            return Url;
        }
    }
}
