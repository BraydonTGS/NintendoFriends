namespace NintendoFriends.WPF.MVVM.ViewModels
{
   public class FriendDetailsViewModel : ViewModelBase
    {
        public string Username { get; }
        public string IsBestFriendDisplay { get; }
        public string IsOnlineDisplay { get; }
        public string FavoriteGame { get; }

        public FriendDetailsViewModel()
        {
            Username = "GeoMatics";
            IsBestFriendDisplay = "Yes";
            IsOnlineDisplay = "No";
            FavoriteGame = "Breath of the Wild";
        }

    }
}
