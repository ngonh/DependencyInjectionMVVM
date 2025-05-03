using SwitchingViewsNavigation.ViewModels;
using System;

namespace SwitchingViewsNavigation.Services
{
    public class NavigationService : ViewModelBase, INavigationService
    {
        public NavigationService(Func<Type, ViewModelBase> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }
        

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            private set => SetProperty(ref _currentViewModel, value);
        }

        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            ViewModelBase viewModelBase = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentViewModel = viewModelBase;
        }

        private ViewModelBase _currentViewModel;
        private readonly Func<Type, ViewModelBase> _viewModelFactory;
    }
}
