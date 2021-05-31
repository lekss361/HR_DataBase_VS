CREATE PROCEDURE [HR_DataBase_VSDB].[AddSkillType]
    @Name  NVARCHAR (255)
AS 
INSERT INTO [SkillTypes] (Name)
VALUES(@Name)