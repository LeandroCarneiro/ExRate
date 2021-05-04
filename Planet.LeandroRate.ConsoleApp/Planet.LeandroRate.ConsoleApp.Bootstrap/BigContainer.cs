using Microsoft.Extensions.DependencyInjection;
using Planet.LeandroRate.ConsoleApp.Application.AppServices;
using Planet.LeandroRate.ConsoleApp.Application.Interfaces;
using Planet.LeandroRate.ConsoleApp.Business.Domain;
using Planet.LeandroRate.ConsoleApp.Data.Contexts;
using Planet.LeandroRate.ConsoleApp.Domain.Interfaces;

namespace Planet.LeandroRate.ConsoleApp.Bootstrap
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

        public static IServiceCollection RegisterAppPersistence(this IServiceCollection service)
        {
            service.AddDbContext<TeslaDbContext>();
            service.AddTransient<IDbContext, TeslaDbContext>();
            return service;
        }
    }
}
