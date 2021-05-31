CREATE TABLE [HR_DataBase_VSDB].[SkillName] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Skill]       NVARCHAR (255) NOT NULL,
    [SkillTypeID] INT            NOT NULL,
    CONSTRAINT [PK_SKILLNAME] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [SkillName_fk0] FOREIGN KEY ([SkillTypeID]) REFERENCES [HR_DataBase_VSDB].[SkillType] ([id])
);

