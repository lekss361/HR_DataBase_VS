CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteDivisionByID]
	@id int
AS
	DELETE FROM [Divisions] 
	WHERE [id] = @id