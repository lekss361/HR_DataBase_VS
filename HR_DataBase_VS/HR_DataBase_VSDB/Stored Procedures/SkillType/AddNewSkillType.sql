CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewSkillType]
    @Name  NVARCHAR (255)
AS 
    INSERT INTO [SkillTypes] (Name)
    VALUES(@Name)
	SELECT @@IDENTITY