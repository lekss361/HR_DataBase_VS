CREATE TABLE [dbo].[Company] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (255) NOT NULL,
    [Iformation] NVARCHAR (255) NULL,
    [ContactID]    INT            NOT NULL,
    [LocationID]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Company_fk1] FOREIGN KEY ([ContactID]) REFERENCES [dbo].[Contacts] ([ID]),
    CONSTRAINT [Company_fk2] FOREIGN KEY ([LocationID]) REFERENCES [dbo].[Location] ([ID])
);

