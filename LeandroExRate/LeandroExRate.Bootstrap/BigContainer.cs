using LeandroExRate.Application.AppServices;
using LeandroExRate.Application.Interfaces;
using LeandroExRate.Business.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace LeandroExRate.Bootstrap
{
    public static class BigContainer
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection service)
        {
            service.AddTransient<SurveyAppService>();
            service.AddTransient<UserAppService>();
            return service;
        }

        public static IServiceCollection RegisterAppBusiness(this IServiceCollection service)
        {
            service.AddTransient<ISurveyBusiness, SurveyBusiness>();
            service.AddTransient<IUserBusiness, UserBusiness>();
            return service;
        }
    }
}
