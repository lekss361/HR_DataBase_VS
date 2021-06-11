CREATE TABLE [HR_DataBase_VSDB].[Directions] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (255) NOT NULL UNIQUE
    CONSTRAINT [PK_DIRECTIONS] PRIMARY KEY CLUSTERED ([id] ASC),
);