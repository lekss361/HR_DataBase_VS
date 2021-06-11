CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewStatus]
    @Name  NVARCHAR (255)
AS 
    INSERT INTO [Statuses] (Name)
    VALUES(@Name)
	SELECT @@IDENTITY