using Moq;
using StackExchange.StacMan.Tests.Utilities;
using System.Linq;
using Xunit;

namespace StackExchange.StacMan.Tests
{

    public class UserMethodTests
    {
        [Fact]
        public void Users_get_all_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/users?pagesize=1&order=desc&min=1&max=1000&sort=reputation&inname=doug&site=webapps
            mock.FakeGET(response: @"{""items"":[{""user_id"":183,""user_type"":""registered"",""creation_date"":1277932837,""display_name"":""Doug Harris"",""profile_image"":""http://www.gravatar.com/avatar/731e7de87c241fce562d03b23770b5cf?d=identicon&r=PG"",""reputation"":545,""reputation_change_day"":0,""reputation_change_week"":0,""reputation_change_month"":0,""reputation_change_quarter"":0,""reputation_change_year"":15,""age"":92,""last_access_date"":1332536617,""last_modified_date"":1332297406,""is_employee"":false,""link"":""http://webapps.stackexchange.com/users/183/doug-harris"",""website_url"":""http://delicious.com/dharris"",""location"":""Washington, DC"",""account_id"":46903,""badge_counts"":{""gold"":1,""silver"":4,""bronze"":8},""accept_rate"":25}],""quota_remaining"":-210785,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;

            var result = client.Users.GetAll("webapps", pagesize: 1, order: Order.Desc, min: 1, max: 1000, sort: Users.Sort.Reputation, inname: "doug").Result;
            Assert.True(result.Success);

            var user = result.Data.Items.Single();
            Assert.Equal(183, user.UserId);
            Assert.Equal(Users.UserType.Registered, user.UserType);
            Assert.Equal("Doug Harris", user.DisplayName);
            Assert.Equal("http://www.gravatar.com/avatar/731e7de87c241fce562d03b23770b5cf?d=identicon&r=PG", user.ProfileImage);
            Assert.Equal(545, user.Reputation);
            Assert.Equal(0, user.ReputationChangeDay);
            Assert.Equal(0, user.ReputationChangeWeek);
            Assert.Equal(0, user.ReputationChangeMonth);
            Assert.Equal(0, user.ReputationChangeQuarter);
            Assert.Equal(15, user.ReputationChangeYear);
            Assert.Equal(92, user.Age);
            Assert.Equal(1332536617L.ToDateTime(), user.LastAccessDate);
            Assert.Equal(1332297406L.ToDateTime(), user.LastModifiedDate);
            Assert.False(user.IsEmployee);
            Assert.Equal("http://webapps.stackexchange.com/users/183/doug-harris", user.Link);
            Assert.Equal("http://delicious.com/dharris", user.WebsiteUrl);
            Assert.Equal("Washington, DC", user.Location);
            Assert.Equal(46903, user.AccountId);
            Assert.Equal(1, user.BadgeCounts.Gold);
            Assert.Equal(4, user.BadgeCounts.Silver);
            Assert.Equal(8, user.BadgeCounts.Bronze);
            Assert.Equal(25, user.AcceptRate);
            Assert.Null(user.TimedPenaltyDate);
        }

        [Fact]
        public void Users_get_associated_test()
        {
            var mock = new Mock<StacManClient>(null, null);

            //http://api.stackexchange.com/2.0/users/1998/associated?pagesize=2
            mock.FakeGET(response: @"{""items"":[{""site_name"":""Stack Overflow"",""site_url"":""http://stackoverflow.com"",""user_id"":2749,""reputation"":4365,""account_id"":1998,""creation_date"":1219613204,""badge_counts"":{""gold"":1,""silver"":13,""bronze"":26},""last_access_date"":1334611626,""answer_count"":144,""question_count"":20},{""site_name"":""Server Fault"",""site_url"":""http://serverfault.com"",""user_id"":31532,""reputation"":101,""account_id"":1998,""creation_date"":1263334764,""badge_counts"":{""gold"":0,""silver"":0,""bronze"":3},""last_access_date"":1334610908,""answer_count"":0,""question_count"":0}],""quota_remaining"":-212787,""quota_max"":300,""has_more"":true}");

            var client = mock.Object;

            var result = client.Users.GetAssociated(new int[] { 1998 }, pagesize: 2).Result;
            Assert.True(result.Success);

            var networkUser = result.Data.Items.First();
            Assert.Equal("Stack Overflow", networkUser.SiteName);
            Assert.Equal("http://stackoverflow.com", networkUser.SiteUrl);
            Assert.Equal(2749, networkUser.UserId);
            Assert.Equal(4365, networkUser.Reputation);
            Assert.Equal(1998, networkUser.AccountId);
            Assert.Equal(1219613204L.ToDateTime(), networkUser.CreationDate);
            Assert.Equal(1, networkUser.BadgeCounts.Gold);
            Assert.Equal(13, networkUser.BadgeCounts.Silver);
            Assert.Equal(26, networkUser.BadgeCounts.Bronze);
            Assert.Equal(1334611626L.ToDateTime(), networkUser.LastAccessDate);
            Assert.Equal(144, networkUser.AnswerCount);
            Assert.Equal(20, networkUser.QuestionCount);
            Assert.Equal(default(StackExchange.StacMan.Users.UserType), networkUser.UserType);
        }
    }
}
