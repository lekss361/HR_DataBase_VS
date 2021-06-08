CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewProject]
	@Name  nvarchar (255),
	@DirectionsID int,
	@Information nvarchar (255)
AS
	INSERT [Projects]([Name],[DirectionsID])
	VALUES (@Name, @DirectionsID)