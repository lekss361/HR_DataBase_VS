CREATE TABLE [dbo].[Project] (
    [ID]           INT            NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [DirectionsID] INT            NULL,
    CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Project_fk0] FOREIGN KEY ([DirectionsID]) REFERENCES [dbo].[Directions] ([ID])
);

