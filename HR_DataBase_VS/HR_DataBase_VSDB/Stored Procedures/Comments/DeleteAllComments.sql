CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllComments]
AS
	delete from [Comments]
	DBCC CHECKIDENT ([Comments], RESEED, 0)