using LeandroExRate.DI;
using LeandroExRate.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace LeandroExRate.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterTypes(IServiceCollection service)
        {
            service.RegisterAppServices();

            AppContainer.SetContainer(service);
            AutoMapperConfiguration.Register();
        }
    }
}