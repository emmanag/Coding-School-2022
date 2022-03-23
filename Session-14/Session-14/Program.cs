
using Microsoft.Extensions.DependencyInjection;

using Session_14.App.Repositories;
using Session_14.model;
using TodoApp.EF.Repositories;

namespace Session_14
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

      
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton<IEntityRepo<TransactionLine>, TransactionLineRepository>();
            services.AddSingleton<MainForm>();

            ServiceProvider = services.BuildServiceProvider();
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
    }
}