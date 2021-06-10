CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewDivision]
	@Name nvarchar (255),
	@Information nvarchar (255),
	@CompanyID int,   
    @ContactID int,
    @LocationID int,
    @DirectionsID int
AS
	INSERT [Divisions]([Name], [CompanyID], [ContactID], [LocationID], [DirectionID], [Information])
	VALUES (@Name, @CompanyID, @ContactID, @LocationID, @DirectionsID, @Information)
	SELECT @@IDENTITY