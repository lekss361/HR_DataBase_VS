CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewProject]
	@Name			nvarchar (255),
	@DirectionID	int,
	@Information	nvarchar (255)
AS
	INSERT [Projects]([Name], [DirectionID], [Information])
	VALUES (@Name, @DirectionID,@Information)
	SELECT @@IDENTITY