CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllLevels]
AS
	delete from [Levels]
	DBCC CHECKIDENT ([Comments], RESEED, 0)
