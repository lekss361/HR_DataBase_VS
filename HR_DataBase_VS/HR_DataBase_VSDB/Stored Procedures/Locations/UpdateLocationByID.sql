CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLocationByID]
    @Id              INT            ,
    @LocationIndex   INT            ,
    @Country         NVARCHAR (255) ,
    @City            NVARCHAR (255) ,
    @Street          NVARCHAR (255) ,
    @HouseNumber     INT            ,
    @ApartmentNumber INT            
AS
    UPDATE [Locations]
    SET
    [LocationIndex] =   @LocationIndex,
    [Country] =         @Country,
    [City] =            @City,
    [Street] =          @Street,
    [HouseNumber] =     @HouseNumber,
    [ApartmentNumber] = @ApartmentNumber
    WHERE [id] = @Id