CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateStatusesByID]
	@Id int,
    @Name  NVARCHAR (255) 
AS
	update [Statuses]
	set [Name]=@Name
	WHERE [id]=@Id