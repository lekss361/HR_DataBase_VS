CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteCompaniesByID]
	@id INT
AS
	DELETE from [Companies] 
	WHERE [id] = @id