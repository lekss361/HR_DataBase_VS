CREATE TABLE [HR_DataBase_VSDB].[ProjectMaps](
    [WorkerID]   INT NOT NULL,
    [ProjectID]  INT NOT NULL,
    CONSTRAINT [ProjectMaps_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id]),
    CONSTRAINT [ProjectMaps_fk1] FOREIGN KEY ([ProjectID]) REFERENCES [HR_DataBase_VSDB].[Projects] ([id])
);