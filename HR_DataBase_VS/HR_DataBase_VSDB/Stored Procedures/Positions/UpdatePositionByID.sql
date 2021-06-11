CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePositionByID]
    @id             int           ,
    @Name           nvarchar (255),       
    @DirectionID    int     
As
    INSERT  [Positions]
        ([Name], [DirectionID])
    OUTPUT
    INSERTED.[id],
    INSERTED.[Name],
    INSERTED.[DirectionID]
  VALUES ( @Name, @DirectionID)