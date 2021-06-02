CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAll]
AS
	delete from [Comments]
	DBCC CHECKIDENT ([Comments], RESEED, 0)