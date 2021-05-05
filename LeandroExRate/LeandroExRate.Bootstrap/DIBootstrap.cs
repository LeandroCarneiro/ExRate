using LeandroExRate.DI;
using Microsoft.Extensions.DependencyInjection;

namespace LeandroExRate.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterTypes(IServiceCollection service)
        {
            service.RegisterAppServices()
                .RegisterServices();

            DIHelper.SetContainer(service);
        }
    }
}