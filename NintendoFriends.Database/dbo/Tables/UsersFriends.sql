CREATE TABLE [dbo].[UsersFriends]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1), 
	[UserId] INT NOT NULL CONSTRAINT FK_UsersFriends_UserId REFERENCES [dbo].[Users]([Id]), 
	[FriendId] INT NOT NULL CONSTRAINT FK_UsersFriends_FriendId REFERENCES [dbo].[Friends]([Id])
)
