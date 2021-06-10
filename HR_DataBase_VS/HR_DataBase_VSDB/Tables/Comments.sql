CREATE TABLE [HR_DataBase_VSDB].[Comments] (
    [id] INT  IDENTITY (1, 1)  NOT NULL,
    [WorkerID] INT            NOT NULL,
    [Comment]   NVARCHAR (255) NOT NULL,
    [Date]      DATE           NOT NULL,
    CONSTRAINT [Comments_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id])
);