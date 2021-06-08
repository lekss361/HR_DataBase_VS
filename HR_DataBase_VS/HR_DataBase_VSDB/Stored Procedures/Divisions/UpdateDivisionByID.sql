﻿CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDivisionByID]
	@Id int,
	@Name nvarchar (255),
	@Information nvarchar (255),
	@CompanyID int,   
    @ContactID int,
    @LocationID int,
    @DirectionsID int

AS
	UPDATE [Divisions]
	SET [Name] = @Name,
	    [Information] = @Information,
		[CompanyID] = @CompanyID,
		[ContactID] = @ContactID,
		[LocationID] = @LocationID,
		[DirectionsID] = @DirectionsID
	WHERE [id] = @Id