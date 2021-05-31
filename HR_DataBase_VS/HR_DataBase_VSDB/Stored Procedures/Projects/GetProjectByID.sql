CREATE PROCEDURE [HR_DataBase_VSDB].[GetProjectByID]
	@id int
AS
	SELECT * FROM [Projects]
    WHERE [id] = @id