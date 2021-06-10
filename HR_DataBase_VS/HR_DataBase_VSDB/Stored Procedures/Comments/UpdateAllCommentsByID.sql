/*CREATE PROCEDURE [HR_DataBase].[UpdateAllByID]
	@id int,
	@Worker int,
	@Comment  nvarchar (255),
	@Date date
AS
	update  [dbo].[Comments]
	set [WorkersID]=@Worker,
	[Comment]=@Comment,
	[Date]=@Date
	where ID=@id
	*/