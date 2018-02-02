using Moq;
using StackExchange.StacMan.Tests.Utilities;
using System.Linq;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class InfoMethodTests
    {
        [Fact]
        public void Info_get_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/info?site=english
            mock.FakeGET(response: @"{""items"":[{""total_questions"":14647,""total_unanswered"":15,""total_accepted"":10674,""total_answers"":41975,""questions_per_minute"":0.01,""answers_per_minute"":0.02,""total_comments"":112674,""total_votes"":251459,""total_badges"":41800,""badges_per_minute"":0.02,""total_users"":17118,""new_active_users"":1,""api_revision"":""2012.4.12.2100""}],""quota_remaining"":291,""quota_max"":300,""has_more"":false}");

            var client = mock.Object;

            var result = client.Info.Get("english").Result;
            Assert.True(result.Success);
            
            var info = result.Data.Items.Single();
            Assert.Equal(14647, info.TotalQuestions);
            Assert.Equal(15, info.TotalUnanswered);
            Assert.Equal(10674, info.TotalAccepted);
            Assert.Equal(41975, info.TotalAnswers);
            Assert.Equal(.01m, info.QuestionsPerMinute);
            Assert.Equal(.02m, info.AnswersPerMinute);
            Assert.Equal(112674, info.TotalComments);
            Assert.Equal(251459, info.TotalVotes);
            Assert.Equal(41800, info.TotalBadges);
            Assert.Equal(.02m, info.BadgesPerMinute);
            Assert.Equal(17118, info.TotalUsers);
            Assert.Equal(1, info.NewActiveUsers);
            Assert.Equal("2012.4.12.2100", info.ApiRevision);
            Assert.Null(info.Site);
        }
    }
}
