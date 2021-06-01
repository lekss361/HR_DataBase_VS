CREATE PROCEDURE [HR_DataBase_VSDB].[GetEmloymentByID]
	@WorkerID int
AS
	SELECT * FROM [Projects]
    WHERE [WorkerID]=@WorkerID