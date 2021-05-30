CREATE PROCEDURE [dbo].[DeleteByID]
	@id INT
AS
	DELETE from [Comments] 
	WHERE id = @id
