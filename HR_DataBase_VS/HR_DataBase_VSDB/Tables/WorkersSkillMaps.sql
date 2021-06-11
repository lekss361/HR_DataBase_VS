CREATE TABLE [HR_DataBase_VSDB].[WorkersSkillMaps] (
    [WorkerID]     INT NOT NULL,
    [SkillsMapID]  INT NOT NULL
    CONSTRAINT [WorkersSkillMap_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id]),
    CONSTRAINT [WorkersSkillMap_fk1] FOREIGN KEY ([SkillsMapID]) REFERENCES [HR_DataBase_VSDB].[SkillsMaps] ([id])
);