CREATE PROCEDURE [HR_DataBase_VSDB].[DeletePreviousWorkByID]
	@WorkerID INT
AS
	DELETE FROM [PreviousWorks] 
	WHERE [WorkerID] = @WorkerID