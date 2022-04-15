
using Gas_Station.Model;
using Handler;
using Microsoft.Extensions.DependencyInjection;

namespace Gas_Station.Win
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            services.AddScoped<TransactionHandler>();




            Application.Run(new Login());
        }

        
    }
}