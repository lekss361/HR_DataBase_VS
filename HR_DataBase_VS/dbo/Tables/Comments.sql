CREATE TABLE [dbo].[Comments] (
    [WorkersID] INT          NOT NULL,
    [Comment]   NVARCHAR (255) NOT NULL,
    [Date]      DATE         NOT NULL,
    CONSTRAINT [Comments_fk0] FOREIGN KEY ([WorkersID]) REFERENCES [dbo].[Workers] ([ID])
);

