CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllSkillTypes]
AS 
	DELETE FROM [SkillTypes]
	DBCC CHECKIDENT ([SkillTypes], RESEED, 0)