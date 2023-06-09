﻿CREATE TABLE [dbo].[Friends]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1),
	[FirstName] VARCHAR(25) NOT NULL, 
	[LastName] VARCHAR(25) NOT NULL, 
	[Username] VARCHAR(25) NOT NULL UNIQUE CHECK (LEN(Username) >= 8),
	[Online] VARCHAR(5) NOT NULL, 
	[BestFriend] VARCHAR(5) NOT NULL, 
)
