using CefaleasApp.Services;
using Pitasoft.Shell.Xamarin.Services;
using Pitasoft.Shell.Xamarin.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CefaleasApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeApp();

            if (Device.RuntimePlatform == Device.UWP)
            {
                InitializeNavigation();
            }
        }
        private void InitializeApp()
        {
            ViewModelLocator.SetIoCService(new IoCService());
        }
        private Task InitializeNavigation()
        {
            INavigationService navigationService = ViewModelLocator.GetService<INavigationService>();

            return navigationService.InitializeAsync();
        }
        protected override async void OnStart()
        {
            if (Device.RuntimePlatform != Device.UWP)
            {
                await InitializeNavigation();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
