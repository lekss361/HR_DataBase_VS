CREATE PROCEDURE [HR_DataBase_VSDB].[GetEmloymentByID]
	@WorkerID int
AS
	SELECT * FROM [Employments]
    WHERE [WorkerID] = @WorkerID