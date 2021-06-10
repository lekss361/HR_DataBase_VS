CREATE PROCEDURE [HR_DataBase_VSDB].[AddLocation]
    @LocationIndex   INT            null,
    @Country         NVARCHAR (255) ,
    @City            NVARCHAR (255) ,
    @Street          NVARCHAR (255) ,
    @HouseNumber     INT            ,
    @ApartmentNumber INT            null
AS
	INSERT INTO [Locations]
        ([Country],[City],[Street],[HouseNumber],[ApartmentNumber],[LocationIndex])
	VALUES ( @Country, @City, @Street, @HouseNumber, @ApartmentNumber, @LocationIndex)
	SELECT @@IDENTITY