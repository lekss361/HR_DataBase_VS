CREATE PROCEDURE [HR_DataBase_VSDB].[GetLocationByID]
	@id int
AS 
 SELECT *
 FROM [Locations] 
 WHERE [id] = @id