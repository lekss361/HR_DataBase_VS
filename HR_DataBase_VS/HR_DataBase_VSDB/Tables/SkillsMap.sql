CREATE TABLE [HR_DataBase_VSDB].[SkillsMap] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [SkillID]  INT NOT NULL,
    [LevelsID] INT NOT NULL,
    CONSTRAINT [PK_SKILLSMAP] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [SkillsMap_fk0] FOREIGN KEY ([SkillID]) REFERENCES [HR_DataBase_VSDB].[SkillName] ([id]),
    CONSTRAINT [SkillsMap_fk1] FOREIGN KEY ([LevelsID]) REFERENCES [HR_DataBase_VSDB].[Levels] ([id])
);

