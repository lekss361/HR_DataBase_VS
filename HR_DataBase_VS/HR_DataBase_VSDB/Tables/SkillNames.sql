CREATE TABLE [HR_DataBase_VSDB].[SkillNames] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [Skill]       NVARCHAR (50)  NOT NULL UNIQUE,
    [SkillTypeID] INT            NOT NULL,
    CONSTRAINT [PK_SKILLNAME] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [SkillName_fk0] FOREIGN KEY ([SkillTypeID]) REFERENCES [HR_DataBase_VSDB].[SkillTypes] ([id])
);