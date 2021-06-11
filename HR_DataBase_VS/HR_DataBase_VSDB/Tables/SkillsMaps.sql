CREATE TABLE [HR_DataBase_VSDB].[SkillsMaps] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [SkillID]    INT NOT NULL,
    [LevelID]    INT NOT NULL,
    CONSTRAINT [PK_SKILLSMAP] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [SkillsMap_fk0] FOREIGN KEY ([SkillID]) REFERENCES [HR_DataBase_VSDB].[SkillNames] ([id]),
    CONSTRAINT [SkillsMap_fk1] FOREIGN KEY ([LevelID]) REFERENCES [HR_DataBase_VSDB].[Levels] ([id])
);