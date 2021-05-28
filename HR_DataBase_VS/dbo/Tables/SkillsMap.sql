CREATE TABLE [dbo].[SkillsMap] (
    [ID]       INT NOT NULL,
    [SkillID]  INT NOT NULL,
    [LevelsID] INT NOT NULL,
    CONSTRAINT [PK_SKILLSMAP] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [SkillsMap_fk0] FOREIGN KEY ([SkillID]) REFERENCES [dbo].[SkillName] ([ID]),
    CONSTRAINT [SkillsMap_fk1] FOREIGN KEY ([LevelsID]) REFERENCES [dbo].[Levels] ([ID])
);

