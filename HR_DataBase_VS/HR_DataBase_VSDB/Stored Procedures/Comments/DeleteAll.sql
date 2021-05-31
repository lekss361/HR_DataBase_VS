CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAll]
AS
	delete from [SkillNames]
	DBCC CHECKIDENT ([Comments], RESEED, 0)