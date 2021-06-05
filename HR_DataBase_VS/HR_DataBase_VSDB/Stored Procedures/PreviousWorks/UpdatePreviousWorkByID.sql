CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePreviousWorkByID]
	@WorkerID int,
	@Information  nvarchar (255),
	@DateStart date,
	@DateEnd date
AS
	UPDATE [PreviousWorks]
	SET [Information] = @Information,
		[DateStart] = @DateStart,
		[DateEnd] = @DateEnd
	WHERE [WorkerID] = @WorkerID