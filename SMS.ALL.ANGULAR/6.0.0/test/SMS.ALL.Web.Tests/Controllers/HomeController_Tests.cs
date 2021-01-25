using System.Threading.Tasks;
using SMS.ALL.Models.TokenAuth;
using SMS.ALL.Web.Controllers;
using Shouldly;
using Xunit;

namespace SMS.ALL.Web.Tests.Controllers
{
    public class HomeController_Tests: ALLWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}