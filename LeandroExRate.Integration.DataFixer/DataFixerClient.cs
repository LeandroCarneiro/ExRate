using LeandroExRate.Application.Interfaces;
using LeandroExRate.Common;
using LeandroExRate.Common.Helpers;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.Common.Middleware;
using LeandroExRate.ViewModels.AppObjects;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeandroExRate.Integration.DataFixer
{
    public class DataFixerClient : IRateService
    {
        readonly RestRequester _requester;

        public DataFixerClient(IConfiguration config)
        {
            var configApi = config.GetSection("DataFixer").Get<ApiConfig>();
            _requester = new RestRequester(configApi.Url, configApi.AccessKey);
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

        public async Task<AppResult<List<Rate_vw>>> GetAllRateAsync()
        {
            var result = await _requester.SendAsync<RatesData>(ERestCall.Get);
            var lst = new List<Rate_vw>();
          
            foreach (var itemFrom in EnumHelper.GetEnumValues<ECurrency>())
            {
                foreach (var itemTo in EnumHelper.GetEnumValues<ECurrency>())
                {
                    if (itemFrom == itemTo)
                        continue;

                    lst.Add(new Rate_vw()
                    {
                        Date = result.Date,
                        ExchangeRate = result.GetRate(itemFrom.ToString(), itemTo.ToString()),
                        From = itemFrom,
                        To = itemTo
                    });
                }
            }
            
            return new AppResult<List<Rate_vw>>(lst);
        }
    }
}