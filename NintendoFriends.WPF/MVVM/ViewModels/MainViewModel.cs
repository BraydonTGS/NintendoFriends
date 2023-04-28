using NintendoFriends.WPF.Stores;

namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase  
    {
        private readonly ModalNavigationStore _modalNavigationStore; 

        public NintendoFriendsViewModel NintendoFriends { get;}

        public MainViewModel(ModalNavigationStore modalNavigationStore, NintendoFriendsViewModel nintendoFriends)
        {
            _modalNavigationStore = modalNavigationStore;
            NintendoFriends = nintendoFriends;
        }
    }
}
