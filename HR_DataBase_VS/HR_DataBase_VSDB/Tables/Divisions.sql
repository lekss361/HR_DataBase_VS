CREATE TABLE [HR_DataBase_VSDB].[Divisions] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [CompanyID]    INT            NOT NULL,
    [ContactID]    INT            NOT NULL,
    [LocationID]   INT            NOT NULL,
    [DirectionsID] INT            NOT NULL,
    CONSTRAINT [PK_DIVISIONS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Divisions_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [HR_DataBase_VSDB].[Company] ([id]),
    CONSTRAINT [Divisions_fk1] FOREIGN KEY ([ContactID]) REFERENCES [HR_DataBase_VSDB].[Contacts] ([id]),
    CONSTRAINT [Divisions_fk2] FOREIGN KEY ([LocationID]) REFERENCES [HR_DataBase_VSDB].[Location] ([id]),
    CONSTRAINT [Divisions_fk3] FOREIGN KEY ([DirectionsID]) REFERENCES [HR_DataBase_VSDB].[Directions] ([id])
);

