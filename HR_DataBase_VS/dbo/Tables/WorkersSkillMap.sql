CREATE TABLE [dbo].[WorkersSkillMap] (
    [WorkersID] INT NOT NULL,
    [SkillsID]  INT NOT NULL,
    CONSTRAINT [WorkersSkillMap_fk0] FOREIGN KEY ([WorkersID]) REFERENCES [dbo].[Workers] ([ID]),
    CONSTRAINT [WorkersSkillMap_fk1] FOREIGN KEY ([SkillsID]) REFERENCES [dbo].[SkillsMap] ([ID])
);

