using LeandroExRate.Application.Interfaces;
using LeandroExRate.Common;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.Common.Middleware;
using LeandroExRate.ViewModels.AppObjects;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace LeandroExRate.Integration.DataFixer
{
    public class Client : IRateService
    {
        readonly RestRequester _requester;

        public Client(IConfiguration config)
        {
            var configApi = config.GetSection("DataFixer").Value;
            _requester = new RestRequester(configApi);
        }

        public async Task<AppResult<Rate_vw>> GetRateAsync(ECurrency from, ECurrency to)
        {
            var result = await _requester.SendAsync<RatesData>(ERestCall.Get);

            return new AppResult<Rate_vw>(new Rate_vw()
            {
                Date = result.Date,
                ExchangeRate = result.GetRate(from.ToString(), to.ToString()),
                From = from,
                To = to
            });
        }
    }
}