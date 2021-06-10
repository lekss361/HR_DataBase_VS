CREATE TABLE [HR_DataBase_VSDB].[Statuses] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL UNIQUE
    CONSTRAINT [PK_STATUSES] PRIMARY KEY CLUSTERED ([id] ASC)
);