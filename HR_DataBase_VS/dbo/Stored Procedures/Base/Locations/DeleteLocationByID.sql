CREATE PROCEDURE [dbo].[DeleteLocationByID]
	@id INT
AS
	DELETE from [Location] 
	WHERE id = @id
