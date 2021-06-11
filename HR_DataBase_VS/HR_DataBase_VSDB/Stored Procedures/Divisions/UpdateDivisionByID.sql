/*CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDivisionByID]
	@Id				int,
	@Name			nvarchar (255),
	@Information	nvarchar (255),
	@CompanyID		int,   
    @ContactID		int,
    @LocationID		int,
    @DirectionsID   int
AS
    INSERT  [HR_DataBase_VSDB].[Divisions]
        ([Name], [Information], [CompanyID], [ContactID], [LocationID], [DirectionsID])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name],
    INSERTED.[Information],
    INSERTED.[CompanyID],
    INSERTED.[ContactID],
    INSERTED.[LocationID],
    INSERTED.[DirectionsID]
  VALUES (@Name, @Information, @CompanyID, @ContactID, @LocationID, @DirectionsID)*/