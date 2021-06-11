CREATE TABLE [HR_DataBase_VSDB].[Workers] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (50)  NOT NULL,
    [LastName]   NVARCHAR (50)  NOT NULL,
    [Patronymic] NVARCHAR (50)  NOT NULL,
    [BirthDay]   DATE           NOT NULL,
    [Sex]        NVARCHAR (20)  NOT NULL,
    [StatusID]   INT            NOT NULL,
    [Education]  NVARCHAR (100) NULL,
    [ContactID]  INT            NULL,
    [LocationID] INT            NULL,
    [Hobby]      NVARCHAR (50)  NULL,
    [PositionID] INT            NULL,
    [DivisionID] INT            NULL
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Workers_fk0] FOREIGN KEY ([ContactID]) REFERENCES [HR_DataBase_VSDB].[Contacts] ([id]),
    CONSTRAINT [Workers_fk1] FOREIGN KEY ([LocationID]) REFERENCES [HR_DataBase_VSDB].[Locations] ([id]),
    CONSTRAINT [Workers_fk2] FOREIGN KEY ([StatusID]) REFERENCES [HR_DataBase_VSDB].[Statuses] ([id]),
    CONSTRAINT [Workers_fk3] FOREIGN KEY ([PositionID]) REFERENCES [HR_DataBase_VSDB].[Positions] ([id]),
    CONSTRAINT [Workers_fk4] FOREIGN KEY ([DivisionID]) REFERENCES [HR_DataBase_VSDB].[Divisions] ([id])
);