CREATE PROCEDURE [HR_DataBase_VSDB].[DeletePositionByID]
	@id int
	AS
	DELETE FROM [Positions] 
	WHERE [id] = @id