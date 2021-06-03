CREATE TABLE [HR_DataBase_VSDB].[WorkersSkillMaps] (
    --[id]         INT            IDENTITY (1, 1) NOT NULL,
    [WorkersID] INT NOT NULL,
    [SkillsMapsID]  INT NOT NULL,
    CONSTRAINT [WorkersSkillMap_fk0] FOREIGN KEY ([WorkersID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id]),
    CONSTRAINT [WorkersSkillMap_fk1] FOREIGN KEY ([SkillsMapsID]) REFERENCES [HR_DataBase_VSDB].[SkillsMaps] ([id])
);

