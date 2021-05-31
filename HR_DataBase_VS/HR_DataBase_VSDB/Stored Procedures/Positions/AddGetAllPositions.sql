CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllPositions]
	@Positions int
AS
    SELECT * FROM [Positions]