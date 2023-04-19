CREATE PROCEDURE [dbo].[spFriend_Delete]
@Id int

AS
DELETE
FROM [dbo].Friends
WHERE Id = @ID;
