CREATE TABLE [HR_DataBase_VSDB].[Locations] (
    [id]              INT            IDENTITY (1, 1) NOT NULL,
    [LocationIndex]   INT            NOT NULL,
    [Country]         NVARCHAR (100) NOT NULL,
    [City]            NVARCHAR (100) NOT NULL,
    [Street]          NVARCHAR (100) NOT NULL,
    [HouseNumber]     INT            NOT NULL,
    [ApartmentNumber] INT            NOT NULL
    CONSTRAINT [PK_LOCATION] PRIMARY KEY CLUSTERED ([id] ASC)
);