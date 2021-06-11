CREATE TABLE [HR_DataBase_VSDB].[Positions] (
    [id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50)  NOT NULL UNIQUE,
    [DirectionID] INT            NOT NULL,
    CONSTRAINT [PK_POSITIONS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Positions_fk0] FOREIGN KEY ([DirectionID]) REFERENCES [HR_DataBase_VSDB].[Directions] ([id])
);