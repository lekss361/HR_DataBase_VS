CREATE PROCEDURE [HR_DataBase_VSDB].[GetLevelByID]
	@id int
AS 
 SELECT *
 FROM [Levels] 
 WHERE [id] = @id