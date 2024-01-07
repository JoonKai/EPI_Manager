using EPI_Manager.Services;
using EPI_Manager.ViewModels;
using EPI_Manager.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace EPI_Manager
{
    public partial class App : Application
    {
        private readonly IServiceProvider _services = null;
        public App()
        {
            _services = ConfigureService();
        }

        private IServiceProvider ConfigureService()
        {
            IServiceCollection services = new ServiceCollection();
            //View
            services.AddSingleton<MainView>();
            services.AddTransient<SettingView>();
            services.AddTransient<MainViewScreenViewModel>();
            //ViewModel
            services.AddSingleton<MainViewModel>();
            services.AddTransient<SettingViewModel>();
            //Service
            services.AddSingleton<IViewService, ViewService>();


            return services.BuildServiceProvider();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var viewService = (IViewService)_services.GetService(typeof(IViewService));
            viewService.ShowMainView();
        }
    }
}
