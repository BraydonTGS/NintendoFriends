CREATE TABLE [dbo].[VideoGameSystem]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1), 
	[VideoGameId] INT NOT NULL CONSTRAINT FK_VideoGameSystem_VideoGameId REFERENCES [dbo].[VideoGame]([Id]), 
	[SystemId] INT NOT NULL CONSTRAINT FK_VideoGameSystem_SystemId REFERENCES [dbo].[System]([Id])
)
