CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllDirections]
AS
	delete from [Directions]
	DBCC CHECKIDENT ([Directions], RESEED, 0)
