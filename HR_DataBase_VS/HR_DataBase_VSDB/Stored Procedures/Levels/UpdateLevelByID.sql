CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLevelByID]
    @Id         INT,
    @Name       NVARCHAR (255) 
AS
    INSERT  [Levels]
        ([Name])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name]
  VALUES (@Name)