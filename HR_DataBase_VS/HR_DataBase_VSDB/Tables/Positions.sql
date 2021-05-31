CREATE TABLE [HR_DataBase_VSDB].[Positions] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [DirectionsID] INT            NOT NULL,
    [DivisionsID]  INT            NOT NULL,
    CONSTRAINT [PK_POSITIONS] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Positions_fk0] FOREIGN KEY ([DirectionsID]) REFERENCES [HR_DataBase_VSDB].[Directions] ([id]),
    CONSTRAINT [Positions_fk1] FOREIGN KEY ([DivisionsID]) REFERENCES [HR_DataBase_VSDB].[Divisions] ([id])
);

