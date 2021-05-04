using Planet.LeandroRate.ConsoleApp.Application.Interfaces;
using Planet.LeandroRate.ConsoleApp.Domain.Entities;
using Planet.LeandroRate.ConsoleApp.ViewModels.AppObjects;

namespace Planet.LeandroRate.ConsoleApp.Application.AppServices
{
    public class UserAppService : BaseAppService<UserApp_vw, UserApp>
    {
        public UserAppService(IUserBusiness business) : base(business) { }
    }
}
