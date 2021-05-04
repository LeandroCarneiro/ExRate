using LeandroExRate.Application.AppServices;
using LeandroExRate.Application.Interfaces;
using LeandroExRate.Common;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.Common.Middleware;
using LeandroExRate.ViewModels.AppObjects;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace LeandroExRate.Test.Unit
{
    public class RateTest : BaseTest
    {
        private readonly RateAppService _appService;
        private readonly Mock<IRateService> _service = new Mock<IRateService>();
        private readonly Mock<RestRequester> _requester = new Mock<RestRequester>();

        public RateTest() : base()
        {
            _service.Setup(x => x.GetRateAsync(It.IsAny<ECurrency>(), It.IsAny<ECurrency>())).ReturnsAsync(It.IsAny<AppResult<Rate_vw>>());
            _appService = new RateAppService(_service.Object);
        }
       
        [Fact]
        public async Task GetSumary()
        {
            var result = await _appService.Sumary();
            Assert.False(result.HasError);
        }
    }
}
