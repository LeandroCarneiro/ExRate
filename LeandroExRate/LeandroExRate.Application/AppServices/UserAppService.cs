using LeandroExRate.Application.Interfaces;
using LeandroExRate.Domain.Entities;
using LeandroExRate.ViewModels.AppObjects;

namespace LeandroExRate.Application.AppServices
{
    public class UserAppService : BaseAppService<UserApp_vw, UserApp>
    {
        public UserAppService(IUserBusiness business) : base(business) { }
    }
}
