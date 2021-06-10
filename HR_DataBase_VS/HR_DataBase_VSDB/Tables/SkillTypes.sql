CREATE TABLE [HR_DataBase_VSDB].[SkillTypes] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (30) NOT NULL UNIQUE,
    CONSTRAINT [PK_SKILLTYPE] PRIMARY KEY CLUSTERED ([id] ASC)
);