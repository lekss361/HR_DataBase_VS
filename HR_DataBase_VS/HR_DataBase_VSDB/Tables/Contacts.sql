CREATE TABLE [HR_DataBase_VSDB].[Contacts] (
    [id]          INT              IDENTITY (1, 1) NOT NULL,
    [Phone]       NVARCHAR (50)    NOT NULL UNIQUE,
    [Email]       NVARCHAR (100)   NULL     UNIQUE,
    [Information] NVARCHAR (100)   NULL
    CONSTRAINT [PK_CONTACTS] PRIMARY KEY CLUSTERED ([id] ASC)
);