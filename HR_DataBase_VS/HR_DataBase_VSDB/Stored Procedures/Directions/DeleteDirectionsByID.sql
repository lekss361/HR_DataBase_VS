CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteDirectionsByID]
	@id INT
AS
	DELETE from [Directions] 
	WHERE [id] = @id