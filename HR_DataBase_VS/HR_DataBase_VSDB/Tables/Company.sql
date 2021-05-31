CREATE TABLE [HR_DataBase_VSDB].[Company] (
    [id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (255) NOT NULL,
    [Iformation] NVARCHAR (255) NULL,
    [ContactID]    INT            NOT NULL,
    [LocationID]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Company_fk1] FOREIGN KEY ([ContactID]) REFERENCES [HR_DataBase_VSDB].[Contacts] ([id]),
    CONSTRAINT [Company_fk2] FOREIGN KEY ([LocationID]) REFERENCES [HR_DataBase_VSDB].[Location] ([id])
);

