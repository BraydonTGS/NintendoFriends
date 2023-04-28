using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
