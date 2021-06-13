CREATE PROCEDURE [HR_DataBase_VSDB].[GetProjectsWithDirectionName]
AS
SELECT P.id, P.Name ,D.Name as DirectionName, P.Information
FROM [HR_DataBase_VSDB].[Projects] as P,[HR_DataBase_VSDB].[Directions] as D
WHERE (P.DirectionID = D.id)