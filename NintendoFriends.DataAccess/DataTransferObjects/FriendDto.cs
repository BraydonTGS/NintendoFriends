namespace NintendoFriends.DataAccess.DataTransferObjects
{
    public class FriendDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Username { get; set; } = string.Empty;    
        public string BestFriend { get; set; } = string.Empty;  
        public string Online { get ; set; } = string.Empty;
        public string FavoriteGame { get; set; } = string.Empty; 

    }
}
