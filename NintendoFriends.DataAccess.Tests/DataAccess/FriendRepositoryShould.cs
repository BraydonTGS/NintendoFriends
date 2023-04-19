using NintendoFriends.DataAccess.Tests.Base;

namespace NintendoFriends.DataAccess.Tests.DataAccess
{
    public class FriendRepositoryShould : TestBase
    {
        [Fact]
        public async Task GetAllFriends_AndReturnAllFriendsAsync()
        {
            // Act //
            var result = await _friendRepository.GetAllAsync();

            // Assert //
            Assert.NotNull(result);
            Assert.Equal(5, result.Count());

            var firstFriend = result.FirstOrDefault(); 

            Assert.NotNull(firstFriend);
            Assert.Equal(firstFriend.FirstName, _friends.ElementAt(0).FirstName);
            Assert.Equal(firstFriend.LastName, _friends.ElementAt(0).LastName);
            Assert.Equal(firstFriend.Username, _friends.ElementAt(0).Username);
            Assert.Equal(firstFriend.Online, _friends.ElementAt(0).Online);
            Assert.Equal(firstFriend.BestFriend, _friends.ElementAt(0).BestFriend);
        }

        [Fact]
        public async Task GetFriendById_AndReturnFriend()
        {
            // Act //
            var friend = await _friendRepository.GetAllAsync(); 
            var expectedFriend = friend?.FirstOrDefault();

            // Assert //
            Assert.NotNull(expectedFriend);

            // Act //
            var actualFriend = await _friendRepository.GetFriendByIdAsync(expectedFriend.Id); 

            // Assert //
            Assert.NotNull(actualFriend);
            Assert.Equal(expectedFriend.FirstName, actualFriend.FirstName); 
            Assert.Equal(expectedFriend.LastName, actualFriend.LastName);
            Assert.Equal(expectedFriend.Username, actualFriend.Username);
            Assert.Equal(expectedFriend.Online, actualFriend.Online);
            Assert.Equal(expectedFriend.BestFriend, actualFriend.BestFriend);
        }

        [Fact]
        public async Task CreateFriend_ShouldReturnTrue()
        {
            // Arrange //
            var newFriend = TestBase.CreateSingleMockFriend();

            // Act //
            var results = await _friendRepository.InsertFriendAsync(newFriend);

            // Assert //
            Assert.True(results);
        }

        [Fact]
        public async Task UpdateFriend_ShouldReturnTrue()
        {
            // Act //
            var friends = await _friendRepository.GetAllAsync();
            var friendToUpdate = friends?.FirstOrDefault();

            // Assert //
            Assert.NotNull(friendToUpdate);

            // Arrange //
            friendToUpdate.Username = "xGeoMaticxNintendo";
            friendToUpdate.FirstName = "Bee";
            friendToUpdate.LastName = "Suth";

            // Act //
            var results = await _friendRepository.UpdateFriendAsync(friendToUpdate);

            // Assert //
            Assert.True(results);
        }

        [Fact]
       public async Task DeleteFriend_ShouldReturnTrue()
        {
            // Act //
            var friends = await _friendRepository.GetAllAsync(); 
            var userToDelete = friends?.FirstOrDefault();

            // Assert //
            Assert.NotNull(userToDelete);

            // Act //
            var result = await _friendRepository.DeleteFriendAsync(userToDelete.Id);

            // Assert //
            Assert.True(result); 
        }
    }
}
