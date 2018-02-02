using Moq;
using StackExchange.StacMan.Tests.Utilities;
using System.Linq;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class TagMethodTests
    {
        [Fact]
        public void Tags_get_all_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/tags?page=3&pagesize=2&order=desc&sort=popular&site=gaming
            mock.FakeGET(response: @"{""items"":[{""name"":""league-of-legends"",""count"":768,""is_required"":false,""is_moderator_only"":false,""has_synonyms"":true},{""name"":""pc"",""count"":607,""is_required"":false,""is_moderator_only"":false,""has_synonyms"":false}],""quota_remaining"":-47478,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;

            var result = client.Tags.GetAll("gaming", page: 3, pagesize: 2, order: Order.Desc, sort: Tags.Sort.Popular).Result;
            Assert.True(result.Success);

            var tag = result.Data.Items.Skip(1).First();

            Assert.Equal("pc", tag.Name);
            Assert.Equal(607, tag.Count);
            Assert.False(tag.IsRequired);
            Assert.False(tag.IsModeratorOnly);
            Assert.False(tag.HasSynonyms);
            Assert.Null(tag.UserId);
            Assert.Null(tag.LastActivityDate);
        }
    }
}
