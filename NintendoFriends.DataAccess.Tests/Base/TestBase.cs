using NintendoFriends.DataAccess.DataTransferObjects;
using NintendoFriends.DataAccess.DbAccess;
using NintendoFriends.DataAccess.Repository;

namespace NintendoFriends.DataAccess.Tests.Base
{
    public class TestBase : IAsyncLifetime
    {
        protected readonly IFriendRepository _friendRepository;
        protected readonly ISqlDataAccess _sqlDataAccess;
        protected IEnumerable<FriendDto> _friends = Enumerable.Empty<FriendDto>();

        public TestBase()
        { 
            _sqlDataAccess = new SqlDataAccess(Hidden.TestDbConnectionString);
            _friendRepository = new FriendRepository(_sqlDataAccess);
        }
        public async Task DisposeAsync()
        {
            var testFriends = await _friendRepository.GetAllAsync();
            foreach (var testFriend in testFriends)
            {
                await _friendRepository.DeleteFriendAsync(testFriend.Id);
            }
        }

        public async Task InitializeAsync()
        {
            await SeedListWithMockFriends();
            await Task.CompletedTask;
        }

        #region Seed Test Db
        protected static FriendDto CreateSingleMockFriend()
        {
            var newFriend = new FriendDto() { FirstName = "Braydon", LastName = "Sutherland", Username = "xGeoMaticx", BestFriend = "Yes", Online = "NO" };
            return newFriend;

        }
        private async Task SeedListWithMockFriends()
        {
            _friends = new List<FriendDto>()
            {
                new FriendDto() {FirstName = "Braydon", LastName = "Sutherland", Username = "GeoMatics", BestFriend = "Yes", Online = "NO"},
                new FriendDto() {FirstName = "Sally", LastName = "Sutherland", Username = "Salmeaux", BestFriend = "Yes", Online = "Yes"},
                new FriendDto() {FirstName = "Colin", LastName = "Sutherland", Username = "CWallyWongs", BestFriend = "Yes", Online = "Yes"},
                new FriendDto() {FirstName = "Chase", LastName = "Iguieri", Username = "ChapsDonWaldo", BestFriend = "Yes", Online = "Yes"},
                new FriendDto() {FirstName = "Morgan", LastName = "White", Username = "MWhiteForEver", BestFriend = "Yes", Online = "Yes"},

            };

            foreach (var friend in _friends)
            {
                await _friendRepository.InsertFriendAsync(friend);
            }
        }
        #endregion
    }
}
