CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllLevels]
AS
	delete from [Levels]
	DBCC CHECKIDENT ([Levels], RESEED, 0)
