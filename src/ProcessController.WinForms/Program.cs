using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProcessController.Data;
using ProcessController.Data.Contexts;
using ProcessController.Data.Repositories;
using ProcessController.Service;
using ProcessController.WinForms.Configurations;
using ProcessController.WinForms.Services;

namespace ProcessController.WinForms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var serviceProvider = ConfigureServices().BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<MainForm>());
            }
        }

        private static ServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<MainForm>();

            var jsonConfiguration = new JsonContextConfiguration();
            services.AddSingleton<IJsonContextConfiguration>(jsonConfiguration);
            services.AddSingleton((IPersistenceContext<Domain.App>)new Data.AppContext(jsonConfiguration));

            services.AddScoped<IEnvironmentService, EnvironmentService>();
            services.AddScoped<IAppService, AppService>();
            services.AddScoped<IAppRepository, AppRepository>();

            return services;
        }
    }
}