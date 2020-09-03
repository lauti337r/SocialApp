using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Prism.Services.Dialogs;
using SocialApp.Models;
using SocialApp.Services;

namespace SocialApp.ViewModels
{
    public class ProfilePageViewModel : ViewModelBase, INavigationAware
    {
        private Profile _userProfile;

        public Profile UserProfile
        {
            get => _userProfile;
            set => SetProperty(ref _userProfile, value);
        }
        private INavigationService _navigationService;
        private BackEndService _backEndService;
        private IDialogService _dialogService;

        public ProfilePageViewModel(INavigationService navigationService, BackEndService backEndService, IDialogService dialogService) : base(navigationService)
        {
            Title = "Profile";
            _navigationService = navigationService;
            _backEndService = backEndService;
            _dialogService = dialogService;
        }

        public async void OnNavigatedTo(INavigationParameters parameters)
        {
            string id = parameters.GetValue<string>("UserId");
            if (string.IsNullOrEmpty(id))
            {
                DialogParameters dialogParameters = new DialogParameters()
                {
                    { "title", "Error"},
                    { "message", "There was an unexpected error. Please try again."}
                };
                _dialogService.ShowDialog("Dialog", dialogParameters);
                _navigationService.GoBackAsync();   
            }
            else
            {
                try
                {
                    UserProfile = await _backEndService.GetProfile(id);
                }
                catch (Exception ex)
                {
                    DialogParameters dialogParameters = new DialogParameters()
                    {
                        { "title", "Error"},
                        { "message", "There was an unexpected error. Please try again." }
                    };
                    _dialogService.ShowDialog("Dialog", dialogParameters, async res => { await _navigationService.GoBackAsync(); });
                    
                }
            }
        }
    }
}
