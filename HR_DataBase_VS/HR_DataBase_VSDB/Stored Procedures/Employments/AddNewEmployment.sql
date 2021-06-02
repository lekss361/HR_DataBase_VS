CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewEmployment]
	@WorkerID int
	@PositionID int
	@ProjectID int
	@StatusID int
AS
	INSERT [Employments]([WorkerID],[PositionID],[ProjectID],[StatusID])
	VALUES (@WorkerID, @PositionID, @ProjectID, @StatusID)