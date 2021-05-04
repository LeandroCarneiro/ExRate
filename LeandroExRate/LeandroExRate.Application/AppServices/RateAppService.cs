using LeandroExRate.Application.Interfaces;
using LeandroExRate.Common;
using LeandroExRate.Common.Exceptions;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.DI;
using LeandroExRate.ViewModels.AppObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeandroExRate.Application.AppServices
{
    public class RateAppService
    {
        readonly IRateService _service;
        public RateAppService()
        {
            _service = AppContainer.Resolve<IRateService>();
        }

        public async Task<AppResult<Rate_vw>> SelectOptionAsync(EOption option)
        {
            switch (option)
            {
                case EOption.USD_EUR:
                    return await _service.GetRateAsync(ECurrency.USD, ECurrency.EUR);
                case EOption.USD_GBP:
                    return await _service.GetRateAsync(ECurrency.USD, ECurrency.GBP);
                case EOption.EUR_USD:
                    return await _service.GetRateAsync(ECurrency.EUR, ECurrency.USD);
                case EOption.EUR_GBP:
                    return await _service.GetRateAsync(ECurrency.EUR, ECurrency.GBP);
                case EOption.GPB_USD:
                    return await _service.GetRateAsync(ECurrency.GBP, ECurrency.USD);
                case EOption.GPB_EUR:
                    return await _service.GetRateAsync(ECurrency.GBP, ECurrency.EUR);
                default:
                    throw new InvalidOptionException();
            }
        }

        public async Task<AppResult<List<Rate_vw>>> Sumary()
        {
            return await _service.GetAllRateAsync();
        }
    }
}
