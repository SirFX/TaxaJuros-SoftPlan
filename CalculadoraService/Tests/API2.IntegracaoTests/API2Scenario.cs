using FluentAssertions;
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
            var response = await _testContext.Client.GetAsync("/api/calculajuros?valorInicial=100&Meses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task ShowMeTheCode_getReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/api/showmethecode");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
