CREATE TABLE [dbo].[Workers] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (255) NOT NULL,
    [LastName]   NVARCHAR (255) NOT NULL,
    [BirthDay]   DATE           NOT NULL,
    [Education]  NVARCHAR (255) NOT NULL,
    [ContactID]  INT            NOT NULL,
    [LocationID] INT            NOT NULL,
    [Sex]        NVARCHAR (255) NOT NULL,
    [Hobby]      NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Workers_fk0] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contacts] ([ID]),
    CONSTRAINT [Workers_fk1] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID])
);

