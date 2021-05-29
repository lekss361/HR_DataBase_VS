CREATE TABLE [dbo].[Positions] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [DirectionsID] INT            NOT NULL,
    [DivisionsID]  INT            NOT NULL,
    CONSTRAINT [PK_POSITIONS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Positions_fk0] FOREIGN KEY ([DirectionsID]) REFERENCES [dbo].[Directions] ([ID]),
    CONSTRAINT [Positions_fk1] FOREIGN KEY ([DivisionsID]) REFERENCES [dbo].[Divisions] ([ID])
);

