CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteByID1]
	@id INT
AS
	DELETE from [Comments] 
	WHERE id = @id
