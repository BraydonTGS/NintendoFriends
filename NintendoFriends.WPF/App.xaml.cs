using NintendoFriends.WPF.MVVM.ViewModels;
using NintendoFriends.WPF.Stores;
using System.Windows;

namespace NintendoFriends.WPF
{

    public partial class App : Application
    {
        private readonly SelectedFriendStore _selectedStore;
        private readonly ModalNavigationStore _modalNavigationStore;
        private readonly NintendoFriendsViewModel _nintendoFriendViewModel;
        public App()
        {
            _selectedStore = new SelectedFriendStore();
            _modalNavigationStore = new ModalNavigationStore();
            _nintendoFriendViewModel = new NintendoFriendsViewModel(_selectedStore, _modalNavigationStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, _nintendoFriendViewModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
