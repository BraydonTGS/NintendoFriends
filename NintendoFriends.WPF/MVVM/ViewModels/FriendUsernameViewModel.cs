using NintendoFriends.WPF.MVVM.ViewModels;
using System.Windows.Input;

namespace NintendoFriends.WPF.MVVM.Components
{
    public class FriendUsernameViewModel : ViewModelBase
    {
        public string Username { get; }

        // Commands //
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public FriendUsernameViewModel(string userName)
        {
            Username = userName;
        }
    }
}
