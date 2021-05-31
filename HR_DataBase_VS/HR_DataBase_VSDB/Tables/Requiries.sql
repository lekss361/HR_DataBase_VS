CREATE TABLE [HR_DataBase_VSDB].[Requiries] (
    [PositionID] INT NOT NULL,
    [SkillMapID] INT NOT NULL,
    CONSTRAINT [Requiries_fk0] FOREIGN KEY ([PositionID]) REFERENCES [HR_DataBase_VSDB].[Project] ([id]),
    CONSTRAINT [Requiries_fk1] FOREIGN KEY ([SkillMapID]) REFERENCES [HR_DataBase_VSDB].[SkillsMap] ([id])
);

