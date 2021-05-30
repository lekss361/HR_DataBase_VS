CREATE PROCEDURE [HR_DataBase].[DeleteByID]
	@id INT
AS
	DELETE from [Comments] 
	WHERE id = @id
