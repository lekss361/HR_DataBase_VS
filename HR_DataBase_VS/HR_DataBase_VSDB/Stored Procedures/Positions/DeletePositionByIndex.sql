CREATE PROCEDURE [HR_DataBase_VSDB].[DeletePositionByIndex]
	@id int
	AS
	DELETE FROM [Positions] 
	WHERE [id] = @id