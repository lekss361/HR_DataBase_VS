CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLocationByID]
    @Id              INT            ,
    @LocationIndex   INT            ,
    @Country         NVARCHAR (255) ,
    @City            NVARCHAR (255) ,
    @Street          NVARCHAR (255) ,
    @HouseNumber     INT            ,
    @ApartmentNumber INT            
AS
    INSERT  [HR_DataBase_VSDB].[Locations]
        ([LocationIndex], [Country], [City], [Street], [HouseNumber], [ApartmentNumber])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[LocationIndex],
    INSERTED.[Country],
    INSERTED.[City],
    INSERTED.[Street],
    INSERTED.[HouseNumber],
    INSERTED.[ApartmentNumber]
  VALUES (@LocationIndex, @Country, @City, @Street, @HouseNumber, @ApartmentNumber)