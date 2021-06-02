CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteEmloymentByID]
	@WorkerID INT
AS
	DELETE FROM [Employments] 
	WHERE [WorkerID] = @WorkerID