CREATE PROCEDURE [dbo].[DeletePositionByID]	
	@Positions int
AS
    DELETE FROM [DBO].[Positions] where id = @Positions
