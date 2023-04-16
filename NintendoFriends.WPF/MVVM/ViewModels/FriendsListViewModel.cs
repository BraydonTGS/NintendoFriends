using NintendoFriends.WPF.MVVM.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class FriendsListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<FriendUsernameViewModel> _friendListingViewModels;
        public IEnumerable<FriendUsernameViewModel> FriendListingViewModels => _friendListingViewModels;

        public FriendsListViewModel()
        {
            _friendListingViewModels = new ObservableCollection<FriendUsernameViewModel>
            {
                new FriendUsernameViewModel("GeoMatics"),
                new FriendUsernameViewModel("StepDown"),
                new FriendUsernameViewModel("RageBlast"),
                new FriendUsernameViewModel("GeoMatics"),
                new FriendUsernameViewModel("StepDown"),
                new FriendUsernameViewModel("RageBlast"),
                new FriendUsernameViewModel("GeoMatics"),
                new FriendUsernameViewModel("StepDown"),
                new FriendUsernameViewModel("RageBlast"),
            };
        }
    }
}
