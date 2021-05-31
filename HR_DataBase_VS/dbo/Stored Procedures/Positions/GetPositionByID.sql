CREATE PROCEDURE [dbo].[GetPositionByID]
	@Positions int
AS
    SELECT [ID],
    [Name], 
    [DirectionsID],
    [DivisionsID] 
	FROM [POSITIONS]
    WHERE ID = @Positions