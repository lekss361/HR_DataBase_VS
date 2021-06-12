CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDirectionsByID]
    @Id			INT,
    @Name       NVARCHAR (255) 
AS
    UPDATE [Directions]
    SET
    [Name] =   @Name
    WHERE [Id] = @Id