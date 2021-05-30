CREATE PROCEDURE [HR_DataBase].[AddNewComments]
	@Worker int,
	@Comment  NVARCHAR (255),
	@Date date
AS
	INSERT [Comments]([WorkersID],[Comment],[Date])
	VALUES (@Worker,@Comment,@Date)