CREATE PROCEDURE [HR_DataBase_VSDB].[AddLocation]
    @LocationIndex   INT            ,
    @Country         NVARCHAR (255) ,
    @City            NVARCHAR (255) ,
    @Street          NVARCHAR (255) ,
    @HouseNumber     INT            ,
    @ApartmentNumber INT            
AS
	INSERT INTO [Location]
        ([LocationIndex],[Country],[City],[Street],[HouseNumber],[ApartmentNumber])
	VALUES (@LocationIndex, @Country, @City, @Street, @HouseNumber, @ApartmentNumber)
