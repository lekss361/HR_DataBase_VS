CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePositionByID]
    @Id             int           ,
    @Name           nvarchar (255),       
    @DirectionID    int     
As
    UPDATE [Positions]
    SET
    [Name] =        @Name,
    [DirectionID] = @DirectionID
    WHERE [id] = @Id