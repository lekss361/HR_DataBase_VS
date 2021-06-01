CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePositionBID]
    @id int              ,
    @Name nvarchar (255) ,       
    @DirectionsID int    ,       
    @DivisionsID  int   
    As
    UPDATE [Positions]
    set [Name] = @Name,
    [DirectionsID] = @DirectionsID,
    [DivisionsID] = DivisionsID
    WHERE [id] = @id