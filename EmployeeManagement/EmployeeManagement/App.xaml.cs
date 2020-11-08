using DomainModel.Models;
using DomainModel.Services;
//using DomainModel.Services.UserManagement;
using EmployeeManagement.Sate.Navigators;
using EmployeeManagement.State.Navigators;
using EmployeeManagement.Utlility;
using EmployeeManagement.ViewModels;
using EmployeeManagement.ViewModels.Factories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelingAPI.APIHelpers;
using ModelingAPI.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = CreateHostBuilder().Build();
        }
        public static IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(c =>
                {
                  //c.AddJsonFile("appsettings.json");
                   c.AddEnvironmentVariables();
                })
                .ConfigureServices((context, services) =>
                {
                    string apiKey = context.Configuration.GetValue<string>("API_KEY");
                    services.AddSingleton<APIClientHelperFactory>(new APIClientHelperFactory("fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56", "https://gorest1.co.in/public-api/"));
                    //services.AddSingleton<Export>(new Export(@"C:\Temp\export.csv"));
                    services.AddSingleton<IUserServices, UserManagementServices>();
                    services.AddSingleton<IExport, Export>();
                    services.AddSingleton<IEmployeeManagementViewModelFactory, EmployeeManagementViewModelFactory>();
                    services.AddSingleton<RegisterViewModel>();
                    services.AddSingleton<StartViewModel>();
                    services.AddSingleton<ManageUsersViewModel>();

                    services.AddSingleton<HomeViewModel>(services => new HomeViewModel(

                            ManageUsersViewModel.LoadManageUsersViewModel(
                                services.GetRequiredService<IUserServices>(), services.GetRequiredService<IExport>()))
                    );

                    services.AddSingleton<CreateViewModel<HomeViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<HomeViewModel>();
                    });

                    services.AddSingleton<CreateViewModel<RegisterViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<RegisterViewModel>();
                    });
                    services.AddSingleton<CreateViewModel<StartViewModel>>(services =>
                    {
                        return () => services.GetRequiredService<StartViewModel>();
                    });
                    services.AddSingleton<INavigator, Navigator>();
                    

                    //services.AddSingleton<ViewModelDelegateRenavigator<HomeViewModel>>();
                    //services.AddSingleton<ViewModelDelegateRenavigator<RegisterViewModel>>();
                    services.AddScoped<MainViewModel>();
                    services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));
                });
        }
        protected override void OnStartup(StartupEventArgs e)
        {
           _host.Start();

            Window window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }

    }
}
