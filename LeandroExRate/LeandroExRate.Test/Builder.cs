using LeandroExRate.Bootstrap;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Linq;

namespace LeandroExRate.Test
{
    public static class Builder
    {
        static IServiceCollection _container;

        public static void Setup()
        {
            if (_container == null)
            {
                _container = new ServiceCollection();
                _container.AddSingleton(GetConfiguration());
               
                DIBootstrap.RegisterTypes(_container);
            }
        }

        public static IConfiguration GetConfiguration()
        {
            var current = Directory.GetCurrentDirectory();
            var directories = Directory.GetParent(current)
                .Parent.Parent.Parent.GetDirectories();

            var config = directories.Where(x => x.FullName.Contains("LeandroExRate.App"))?.First()?.FullName;

            return new ConfigurationBuilder()                
                .SetBasePath(config)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
