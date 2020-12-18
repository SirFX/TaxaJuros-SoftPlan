using API1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;

namespace AP1.IntegracaoTests
{
    public class API1TestContext
    {
        public HttpClient Client { get; set; }
        private TestServer _server;

        public API1TestContext()
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

