using LeandroExRate.Common;
using LeandroExRate.Common.InternalObjects;
using LeandroExRate.ViewModels.AppObjects;
using System.Threading.Tasks;

namespace LeandroExRate.Application.Interfaces
{
    public interface IRateService
    {
        Task<AppResult<Rate_vw>> GetRateAsync(ECurrency from, ECurrency to);
    }
}
