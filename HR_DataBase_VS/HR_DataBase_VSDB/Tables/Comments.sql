CREATE TABLE [HR_DataBase_VSDB].[Comments] (
    [id] INT  IDENTITY (1, 1) NOT NULL,
    [WorkersID] INT          NOT NULL,
    [Comment]   NVARCHAR (255) NOT NULL,
    [Date]      DATE         NOT NULL,
    CONSTRAINT [Comments_fk0] FOREIGN KEY ([WorkersID]) REFERENCES [HR_DataBase_VSDB].[Workers] ([id])
);

