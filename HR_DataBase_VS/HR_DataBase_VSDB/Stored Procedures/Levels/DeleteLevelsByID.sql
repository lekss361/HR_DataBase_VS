CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteLevelsByID]
	@id INT
AS
	DELETE from [Levels] 
	WHERE [id] = @id