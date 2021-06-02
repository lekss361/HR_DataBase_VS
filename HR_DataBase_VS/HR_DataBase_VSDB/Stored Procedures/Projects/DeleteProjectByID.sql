CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteProjectByID]
	@id INT
AS
	DELETE FROM [Projects] 
	WHERE [id] = @id