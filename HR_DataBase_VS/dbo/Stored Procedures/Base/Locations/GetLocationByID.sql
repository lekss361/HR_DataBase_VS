CREATE PROCEDURE [HR_DataBase_VSDB].[GetLocationByID]
	@id int
AS 
 SELECT *
 FROM [Location] 
 WHERE ID=@id