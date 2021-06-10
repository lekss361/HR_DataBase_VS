CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewStatuses]
    @Name  NVARCHAR (255)
AS 
    INSERT INTO [Statuses] (Name)
    VALUES(@Name)
	SELECT @@IDENTITY