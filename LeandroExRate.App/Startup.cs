using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace LeandroExRate.App
{
    public static class Startup 
    {
        public static IHostBuilder CreateHostBuilder(string[] args) =>
             Host.CreateDefaultBuilder(args)
                 .ConfigureAppConfiguration((hostingContext, configuration) =>
                 {
                     configuration.Sources.Clear();

                     IHostEnvironment env = hostingContext.HostingEnvironment;

                     configuration
                         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                     IConfigurationRoot configurationRoot = configuration.Build();

                    //TransientFaultHandlingOptions options = new();
                    //configurationRoot.GetSection(nameof(TransientFaultHandlingOptions))
                    //                 .Bind(options);

                    //Console.WriteLine($"TransientFaultHandlingOptions.Enabled={options.Enabled}");
                    //Console.WriteLine($"TransientFaultHandlingOptions.AutoRetryDelay={options.AutoRetryDelay}");
                });
    }
}
