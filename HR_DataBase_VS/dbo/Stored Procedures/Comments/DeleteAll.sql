CREATE PROCEDURE [HR_DataBase].[DeleteAll]
AS
	delete from [SkillName]
	DBCC CHECKIDENT ([Comments], RESEED, 0)