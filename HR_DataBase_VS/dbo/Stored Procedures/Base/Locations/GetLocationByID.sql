CREATE PROCEDURE [dbo].[GetLocationByID]
	@id int
AS 
 SELECT *
 FROM [Location] 
 WHERE ID=@id