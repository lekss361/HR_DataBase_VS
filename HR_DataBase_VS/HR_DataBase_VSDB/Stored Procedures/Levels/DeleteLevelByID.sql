CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteLevelByID]
	@id INT
AS
	DELETE from [Levels] 
	WHERE [id] = @id