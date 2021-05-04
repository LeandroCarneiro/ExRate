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
                    var option = "";
                    do
                    {
                        var appService = new RateAppService();
                        var result = (await appService.Sumary()).Result;

                        foreach (var item in result)                        
                            Console.WriteLine(item.ResultString);
                        
                        Console.WriteLine("Type '#' to exit");
                        option = Console.ReadLine();
                        Console.Clear();

                    } while (option != "#");
                    await host.RunAsync();
                }
            }
            catch (AppBaseException ex)
            {
                //Console.Beep();
                Console.Clear();
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                //Console.Beep();
                Console.Clear();
                Console.WriteLine("Error: System could not calculate the rates");
            }
        }        
    }
}
