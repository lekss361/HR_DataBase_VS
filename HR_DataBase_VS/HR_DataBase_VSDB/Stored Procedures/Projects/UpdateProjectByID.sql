CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateProjectByID]
	@id				int,
	@Name			nvarchar (255),
	@DirectionsID	int
AS
    UPDATE [Projects]
    SET
    [Name] =            @Name,
    [DirectionsID] =    @DirectionsID
    WHERE [Id] = @Id