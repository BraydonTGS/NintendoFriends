namespace NintendoFriends.DataAccess.DataTransferObjects
{
    public class Friend
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty; 
        public string Username { get; set; } = string.Empty;    
        public IEnumerable<VideoGame> VideoGames { get; set; } = Enumerable.Empty<VideoGame>();
    }
}
