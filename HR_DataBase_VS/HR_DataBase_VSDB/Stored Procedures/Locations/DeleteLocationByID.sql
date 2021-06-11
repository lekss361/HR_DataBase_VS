CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteLocationByID]
	@id INT
AS
	DELETE from [Locations] 
	WHERE [id] = @id