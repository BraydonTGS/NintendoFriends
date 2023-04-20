using NintendoFriends.WPF.MVVM.Components;
using NintendoFriends.WPF.MVVM.Models;
using NintendoFriends.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class FriendsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<FriendUsernameViewModel> _friendListingViewModels;
        private readonly SelectedFriendStore _selectedStore;

        public IEnumerable<FriendUsernameViewModel> FriendListingViewModels => _friendListingViewModels;

        private FriendUsernameViewModel _selectedFriendListingViewModel;

        public FriendUsernameViewModel SelectedFriendListingViewModel
        {
            get { return _selectedFriendListingViewModel; }
            set
            {
                _selectedFriendListingViewModel = value;
                OnPropertyChanged(nameof(SelectedFriendListingViewModel));
                _selectedStore.SelectedFriend = _selectedFriendListingViewModel?.Friend;
            }
        }

        public FriendsListViewModel(SelectedFriendStore selectedStore)
        {
            _friendListingViewModels = new ObservableCollection<FriendUsernameViewModel>
            {
                new FriendUsernameViewModel(new Friend("Braydon", "Sutherland", "Geomatics", "Yes", "Yes", "Breath of the Wild")),
                new FriendUsernameViewModel(new Friend("Sally", "Sutherland", "Salmeaux", "Yes", "No", "Mario 64")),
                new FriendUsernameViewModel(new Friend("Colin", "Sutherland", "CollyWongs", "No", "Yes", "Golden Eye")),
                new FriendUsernameViewModel(new Friend("Devon", "Sutherland", "RiverRat", "No", "Yes", "Snowboard Kids")),
                new FriendUsernameViewModel(new Friend("John", "Sutherland", "FlyHigh", "Yes", "No", "Donkey Kong")),

            };
            _selectedStore = selectedStore;
        }
    }
}
