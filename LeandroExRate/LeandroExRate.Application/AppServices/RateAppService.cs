using LeandroExRate.Application.Interfaces;
using LeandroExRate.Common;
using LeandroExRate.Common.Exceptions;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.DI;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Application.AppServices
{
    public class RateAppService
    {
        readonly IRateService _service;
        public RateAppService()
        {
            _service = AppContainer.Resolve<IRateService>();
        }

        public AppResult<Rate_vw> SelectOption(EOption option)
        {
            switch (option)
            {
                case EOption.USD_EUR:
                    return _service.GetRate(ECurrency.USD, ECurrency.EUR);
                case EOption.USD_GBP:
                    return _service.GetRate(ECurrency.USD, ECurrency.GBP);
                case EOption.EUR_USD:
                    return _service.GetRate(ECurrency.EUR, ECurrency.USD);
                case EOption.EUR_GBP:
                    return _service.GetRate(ECurrency.EUR, ECurrency.GBP);
                case EOption.GPB_USD:
                    return _service.GetRate(ECurrency.GBP, ECurrency.USD);
                case EOption.GPB_EUR:
                    return _service.GetRate(ECurrency.GBP, ECurrency.EUR);
                default:
                    throw new InvalidOptionException();
            }
        }
    }
}
