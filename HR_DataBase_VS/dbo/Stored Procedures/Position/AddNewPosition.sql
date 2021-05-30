CREATE PROCEDURE [dbo].[AddNewPosition]
	@Name nvarchar (255),
	@DirectionsID int,
	@DivisionsID int
AS
	INSERT [Positions]([Name], [DirectionsID], [DivisionsID])
	values (@Name, @DirectionsID, @DivisionsID )
