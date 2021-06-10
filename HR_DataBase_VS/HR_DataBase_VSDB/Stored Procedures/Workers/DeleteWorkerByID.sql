CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteWorkerByID]
	@Id INT
AS
	DELETE from [Workers] 
	WHERE [id] = @Id