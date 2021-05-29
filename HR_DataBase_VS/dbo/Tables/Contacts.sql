CREATE TABLE [dbo].[Contacts] (
    [ID]          INT            NOT NULL,
    [Phone]       DECIMAL (30)   NULL,
    [Email]       NVARCHAR (255) NULL,
    [Information] NVARCHAR (255)   NOT NULL,
    CONSTRAINT [PK_CONTACTS] PRIMARY KEY CLUSTERED ([ID] ASC)
);

