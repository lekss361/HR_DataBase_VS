CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllDivisions]
AS
	DELETE FROM [Divisions]
	DBCC CHECKIDENT ([Divisions], RESEED, 0)