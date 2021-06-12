CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewPosition]
	@Name			nvarchar (255),
	@DirectionID	int
AS
	INSERT [Positions]([Name], [DirectionID])
	VALUES (@Name, @DirectionID )
	SELECT @@IDENTITY