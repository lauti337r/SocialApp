using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Xamarin.Essentials;

namespace SocialApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public bool IsLoggedIn
        {
            get => Preferences.Get("IsLoggedIn", false);
        }
        public DelegateCommand<string> NavigateCommand { get; }

        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(NavigateCommandExecuted);
        }


        private async void NavigateCommandExecuted(string parameter)
        {
            if (parameter == "LogOut")
            {
                Preferences.Set("IsLoggedIn", false);
                await NavigationService.NavigateAsync("MainPage/NavigationPage/LoginPage");
            }
            else
            {
                await _navigationService.NavigateAsync($"MainPage/NavigationPage/{parameter}");
            }
        }
    }
}
