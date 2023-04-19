CREATE PROCEDURE [dbo].[spFriend_Insert]
@FirstName VARCHAR(25), 
@LastName VARCHAR(25), 
@Username VARCHAR(25), 
@Online VARCHAR(5), 
@BestFriend VARCHAR(5)
AS
BEGIN
INSERT INTO [dbo].Friends(FirstName, LastName, Username, Online, BestFriend)
VALUES(@FirstName, @LastName, @Username, @Online, @BestFriend);
END
