CREATE PROCEDURE [dbo].[AddSkillType]
    @Name  NVARCHAR (255) NOT NULL
AS 
INSERT INTO [SkillType] (Name)
VALUES(@Name)