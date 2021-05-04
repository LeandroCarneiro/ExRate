using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Planet.LeandroRate.ConsoleApp.Data.Contexts;
using Planet.LeandroRate.ConsoleApp.DI;
using Planet.LeandroRate.ConsoleApp.Mapping;

namespace Planet.LeandroRate.ConsoleApp.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterTypes(IServiceCollection service)
        {
            service.RegisterAppServices()
                .RegisterAppBusiness()
                .RegisterAppPersistence();

            AppContainer.SetContainer(service);
            AutoMapperConfiguration.Register();

            Migrate(service);
        }

        private static void Migrate(IServiceCollection services)
        {
            var dao = services.BuildServiceProvider().GetService<TeslaDbContext>();
            dao.Database.EnsureCreated();
            //dao.Database.Migrate();
        }
    }
}