using NintendoFriends.WPF.MVVM.ViewModels;
using NintendoFriends.WPF.Stores;
using System;
using System.Net.Http.Headers;
using System.Windows.Input;

namespace NintendoFriends.WPF.Commands
{
    public class OpenAddNewFriendCommand : ComandBase
    {
        private readonly ModalNavigationStore _navigationStore;

        public OpenAddNewFriendCommand(ModalNavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
            AddFriendViewModel addFriendViewModel = new AddFriendViewModel();
            _navigationStore.CurrentViewModel = addFriendViewModel;
        }
    }
}
