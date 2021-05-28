CREATE TABLE [dbo].[Location] (
    [ID]              INT            NOT NULL,
    [LocationIndex]   INT            NOT NULL,
    [Country]         NVARCHAR (255) NOT NULL,
    [City]            NVARCHAR (255) NOT NULL,
    [Street]          NVARCHAR (255) NOT NULL,
    [HouseNumber]     INT            NOT NULL,
    [ApartmentNumber] INT            NOT NULL,
    CONSTRAINT [PK_LOCATION] PRIMARY KEY CLUSTERED ([ID] ASC)
);

