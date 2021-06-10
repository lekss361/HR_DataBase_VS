CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewPosition]
	@Name nvarchar (255),
	@DirectionsID int,
	@DivisionsID int
AS
	INSERT [Positions]([Name], [DirectionsID], [DivisionsID])
	VALUES (@Name, @DirectionsID, @DivisionsID )
	SELECT @@IDENTITY