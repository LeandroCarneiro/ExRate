using LeandroExRate.Application.AppServices;
using LeandroExRate.Common;
using LeandroExRate.Common.Exceptions;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace LeandroExRate.App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                using (IHost host = Startup.CreateHostBuilder(args).Build())
                {
                    int option = 0;
                    Console.WriteLine("1- Return a rate for EUR to USD");
                    Console.WriteLine("2- Return a rate for EUR to USD");
                    Console.WriteLine("3- Return a rate for EUR to USD");
                    Console.WriteLine("0- Return all rates");

                    int.TryParse(Console.ReadLine(), out option);
                    if (option < 0 || option > 3)
                        throw new InvalidOptionException();

                    var appService = new RateAppService();
                    appService.SelectOption((EOption)option);

                    Console.WriteLine("Hello World!");
                    await host.RunAsync();
                }
            }
            catch (InvalidOptionException ex)
            {
                Console.Beep();
                Console.Clear();
                Console.WriteLine("Error: " + ex.Message);
            }
        }        
    }
}
