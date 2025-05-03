using CommunityToolkit.Mvvm.Input;
using SwitchingViewsNavigation.Services;

namespace SwitchingViewsNavigation.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            NavigateToHomeCommand = new RelayCommand(() => NavigationService.NavigateTo<HomeViewModel>());
            NavigateToSettingCommand = new RelayCommand(() => NavigationService.NavigateTo<SettingViewModel>());
        }
        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToSettingCommand { get; set; }
        public INavigationService NavigationService
        {
            get => _navigationService;
            set => SetProperty(ref _navigationService, value);
        }
        private INavigationService _navigationService;
    }
}
