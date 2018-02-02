using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StackExchange.StacMan.Tests
{
    // these actually talk over the network
    public class IntegrationTests
    {
        [Fact]
        public void BasicTestNoManager()
        {
            var client = new StacManClient();

            var sites = client.Sites.GetAll(pagesize: 50).Result;
            Assert.Equal("http://api.stackexchange.com/2.0/sites?pagesize=50", sites.ApiUrl);
            Assert.Equal(50, sites.Data.Items.Count());
            Assert.True(sites.Data.HasMore);
        }
        [Fact]
        public void BasicTestWithManager()
        {
            var client = new StacManClient();
            client.UserAgent = GetType().Name;
            List<string> urls = new List<string>();
            client.SetUrlManager(x =>
            {
                lock (urls) urls.Add(x);
                System.Console.WriteLine("Querying: " + x);
                return x;
            });

            var sites = client.Sites.GetAll(pagesize: 50).Result;
            Assert.Equal("http://api.stackexchange.com/2.0/sites?pagesize=50", sites.ApiUrl);
            Assert.Equal(50, sites.Data.Items.Count());
            Assert.True(sites.Data.HasMore);

            lock (urls)
            {
                Assert.Single(urls);
                Assert.Equal("http://api.stackexchange.com/2.0/sites?pagesize=50", urls[0]);
            }
        }


    }
}
