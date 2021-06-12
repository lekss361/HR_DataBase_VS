CREATE PROCEDURE [HR_DataBase_VSDB].[GetPositionsWithDirectionName]
AS
SELECT Pos.Name, D.Name as DirectionName
FROM [HR_DataBase_VSDB].[Positions] as Pos,
	[HR_DataBase_VSDB].[Directions] as D
WHERE (Pos.DirectionID = D.id)