namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class AddFriendViewModel : ViewModelBase
    {
        public FriendDetailsFormViewModel Form { get; set; }
        public AddFriendViewModel()
        {
            Form = new FriendDetailsFormViewModel();
        }
    }
}
