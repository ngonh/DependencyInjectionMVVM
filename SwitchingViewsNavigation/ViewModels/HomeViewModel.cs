using CommunityToolkit.Mvvm.Input;
using SwitchingViewsNavigation.Services;

namespace SwitchingViewsNavigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToSettingCommand = new RelayCommand(() => _navigationService.NavigateTo<SettingViewModel>());

        }
        public RelayCommand NavigateToSettingCommand { get; set; }
    }
}
