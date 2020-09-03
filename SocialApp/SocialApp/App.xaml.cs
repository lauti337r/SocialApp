using System;
using Prism;
using Prism.Ioc;
using SocialApp.Services;
using SocialApp.ViewModels;
using SocialApp.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace SocialApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            bool isLoggedIn = Preferences.Get("IsLoggedIn", false);

            try
            {
                if (isLoggedIn)
                    await NavigationService.NavigateAsync("MainPage/NavigationPage/HomePage");
                else
                    await NavigationService.NavigateAsync("MainPage/NavigationPage/LoginPage");
            }
            catch (Exception ex)
            {

            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.Register<BackEndService>(); 
            containerRegistry.RegisterDialog<Dialog>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
        }
    }
}
