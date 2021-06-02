CREATE PROCEDURE [HR_DataBase_VSDB].[GetEmloymentByID]
	@WorkerID int
AS
	SELECT * FROM [Emloyments]
    WHERE [WorkerID] = @WorkerID