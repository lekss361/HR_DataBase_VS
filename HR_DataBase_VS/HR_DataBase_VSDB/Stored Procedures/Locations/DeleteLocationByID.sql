CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteLocationByID]
	@id INT
AS
	DELETE from [Location] 
	WHERE [id] = @id
