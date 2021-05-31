CREATE PROCEDURE [dbo].[GetAllPositions]
	@Positions int
AS
    SELECT [id],
    [Name], 
    [DirectionsID],
    [DivisionsID] 
	FROM [POSITIONS]
     
