CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllSkillNames]
AS
	delete from [SkillNames]
	DBCC CHECKIDENT ([SkillNames], RESEED, 0)