CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLevelByID]
    @Id         INT,
    @Name       NVARCHAR (255) 
AS
    UPDATE [Levels]
    SET
    [Name] =   @Name
    WHERE [id] = @Id