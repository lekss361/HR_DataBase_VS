CREATE PROCEDURE [HR_DataBase_VSDB].[AddLocation]
    @LocationIndex   INT            NOT NULL,
    @Country         NVARCHAR (255) NOT NULL,
    @City            NVARCHAR (255) NOT NULL,
    @Street          NVARCHAR (255) NOT NULL,
    @HouseNumber     INT            NOT NULL,
    @ApartmentNumber INT            NOT NULL
AS
	INSERT INTO [Location]
        ([LocationIndex],[Country],[City],[Street],[HouseNumber],[ApartmentNumber])
	VALUES (@LocationIndex, @Country, @City, @Street, @HouseNumber, @ApartmentNumber)
