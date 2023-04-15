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

        public NintendoFriendsViewModel()
        {
            FriendDetailsViewModel = new FriendDetailsViewModel();
            FriendsListViewModel = new FriendsListViewModel();
        }
    }
}
