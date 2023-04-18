namespace NintendoFriends.DataAccess.DataTransferObjects
{
    public class VideoGame
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty; 
        public string Description { get; set; } = string.Empty;
    }
}
