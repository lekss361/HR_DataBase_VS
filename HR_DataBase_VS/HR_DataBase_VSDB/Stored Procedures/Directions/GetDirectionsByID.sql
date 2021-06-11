CREATE PROCEDURE [HR_DataBase_VSDB].[GetDirectionsByID]
	@id		int
AS 
 SELECT *
 FROM [Directions] 
 WHERE [id] = @id