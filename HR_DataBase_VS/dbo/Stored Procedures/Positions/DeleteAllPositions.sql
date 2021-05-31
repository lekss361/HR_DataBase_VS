CREATE PROCEDURE [dbo].[DeleteAllPositions]	
	@Positions int
AS
    DELETE FROM [DBO].[Positions]
