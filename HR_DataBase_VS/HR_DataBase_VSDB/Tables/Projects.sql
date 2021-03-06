CREATE TABLE [HR_DataBase_VSDB].[Projects] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (100) NOT NULL,
    [DirectionID] INT            NULL,
    [Information]  NVARCHAR (255) NULL
    CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Project_fk0] FOREIGN KEY ([DirectionID]) REFERENCES [HR_DataBase_VSDB].[Directions] ([id])
);