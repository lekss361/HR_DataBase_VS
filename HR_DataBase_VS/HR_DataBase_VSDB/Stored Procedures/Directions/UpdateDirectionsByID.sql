CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDirectionsByID]
    @Id			INT,
    @Name       NVARCHAR (255) 
AS
    INSERT  [Directions]
        ([Name])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name]
    VALUES ( @Name)