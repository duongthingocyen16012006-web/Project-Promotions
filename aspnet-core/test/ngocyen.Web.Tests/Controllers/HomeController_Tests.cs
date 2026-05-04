using System.Threading.Tasks;
using ngocyen.Models.TokenAuth;
using ngocyen.Web.Controllers;
using Shouldly;
using Xunit;

namespace ngocyen.Web.Tests.Controllers
{
    public class HomeController_Tests: ngocyenWebTestBase
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