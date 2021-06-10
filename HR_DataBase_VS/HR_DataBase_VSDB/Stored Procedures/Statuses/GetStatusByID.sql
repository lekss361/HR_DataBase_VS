CREATE PROCEDURE [HR_DataBase_VSDB].[GetStatusByID]
	@id		int
AS 
	SELECT *
	FROM [Statuses] 
	WHERE [id] = @id