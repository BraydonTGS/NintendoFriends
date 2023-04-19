CREATE PROCEDURE [dbo].[spFriend_Get]
@Id int
AS
BEGIN
SELECT [FirstName], [LastName], [Username], [Online], [BestFriend] FROM [dbo].Friends
WHERE Id = @Id;
END
