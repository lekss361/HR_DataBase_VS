CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewLevel]
    @Name     NVARCHAR (255) 
AS
	INSERT INTO [Levels] ([Name])
	VALUES (@Name)
	SELECT @@IDENTITY