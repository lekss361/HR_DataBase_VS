CREATE TABLE [dbo].[Employment] (
    [WorkerID]   INT NOT NULL,
    [PositionID] INT NOT NULL,
    [ProjectID]  INT NULL,
    [StatusID]   INT NOT NULL,
    CONSTRAINT [PK_EMPLOYMENT] PRIMARY KEY CLUSTERED ([WorkerID] ASC),
    CONSTRAINT [Employment_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [dbo].[Workers] ([ID]),
    CONSTRAINT [Employment_fk1] FOREIGN KEY ([PositionID]) REFERENCES [dbo].[Positions] ([ID]),
    CONSTRAINT [Employment_fk2] FOREIGN KEY ([ProjectID]) REFERENCES [dbo].[Project] ([ID]),
    CONSTRAINT [Employment_fk3] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[Statuses] ([ID])
);

