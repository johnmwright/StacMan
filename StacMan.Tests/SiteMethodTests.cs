using Moq;
using StackExchange.StacMan.Tests.Utilities;
using System.Linq;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class SiteMethodTests
    {
        [Fact]
        public void Sites_get_all_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/sites?page=1&pagesize=1
            mock.FakeGET(response: @"{""items"":[{""site_type"":""main_site"",""name"":""Stack Overflow"",""logo_url"":""http://cdn.sstatic.net/stackoverflow/img/logo.png"",""api_site_parameter"":""stackoverflow"",""site_url"":""http://stackoverflow.com"",""audience"":""professional and enthusiast programmers"",""icon_url"":""http://cdn.sstatic.net/stackoverflow/img/apple-touch-icon.png"",""aliases"":[""http://www.stackoverflow.com""],""site_state"":""normal"",""styling"":{""link_color"":""#0077CC"",""tag_foreground_color"":""#3E6D8E"",""tag_background_color"":""#E0EAF1""},""launch_date"":1221436800,""favicon_url"":""http://cdn.sstatic.net/stackoverflow/img/favicon.ico"",""related_sites"":[{""name"":""Stack Overflow Chat"",""site_url"":""http://chat.stackoverflow.com"",""relation"":""chat""}],""markdown_extensions"":[""Prettify""]}],""quota_remaining"":-50833,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;

            var result = client.Sites.GetAll(filter: "default", page: 1, pagesize: 1).Result;
            Assert.True(result.Success);

            var site = result.Data.Items.Single();

            Assert.Equal("main_site", site.SiteType);
            Assert.Equal("Stack Overflow", site.Name);
            Assert.Equal("http://cdn.sstatic.net/stackoverflow/img/logo.png", site.LogoUrl);
            Assert.Equal("stackoverflow", site.ApiSiteParameter);
            Assert.Equal("http://stackoverflow.com", site.SiteUrl);
            Assert.Equal("professional and enthusiast programmers", site.Audience);
            Assert.Equal("http://cdn.sstatic.net/stackoverflow/img/apple-touch-icon.png", site.IconUrl);
            Assert.Equal("http://www.stackoverflow.com", site.Aliases.Single());
            Assert.Equal(StacMan.Sites.SiteState.Normal, site.SiteState);
            Assert.Equal("#0077CC", site.Styling.LinkColor);
            Assert.Equal("#3E6D8E", site.Styling.TagForegroundColor);
            Assert.Equal("#E0EAF1", site.Styling.TagBackgroundColor);
            Assert.Equal(1221436800L.ToDateTime(), site.LaunchDate);
            Assert.Equal("http://cdn.sstatic.net/stackoverflow/img/favicon.ico", site.FaviconUrl);
            Assert.Equal("Stack Overflow Chat", site.RelatedSites.Single().Name);
            Assert.Equal("http://chat.stackoverflow.com", site.RelatedSites.Single().SiteUrl);
            Assert.Equal("chat", site.RelatedSites.Single().Relation);
            Assert.Equal("Prettify", site.MarkdownExtensions.Single());
        }
    }
}
