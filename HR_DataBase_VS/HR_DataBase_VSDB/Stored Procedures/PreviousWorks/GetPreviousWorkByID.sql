CREATE PROCEDURE [HR_DataBase_VSDB].[GetPreviousWorkByID]
	@WorkerID int
AS
	SELECT * FROM [PreviousWorks]
    WHERE [WorkerID] = @WorkerID