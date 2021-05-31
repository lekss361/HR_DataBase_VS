CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAll1]
AS
	delete from [Comments]
	DBCC CHECKIDENT ([Comments], RESEED, 0)
