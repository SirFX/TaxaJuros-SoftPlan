using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AP1.IntegracaoTests
{
    public class API1Scenario
    {
        private readonly API1TestContext _testContext;

        public API1Scenario()
        {
            _testContext = new API1TestContext();
        }

        [Fact]
        public async Task TaxaJuros_getReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/taxajuros");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task TaxaJuros_GetById_ReturnsNotFoundResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/taxajuros/1");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
