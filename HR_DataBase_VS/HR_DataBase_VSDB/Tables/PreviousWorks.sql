CREATE TABLE [HR_DataBase_VSDB].[PreviousWorks] (
    [WorkerID]    INT            NOT NULL,
    [Information] NVARCHAR (255) NOT NULL,
    [DateStart]   DATE           NOT NULL,
    [DateEnd]     DATE           NOT NULL,
    CONSTRAINT [Previous_works_fk0] FOREIGN KEY ([WorkerID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id])
);