using NintendoFriends.WPF.MVVM.ViewModels;
using System;

namespace NintendoFriends.WPF.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set 
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke(); 
            }
        }

        public bool IsOpen => _currentViewModel != null;

        public event Action CurrentViewModelChanged; 

    }
}
