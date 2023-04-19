﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY CLUSTERED IDENTITY(1, 1), 
	[FirstName] VARCHAR(25) NOT NULL, 
	[LastName] VARCHAR(25) NOT NULL, 
	[Username] NVARCHAR(25) NOT NULL UNIQUE CHECK (LEN(Username) >= 8),
	[Password] NVARCHAR(25) NOT NULL,
)
