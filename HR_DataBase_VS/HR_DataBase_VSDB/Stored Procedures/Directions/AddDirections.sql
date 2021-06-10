CREATE PROCEDURE [HR_DataBase_VSDB].[AddDirections]
    @Name         NVARCHAR (255)
AS
	INSERT INTO [Directions]([Name])
	VALUES (@Name)
	SELECT @@IDENTITY