using NintendoFriends.WPF.MVVM.Models;
using NintendoFriends.WPF.MVVM.ViewModels;
using System.Windows.Input;

namespace NintendoFriends.WPF.MVVM.Components
{
    public class FriendUsernameViewModel : ViewModelBase
    {
        public readonly Friend Friend;
        public string Username => Friend.Username;

        // Commands //
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public FriendUsernameViewModel(Friend friend) => Friend = friend;
    }
}
