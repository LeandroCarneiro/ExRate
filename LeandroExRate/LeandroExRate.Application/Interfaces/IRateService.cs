using LeandroExRate.Common;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Application.Interfaces
{
    public interface IRateService
    {
        AppResult<Rate_vw> GetRate(ECurrency uSD, ECurrency eUR);
    }
}
