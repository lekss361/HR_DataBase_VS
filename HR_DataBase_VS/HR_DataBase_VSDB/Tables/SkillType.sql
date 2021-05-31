CREATE TABLE [HR_DataBase_VSDB].[SkillType] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_SKILLTYPE] PRIMARY KEY CLUSTERED ([id] ASC)
);

