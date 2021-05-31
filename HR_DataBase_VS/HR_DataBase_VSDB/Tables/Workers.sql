CREATE TABLE [HR_DataBase_VSDB].[Workers] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (255) NOT NULL,
    [LastName]   NVARCHAR (255) NOT NULL,
    [BirthDay]   DATE           NOT NULL,
    [Education]  NVARCHAR (255) NOT NULL,
    [ContactID]  INT            NULL,
    [LocationID] INT            NULL,
    [Sex]        NVARCHAR (255) NOT NULL,
    [Hobby]      NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Workers_fk0] FOREIGN KEY ([ContactID]) REFERENCES [HR_DataBase_VSDB].[Contacts] ([id]),
    CONSTRAINT [Workers_fk1] FOREIGN KEY ([LocationID]) REFERENCES [HR_DataBase_VSDB].[Locations] ([id])
);

