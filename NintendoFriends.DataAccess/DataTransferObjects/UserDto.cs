namespace NintendoFriends.DataAccess.DataTransferObjects
{
    public class UserDto
    {
        public int Id { get; set; } 
        public string FristName { get ; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public IEnumerable<FriendDto> Friends { get; set; } = Enumerable.Empty<FriendDto>();
    }
}
