using Moq;
using StackExchange.StacMan.Tests.Utilities;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class StacManResponseTests
    {
        [Fact]
        public void Api_web_exception_response()
        {
            var mock = new Mock<StacManClient>(null, null);
            var client = mock.Object;

            mock.FakeGET(throws: new System.Net.WebException("timeout"));
            
            var response = client.Users.GetAll("gaming.stackexchange.com").Result;
            
            Assert.False(response.Success);
            Assert.Null(response.Data);
            Assert.IsType<System.Net.WebException>(response.Error);
            Assert.False(response.ReceivedApiResponse);
            Assert.NotNull(response.ApiUrl);
            Assert.Null(response.RawData);
        }

        [Fact]
        public void Test_response_debugging_properties()
        {
            var mock = new Mock<StacManClient>("myappkey", null);

            //http://api.stackexchange.com/2.0/suggested-edits?pagesize=2&site=superuser
            mock.FakeGET(response: @"{""items"":[{""suggested_edit_id"":10345,""post_id"":410422,""post_type"":""question"",""comment"":""Removed unnecessary greetings"",""creation_date"":1333996736,""proposing_user"":{""user_id"":111438,""display_name"":""dnbrv"",""reputation"":348,""user_type"":""registered"",""profile_image"":""http://www.gravatar.com/avatar/0299470f4dcad8b4d79fd01c5dc7be4a?d=identicon&r=PG"",""link"":""http://superuser.com/users/111438/dnbrv""}},{""suggested_edit_id"":10344,""post_id"":410423,""post_type"":""question"",""comment"":""updated info"",""creation_date"":1333995585,""approval_date"":1333997046,""proposing_user"":{""user_id"":127397,""display_name"":""James Wilson"",""reputation"":3,""user_type"":""unregistered"",""profile_image"":""http://www.gravatar.com/avatar/ace280d5491b40c2645d856bf20337a3?d=identicon&r=PG"",""link"":""http://superuser.com/users/127397/james-wilson""}}],""quota_remaining"":262,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;

            var response = client.SuggestedEdits.GetAll("superuser", pagesize: 2).Result;
            Assert.Contains("site=superuser", response.ApiUrl);
            Assert.Contains("pagesize=2", response.ApiUrl);
            Assert.Contains("key=myappkey", response.ApiUrl);

            Assert.NotNull(response.RawData);
        }

        [Fact]
        public void Stack_Exchange_API_Exception_response()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/inbox?access_token=foo
            mock.FakeGET(response: @"{""error_id"":405,""error_name"":""key_required"",""error_message"":""`key` is required when `access_token` is passed.""}");

            var client = mock.Object;

            var response = client.Inbox.Get("foo").Result;

            Assert.False(response.Success);
            Assert.True(response.ReceivedApiResponse);
            Assert.NotNull(response.RawData);
            Assert.IsType<Exceptions.StackExchangeApiException>(response.Error);
            Assert.Equal(405, ((Exceptions.StackExchangeApiException)response.Error).ErrorId);
            Assert.Equal("key_required", ((Exceptions.StackExchangeApiException)response.Error).ErrorName);
            Assert.Equal("`key` is required when `access_token` is passed.", ((Exceptions.StackExchangeApiException)response.Error).ErrorMessage);
            Assert.Null(response.Data.Items);
            Assert.Equal(405, response.Data.ErrorId);
            Assert.Equal("key_required", response.Data.ErrorName);
            Assert.Equal("`key` is required when `access_token` is passed.", response.Data.ErrorMessage);
        }
    }
}
