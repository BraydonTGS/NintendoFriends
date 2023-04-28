namespace NintendoFriends.WPF.MVVM.ViewModels
{
    public class EditFriendViewModel : ViewModelBase
    {
        public FriendDetailsFormViewModel Form { get; set; }

        public EditFriendViewModel()
        {
            Form = new FriendDetailsFormViewModel(); 
        }
    }
}
