using NintendoFriends.WPF.Commands;
using NintendoFriends.WPF.Stores;
using System.Security.Cryptography.Xml;
using System.Windows.Input;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class NintendoFriendsViewModel : ViewModelBase
    {
        // Commands //
        public ICommand AddNewFriendCommand { get; }

        // ViewModels //
        public FriendDetailsViewModel FriendDetailsViewModel { get; }
        public FriendsListViewModel FriendsListViewModel { get; }

        public NintendoFriendsViewModel(SelectedFriendStore _selectedStore, ModalNavigationStore modalNavigationStore)
        {
            FriendDetailsViewModel = new FriendDetailsViewModel(_selectedStore);
            FriendsListViewModel = new FriendsListViewModel(_selectedStore);

            AddNewFriendCommand = new OpenAddNewFriendCommand(modalNavigationStore); 
        }
    }
}
