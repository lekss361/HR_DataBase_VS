CREATE TABLE [HR_DataBase_VSDB].[Contacts] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Phone]       NVARCHAR (255)   NULL,
    [Email]       NVARCHAR (255)   NULL,
    [Information] NVARCHAR (255)   NOT NULL,
    CONSTRAINT [PK_CONTACTS] PRIMARY KEY CLUSTERED ([id] ASC)
);

