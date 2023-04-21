using NintendoFriends.WPF.MVVM.Models;
using NintendoFriends.WPF.Stores;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
   public class FriendDetailsViewModel : ViewModelBase
    {
        // Selected Friend Store => Source of Truth // 
        private readonly SelectedFriendStore _selectedStore;
        private Friend _selectedFriend => _selectedStore.SelectedFriend;
        public bool HasSelectedFriend => _selectedStore.SelectedFriend != null;
        public string? Username => _selectedFriend?.Username; 
        public string? IsBestFriendDisplay => _selectedFriend?.BestFriend;
        public string? IsOnlineDisplay => _selectedFriend?.Online;
        public string? FavoriteGame => _selectedFriend?.FavoriteGame;

        public FriendDetailsViewModel(SelectedFriendStore selectedStore)
        {
            _selectedStore = selectedStore;

            _selectedStore.SelectedFriendChanged += _selectedStore_SelectedFriendChanged;
        }

        protected override void Dispose()
        {
            _selectedStore.SelectedFriendChanged -= _selectedStore_SelectedFriendChanged;
            base.Dispose();
        }
        private void _selectedStore_SelectedFriendChanged()
        {
            OnPropertyChanged(nameof(HasSelectedFriend));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsBestFriendDisplay));
            OnPropertyChanged(nameof(IsOnlineDisplay));
            OnPropertyChanged(nameof(FavoriteGame));
        }
    }
}
