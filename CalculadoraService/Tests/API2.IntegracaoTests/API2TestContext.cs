using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using API2;

namespace API2.IntegracaoTests
{
    public class API2TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public API2TestContext()
        {
            SetupClient();
        }

        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = _server.CreateClient();
        }
    }
}
