CREATE PROCEDURE [HR_DataBase_VSDB].[GetLevelsByID]
	@id int
AS 
 SELECT *
 FROM [Levels] 
 WHERE [id]=@id