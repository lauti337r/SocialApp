using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services.Dialogs;
using SocialApp.Models;
using SocialApp.Services;
using Xamarin.Essentials;

namespace SocialApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private LoginInfo _loginInput;

        public LoginInfo LoginInput
        {
            get => _loginInput;
            set => SetProperty(ref _loginInput, value);
        }

        private INavigationService _navigationService;
        private BackEndService _backEndService;
        private IDialogService _dialogService;

        public DelegateCommand SubmitLoginCommand { get; }

        private async void SubmitLoginCommandExecuted()
        {
            bool inputIsCorrect = await _backEndService.CheckUserLogin(LoginInput);

            if (inputIsCorrect)
            {
                Preferences.Set("IsLoggedIn", true);
                await _navigationService.NavigateAsync("/MainPage/NavigationPage/HomePage");
            }
            else
            {
                DialogParameters parameters = new DialogParameters()
                {
                    { "title", "Error"},
                    { "message", "Wrong username or password."}
                };
                _dialogService.ShowDialog("Dialog", parameters);
            }
        }
        public LoginPageViewModel(INavigationService navigationService, BackEndService backEndService, IDialogService dialogService) : base(navigationService)
        {
            _navigationService = navigationService;
            _backEndService = backEndService;
            _dialogService = dialogService;
            SubmitLoginCommand = new DelegateCommand(SubmitLoginCommandExecuted);
            LoginInput = new LoginInfo();
        }


    }
}
