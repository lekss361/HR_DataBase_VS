CREATE TABLE [HR_DataBase_VSDB].[WorkersSkillMap] (
    [WorkersID] INT NOT NULL,
    [SkillsID]  INT NOT NULL,
    CONSTRAINT [WorkersSkillMap_fk0] FOREIGN KEY ([WorkersID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id]),
    CONSTRAINT [WorkersSkillMap_fk1] FOREIGN KEY ([SkillsID]) REFERENCES [HR_DataBase_VSDB].[SkillsMap] ([id])
);

