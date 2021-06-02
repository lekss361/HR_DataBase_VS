CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewProject]
	@Name  nvarchar (255),
	@DirectionsID int
AS
	INSERT [Projects]([Name],[DirectionsID])
	VALUES (@Name, @DirectionsID)