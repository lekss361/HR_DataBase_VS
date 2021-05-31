CREATE TABLE [HR_DataBase_VSDB].[Project] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (255) NOT NULL,
    [DirectionsID] INT            NULL,
    CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Project_fk0] FOREIGN KEY ([DirectionsID]) REFERENCES [HR_DataBase_VSDB].[Directions] ([id])
);

