using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace API2.IntegracaoTests
{
    public class API2Scenario
    {
        private readonly API2TestContext _testContext;

        public API2Scenario()
        {
            _testContext = new API2TestContext();
        }

        [Fact]
        public async Task CalculaTaxaJuros_getReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
