CREATE TABLE [HR_DataBase_VSDB].[Employment] (
    [WorkerID]   INT NOT NULL,
    [PositionID] INT NOT NULL,
    [ProjectID]  INT NULL,
    [StatusID]   INT NOT NULL,
    CONSTRAINT [PK_EMPLOYMENT] PRIMARY KEY CLUSTERED ([WorkerID] ASC),
    CONSTRAINT [Employment_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id]),
    CONSTRAINT [Employment_fk1] FOREIGN KEY ([PositionID]) REFERENCES [HR_DataBase_VSDB].[Positions] ([id]),
    CONSTRAINT [Employment_fk2] FOREIGN KEY ([ProjectID]) REFERENCES [HR_DataBase_VSDB].[Project] ([id]),
    CONSTRAINT [Employment_fk3] FOREIGN KEY ([StatusID]) REFERENCES [HR_DataBase_VSDB].[Statuses] ([id])
);

