using NintendoFriends.DataAccess.DataTransferObjects;

namespace NintendoFriends.DataAccess.Repository
{
    public interface IFriendRepository
    {
        Task<bool> DeleteUserAsync(int id);
        Task<IEnumerable<FriendDto>> GetAllAsync();
        Task<FriendDto?> GetUserByIdAsync(int id);
        Task<bool> InsertUserAsync(FriendDto friend);
        Task<bool> UpdateUserAsync(FriendDto friend);
    }
}
