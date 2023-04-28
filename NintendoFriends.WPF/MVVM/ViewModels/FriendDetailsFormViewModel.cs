using System.Windows.Input;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class FriendDetailsFormViewModel : ViewModelBase
    {
        #region Property Changed
        // Username //
        private string _username;
		public string Username
		{
			get { return _username; }
			set
			{
                _username = value; 
				OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));
			}
		}


        // Best Friend //
        private string _isBestFriend;
        public string IsBestFriend
        {
            get { return _isBestFriend; }
            set
            {
                _isBestFriend = value;
                OnPropertyChanged(nameof(IsBestFriend));
            }
        }


        // Online //
        private string _isOnline;
        public string IsOnline
        {
            get { return _isOnline; }
            set
            {
                _isOnline = value;
                OnPropertyChanged(nameof(IsOnline));
            }
        }


        // Favorite Game //
        private string _favoriteGame;
        public string FavoriteGame
        {
            get { return _favoriteGame; }
            set
            {
                _favoriteGame = value;
                OnPropertyChanged(nameof(FavoriteGame));
            }
        }
        #endregion

        // Calculated Property //
        public bool CanSubmit => !string.IsNullOrEmpty(Username);

        // Commands //
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

    }
}
