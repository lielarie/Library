using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider Provider;
        const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryProject;Trusted_Connection=true";

        public App()
        {
            ServiceCollection serviceDescriptors = new ServiceCollection();
            ConfigureServices(serviceDescriptors);
            serviceDescriptors.AddSingleton<ItemsContext>();
            Provider = serviceDescriptors.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddDbContext<ItemsContext>(options => 
            options.UseLazyLoadingProxies().UseSqlServer(connectionString));
            serviceDescriptors.AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = Provider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
