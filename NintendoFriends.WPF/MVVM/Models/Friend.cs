namespace NintendoFriends.WPF.MVVM.Models
{
    public class Friend
    {
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string Username { get;} = string.Empty;
        public string BestFriend { get; } = string.Empty;
        public string Online { get; } = string.Empty;
        public string FavoriteGame { get; } = string.Empty;

        public Friend(string firstName, string lastName, string username, string bestFriend, string online, string favoriteGame)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            BestFriend = bestFriend;
            Online = online;
            FavoriteGame = favoriteGame;
        }
    }
}
