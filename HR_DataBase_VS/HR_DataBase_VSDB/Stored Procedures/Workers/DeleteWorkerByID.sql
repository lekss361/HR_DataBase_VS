CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteWorkerByID]
	@id INT
AS
	DELETE from [Workers] 
	WHERE id = @id
