CREATE TABLE [dbo].[FriendsVideoGame]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1), 
	[FriendId] INT NOT NULL CONSTRAINT FK_FriendsVideoGame_FriendId REFERENCES [dbo].[Friends]([Id]),
	[VideoGameId] INT NOT NULL CONSTRAINT FK_FriendsVideoGame_VideoGameId REFERENCES [dbo].[VideoGame]([Id])
)
