﻿CREATE PROCEDURE [HR_DataBase_VSDB].[UpdatePositionBID]
    @id int              ,
    @Name nvarchar (255) ,       
    @DirectionID int     
    As
    UPDATE [Positions]
    set [Name] = @Name,
    [DirectionID] = @DirectionID
    WHERE [id] = @id