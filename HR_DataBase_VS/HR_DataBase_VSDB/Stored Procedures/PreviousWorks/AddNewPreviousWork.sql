CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewPreviousWork]
	@WorkerID int,
	@Information  nvarchar (255),
	@DateStart date,
	@DateEnd date
AS
	INSERT [PreviousWorks]([WorkerID],[Information],[DateStart],[DateEnd])
	VALUES (@WorkerID, @Information, @DateStart, @DateEnd)