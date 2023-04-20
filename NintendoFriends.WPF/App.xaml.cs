using NintendoFriends.WPF.MVVM.ViewModels;
using NintendoFriends.WPF.Stores;
using System.Windows;

namespace NintendoFriends.WPF
{

    public partial class App : Application
    {
        private readonly SelectedFriendStore _selectedStore;
        public App()
        {
            _selectedStore = new SelectedFriendStore(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new NintendoFriendsViewModel(_selectedStore)
            };


            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
