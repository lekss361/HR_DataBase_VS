CREATE PROCEDURE [dbo].[AddNewDivision]
	@Name nvarchar (255),
	@CompanyID int,   
    @ContactID int,
    @LocationID int,
    @DirectionsID int
AS
	insert [Division] ([Name],[CompanyID], [ContactID], [LocationID], [DirectionsID])
	values (@Name,CompanyID, @ContactID, @LocationID, @DirectionsID)