CREATE TABLE [dbo].[Previous_works] (
    [WorkerID]    INT            NOT NULL,
    [Information] NVARCHAR (255) NOT NULL,
    [DateStart]   DATE           NOT NULL,
    [DateEnd]     DATE           NOT NULL,
    CONSTRAINT [Previous_works_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [dbo].[Workers] ([ID])
);

