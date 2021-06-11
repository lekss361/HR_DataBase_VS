CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateProjectByID]
	@id				int,
	@Name			nvarchar (255),
	@DirectionsID	int
AS
    INSERT  [Projects]
        ([Name], [DirectionsID])
    OUTPUT
    INSERTED.[id],
    INSERTED.[Name],
    INSERTED.[DirectionsID],
  VALUES ( @Name, @DirectionsID)