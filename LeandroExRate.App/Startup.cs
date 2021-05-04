using LeandroExRate.Bootstrap;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;

namespace LeandroExRate.App
{
    public static class Startup 
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                     //Dependency Injection :)
                 .ConfigureServices((_, services) => DIBootstrap.RegisterTypes(services))
                 .ConfigureAppConfiguration((hostingContext, configuration) =>
                 {

                     var current = Directory.GetCurrentDirectory();
                     var directories = Directory.GetParent(current)
                         .Parent.Parent.Parent.GetDirectories();
                     var config = directories.Where(x => x.FullName.Contains("LeandroExRate.App"))?.First()?.FullName;


                     //Configuration :)
                     var builder = configuration
                        .SetBasePath(config)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                     
                     builder.Build();                     
                 });
    }
}
