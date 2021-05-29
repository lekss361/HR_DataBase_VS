CREATE TABLE [dbo].[Divisions] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [CompanyID]    INT            NOT NULL,
    [ContactID]    INT            NOT NULL,
    [LocationID]   INT            NOT NULL,
    [DirectionsID] INT            NOT NULL,
    CONSTRAINT [PK_DIVISIONS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Divisions_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Company] ([ID]),
    CONSTRAINT [Divisions_fk1] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contacts] ([ID]),
    CONSTRAINT [Divisions_fk2] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID]),
    CONSTRAINT [Divisions_fk3] FOREIGN KEY ([DirectionsID]) REFERENCES [dbo].[Directions] ([ID])
);

