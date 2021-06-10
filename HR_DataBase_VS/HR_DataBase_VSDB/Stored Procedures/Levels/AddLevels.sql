CREATE PROCEDURE [HR_DataBase_VSDB].[AddLevels]
    @Name         NVARCHAR (255) 
AS
	INSERT INTO [Levels] ([Name])
	VALUES (@Name)
	SELECT @@IDENTITY