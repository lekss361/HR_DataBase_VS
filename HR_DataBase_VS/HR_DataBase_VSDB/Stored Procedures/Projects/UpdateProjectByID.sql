CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateProjectByID]
	@Id int,
	@Name  nvarchar (255),
	@DirectionsID int
AS
	UPDATE [SkillNames]
	SET [Name] = @Name,
	[DirectionsID] = @DirectionsID
	WHERE [id] = @Id