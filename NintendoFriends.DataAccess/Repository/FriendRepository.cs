using NintendoFriends.DataAccess.DataTransferObjects;
using NintendoFriends.DataAccess.DbAccess;

namespace NintendoFriends.DataAccess.Repository
{
    public class FriendRepository : IFriendRepository
    {
        private readonly ISqlDataAccess _repo;

        public FriendRepository(ISqlDataAccess repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<FriendDto>> GetAllAsync() => await _repo.LoadData<FriendDto>(storedProcedure: "dbo.spFriend_GetAll");

        public async Task<FriendDto?> GetUserByIdAsync(int id)
        {
            var result = await _repo.LoadData<FriendDto>(storedProcedure: "dbo.spFriend_Get", new { id });
            var user = result.FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            return null;
        }
        public async Task<bool> DeleteUserAsync(int id) => await _repo.SaveData<FriendDto>(storedProcedure: "dbo.spFriend_Delete", new { id });

        public async Task<bool> InsertUserAsync(FriendDto friend)
        {
            try
            {
                var result = await _repo.SaveData<FriendDto>(storedProcedure: "dbo.spFriend_Insert", new { friend.FirstName, friend.LastName, friend.Username, friend.Online, friend.BestFriend });
                return result; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<bool> UpdateUserAsync(FriendDto friend)
        {
            try
            {
                var result = await _repo.SaveData<FriendDto>(storedProcedure: "dbo.spFriend_Update", friend); 
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex); 
            }
        }
    }
}
