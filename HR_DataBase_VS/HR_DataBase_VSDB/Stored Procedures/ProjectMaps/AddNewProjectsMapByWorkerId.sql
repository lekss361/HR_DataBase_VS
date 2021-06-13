CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewProjectsMapByWorkerId]
	@ProjectID  int,
	@WorkerID int
AS
	INSERT [ProjectMaps]([ProjectID],[WorkerID])
	VALUES (@ProjectID, @WorkerID)