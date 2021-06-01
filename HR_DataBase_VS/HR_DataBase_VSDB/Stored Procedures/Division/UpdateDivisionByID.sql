CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDivisionByID]
	@id int	              ,
	@Name  NVARCHAR (255) ,
    @CompanyID   INT      ,      
    @ContactID   INT      ,      
    @LocationID  INT      ,      
    @DirectionsID INT
    AS
    UPDATE [Divisions]
	set [Name] = @Name,
    [CompanyID] = @CompanyID,
    [ContactID] = @ContactID,
    [LocationID] = @LocationID,
    [DirectionsID] = @DirectionsID
    WHERE [id] = @id