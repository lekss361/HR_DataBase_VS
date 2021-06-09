CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePreviousWorkByID]
	@WorkerID int,
	@DateStart date,
	@DateEnd date,
	@Information  nvarchar (255)
AS
	UPDATE [PreviousWorks]
	SET [DateStart] = @DateStart,
		[DateEnd] = @DateEnd,
		[Information] = @Information
	WHERE [WorkerID] = @WorkerID