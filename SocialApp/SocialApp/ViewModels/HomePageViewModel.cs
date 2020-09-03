
using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Navigation;
using SocialApp.Models;
using SocialApp.Services;
using SocialApp.Utilities;

namespace SocialApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public ObservableCollection<News> NewsList { get; set; }
        public ObservableCollection<Status> StatusList { get; set; }
        public DelegateCommand<Status> StatusTappedCommand { get; }

        private INavigationService _navigationService;
        private BackEndService _backEndService;
        public HomePageViewModel(INavigationService navigationService, BackEndService backEndService)
            : base(navigationService)
        {
            _backEndService = backEndService;
            _navigationService = navigationService;
            Title = "Home";
            LoadData();
            StatusTappedCommand = new DelegateCommand<Status>(StatusTappedCommandExecuted);
        }

        private async void LoadData()
        {
            NewsList = new ObservableCollection<News>(await _backEndService.GetNews());
            StatusList = new ObservableCollection<Status>(await _backEndService.GetStatuses());
        }

        private async void StatusTappedCommandExecuted(Status tappedStatus)
        {
            NavigationParameters parameters = new NavigationParameters();
            parameters.Add("UserId", tappedStatus.UserId);
            await _navigationService.NavigateAsync("ProfilePage", parameters);
        }
    }
}
