CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewPreviousWork]
	@WorkerID int,
	@DateStart date,
	@DateEnd date,
	@Information  nvarchar (255)
AS
	INSERT INTO [PreviousWorks]([WorkerID],[DateStart],[DateEnd],[Information])
	VALUES (@WorkerID, @DateStart, @DateEnd, @Information)