CREATE TABLE [dbo].[Requiries] (
    [PositionID] INT NOT NULL,
    [SkillMapID] INT NOT NULL,
    CONSTRAINT [Requiries_fk0] FOREIGN KEY ([PositionID]) REFERENCES [dbo].[Project] ([ID]),
    CONSTRAINT [Requiries_fk1] FOREIGN KEY ([SkillMapID]) REFERENCES [dbo].[SkillsMap] ([ID])
);

