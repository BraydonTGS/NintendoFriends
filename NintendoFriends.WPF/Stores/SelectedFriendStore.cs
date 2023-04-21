using NintendoFriends.WPF.MVVM.Models;
using System;

namespace NintendoFriends.WPF.Stores
{
    public class SelectedFriendStore
    {
        private Friend _selectedFriend;

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                SelectedFriendChanged?.Invoke();

            }
        }
        public event Action? SelectedFriendChanged;
    }
}
