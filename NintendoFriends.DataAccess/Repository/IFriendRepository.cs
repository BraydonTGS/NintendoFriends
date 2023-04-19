using NintendoFriends.DataAccess.DataTransferObjects;

namespace NintendoFriends.DataAccess.Repository
{
    public interface IFriendRepository
    {
        Task<bool> DeleteFriendAsync(int id);
        Task<IEnumerable<FriendDto>> GetAllAsync();
        Task<FriendDto?> GetFriendByIdAsync(int id);
        Task<bool> InsertFriendAsync(FriendDto friend);
        Task<bool> UpdateFriendAsync(FriendDto friend);
    }
}
