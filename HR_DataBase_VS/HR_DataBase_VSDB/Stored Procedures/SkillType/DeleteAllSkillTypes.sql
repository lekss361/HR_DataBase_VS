CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllSkillTypes]
AS 
	DELETE FROM [SkillTypes]
	DBCC CHECKIDENT ([Projects], RESEED, 0)