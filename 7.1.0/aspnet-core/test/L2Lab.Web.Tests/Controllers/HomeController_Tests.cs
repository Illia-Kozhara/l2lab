using System.Threading.Tasks;
using L2Lab.Models.TokenAuth;
using L2Lab.Web.Controllers;
using Shouldly;
using Xunit;

namespace L2Lab.Web.Tests.Controllers
{
    public class HomeController_Tests: L2LabWebTestBase
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