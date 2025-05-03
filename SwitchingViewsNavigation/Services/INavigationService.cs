using SwitchingViewsNavigation.ViewModels;

namespace SwitchingViewsNavigation.Services
{
    public interface INavigationService
    {
        ViewModelBase CurrentViewModel { get; }
        void NavigateTo<TViewModel>() where TViewModel : ViewModelBase;
    }
}
