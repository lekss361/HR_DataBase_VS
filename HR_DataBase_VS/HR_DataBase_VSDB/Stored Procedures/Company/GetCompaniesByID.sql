CREATE PROCEDURE [HR_DataBase_VSDB].[GetCompaniesByID]
	@id int
AS 
 SELECT *
 FROM [Companies] 
 WHERE [id] = @id