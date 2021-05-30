CREATE TABLE [dbo].[SkillName] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Skill]       NVARCHAR (255) NOT NULL,
    [SkillTypeID] INT            NOT NULL,
    CONSTRAINT [PK_SKILLNAME] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [SkillName_fk0] FOREIGN KEY ([SkillTypeID]) REFERENCES [dbo].[SkillType] ([ID])
);

