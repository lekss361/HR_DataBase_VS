CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAll]
AS
	delete from [SkillName]
	DBCC CHECKIDENT ([Comments], RESEED, 0)