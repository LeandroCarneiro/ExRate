using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace LeandroExRate.App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (IHost host = Startup.CreateHostBuilder(args).Build())
            {

                
                Console.WriteLine("Hello World!");
                await host.RunAsync();
            }
        }        
    }
}
