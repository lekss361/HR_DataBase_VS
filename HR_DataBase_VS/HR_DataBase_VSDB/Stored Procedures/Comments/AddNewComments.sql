	CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewComments]
	@Worker int,
	@Comment  nvarchar (255),
	@Date date
AS
	INSERT [Comments]([WorkerID],[Comment],[Date])
	VALUES (@Worker,@Comment,@Date)
	SELECT @@IDENTITY