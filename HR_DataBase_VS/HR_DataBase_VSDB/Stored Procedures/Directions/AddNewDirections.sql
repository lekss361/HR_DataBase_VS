CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewDirections]
    @Name    NVARCHAR (255)           
AS
	INSERT INTO [Directions] ([Name])
	VALUES (@Name)
	SELECT @@IDENTITY