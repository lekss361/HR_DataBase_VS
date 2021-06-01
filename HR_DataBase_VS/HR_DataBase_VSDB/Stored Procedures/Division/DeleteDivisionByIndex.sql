CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteDivisionByIndex]
	@id int
	AS
	DELETE FROM [Divisions]
	WHERE [id] = @id 