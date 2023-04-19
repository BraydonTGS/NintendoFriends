CREATE PROCEDURE [dbo].[spFriend_Update]
@Id int,
@FirstName VARCHAR(25), 
@LastName VARCHAR(25), 
@Username VARCHAR(25), 
@Online VARCHAR(5), 
@BestFriend VARCHAR(5)
AS
BEGIN
UPDATE [dbo].Friends
SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Online = @Online, BestFriend = @BestFriend
WHERE Id = @Id;
END
