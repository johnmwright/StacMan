using Moq;
using StackExchange.StacMan.Tests.Utilities;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class WrapperTests
    {
        [Fact]
        public void Wrapper_fields_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/filters/!*bOpvmsY(F)
            mock.FakeGETForUrlPattern("filters", response: @"{""items"":[{""filter"":""!*bOpvmsY(F)"",""included_fields"":["".backoff"","".error_id"","".error_message"","".error_name"","".has_more"","".items"","".page"","".page_size"","".quota_max"","".quota_remaining"","".total"","".type"",""badge.badge_id""],""filter_type"":""safe""}],""quota_remaining"":271,""quota_max"":300,""has_more"":false}");

            //http://api.stackexchange.com/2.0/badges?page=2&pagesize=5&site=stackoverflow&filter=!*bOpvmsY(F)
            mock.FakeGETForUrlPattern("badges", @"{""total"":1713,""page_size"":5,""page"":2,""type"":""badge"",""items"":[{""badge_id"":460},{""badge_id"":461},{""badge_id"":462},{""badge_id"":463},{""badge_id"":464}],""quota_remaining"":273,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;
            var result = client.Badges.GetAll("stackoverflow", page: 2, pagesize: 5, filter: "!*bOpvmsY(F)").Result;
            var wrapper = result.Data;

            Assert.Equal(1713, wrapper.Total);
            Assert.Equal(5, wrapper.PageSize);
            Assert.Equal(2, wrapper.Page);
            Assert.Equal(5, wrapper.Items.Length);
            Assert.Equal("badge", wrapper.Type);
            Assert.Equal(273, wrapper.QuotaRemaining);
            Assert.Equal(300, wrapper.QuotaMax);
            Assert.Equal(true, wrapper.HasMore);
            Assert.Null(wrapper.Backoff);
            Assert.Null(wrapper.ErrorId);
            Assert.Null(wrapper.ErrorName);
            Assert.Null(wrapper.ErrorMessage);
        }
    }
}
