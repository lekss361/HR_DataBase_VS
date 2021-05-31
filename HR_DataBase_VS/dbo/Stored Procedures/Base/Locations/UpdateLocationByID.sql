CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLocationByID]
    @ID              INT            NOT NULL,
    @LocationIndex   INT            NOT NULL,
    @Country         NVARCHAR (255) NOT NULL,
    @City            NVARCHAR (255) NOT NULL,
    @Street          NVARCHAR (255) NOT NULL,
    @HouseNumber     INT            NOT NULL,
    @ApartmentNumber INT            NOT NULL
AS
	update  [dbo].[Location]
	set [ID]=@ID,
	    [LocationIndex]=@LocationIndex,
	    [Country]=@Country,
	    [City]=@City,
	    [Street]=@Street,
	    [HouseNumber]=@HouseNumber,
	    [ApartmentNumber]=@ApartmentNumber
	WHERE ID=@ID