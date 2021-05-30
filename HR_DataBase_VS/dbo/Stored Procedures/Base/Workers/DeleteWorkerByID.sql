CREATE PROCEDURE [HR_DataBase].[DeleteWorkerByID]
	@id INT
AS
	DELETE from [Workers] 
	WHERE id = @id
